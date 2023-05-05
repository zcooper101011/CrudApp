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
    public partial class MenuItems : Form
    {
        public MenuItems()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuItemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.resturantDataSet);

        }

        private void MenuItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resturantDataSet.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter.Fill(this.resturantDataSet.MenuItems);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuItems_Click(object sender, EventArgs e)
        {
            MenuItemsTableAdapter menuItemsTableAdapter = new MenuItemsTableAdapter();

            menuItemsTableAdapter.Insert(Int32.Parse(txtMenuItemType.Text), txtMenuItemName.Text,
                Int32.Parse(txtMenuItemPrice.Text), txtMenuItemDescription.Text);
        }

        private void txtMenuItemPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMenuItemDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMenuItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMenuItemType_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchItemName_Click(object sender, EventArgs e)
        {
            this.menuItemsTableAdapter.SearchItemName(this.resturantDataSet.MenuItems, txtMenuItemName.Text);
        }

        private void btnSearchPrice_Click(object sender, EventArgs e)
        {
            int priceToSearch;
            Int32.TryParse(txtMenuItemPrice.Text, out priceToSearch);

            this.menuItemsTableAdapter.SearchItemPrice(this.resturantDataSet.MenuItems, priceToSearch);
        }

        private void btnDescription_Click(object sender, EventArgs e)
        {
            this.menuItemsTableAdapter.SearchItemDescription(this.resturantDataSet.MenuItems, txtMenuItemDescription.Text);
        }

        private void btnSearchMenuTypeId_Click(object sender, EventArgs e)
        {
            int quantityTypeSearch;
            Int32.TryParse(txtMenuItemType.Text, out quantityTypeSearch);
            this.menuItemsTableAdapter.SearchMenuTypeId(this.resturantDataSet.MenuItems, quantityTypeSearch);
        }
    }
}
