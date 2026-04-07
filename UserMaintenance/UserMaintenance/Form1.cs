using System.ComponentModel;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = Resource1.LastName; // label1
            lblFirstName.Text = Resource1.FirstName; // label2
            btnAdd.Text = Resource1.Add; // button1

            listUsers.DataSource = users;
            listUsers.DisplayMember = "FullName";
            listUsers.ValueMember = "ID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };
            users.Add(u);
        }
    }
}
