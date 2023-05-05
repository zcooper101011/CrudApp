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
    public partial class ResturantTable : Form
    {
        public ResturantTable()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        this.Close();
        }

        private void resturantTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.resturantTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.resturantDataSet);

        }

        private void ResturantTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resturantDataSet.ResturantTable' table. You can move, or remove it, as needed.
            this.resturantTableTableAdapter.Fill(this.resturantDataSet.ResturantTable);

        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            ResturantTableTableAdapter resturantTableTableAdapter = new ResturantTableTableAdapter();

            resturantTableTableAdapter.Insert(txtTableDescription.Text);
        }

        private void txtTableDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.resturantTableTableAdapter.Fill(this.resturantDataSet.ResturantTable);
        }

        private void btnSearchTableNumber_Click(object sender, EventArgs e)
        {
            int quantityToSearch;
            Int32.TryParse(txtTableNumber.Text, out quantityToSearch);
            this.resturantTableTableAdapter.SearchByTableId(this.resturantDataSet.ResturantTable, quantityToSearch);
        }

        private void btnSearchTableDescription_Click(object sender, EventArgs e)
        {
            this.resturantTableTableAdapter.SearchByTableDescription(this.resturantDataSet.ResturantTable, txtTableDescription.Text);
        }
    }
}
