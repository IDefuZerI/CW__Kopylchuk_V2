using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Drawing.Drawing2D;

namespace CW_Kopylchuk_V2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        enum PublicationType { Book, Journal, Booklet };

        private int PPCounter = 1;
        private void ShowColumns(PublicationType type)
        {
            databaseTable.Columns.Clear();
            databaseTable.Rows.Clear();
            switch (type)
            {
                case PublicationType.Book:
                    databaseTable.Columns.Add("BookID", "Id");
                    databaseTable.Columns.Add("Title", "Title");
                    databaseTable.Columns.Add("Author", "Author");
                    databaseTable.Columns.Add("Genre", "Genre");
                    databaseTable.Columns.Add("PublicationDate", "Date");
                    break;

                case PublicationType.Journal:
                    databaseTable.Columns.Add("OrderId", "Id");
                    databaseTable.Columns.Add("Title", "Title");
                    databaseTable.Columns.Add("Editor", "Editor");
                    databaseTable.Columns.Add("Topic", "Topic");
                    databaseTable.Columns.Add("Publisher", "Publisher");
                    break;

                case PublicationType.Booklet:
                    databaseTable.Columns.Add("BookletId", "Id");
                    databaseTable.Columns.Add("Title", "Title");
                    databaseTable.Columns.Add("Description", "Description");
                    databaseTable.Columns.Add("Size", "Number of pages");
                    databaseTable.Columns.Add("PrintRun", "Number of copies");
                    break;
                    
            }
        }

        private void AddRow(DataGridView dataGrid, PublicationType type, IDataRecord rec)
        {
            switch (type)
            {
                case PublicationType.Book:
                    dataGrid.Rows.Add(rec.GetInt32(0), rec.GetString(1), rec.GetString(2), rec.GetString(3), rec.GetDateTime(4).ToShortDateString());
                    break;

                case PublicationType.Journal:
                    dataGrid.Rows.Add(rec.GetInt32(0), rec.GetString(1), rec.GetString(2), rec.GetString(3), rec.GetString(4));
                    break;

                case PublicationType.Booklet:
                    dataGrid.Rows.Add(rec.GetInt32(0), rec.GetString(1), rec.GetString(2), rec.GetInt32(3), rec.GetInt32(4));
                    break;
            }
        }

        private void UpdateTable(PublicationType type)
        {
            ShowColumns(type);
            string sqlQuery = "";

            switch (type)
            {
                case PublicationType.Book:
                    sqlQuery = "SELECT * FROM Books"; break;

                case PublicationType.Journal:
                    sqlQuery = "SELECT * FROM Journals"; break;

                case PublicationType.Booklet:
                    sqlQuery = "SELECT * FROM Booklets"; break;
            }

            using (SqlConnection sqlConnection = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath(@"..\..\PublishingDB.mdf")};Integrated Security=True"))
            {

                sqlConnection.Open();

                SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    AddRow(databaseTable, type, dataReader);
                }

                dataReader.Close();
            }
        }

        private void PubTypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pubType = (PublicationType)PubTypePicker.SelectedIndex;
            UpdateTable(pubType);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            AddNewPubType.SelectedIndex = PubTypePicker.SelectedIndex = 0;
            UpdateTable((PublicationType)PubTypePicker.SelectedIndex);
            LoadPPData(PPCounter);
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MainTabControl.SelectedIndex)
            {
                case 0:
                    BackColor = ColorTranslator.FromHtml("#EE6A59");
                    break;
                case 1:
                    BackColor = ColorTranslator.FromHtml("#F9AC67");
                    break;
                case 2:
                    BackColor = ColorTranslator.FromHtml("#C3CB83");
                    break;
                default:
                    break;
            }
        }

        // Add
        private void AddNewPub(PublicationType type)
        {
            string sqlQuery = "";

            switch (type)
            {
                case PublicationType.Book:
                    sqlQuery = "INSERT INTO Books (Title, Author, Genre, PublicationDate) VALUES (@Param1, @Param2, @Param3, @Param4)";
                    break;

                case PublicationType.Journal:
                    sqlQuery = "INSERT INTO Journals (Title, Editor, Topic, Publisher) VALUES (@Param1, @Param2, @Param3, @Param4)";
                    break;

                case PublicationType.Booklet:
                    sqlQuery = "INSERT INTO Booklets (Title, Description, Size, PrintRun) VALUES (@Param1, @Param2, @Param3, @Param4)";
                    break;
            }

            try
            {
                if (InputBox1.Text == "" || InputBox2.Text == "" || InputBox3.Text == "" || (type != PublicationType.Book && InputBox4.Text == "") || (type == PublicationType.Booklet && (!int.TryParse(InputBox3.Text, out int size) || !int.TryParse(InputBox4.Text, out int printRun))))
                {
                    throw new Exception("Wrong data format!");
                }

                using (SqlConnection sqlConnection = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath(@"..\..\PublishingDB.mdf")};Integrated Security=True"))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

                    sqlCommand.Parameters.AddWithValue("@Param1", InputBox1.Text);
                    sqlCommand.Parameters.AddWithValue("@Param2", InputBox2.Text);
                    sqlCommand.Parameters.AddWithValue("@Param3", InputBox3.Text);
                    if (type == PublicationType.Book) sqlCommand.Parameters.AddWithValue("@Param4", dateTimePicker1.Value);
                    else sqlCommand.Parameters.AddWithValue("@Param4", InputBox4.Text);

                    if (sqlCommand.ExecuteNonQuery() > 0) MessageBox.Show($"Added new {type} - {InputBox1.Text}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Something went wrong...", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AddNewPubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pubType = (PublicationType)AddNewPubType.SelectedIndex;

            switch (pubType)
            {
                case PublicationType.Book:
                    InputLabel1.Text = "Title:";
                    InputLabel2.Text = "Author:";
                    InputLabel3.Text = "Genre:";
                    InputLabel4.Text = "Publication Date:";
                    dateTimePicker1.Visible = true;
                    break;

                case PublicationType.Journal:
                    InputLabel1.Text = "Title:";
                    InputLabel2.Text = "Editor:";
                    InputLabel3.Text = "Topic:";
                    InputLabel4.Text = "Publisher:";
                    dateTimePicker1.Visible = false;
                    break;

                case PublicationType.Booklet:
                    InputLabel1.Text = "Title:";
                    InputLabel2.Text = "Description:";
                    InputLabel3.Text = "Number of Pages:";
                    InputLabel4.Text = "Number of Copies:";
                    dateTimePicker1.Visible = false;
                    break;
            }
        }

        private void PublishNewButton_Click(object sender, EventArgs e)
        {
            var pubType = (PublicationType)AddNewPubType.SelectedIndex;
            AddNewPub(pubType);

            InputBox1.Text = InputBox2.Text = InputBox3.Text = InputBox4.Text = "";
            dateTimePicker1.Visible = true;

            UpdateTable((PublicationType)PubTypePicker.SelectedIndex);
        }

        // Typography
        private void NextPPButton_Click(object sender, EventArgs e)
        {
            LoadPPData(++PPCounter);
        }

        private void LoadPPData(int counter)
        {
            if (counter > 5) counter=PPCounter = 1;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath(@"..\..\PublishingDB.mdf")};Integrated Security=True"))
                {
                    sqlConnection.Open();

                    string sqlQuery = "SELECT * FROM PrintingPresses WHERE PrintingId = @PrintingId";
                    SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);

                    command.Parameters.AddWithValue("@PrintingId", counter);

                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.Read())
                    {
                        PPName.Text = dataReader["Name"].ToString();
                        PPAddress.Text = dataReader["Address"].ToString();
                        PPContacts.Text = dataReader["Contacts"].ToString();

                        PPImage.Image = null;

                        string imagePath = Path.GetFullPath(@"..\..\photos\pp" + counter.ToString() + ".jpg");
                        using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            PPImage.Image = Image.FromStream(fs);
                        }
                    }

                    dataReader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

    }
}
