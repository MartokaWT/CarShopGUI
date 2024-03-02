namespace CarShopGUI
{
    partial class CarShopGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createCarGroup = new System.Windows.Forms.GroupBox();
            this.create_car_btn = new System.Windows.Forms.Button();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.model_txt = new System.Windows.Forms.TextBox();
            this.make_txt = new System.Windows.Forms.TextBox();
            this.price_lbl = new System.Windows.Forms.Label();
            this.model_lbl = new System.Windows.Forms.Label();
            this.make_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_inventory = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_cart = new System.Windows.Forms.ListBox();
            this.add_to_cart_btn = new System.Windows.Forms.Button();
            this.checkout_btn = new System.Windows.Forms.Button();
            this.total_txt_lbl = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.createCarGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createCarGroup
            // 
            this.createCarGroup.Controls.Add(this.create_car_btn);
            this.createCarGroup.Controls.Add(this.price_txt);
            this.createCarGroup.Controls.Add(this.model_txt);
            this.createCarGroup.Controls.Add(this.make_txt);
            this.createCarGroup.Controls.Add(this.price_lbl);
            this.createCarGroup.Controls.Add(this.model_lbl);
            this.createCarGroup.Controls.Add(this.make_lbl);
            this.createCarGroup.Location = new System.Drawing.Point(13, 13);
            this.createCarGroup.Name = "createCarGroup";
            this.createCarGroup.Size = new System.Drawing.Size(200, 174);
            this.createCarGroup.TabIndex = 0;
            this.createCarGroup.TabStop = false;
            this.createCarGroup.Text = "Create a Car";
            // 
            // create_car_btn
            // 
            this.create_car_btn.Location = new System.Drawing.Point(65, 125);
            this.create_car_btn.Name = "create_car_btn";
            this.create_car_btn.Size = new System.Drawing.Size(100, 28);
            this.create_car_btn.TabIndex = 3;
            this.create_car_btn.Text = "Create Car";
            this.create_car_btn.UseVisualStyleBackColor = true;
            this.create_car_btn.Click += new System.EventHandler(this.create_car_btn_Click);
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(65, 89);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(100, 20);
            this.price_txt.TabIndex = 5;
            // 
            // model_txt
            // 
            this.model_txt.Location = new System.Drawing.Point(65, 60);
            this.model_txt.Name = "model_txt";
            this.model_txt.Size = new System.Drawing.Size(100, 20);
            this.model_txt.TabIndex = 4;
            // 
            // make_txt
            // 
            this.make_txt.Location = new System.Drawing.Point(65, 31);
            this.make_txt.Name = "make_txt";
            this.make_txt.Size = new System.Drawing.Size(100, 20);
            this.make_txt.TabIndex = 3;
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Location = new System.Drawing.Point(8, 92);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(34, 13);
            this.price_lbl.TabIndex = 2;
            this.price_lbl.Text = "Price:";
            // 
            // model_lbl
            // 
            this.model_lbl.AutoSize = true;
            this.model_lbl.Location = new System.Drawing.Point(8, 63);
            this.model_lbl.Name = "model_lbl";
            this.model_lbl.Size = new System.Drawing.Size(39, 13);
            this.model_lbl.TabIndex = 1;
            this.model_lbl.Text = "Model:";
            // 
            // make_lbl
            // 
            this.make_lbl.AutoSize = true;
            this.make_lbl.Location = new System.Drawing.Point(8, 34);
            this.make_lbl.Name = "make_lbl";
            this.make_lbl.Size = new System.Drawing.Size(37, 13);
            this.make_lbl.TabIndex = 0;
            this.make_lbl.Text = "Make:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_inventory);
            this.groupBox1.Location = new System.Drawing.Point(229, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 398);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Inventory";
            // 
            // lst_inventory
            // 
            this.lst_inventory.FormattingEnabled = true;
            this.lst_inventory.Location = new System.Drawing.Point(6, 31);
            this.lst_inventory.Name = "lst_inventory";
            this.lst_inventory.Size = new System.Drawing.Size(208, 355);
            this.lst_inventory.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_cart);
            this.groupBox2.Location = new System.Drawing.Point(561, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 398);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shopping Cart";
            // 
            // lst_cart
            // 
            this.lst_cart.FormattingEnabled = true;
            this.lst_cart.Location = new System.Drawing.Point(6, 30);
            this.lst_cart.Name = "lst_cart";
            this.lst_cart.Size = new System.Drawing.Size(208, 355);
            this.lst_cart.TabIndex = 0;
            // 
            // add_to_cart_btn
            // 
            this.add_to_cart_btn.Location = new System.Drawing.Point(455, 138);
            this.add_to_cart_btn.Name = "add_to_cart_btn";
            this.add_to_cart_btn.Size = new System.Drawing.Size(100, 28);
            this.add_to_cart_btn.TabIndex = 6;
            this.add_to_cart_btn.Text = "Add to cart -->";
            this.add_to_cart_btn.UseVisualStyleBackColor = true;
            this.add_to_cart_btn.Click += new System.EventHandler(this.add_to_cart_btn_Click);
            // 
            // checkout_btn
            // 
            this.checkout_btn.Location = new System.Drawing.Point(455, 172);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Size = new System.Drawing.Size(100, 28);
            this.checkout_btn.TabIndex = 7;
            this.checkout_btn.Text = "Checkout";
            this.checkout_btn.UseVisualStyleBackColor = true;
            this.checkout_btn.Click += new System.EventHandler(this.checkout_btn_Click);
            // 
            // total_txt_lbl
            // 
            this.total_txt_lbl.AutoSize = true;
            this.total_txt_lbl.Location = new System.Drawing.Point(455, 210);
            this.total_txt_lbl.Name = "total_txt_lbl";
            this.total_txt_lbl.Size = new System.Drawing.Size(58, 13);
            this.total_txt_lbl.TabIndex = 8;
            this.total_txt_lbl.Text = "Total Cost:";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Location = new System.Drawing.Point(519, 210);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(34, 13);
            this.total_lbl.TabIndex = 9;
            this.total_lbl.Text = "$0.00";
            // 
            // CarShopGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.total_txt_lbl);
            this.Controls.Add(this.add_to_cart_btn);
            this.Controls.Add(this.checkout_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createCarGroup);
            this.Name = "CarShopGUI";
            this.Text = "cars.bg";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.createCarGroup.ResumeLayout(false);
            this.createCarGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox createCarGroup;
        private System.Windows.Forms.TextBox make_txt;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label model_lbl;
        private System.Windows.Forms.Label make_lbl;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.TextBox model_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_inventory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button create_car_btn;
        private System.Windows.Forms.ListBox lst_cart;
        private System.Windows.Forms.Button add_to_cart_btn;
        private System.Windows.Forms.Button checkout_btn;
        private System.Windows.Forms.Label total_txt_lbl;
        private System.Windows.Forms.Label total_lbl;
    }
}

