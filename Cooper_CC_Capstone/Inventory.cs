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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.resturantDataSet);

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resturantDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.resturantDataSet.Inventory);

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
        InventoryTableAdapter inventoryTableAdapter = new InventoryTableAdapter();

            inventoryTableAdapter.Insert(txtInventoryName.Text, 
                txtInventoryDescription.Text, Int32.Parse(txtInventoryQuantity.Text));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtInventoryName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            this.inventoryTableAdapter.SearchName(this.resturantDataSet.Inventory, txtInventoryName.Text);
        }

        private void btnSearchDescription_Click(object sender, EventArgs e)
        {
            this.inventoryTableAdapter.SearchDescription(this.resturantDataSet.Inventory, txtInventoryDescription.Text);
        }

        private void btnSearchQuantity_Click(object sender, EventArgs e)
        {
            int quantityToSearch;
            Int32.TryParse(txtInventoryQuantity.Text,out quantityToSearch);
            this.inventoryTableAdapter.SearchQuantity(this.resturantDataSet.Inventory, quantityToSearch);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.inventoryTableAdapter.Fill(this.resturantDataSet.Inventory);
        }
    }
}
