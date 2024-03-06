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
            theme_btn.Show();

            exit_credits_btn.Hide();
        }

        private void theme_btn_Click(object sender, EventArgs e)
        {
            if (isDarkModeOn == false)
            {
                isDarkModeOn = true;

                //Changes the color of the background for the whole app.
                BackColor = ColorTranslator.FromHtml("#1c1c1c");

                //Changes the color of the background and the text for groups and lists.
                addCarGroup.ForeColor = Color.White;

                carInventoryGroup.BackColor = ColorTranslator.FromHtml("#1e1e1e");
                carInventoryGroup.ForeColor = Color.White;

                lst_cart.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                lst_cart.ForeColor = Color.White;

                shoppingCartGroup.BackColor = ColorTranslator.FromHtml("#1e1e1e");
                shoppingCartGroup.ForeColor = Color.White;

                lst_inventory.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                lst_inventory.ForeColor = Color.White;

                //Changes the color of the total labels.
                total_txt_lbl.ForeColor = Color.White;
                total_lbl.ForeColor = Color.White;

                //Changes the color of the textboxes.
                make_txt.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                make_txt.ForeColor = Color.White;
                model_txt.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                model_txt.ForeColor = Color.White;
                price_txt.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                price_txt.ForeColor = Color.White;

                //Changes the color of the buttons.
                create_car_btn.FlatStyle = FlatStyle.Flat;
                create_car_btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#2d2d2d");
                create_car_btn.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                create_car_btn.ForeColor = Color.White;

                add_to_cart_btn.FlatStyle = FlatStyle.Flat;
                add_to_cart_btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#2d2d2d");
                add_to_cart_btn.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                add_to_cart_btn.ForeColor = Color.White;

                checkout_btn.FlatStyle = FlatStyle.Flat;
                checkout_btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#2d2d2d");
                checkout_btn.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                checkout_btn.ForeColor = Color.White;

                credits_btn.FlatStyle = FlatStyle.Flat;
                credits_btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#2d2d2d");
                credits_btn.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                credits_btn.ForeColor = Color.White;

                theme_btn.FlatStyle = FlatStyle.Flat;
                theme_btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#2d2d2d");
                theme_btn.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                theme_btn.ForeColor = Color.White;
            }
            else if (isDarkModeOn == true)
            {
                isDarkModeOn = false;

                BackColor = default(Color);

                //Changes the color of the background and the text for groups and lists.
                addCarGroup.ForeColor = default(Color);

                carInventoryGroup.BackColor = default(Color);
                carInventoryGroup.ForeColor = default(Color);

                lst_cart.BackColor = default(Color);
                lst_cart.ForeColor = default(Color);

                shoppingCartGroup.BackColor = default(Color);
                shoppingCartGroup.ForeColor = default(Color);

                lst_inventory.BackColor = default(Color);
                lst_inventory.ForeColor = default(Color);

                //Changes the color of the total labels.
                total_txt_lbl.ForeColor = default(Color);
                total_lbl.ForeColor = default(Color);

                //Changes the color of the textboxes.
                make_txt.BackColor = default(Color);
                make_txt.ForeColor = default(Color);
                model_txt.BackColor = default(Color);
                model_txt.ForeColor = default(Color);
                price_txt.BackColor = default(Color);
                price_txt.ForeColor = default(Color);

                //Changes the color of the buttons.
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

                credits_btn.FlatStyle = FlatStyle.Flat;
                credits_btn.FlatAppearance.BorderColor = default(Color);
                credits_btn.BackColor = default(Color);
                credits_btn.ForeColor = default(Color);

                theme_btn.FlatStyle = FlatStyle.Flat;
                theme_btn.FlatAppearance.BorderColor = default(Color);
                theme_btn.BackColor = default(Color);
                theme_btn.ForeColor = default(Color);

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