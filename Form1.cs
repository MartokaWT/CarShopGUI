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
        bool isDarkModeOn = false;

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
                    MessageBox.Show("Автомобилът успешно бе добавен към инвентара!");
                    store.CarList.Add(car);
                    carInventoryBindingSource.ResetBindings(false);
                    make_txt.Text = " ";
                    model_txt.Text = " ";
                    price_txt.Text = " ";
                }

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Текстовото поле не може да е празно!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Входното цисло трябва да е цифра!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Числото е твърде голямо!");
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
                MessageBox.Show("Автомобилът успешно бе добавен към количката!");
                
            }
            else if (lst_inventory.Items.Count == 0)
            {
                MessageBox.Show("Няма наличност на повече автомобили в инвентара ни!");
            }
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Искате ли да продължите с плащането?", "Сигурни ли сте?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (lst_cart.Items.Count != 0)
                {
                    decimal total = store.Checkout();
                    total_lbl.Text = total.ToString() + "лв.";
                    cartBindingSource.ResetBindings(false);
                }
                else
                {
                    total_lbl.Text = "0.00 лв.";
                    MessageBox.Show("Количката е празна!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void theme_btn_Click(object sender, EventArgs e)
        {
            if (isDarkModeOn == false)
            {
                isDarkModeOn = true;

                BackColor = ColorTranslator.FromHtml("#1c1c1c");

                addCarGroup.ForeColor = ColorTranslator.FromHtml("#787878");

                carInventoryGroup.BackColor = ColorTranslator.FromHtml("#1e1e1e");
                carInventoryGroup.ForeColor = ColorTranslator.FromHtml("#787878");
                carInventoryGroup.FlatStyle = FlatStyle.Flat;

                lst_cart.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                lst_cart.ForeColor = ColorTranslator.FromHtml("#787878");

                shoppingCartGroup.BackColor = ColorTranslator.FromHtml("#1e1e1e");
                shoppingCartGroup.ForeColor = ColorTranslator.FromHtml("#787878");

                lst_inventory.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                lst_inventory.ForeColor = ColorTranslator.FromHtml("#787878");

                total_txt_lbl.ForeColor = ColorTranslator.FromHtml("#787878");
                total_lbl.ForeColor = ColorTranslator.FromHtml("#787878");

                make_txt.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                make_txt.ForeColor = ColorTranslator.FromHtml("#787878");

                model_txt.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                model_txt.ForeColor = ColorTranslator.FromHtml("#787878");

                price_txt.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                price_txt.ForeColor = ColorTranslator.FromHtml("#787878");

                create_car_btn.FlatStyle = FlatStyle.Flat;
                create_car_btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#2d2d2d");
                create_car_btn.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                create_car_btn.ForeColor = ColorTranslator.FromHtml("#787878");

                add_to_cart_btn.FlatStyle = FlatStyle.Flat;
                add_to_cart_btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#2d2d2d");
                add_to_cart_btn.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                add_to_cart_btn.ForeColor = ColorTranslator.FromHtml("#787878");

                checkout_btn.FlatStyle = FlatStyle.Flat;
                checkout_btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#2d2d2d");
                checkout_btn.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                checkout_btn.ForeColor = ColorTranslator.FromHtml("#787878");

                theme_btn.FlatStyle = FlatStyle.Flat;
                theme_btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#2d2d2d");
                theme_btn.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                theme_btn.ForeColor = ColorTranslator.FromHtml("#787878");

            }
            else if (isDarkModeOn == true)
            {
                isDarkModeOn = false;

                BackColor = default(Color);

                addCarGroup.ForeColor = default(Color);

                carInventoryGroup.BackColor = default(Color);
                carInventoryGroup.ForeColor = default(Color);

                lst_cart.BackColor = default(Color);
                lst_cart.ForeColor = default(Color);

                shoppingCartGroup.BackColor = default(Color);
                shoppingCartGroup.ForeColor = default(Color);

                lst_inventory.BackColor = default(Color);
                lst_inventory.ForeColor = default(Color);

                total_txt_lbl.ForeColor = default(Color);
                total_lbl.ForeColor = default(Color);

                make_txt.BackColor = default(Color);
                make_txt.ForeColor = default(Color);

                model_txt.BackColor = default(Color);
                model_txt.ForeColor = default(Color);

                price_txt.BackColor = default(Color);
                price_txt.ForeColor = default(Color);

                create_car_btn.FlatStyle = FlatStyle.Flat;
                create_car_btn.FlatAppearance.BorderColor = default(Color);
                create_car_btn.BackColor = default(Color);
                create_car_btn.ForeColor = default(Color);

                add_to_cart_btn.FlatStyle = FlatStyle.Flat;
                add_to_cart_btn.FlatAppearance.BorderColor = default(Color);
                add_to_cart_btn.BackColor = default(Color);
                add_to_cart_btn.ForeColor = default(Color);

                checkout_btn.FlatStyle = FlatStyle.Flat;
                checkout_btn.FlatAppearance.BorderColor = default(Color);
                checkout_btn.BackColor = default(Color);
                checkout_btn.ForeColor = default(Color);

                theme_btn.FlatStyle = FlatStyle.Flat;
                theme_btn.FlatAppearance.BorderColor = default(Color);
                theme_btn.BackColor = default(Color);
                theme_btn.ForeColor = default(Color);
            }
        }
    }
}