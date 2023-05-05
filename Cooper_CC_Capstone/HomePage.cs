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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
        Orders orders= new Orders();
            orders.Show();
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
        OrderDetails details= new OrderDetails();
            details.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
        Users users= new Users();
            users.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
        Inventory inventory= new Inventory();
            inventory.Show();
        }

        private void btnMenuItems_Click(object sender, EventArgs e)
        {
        MenuItems menuItems= new MenuItems();
            menuItems.Show();
        }

        private void btnMenuTypes_Click(object sender, EventArgs e)
        {
        MenuTypes menuTypes= new MenuTypes();
            menuTypes.Show();
        }

        private void btnResturantTable_Click(object sender, EventArgs e)
        {
        ResturantTable resturantTable= new ResturantTable();
            resturantTable.Show();
        }
    }
}
