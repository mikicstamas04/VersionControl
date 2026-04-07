namespace UserMaintenance
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
            listUsers = new ListBox();
            txtFullName = new TextBox();
            lblFullName = new Label();
            btnAdd = new Button();
            btnWriteIntoFile = new Button();
            SuspendLayout();
            // 
            // listUsers
            // 
            listUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listUsers.FormattingEnabled = true;
            listUsers.Location = new Point(47, 86);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(544, 744);
            listUsers.TabIndex = 0;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(816, 87);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(452, 27);
            txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(705, 94);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(50, 20);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "label1";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(816, 168);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 44);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnWriteIntoFile
            // 
            btnWriteIntoFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnWriteIntoFile.Location = new Point(460, 860);
            btnWriteIntoFile.Name = "btnWriteIntoFile";
            btnWriteIntoFile.Size = new Size(131, 45);
            btnWriteIntoFile.TabIndex = 6;
            btnWriteIntoFile.Text = "button1";
            btnWriteIntoFile.UseVisualStyleBackColor = true;
            btnWriteIntoFile.Click += btnWriteIntoFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 976);
            Controls.Add(btnWriteIntoFile);
            Controls.Add(btnAdd);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(listUsers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listUsers;
        private TextBox txtFullName;
        private Label lblFullName;
        private Button btnAdd;
        private Button btnWriteIntoFile;
    }
}
