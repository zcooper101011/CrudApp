using Cooper_CC_Capstone.ResturantDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cooper_CC_Capstone
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.resturantDataSet);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resturantDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.resturantDataSet.Users);

        }

        private void btnUserType_Click(object sender, EventArgs e)
        {
            UsersTableAdapter usersTableAdapter = new UsersTableAdapter();

            usersTableAdapter.Insert(txtUserName.Text, txtUserEmail.Text,
                txtUserPhone.Text, txtUserType.Text);
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.SearchByName(this.resturantDataSet.Users, txtSearchName.Text);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.resturantDataSet.Users);
        }

        private void btnSearchEmail_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.SearchByUserEmail(this.resturantDataSet.Users, txtSearchEmail.Text);
        }

        private void btnSearchPhone_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.SearchByUserPhone(this.resturantDataSet.Users, txtSearchPhone.Text);
        }
    }
}
