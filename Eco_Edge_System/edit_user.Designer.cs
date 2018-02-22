namespace Eco_Edge_System
{
    partial class edit_user
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_user));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.special = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.type1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.adrs = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cnum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.fname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMetroTextbox7 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox8 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuiOSSwitch2 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 7;
            this.bunifuElipse2.TargetControl = this;
            // 
            // special
            // 
            this.special.BackColor = System.Drawing.Color.WhiteSmoke;
            this.special.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.special.BorderColorIdle = System.Drawing.Color.Gray;
            this.special.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.special.BorderThickness = 3;
            this.special.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.special.Enabled = false;
            this.special.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.special.ForeColor = System.Drawing.Color.Black;
            this.special.isPassword = false;
            this.special.Location = new System.Drawing.Point(46, 332);
            this.special.Margin = new System.Windows.Forms.Padding(4);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(437, 44);
            this.special.TabIndex = 35;
            this.special.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // type1
            // 
            this.type1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.type1.BorderRadius = 3;
            this.type1.DisabledColor = System.Drawing.Color.Transparent;
            this.type1.Enabled = false;
            this.type1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type1.ForeColor = System.Drawing.Color.Black;
            this.type1.Items = new string[] {
        "Admin",
        "Operation Manager",
        "Supervisor"};
            this.type1.Location = new System.Drawing.Point(399, 279);
            this.type1.Name = "type1";
            this.type1.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.type1.onHoverColor = System.Drawing.Color.White;
            this.type1.selectedIndex = 0;
            this.type1.Size = new System.Drawing.Size(299, 42);
            this.type1.TabIndex = 34;
            // 
            // bdate
            // 
            this.bdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bdate.BorderRadius = 0;
            this.bdate.Enabled = false;
            this.bdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate.ForeColor = System.Drawing.Color.Black;
            this.bdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bdate.FormatCustom = "dd/MM/yyyy";
            this.bdate.Location = new System.Drawing.Point(57, 279);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(299, 43);
            this.bdate.TabIndex = 33;
            this.bdate.Value = new System.DateTime(2018, 1, 8, 0, 0, 0, 0);
            this.bdate.onValueChanged += new System.EventHandler(this.bdate_onValueChanged);
            // 
            // adrs
            // 
            this.adrs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adrs.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.adrs.BorderColorIdle = System.Drawing.Color.Gray;
            this.adrs.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.adrs.BorderThickness = 3;
            this.adrs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adrs.Enabled = false;
            this.adrs.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adrs.ForeColor = System.Drawing.Color.Black;
            this.adrs.isPassword = false;
            this.adrs.Location = new System.Drawing.Point(46, 224);
            this.adrs.Margin = new System.Windows.Forms.Padding(4);
            this.adrs.Name = "adrs";
            this.adrs.Size = new System.Drawing.Size(663, 44);
            this.adrs.TabIndex = 32;
            this.adrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.email.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.email.BorderColorIdle = System.Drawing.Color.Gray;
            this.email.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.email.BorderThickness = 3;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Enabled = false;
            this.email.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.isPassword = false;
            this.email.Location = new System.Drawing.Point(388, 170);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(321, 44);
            this.email.TabIndex = 31;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cnum
            // 
            this.cnum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cnum.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.cnum.BorderColorIdle = System.Drawing.Color.Gray;
            this.cnum.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.cnum.BorderThickness = 3;
            this.cnum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnum.Enabled = false;
            this.cnum.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnum.ForeColor = System.Drawing.Color.Black;
            this.cnum.isPassword = false;
            this.cnum.Location = new System.Drawing.Point(46, 170);
            this.cnum.Margin = new System.Windows.Forms.Padding(4);
            this.cnum.Name = "cnum";
            this.cnum.Size = new System.Drawing.Size(321, 44);
            this.cnum.TabIndex = 30;
            this.cnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnum.OnValueChanged += new System.EventHandler(this.cnum_OnValueChanged);
            // 
            // lname
            // 
            this.lname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lname.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.lname.BorderColorIdle = System.Drawing.Color.Gray;
            this.lname.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.lname.BorderThickness = 3;
            this.lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lname.Enabled = false;
            this.lname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.Color.Black;
            this.lname.isPassword = false;
            this.lname.Location = new System.Drawing.Point(388, 116);
            this.lname.Margin = new System.Windows.Forms.Padding(4);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(321, 44);
            this.lname.TabIndex = 29;
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fname.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.fname.BorderColorIdle = System.Drawing.Color.Gray;
            this.fname.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.fname.BorderThickness = 3;
            this.fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname.Enabled = false;
            this.fname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.Color.Black;
            this.fname.isPassword = false;
            this.fname.Location = new System.Drawing.Point(46, 116);
            this.fname.Margin = new System.Windows.Forms.Padding(4);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(321, 44);
            this.fname.TabIndex = 28;
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(316, 76);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(127, 24);
            this.bunifuCustomLabel1.TabIndex = 26;
            this.bunifuCustomLabel1.Text = "View User";
            // 
            // bunifuMetroTextbox7
            // 
            this.bunifuMetroTextbox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuMetroTextbox7.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.bunifuMetroTextbox7.BorderColorIdle = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox7.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.bunifuMetroTextbox7.BorderThickness = 3;
            this.bunifuMetroTextbox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox7.Enabled = false;
            this.bunifuMetroTextbox7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox7.ForeColor = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox7.isPassword = false;
            this.bunifuMetroTextbox7.Location = new System.Drawing.Point(46, 278);
            this.bunifuMetroTextbox7.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox7.Name = "bunifuMetroTextbox7";
            this.bunifuMetroTextbox7.Size = new System.Drawing.Size(321, 44);
            this.bunifuMetroTextbox7.TabIndex = 36;
            this.bunifuMetroTextbox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox8
            // 
            this.bunifuMetroTextbox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuMetroTextbox8.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.bunifuMetroTextbox8.BorderColorIdle = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox8.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.bunifuMetroTextbox8.BorderThickness = 3;
            this.bunifuMetroTextbox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox8.Enabled = false;
            this.bunifuMetroTextbox8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox8.ForeColor = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox8.isPassword = false;
            this.bunifuMetroTextbox8.Location = new System.Drawing.Point(388, 278);
            this.bunifuMetroTextbox8.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox8.Name = "bunifuMetroTextbox8";
            this.bunifuMetroTextbox8.Size = new System.Drawing.Size(321, 44);
            this.bunifuMetroTextbox8.TabIndex = 37;
            this.bunifuMetroTextbox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(507, 332);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(140, 16);
            this.bunifuCustomLabel2.TabIndex = 42;
            this.bunifuCustomLabel2.Text = "Reset Username";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(507, 356);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(141, 16);
            this.bunifuCustomLabel3.TabIndex = 43;
            this.bunifuCustomLabel3.Text = "Reset Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Eco_Edge_System.Properties.Resources.pencil_edit_button__1_;
            this.pictureBox2.Location = new System.Drawing.Point(399, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Enabled = false;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(673, 332);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch1.TabIndex = 46;
            this.bunifuiOSSwitch1.Value = true;
            this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // bunifuiOSSwitch2
            // 
            this.bunifuiOSSwitch2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch2.BackgroundImage")));
            this.bunifuiOSSwitch2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch2.Enabled = false;
            this.bunifuiOSSwitch2.Location = new System.Drawing.Point(673, 358);
            this.bunifuiOSSwitch2.Name = "bunifuiOSSwitch2";
            this.bunifuiOSSwitch2.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch2.OnColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuiOSSwitch2.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch2.TabIndex = 45;
            this.bunifuiOSSwitch2.Value = true;
            this.bunifuiOSSwitch2.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch2_OnValueChange);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Eco_Edge_System.Properties.Resources.edit_icon_png_24;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(670, 86);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(39, 23);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 38;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eco_Edge_System.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(341, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Update";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuThinButton22.Location = new System.Drawing.Point(619, 402);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(89, 41);
            this.bunifuThinButton22.TabIndex = 25;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.LightSlateGray;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Cancel";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.LightSlateGray;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.LightSlateGray;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(517, 402);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(89, 41);
            this.bunifuThinButton21.TabIndex = 24;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // edit_user
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(757, 466);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuiOSSwitch1);
            this.Controls.Add(this.bunifuiOSSwitch2);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.special);
            this.Controls.Add(this.type1);
            this.Controls.Add(this.bdate);
            this.Controls.Add(this.adrs);
            this.Controls.Add(this.email);
            this.Controls.Add(this.cnum);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuMetroTextbox7);
            this.Controls.Add(this.bunifuMetroTextbox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit_user";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "edit_user";
            this.Load += new System.EventHandler(this.edit_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox special;
        private Bunifu.Framework.UI.BunifuDropdown type1;
        private Bunifu.Framework.UI.BunifuDatepicker bdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox adrs;
        private Bunifu.Framework.UI.BunifuMetroTextbox email;
        private Bunifu.Framework.UI.BunifuMetroTextbox cnum;
        private Bunifu.Framework.UI.BunifuMetroTextbox lname;
        private Bunifu.Framework.UI.BunifuMetroTextbox fname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox7;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}