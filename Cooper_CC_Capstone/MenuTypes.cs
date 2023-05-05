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
    public partial class MenuTypes : Form
    {
        public MenuTypes()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.resturantDataSet);

        }

        private void MenuTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resturantDataSet.MenuTypes' table. You can move, or remove it, as needed.
            this.menuTypesTableAdapter.Fill(this.resturantDataSet.MenuTypes);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuTypes_Click(object sender, EventArgs e)
        {
            MenuTypesTableAdapter menuTypesTableAdapter = new MenuTypesTableAdapter();

            menuTypesTableAdapter.Insert (txtTypeName.Text, txtTypeDescription.Text);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.menuTypesTableAdapter.Fill(this.resturantDataSet.MenuTypes);
        }

        private void btnSearchTypeName_Click(object sender, EventArgs e)
        {
            this.menuTypesTableAdapter.SearchTypeName(this.resturantDataSet.MenuTypes, txtSearchTypeName.Text);
        }

        private void btnSearchTypeDescription_Click(object sender, EventArgs e)
        {
            this.menuTypesTableAdapter.SearchTypeDescription(this.resturantDataSet.MenuTypes, txtSearchTypeDescription.Text);
        }
    }
}
