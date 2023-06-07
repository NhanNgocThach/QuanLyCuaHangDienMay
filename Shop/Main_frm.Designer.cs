namespace Shop
{
    partial class Main_frm
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
            this.slidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.res_bot = new Guna.UI2.WinForms.Guna2Panel();
            this.custom_btn = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_guest = new Guna.UI2.WinForms.Guna2Button();
            this.btn_bill = new Guna.UI2.WinForms.Guna2Button();
            this.btn_product = new Guna.UI2.WinForms.Guna2Button();
            this.btn_home = new Guna.UI2.WinForms.Guna2Button();
            this.logo = new Guna.UI2.WinForms.Guna2Panel();
            this.mylogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.res_top = new Guna.UI2.WinForms.Guna2Panel();
            this.container = new Guna.UI2.WinForms.Guna2Panel();
            this.slidebar.SuspendLayout();
            this.custom_btn.SuspendLayout();
            this.logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mylogo)).BeginInit();
            this.SuspendLayout();
            // 
            // slidebar
            // 
            this.slidebar.Controls.Add(this.res_bot);
            this.slidebar.Controls.Add(this.custom_btn);
            this.slidebar.Controls.Add(this.logo);
            this.slidebar.Controls.Add(this.res_top);
            this.slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidebar.Location = new System.Drawing.Point(0, 0);
            this.slidebar.Name = "slidebar";
            this.slidebar.Size = new System.Drawing.Size(153, 450);
            this.slidebar.TabIndex = 0;
            // 
            // res_bot
            // 
            this.res_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.res_bot.Location = new System.Drawing.Point(0, 427);
            this.res_bot.Name = "res_bot";
            this.res_bot.Size = new System.Drawing.Size(153, 23);
            this.res_bot.TabIndex = 0;
            // 
            // custom_btn
            // 
            this.custom_btn.Controls.Add(this.btn_guest);
            this.custom_btn.Controls.Add(this.btn_bill);
            this.custom_btn.Controls.Add(this.btn_product);
            this.custom_btn.Controls.Add(this.btn_home);
            this.custom_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custom_btn.Location = new System.Drawing.Point(0, 122);
            this.custom_btn.Name = "custom_btn";
            this.custom_btn.Size = new System.Drawing.Size(153, 328);
            this.custom_btn.TabIndex = 0;
            // 
            // btn_guest
            // 
            this.btn_guest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_guest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_guest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_guest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_guest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_guest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_guest.ForeColor = System.Drawing.Color.White;
            this.btn_guest.Location = new System.Drawing.Point(0, 135);
            this.btn_guest.Name = "btn_guest";
            this.btn_guest.Size = new System.Drawing.Size(153, 45);
            this.btn_guest.TabIndex = 0;
            this.btn_guest.Text = "Khách hàng";
            this.btn_guest.Click += new System.EventHandler(this.btn_guest_Click);
            // 
            // btn_bill
            // 
            this.btn_bill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_bill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_bill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_bill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_bill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_bill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_bill.ForeColor = System.Drawing.Color.White;
            this.btn_bill.Location = new System.Drawing.Point(0, 90);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(153, 45);
            this.btn_bill.TabIndex = 0;
            this.btn_bill.Text = "Hóa đơn";
            // 
            // btn_product
            // 
            this.btn_product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_product.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_product.ForeColor = System.Drawing.Color.White;
            this.btn_product.Location = new System.Drawing.Point(0, 45);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(153, 45);
            this.btn_product.TabIndex = 0;
            this.btn_product.Text = "Sản phẩm";
            // 
            // btn_home
            // 
            this.btn_home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(153, 45);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            // 
            // logo
            // 
            this.logo.Controls.Add(this.mylogo);
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 22);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(153, 100);
            this.logo.TabIndex = 0;
            // 
            // mylogo
            // 
            this.mylogo.BackColor = System.Drawing.Color.Transparent;
            this.mylogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mylogo.FillColor = System.Drawing.Color.Transparent;
            this.mylogo.ImageRotate = 0F;
            this.mylogo.Location = new System.Drawing.Point(0, 0);
            this.mylogo.Name = "mylogo";
            this.mylogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.mylogo.Size = new System.Drawing.Size(153, 100);
            this.mylogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mylogo.TabIndex = 0;
            this.mylogo.TabStop = false;
            this.mylogo.UseTransparentBackground = true;
            // 
            // res_top
            // 
            this.res_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.res_top.Location = new System.Drawing.Point(0, 0);
            this.res_top.Name = "res_top";
            this.res_top.Size = new System.Drawing.Size(153, 22);
            this.res_top.TabIndex = 0;
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(153, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(647, 450);
            this.container.TabIndex = 1;
            // 
            // Main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.container);
            this.Controls.Add(this.slidebar);
            this.Name = "Main_frm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_frm_Load);
            this.slidebar.ResumeLayout(false);
            this.custom_btn.ResumeLayout(false);
            this.logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mylogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel slidebar;
        private Guna.UI2.WinForms.Guna2Panel container;
        private Guna.UI2.WinForms.Guna2Panel res_bot;
        private Guna.UI2.WinForms.Guna2Panel custom_btn;
        private Guna.UI2.WinForms.Guna2Button btn_bill;
        private Guna.UI2.WinForms.Guna2Button btn_product;
        private Guna.UI2.WinForms.Guna2Button btn_home;
        private Guna.UI2.WinForms.Guna2Panel logo;
        private Guna.UI2.WinForms.Guna2Panel res_top;
        private Guna.UI2.WinForms.Guna2Button btn_guest;
        private Guna.UI2.WinForms.Guna2CirclePictureBox mylogo;
    }
}

