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
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // listUsers
            // 
            listUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listUsers.FormattingEnabled = true;
            listUsers.Location = new Point(47, 86);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(544, 764);
            listUsers.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(816, 87);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(452, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(816, 245);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(452, 27);
            txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(705, 94);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(50, 20);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "label1";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(705, 252);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(50, 20);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "label2";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(816, 320);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 44);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 988);
            Controls.Add(btnAdd);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(listUsers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listUsers;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btnAdd;
    }
}
