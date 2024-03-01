using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        const string NullOrEmptyException = "The text box cannot be empty!";
        Store store = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void make_lbl_Click(object sender, EventArgs e)
        {

        }

        private void model_lbl_Click(object sender, EventArgs e)
        {

        }

        private void total_lbl_Click(object sender, EventArgs e)
        {

        }

        private void create_car_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = new Car(make_txt.Text, model_txt.Text, decimal.Parse(price_txt.Text));
                if (make_txt.Text == string.Empty
                    || model_txt.Text == string.Empty)
                {
                    throw new InvalidOperationException();
                }
               
                else
                {
                    MessageBox.Show("Car added to list");
                    store.CarList.Add(car);
                    carInventoryBindingSource.ResetBindings(false);
                    make_txt.Text = " ";
                    model_txt.Text = " ";
                    price_txt.Text = " ";
                }

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Text box cannot be empty!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Input must be a number!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = store.CarList;
            cartBindingSource.DataSource = store.ShoppingList;

            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = ToString();

            lst_cart.DataSource = cartBindingSource;
            lst_cart.DisplayMember = ToString();
        }

        private void add_to_cart_btn_Click(object sender, EventArgs e)
        {
            Car selected = (Car)lst_inventory.SelectedItem;
            store.ShoppingList.Add(selected);

            cartBindingSource.ResetBindings(false);
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            decimal total = store.Checkout();
            total_lbl.Text = "$" + total.ToString();
            cartBindingSource.ResetBindings(false);
        }

        private void make_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}