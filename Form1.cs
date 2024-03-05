using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Schema;

namespace CarShopGUI
{
    public partial class CarShopGUI : Form
    {
        Store store = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();

        public CarShopGUI()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = store.CarList;
            cartBindingSource.DataSource = store.ShoppingList;

            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = ToString();

            lst_cart.DataSource = cartBindingSource;
            lst_cart.DisplayMember = ToString();

            exit_credits_btn.Hide();
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
                    MessageBox.Show("Car added to list.");
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

        private void add_to_cart_btn_Click(object sender, EventArgs e)
        {
            if (lst_inventory.Items.Count != 0)
            {
                Car selected = (Car)lst_inventory.SelectedItem;
                store.ShoppingList.Add(selected);
                store.CarList.Remove(selected);
                cartBindingSource.ResetBindings(false);
                carInventoryBindingSource.ResetBindings(false);
                MessageBox.Show("Added to cart.");
                
            }
            else if (lst_inventory.Items.Count == 0)
            {
                MessageBox.Show("Sorry! There are no more cars in our inventory!");
            }
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed with checkout?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (lst_cart.Items.Count != 0)
                {
                    decimal total = store.Checkout();
                    total_lbl.Text = "$" + total.ToString();
                    cartBindingSource.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("Shopping cart must not be empty!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            //Марто, Пешо - Програма
            //Тедо, Дейвид - Презентация
            //Божидар, Цецо - Представяне на проекта
        }

        private void credits_btn_Click(object sender, EventArgs e)
        {
            addCarGroup.Hide();
            carInventoryGroup.Hide();
            shoppingCartGroup.Hide();
            add_to_cart_btn.Hide();
            checkout_btn.Hide();
            credits_btn.Hide();
            total_txt_lbl.Hide();
            total_lbl.Hide();
            theme_btn.Hide();

            exit_credits_btn.Show();
        }

        private void exit_credits_btn_Click(object sender, EventArgs e)
        {
            addCarGroup.Show();
            carInventoryGroup.Show();
            shoppingCartGroup.Show();
            add_to_cart_btn.Show();
            checkout_btn.Show();
            credits_btn.Show();
            total_txt_lbl.Show();
            total_lbl.Show();

            exit_credits_btn.Hide();
        }

        private void theme_btn_Click(object sender, EventArgs e)
        {
            bool isDarkModeOn = false;

            if (isDarkModeOn == false)
            {
                isDarkModeOn = true;
                BackColor = ColorTranslator.FromHtml("#1c1c1c");
                addCarGroup.ForeColor = Color.White;
                carInventoryGroup.BackColor = ColorTranslator.FromHtml("#1e1e1e");
                carInventoryGroup.ForeColor = Color.White;
                lst_cart.BackColor = ColorTranslator.FromHtml("#282828");
                lst_cart.ForeColor = Color.White;
                shoppingCartGroup.BackColor = ColorTranslator.FromHtml("#1e1e1e");
                shoppingCartGroup.ForeColor = Color.White;
                lst_inventory.BackColor = ColorTranslator.FromHtml("#282828");
                lst_inventory.ForeColor = Color.White;
            }
            
        }

        private void carInventoryLst_Enter(object sender, EventArgs e)
        {

        }
        //udp protokol
        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    base.OnFormClosing(e);

        //    if (e.CloseReason == CloseReason.WindowsShutDown) return;

        //    // Confirm user wants to close
        //    switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
        //    {
        //        case DialogResult.No:
        //            e.Cancel = true;
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }
}