namespace CW_Kopylchuk_V2
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainTabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PubTypePicker = new System.Windows.Forms.ComboBox();
            this.databaseTable = new System.Windows.Forms.DataGridView();
            this.MainTabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.InputLabel4 = new System.Windows.Forms.Label();
            this.InputLabel3 = new System.Windows.Forms.Label();
            this.InputLabel2 = new System.Windows.Forms.Label();
            this.InputLabel1 = new System.Windows.Forms.Label();
            this.PublishNewButton = new System.Windows.Forms.Button();
            this.InputBox4 = new System.Windows.Forms.TextBox();
            this.InputBox3 = new System.Windows.Forms.TextBox();
            this.InputBox2 = new System.Windows.Forms.TextBox();
            this.InputBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddNewPubType = new System.Windows.Forms.ComboBox();
            this.MainTabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NextPPButton = new System.Windows.Forms.Button();
            this.PPImage = new System.Windows.Forms.PictureBox();
            this.PPName = new System.Windows.Forms.TextBox();
            this.PPContacts = new System.Windows.Forms.TextBox();
            this.PPAddress = new System.Windows.Forms.TextBox();
            this.MainTabControl.SuspendLayout();
            this.MainTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTable)).BeginInit();
            this.MainTabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MainTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.MainTabControl.Controls.Add(this.MainTabPage1);
            this.MainTabControl.Controls.Add(this.MainTabPage2);
            this.MainTabControl.Controls.Add(this.MainTabPage3);
            this.MainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTabControl.HotTrack = true;
            this.MainTabControl.ItemSize = new System.Drawing.Size(150, 60);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(995, 629);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // MainTabPage1
            // 
            this.MainTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(89)))));
            this.MainTabPage1.Controls.Add(this.panel2);
            this.MainTabPage1.Controls.Add(this.label1);
            this.MainTabPage1.Controls.Add(this.PubTypePicker);
            this.MainTabPage1.Controls.Add(this.databaseTable);
            this.MainTabPage1.Location = new System.Drawing.Point(4, 4);
            this.MainTabPage1.Name = "MainTabPage1";
            this.MainTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage1.Size = new System.Drawing.Size(987, 561);
            this.MainTabPage1.TabIndex = 0;
            this.MainTabPage1.Text = "Database Editor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.panel2.Location = new System.Drawing.Point(-1, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 15);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(218, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Publication Type :";
            // 
            // PubTypePicker
            // 
            this.PubTypePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PubTypePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PubTypePicker.FormattingEnabled = true;
            this.PubTypePicker.Items.AddRange(new object[] {
            "Book",
            "Journal",
            "Booklet"});
            this.PubTypePicker.Location = new System.Drawing.Point(513, 13);
            this.PubTypePicker.Name = "PubTypePicker";
            this.PubTypePicker.Size = new System.Drawing.Size(257, 37);
            this.PubTypePicker.TabIndex = 1;
            this.PubTypePicker.SelectedIndexChanged += new System.EventHandler(this.PubTypePicker_SelectedIndexChanged);
            // 
            // databaseTable
            // 
            this.databaseTable.AllowUserToAddRows = false;
            this.databaseTable.AllowUserToDeleteRows = false;
            this.databaseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.databaseTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.databaseTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(89)))));
            this.databaseTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.databaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databaseTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.databaseTable.Location = new System.Drawing.Point(2, 76);
            this.databaseTable.Name = "databaseTable";
            this.databaseTable.ReadOnly = true;
            this.databaseTable.RowHeadersWidth = 51;
            this.databaseTable.RowTemplate.Height = 24;
            this.databaseTable.Size = new System.Drawing.Size(981, 452);
            this.databaseTable.TabIndex = 0;
            // 
            // MainTabPage2
            // 
            this.MainTabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(172)))), ((int)(((byte)(103)))));
            this.MainTabPage2.Controls.Add(this.panel1);
            this.MainTabPage2.Controls.Add(this.groupBox1);
            this.MainTabPage2.Controls.Add(this.label2);
            this.MainTabPage2.Controls.Add(this.AddNewPubType);
            this.MainTabPage2.Location = new System.Drawing.Point(4, 4);
            this.MainTabPage2.Name = "MainTabPage2";
            this.MainTabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage2.Size = new System.Drawing.Size(987, 561);
            this.MainTabPage2.TabIndex = 1;
            this.MainTabPage2.Text = "Publish new";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 15);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(172)))), ((int)(((byte)(103)))));
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.InputLabel4);
            this.groupBox1.Controls.Add(this.InputLabel3);
            this.groupBox1.Controls.Add(this.InputLabel2);
            this.groupBox1.Controls.Add(this.InputLabel1);
            this.groupBox1.Controls.Add(this.PublishNewButton);
            this.groupBox1.Controls.Add(this.InputBox4);
            this.groupBox1.Controls.Add(this.InputBox3);
            this.groupBox1.Controls.Add(this.InputBox2);
            this.groupBox1.Controls.Add(this.InputBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(39, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 439);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(526, 236);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 25, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2004, 9, 18, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 36);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // InputLabel4
            // 
            this.InputLabel4.AutoSize = true;
            this.InputLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel4.ForeColor = System.Drawing.Color.Black;
            this.InputLabel4.Location = new System.Drawing.Point(519, 195);
            this.InputLabel4.Name = "InputLabel4";
            this.InputLabel4.Size = new System.Drawing.Size(0, 38);
            this.InputLabel4.TabIndex = 8;
            // 
            // InputLabel3
            // 
            this.InputLabel3.AutoSize = true;
            this.InputLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel3.ForeColor = System.Drawing.Color.Black;
            this.InputLabel3.Location = new System.Drawing.Point(519, 51);
            this.InputLabel3.Name = "InputLabel3";
            this.InputLabel3.Size = new System.Drawing.Size(0, 38);
            this.InputLabel3.TabIndex = 7;
            // 
            // InputLabel2
            // 
            this.InputLabel2.AutoSize = true;
            this.InputLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel2.ForeColor = System.Drawing.Color.Black;
            this.InputLabel2.Location = new System.Drawing.Point(81, 195);
            this.InputLabel2.Name = "InputLabel2";
            this.InputLabel2.Size = new System.Drawing.Size(0, 38);
            this.InputLabel2.TabIndex = 6;
            // 
            // InputLabel1
            // 
            this.InputLabel1.AutoSize = true;
            this.InputLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel1.ForeColor = System.Drawing.Color.Black;
            this.InputLabel1.Location = new System.Drawing.Point(81, 51);
            this.InputLabel1.Name = "InputLabel1";
            this.InputLabel1.Size = new System.Drawing.Size(0, 38);
            this.InputLabel1.TabIndex = 5;
            // 
            // PublishNewButton
            // 
            this.PublishNewButton.BackColor = System.Drawing.Color.LightYellow;
            this.PublishNewButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.PublishNewButton.FlatAppearance.BorderSize = 2;
            this.PublishNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublishNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PublishNewButton.Location = new System.Drawing.Point(251, 322);
            this.PublishNewButton.Name = "PublishNewButton";
            this.PublishNewButton.Size = new System.Drawing.Size(385, 81);
            this.PublishNewButton.TabIndex = 4;
            this.PublishNewButton.Text = "Publish";
            this.PublishNewButton.UseVisualStyleBackColor = false;
            this.PublishNewButton.Click += new System.EventHandler(this.PublishNewButton_Click);
            // 
            // InputBox4
            // 
            this.InputBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputBox4.Location = new System.Drawing.Point(526, 236);
            this.InputBox4.Name = "InputBox4";
            this.InputBox4.Size = new System.Drawing.Size(265, 36);
            this.InputBox4.TabIndex = 3;
            // 
            // InputBox3
            // 
            this.InputBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputBox3.Location = new System.Drawing.Point(526, 92);
            this.InputBox3.Name = "InputBox3";
            this.InputBox3.Size = new System.Drawing.Size(265, 36);
            this.InputBox3.TabIndex = 2;
            // 
            // InputBox2
            // 
            this.InputBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputBox2.Location = new System.Drawing.Point(88, 236);
            this.InputBox2.Name = "InputBox2";
            this.InputBox2.Size = new System.Drawing.Size(261, 36);
            this.InputBox2.TabIndex = 1;
            // 
            // InputBox1
            // 
            this.InputBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputBox1.Location = new System.Drawing.Point(88, 92);
            this.InputBox1.Name = "InputBox1";
            this.InputBox1.Size = new System.Drawing.Size(261, 36);
            this.InputBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(208, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Publication Type : ";
            // 
            // AddNewPubType
            // 
            this.AddNewPubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddNewPubType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewPubType.FormattingEnabled = true;
            this.AddNewPubType.Items.AddRange(new object[] {
            "Book",
            "Journal",
            "Booklet"});
            this.AddNewPubType.Location = new System.Drawing.Point(499, 18);
            this.AddNewPubType.Name = "AddNewPubType";
            this.AddNewPubType.Size = new System.Drawing.Size(257, 37);
            this.AddNewPubType.TabIndex = 3;
            this.AddNewPubType.SelectedIndexChanged += new System.EventHandler(this.AddNewPubType_SelectedIndexChanged);
            // 
            // MainTabPage3
            // 
            this.MainTabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(131)))));
            this.MainTabPage3.Controls.Add(this.label5);
            this.MainTabPage3.Controls.Add(this.label4);
            this.MainTabPage3.Controls.Add(this.label3);
            this.MainTabPage3.Controls.Add(this.NextPPButton);
            this.MainTabPage3.Controls.Add(this.PPImage);
            this.MainTabPage3.Controls.Add(this.PPName);
            this.MainTabPage3.Controls.Add(this.PPContacts);
            this.MainTabPage3.Controls.Add(this.PPAddress);
            this.MainTabPage3.Location = new System.Drawing.Point(4, 4);
            this.MainTabPage3.Name = "MainTabPage3";
            this.MainTabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage3.Size = new System.Drawing.Size(987, 561);
            this.MainTabPage3.TabIndex = 2;
            this.MainTabPage3.Text = "Printing Presses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(750, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contacts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // NextPPButton
            // 
            this.NextPPButton.BackColor = System.Drawing.Color.White;
            this.NextPPButton.Location = new System.Drawing.Point(311, 478);
            this.NextPPButton.Name = "NextPPButton";
            this.NextPPButton.Size = new System.Drawing.Size(330, 55);
            this.NextPPButton.TabIndex = 7;
            this.NextPPButton.Text = "Next Printing Press";
            this.NextPPButton.UseVisualStyleBackColor = false;
            this.NextPPButton.Click += new System.EventHandler(this.NextPPButton_Click);
            // 
            // PPImage
            // 
            this.PPImage.Location = new System.Drawing.Point(47, 111);
            this.PPImage.Name = "PPImage";
            this.PPImage.Size = new System.Drawing.Size(882, 343);
            this.PPImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PPImage.TabIndex = 6;
            this.PPImage.TabStop = false;
            // 
            // PPName
            // 
            this.PPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PPName.Location = new System.Drawing.Point(33, 52);
            this.PPName.Name = "PPName";
            this.PPName.Size = new System.Drawing.Size(265, 36);
            this.PPName.TabIndex = 5;
            // 
            // PPContacts
            // 
            this.PPContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PPContacts.Location = new System.Drawing.Point(678, 52);
            this.PPContacts.Name = "PPContacts";
            this.PPContacts.Size = new System.Drawing.Size(265, 36);
            this.PPContacts.TabIndex = 4;
            // 
            // PPAddress
            // 
            this.PPAddress.BackColor = System.Drawing.Color.White;
            this.PPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PPAddress.Location = new System.Drawing.Point(353, 52);
            this.PPAddress.Name = "PPAddress";
            this.PPAddress.Size = new System.Drawing.Size(265, 36);
            this.PPAddress.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1019, 663);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "PublicationApp";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainTabControl.ResumeLayout(false);
            this.MainTabPage1.ResumeLayout(false);
            this.MainTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTable)).EndInit();
            this.MainTabPage2.ResumeLayout(false);
            this.MainTabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MainTabPage3.ResumeLayout(false);
            this.MainTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PPImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage MainTabPage1;
        private System.Windows.Forms.ComboBox PubTypePicker;
        private System.Windows.Forms.DataGridView databaseTable;
        private System.Windows.Forms.TabPage MainTabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AddNewPubType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label InputLabel1;
        private System.Windows.Forms.Button PublishNewButton;
        private System.Windows.Forms.TextBox InputBox4;
        private System.Windows.Forms.TextBox InputBox3;
        private System.Windows.Forms.TextBox InputBox2;
        private System.Windows.Forms.TextBox InputBox1;
        private System.Windows.Forms.Label InputLabel4;
        private System.Windows.Forms.Label InputLabel3;
        private System.Windows.Forms.Label InputLabel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage MainTabPage3;
        private System.Windows.Forms.PictureBox PPImage;
        private System.Windows.Forms.TextBox PPName;
        private System.Windows.Forms.TextBox PPContacts;
        private System.Windows.Forms.TextBox PPAddress;
        private System.Windows.Forms.Button NextPPButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

