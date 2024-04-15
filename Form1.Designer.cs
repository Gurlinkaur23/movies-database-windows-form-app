namespace MoviesDatabaseWindowsFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            BtnBrowse = new Button();
            label3 = new Label();
            BtnInsert = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtMoviesFile = new TextBox();
            txtUsersFile = new TextBox();
            txtRatingsFile = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(183, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 31);
            label1.TabIndex = 0;
            label1.Text = "Movies DataBase Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Chocolate;
            label2.Location = new Point(47, 65);
            label2.Name = "label2";
            label2.Size = new Size(341, 25);
            label2.TabIndex = 1;
            label2.Text = "Select files for movies, users, and ratings.";
            // 
            // BtnBrowse
            // 
            BtnBrowse.BackColor = Color.LightSkyBlue;
            BtnBrowse.FlatStyle = FlatStyle.Popup;
            BtnBrowse.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBrowse.ForeColor = Color.White;
            BtnBrowse.Location = new Point(47, 106);
            BtnBrowse.Name = "BtnBrowse";
            BtnBrowse.Size = new Size(115, 39);
            BtnBrowse.TabIndex = 2;
            BtnBrowse.Text = "Browse";
            BtnBrowse.UseVisualStyleBackColor = false;
            BtnBrowse.Click += BtnBrowse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Chocolate;
            label3.Location = new Point(47, 345);
            label3.Name = "label3";
            label3.Size = new Size(563, 25);
            label3.TabIndex = 4;
            label3.Text = "Click Insert button to insert the data from the files into the DataBase.";
            // 
            // BtnInsert
            // 
            BtnInsert.BackColor = Color.FromArgb(80, 200, 120);
            BtnInsert.FlatStyle = FlatStyle.Popup;
            BtnInsert.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnInsert.ForeColor = Color.White;
            BtnInsert.Location = new Point(47, 388);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(115, 39);
            BtnInsert.TabIndex = 5;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = false;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtMoviesFile
            // 
            txtMoviesFile.Location = new Point(155, 168);
            txtMoviesFile.Name = "txtMoviesFile";
            txtMoviesFile.Size = new Size(449, 27);
            txtMoviesFile.TabIndex = 6;
            // 
            // txtUsersFile
            // 
            txtUsersFile.Location = new Point(155, 222);
            txtUsersFile.Name = "txtUsersFile";
            txtUsersFile.Size = new Size(449, 27);
            txtUsersFile.TabIndex = 7;
            // 
            // txtRatingsFile
            // 
            txtRatingsFile.Location = new Point(155, 272);
            txtRatingsFile.Name = "txtRatingsFile";
            txtRatingsFile.Size = new Size(449, 27);
            txtRatingsFile.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 168);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 9;
            label4.Text = "Movies file";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 222);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 10;
            label5.Text = "Users file";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 272);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 11;
            label6.Text = "Ratings file";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Chocolate;
            label7.Location = new Point(47, 449);
            label7.Name = "label7";
            label7.Size = new Size(61, 25);
            label7.TabIndex = 12;
            label7.Text = "Status";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(47, 485);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(115, 20);
            labelStatus.TabIndex = 13;
            labelStatus.Text = "Awaiting Action";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 575);
            Controls.Add(labelStatus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtRatingsFile);
            Controls.Add(txtUsersFile);
            Controls.Add(txtMoviesFile);
            Controls.Add(BtnInsert);
            Controls.Add(label3);
            Controls.Add(BtnBrowse);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnBrowse;
        private Label label3;
        private Button BtnInsert;
        private OpenFileDialog openFileDialog1;
        private TextBox txtMoviesFile;
        private TextBox txtUsersFile;
        private TextBox txtRatingsFile;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label labelStatus;
    }
}
