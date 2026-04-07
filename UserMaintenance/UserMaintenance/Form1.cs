using System.ComponentModel;
using System.Text;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblFullName.Text = Resource1.FullName; // label1
            btnAdd.Text = Resource1.Add; // button1
            btnWriteIntoFile.Text = Resource1.WriteIntoFile; // button2

            listUsers.DataSource = users;
            listUsers.DisplayMember = "FullName";
            listUsers.ValueMember = "ID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User
            {
                ID = Guid.NewGuid(),
                FullName = txtFullName.Text
            };
            users.Add(u);
        }

        private void btnWriteIntoFile_Click(object sender, EventArgs e)
        {
            using var saveFileDialog = new SaveFileDialog
            {
                Title = "Save users",
                Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*",
                DefaultExt = "csv",
                AddExtension = true,
                FileName = "users.csv"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                var lines = new List<string> { "ID,FullName" };

                foreach (var user in users)
                {
                    var escapedFullName = (user.FullName ?? string.Empty).Replace("\"", "\"\"");
                    lines.Add($"{user.ID},\"{escapedFullName}\"");
                }

                File.WriteAllLines(saveFileDialog.FileName, lines, Encoding.UTF8);
                MessageBox.Show("Users saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
