﻿namespace CarShopGUI
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
            this.addCarGroup = new System.Windows.Forms.GroupBox();
            this.create_car_btn = new System.Windows.Forms.Button();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.model_txt = new System.Windows.Forms.TextBox();
            this.make_txt = new System.Windows.Forms.TextBox();
            this.price_lbl = new System.Windows.Forms.Label();
            this.model_lbl = new System.Windows.Forms.Label();
            this.make_lbl = new System.Windows.Forms.Label();
            this.carInventoryGroup = new System.Windows.Forms.GroupBox();
            this.lst_inventory = new System.Windows.Forms.ListBox();
            this.shoppingCartGroup = new System.Windows.Forms.GroupBox();
            this.lst_cart = new System.Windows.Forms.ListBox();
            this.add_to_cart_btn = new System.Windows.Forms.Button();
            this.checkout_btn = new System.Windows.Forms.Button();
            this.total_txt_lbl = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.credits_btn = new System.Windows.Forms.Button();
            this.exit_credits_btn = new System.Windows.Forms.Button();
            this.theme_btn = new System.Windows.Forms.Button();
            this.addCarGroup.SuspendLayout();
            this.carInventoryGroup.SuspendLayout();
            this.shoppingCartGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCarGroup
            // 
            this.addCarGroup.Controls.Add(this.create_car_btn);
            this.addCarGroup.Controls.Add(this.price_txt);
            this.addCarGroup.Controls.Add(this.model_txt);
            this.addCarGroup.Controls.Add(this.make_txt);
            this.addCarGroup.Controls.Add(this.price_lbl);
            this.addCarGroup.Controls.Add(this.model_lbl);
            this.addCarGroup.Controls.Add(this.make_lbl);
            this.addCarGroup.Location = new System.Drawing.Point(13, 13);
            this.addCarGroup.Name = "addCarGroup";
            this.addCarGroup.Size = new System.Drawing.Size(200, 187);
            this.addCarGroup.TabIndex = 0;
            this.addCarGroup.TabStop = false;
            this.addCarGroup.Text = "Добави кола";
            // 
            // create_car_btn
            // 
            this.create_car_btn.Location = new System.Drawing.Point(65, 125);
            this.create_car_btn.Name = "create_car_btn";
            this.create_car_btn.Size = new System.Drawing.Size(100, 42);
            this.create_car_btn.TabIndex = 3;
            this.create_car_btn.Text = "Добави към инвентар";
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
            this.price_lbl.Size = new System.Drawing.Size(36, 13);
            this.price_lbl.TabIndex = 2;
            this.price_lbl.Text = "Цена:";
            // 
            // model_lbl
            // 
            this.model_lbl.AutoSize = true;
            this.model_lbl.Location = new System.Drawing.Point(8, 63);
            this.model_lbl.Name = "model_lbl";
            this.model_lbl.Size = new System.Drawing.Size(43, 13);
            this.model_lbl.TabIndex = 1;
            this.model_lbl.Text = "Модел:";
            // 
            // make_lbl
            // 
            this.make_lbl.AutoSize = true;
            this.make_lbl.Location = new System.Drawing.Point(8, 34);
            this.make_lbl.Name = "make_lbl";
            this.make_lbl.Size = new System.Drawing.Size(43, 13);
            this.make_lbl.TabIndex = 0;
            this.make_lbl.Text = "Марка:";
            // 
            // carInventoryGroup
            // 
            this.carInventoryGroup.Controls.Add(this.lst_inventory);
            this.carInventoryGroup.Location = new System.Drawing.Point(229, 13);
            this.carInventoryGroup.Name = "carInventoryGroup";
            this.carInventoryGroup.Size = new System.Drawing.Size(220, 398);
            this.carInventoryGroup.TabIndex = 1;
            this.carInventoryGroup.TabStop = false;
            this.carInventoryGroup.Text = "Инвентар";
            // 
            // lst_inventory
            // 
            this.lst_inventory.BackColor = System.Drawing.Color.White;
            this.lst_inventory.FormattingEnabled = true;
            this.lst_inventory.Location = new System.Drawing.Point(6, 31);
            this.lst_inventory.Name = "lst_inventory";
            this.lst_inventory.Size = new System.Drawing.Size(208, 355);
            this.lst_inventory.TabIndex = 0;
            // 
            // shoppingCartGroup
            // 
            this.shoppingCartGroup.Controls.Add(this.lst_cart);
            this.shoppingCartGroup.Location = new System.Drawing.Point(561, 13);
            this.shoppingCartGroup.Name = "shoppingCartGroup";
            this.shoppingCartGroup.Size = new System.Drawing.Size(220, 398);
            this.shoppingCartGroup.TabIndex = 2;
            this.shoppingCartGroup.TabStop = false;
            this.shoppingCartGroup.Text = "Количка";
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
            this.add_to_cart_btn.Location = new System.Drawing.Point(455, 118);
            this.add_to_cart_btn.Name = "add_to_cart_btn";
            this.add_to_cart_btn.Size = new System.Drawing.Size(100, 36);
            this.add_to_cart_btn.TabIndex = 6;
            this.add_to_cart_btn.Text = "Добави в количката -->";
            this.add_to_cart_btn.UseVisualStyleBackColor = true;
            this.add_to_cart_btn.Click += new System.EventHandler(this.add_to_cart_btn_Click);
            // 
            // checkout_btn
            // 
            this.checkout_btn.Location = new System.Drawing.Point(455, 160);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Size = new System.Drawing.Size(100, 36);
            this.checkout_btn.TabIndex = 7;
            this.checkout_btn.Text = "Купи";
            this.checkout_btn.UseVisualStyleBackColor = true;
            this.checkout_btn.Click += new System.EventHandler(this.checkout_btn_Click);
            // 
            // total_txt_lbl
            // 
            this.total_txt_lbl.AutoSize = true;
            this.total_txt_lbl.Location = new System.Drawing.Point(455, 210);
            this.total_txt_lbl.Name = "total_txt_lbl";
            this.total_txt_lbl.Size = new System.Drawing.Size(36, 13);
            this.total_txt_lbl.TabIndex = 8;
            this.total_txt_lbl.Text = "Цена:";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Location = new System.Drawing.Point(494, 210);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(46, 13);
            this.total_lbl.TabIndex = 9;
            this.total_lbl.Text = "0.00 лв.";
            // 
            // credits_btn
            // 
            this.credits_btn.Location = new System.Drawing.Point(10, 219);
            this.credits_btn.Name = "credits_btn";
            this.credits_btn.Size = new System.Drawing.Size(100, 36);
            this.credits_btn.TabIndex = 10;
            this.credits_btn.Text = "Кредити";
            this.credits_btn.UseVisualStyleBackColor = true;
            this.credits_btn.Click += new System.EventHandler(this.credits_btn_Click);
            // 
            // exit_credits_btn
            // 
            this.exit_credits_btn.Location = new System.Drawing.Point(691, 418);
            this.exit_credits_btn.Name = "exit_credits_btn";
            this.exit_credits_btn.Size = new System.Drawing.Size(100, 28);
            this.exit_credits_btn.TabIndex = 11;
            this.exit_credits_btn.Text = "Exit";
            this.exit_credits_btn.UseVisualStyleBackColor = true;
            this.exit_credits_btn.Click += new System.EventHandler(this.exit_credits_btn_Click);
            // 
            // theme_btn
            // 
            this.theme_btn.Location = new System.Drawing.Point(116, 219);
            this.theme_btn.Name = "theme_btn";
            this.theme_btn.Size = new System.Drawing.Size(100, 36);
            this.theme_btn.TabIndex = 12;
            this.theme_btn.Text = "Тема";
            this.theme_btn.UseVisualStyleBackColor = true;
            this.theme_btn.Click += new System.EventHandler(this.theme_btn_Click);
            // 
            // CarShopGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.theme_btn);
            this.Controls.Add(this.exit_credits_btn);
            this.Controls.Add(this.credits_btn);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.total_txt_lbl);
            this.Controls.Add(this.add_to_cart_btn);
            this.Controls.Add(this.checkout_btn);
            this.Controls.Add(this.shoppingCartGroup);
            this.Controls.Add(this.carInventoryGroup);
            this.Controls.Add(this.addCarGroup);
            this.Name = "CarShopGUI";
            this.Text = "cars.bg";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.addCarGroup.ResumeLayout(false);
            this.addCarGroup.PerformLayout();
            this.carInventoryGroup.ResumeLayout(false);
            this.shoppingCartGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox addCarGroup;
        private System.Windows.Forms.TextBox make_txt;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label model_lbl;
        private System.Windows.Forms.Label make_lbl;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.TextBox model_txt;
        private System.Windows.Forms.GroupBox carInventoryGroup;
        private System.Windows.Forms.ListBox lst_inventory;
        private System.Windows.Forms.GroupBox shoppingCartGroup;
        private System.Windows.Forms.Button create_car_btn;
        private System.Windows.Forms.ListBox lst_cart;
        private System.Windows.Forms.Button add_to_cart_btn;
        private System.Windows.Forms.Button checkout_btn;
        private System.Windows.Forms.Label total_txt_lbl;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Button credits_btn;
        private System.Windows.Forms.Button exit_credits_btn;
        private System.Windows.Forms.Button theme_btn;
    }
}

