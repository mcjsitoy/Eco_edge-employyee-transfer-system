namespace Eco_Edge_System
{
    partial class add_new_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_new_user));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cnum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.adrs = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.type = new Bunifu.Framework.UI.BunifuDropdown();
            this.special = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox7 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox8 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(317, 78);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(123, 24);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "New User";
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fname.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.fname.BorderColorIdle = System.Drawing.Color.Gray;
            this.fname.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.fname.BorderThickness = 3;
            this.fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.Color.Black;
            this.fname.isPassword = false;
            this.fname.Location = new System.Drawing.Point(47, 118);
            this.fname.Margin = new System.Windows.Forms.Padding(4);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(321, 44);
            this.fname.TabIndex = 14;
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fname.OnValueChanged += new System.EventHandler(this.fname_OnValueChanged);
            this.fname.Load += new System.EventHandler(this.fname_Load);
            this.fname.Enter += new System.EventHandler(this.fname_Enter);
            this.fname.Leave += new System.EventHandler(this.fname_Leave);
            // 
            // lname
            // 
            this.lname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lname.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.lname.BorderColorIdle = System.Drawing.Color.Gray;
            this.lname.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.lname.BorderThickness = 3;
            this.lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.Color.Black;
            this.lname.isPassword = false;
            this.lname.Location = new System.Drawing.Point(389, 118);
            this.lname.Margin = new System.Windows.Forms.Padding(4);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(321, 44);
            this.lname.TabIndex = 15;
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lname.Enter += new System.EventHandler(this.lname_Enter);
            this.lname.Leave += new System.EventHandler(this.lname_Leave);
            // 
            // cnum
            // 
            this.cnum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cnum.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.cnum.BorderColorIdle = System.Drawing.Color.Gray;
            this.cnum.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.cnum.BorderThickness = 3;
            this.cnum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnum.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnum.ForeColor = System.Drawing.Color.Black;
            this.cnum.isPassword = false;
            this.cnum.Location = new System.Drawing.Point(47, 172);
            this.cnum.Margin = new System.Windows.Forms.Padding(4);
            this.cnum.Name = "cnum";
            this.cnum.Size = new System.Drawing.Size(321, 44);
            this.cnum.TabIndex = 16;
            this.cnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnum.Enter += new System.EventHandler(this.cnum_Enter);
            this.cnum.Leave += new System.EventHandler(this.cnum_Leave);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.email.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.email.BorderColorIdle = System.Drawing.Color.Gray;
            this.email.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.email.BorderThickness = 3;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.isPassword = false;
            this.email.Location = new System.Drawing.Point(389, 172);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(321, 44);
            this.email.TabIndex = 17;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.Enter += new System.EventHandler(this.email_Enter);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // adrs
            // 
            this.adrs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adrs.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.adrs.BorderColorIdle = System.Drawing.Color.Gray;
            this.adrs.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.adrs.BorderThickness = 3;
            this.adrs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adrs.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adrs.ForeColor = System.Drawing.Color.Black;
            this.adrs.isPassword = false;
            this.adrs.Location = new System.Drawing.Point(47, 226);
            this.adrs.Margin = new System.Windows.Forms.Padding(4);
            this.adrs.Name = "adrs";
            this.adrs.Size = new System.Drawing.Size(663, 44);
            this.adrs.TabIndex = 18;
            this.adrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adrs.Enter += new System.EventHandler(this.adrs_Enter);
            this.adrs.Leave += new System.EventHandler(this.adrs_Leave);
            // 
            // bdate
            // 
            this.bdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bdate.BorderRadius = 0;
            this.bdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate.ForeColor = System.Drawing.Color.Black;
            this.bdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bdate.FormatCustom = null;
            this.bdate.Location = new System.Drawing.Point(59, 282);
            this.bdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(299, 42);
            this.bdate.TabIndex = 19;
            this.bdate.Value = new System.DateTime(2018, 1, 5, 4, 54, 34, 237);
            this.bdate.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.WhiteSmoke;
            this.type.BorderRadius = 3;
            this.type.DisabledColor = System.Drawing.Color.Gray;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.Color.Black;
            this.type.Items = new string[] {
        "Admin",
        "Operation Manager",
        "Supervisor"};
            this.type.Location = new System.Drawing.Point(400, 281);
            this.type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.type.Name = "type";
            this.type.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.type.onHoverColor = System.Drawing.Color.White;
            this.type.selectedIndex = 0;
            this.type.Size = new System.Drawing.Size(299, 42);
            this.type.TabIndex = 20;
            // 
            // special
            // 
            this.special.BackColor = System.Drawing.Color.WhiteSmoke;
            this.special.BorderColorFocused = System.Drawing.Color.DeepSkyBlue;
            this.special.BorderColorIdle = System.Drawing.Color.Gray;
            this.special.BorderColorMouseHover = System.Drawing.Color.DeepSkyBlue;
            this.special.BorderThickness = 3;
            this.special.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.special.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.special.ForeColor = System.Drawing.Color.Black;
            this.special.isPassword = false;
            this.special.Location = new System.Drawing.Point(47, 337);
            this.special.Margin = new System.Windows.Forms.Padding(4);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(663, 44);
            this.special.TabIndex = 21;
            this.special.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.special.Enter += new System.EventHandler(this.special_Enter);
            this.special.Leave += new System.EventHandler(this.special_Leave);
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
            this.bunifuMetroTextbox7.Location = new System.Drawing.Point(47, 280);
            this.bunifuMetroTextbox7.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox7.Name = "bunifuMetroTextbox7";
            this.bunifuMetroTextbox7.Size = new System.Drawing.Size(321, 44);
            this.bunifuMetroTextbox7.TabIndex = 22;
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
            this.bunifuMetroTextbox8.Location = new System.Drawing.Point(389, 280);
            this.bunifuMetroTextbox8.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox8.Name = "bunifuMetroTextbox8";
            this.bunifuMetroTextbox8.Size = new System.Drawing.Size(321, 44);
            this.bunifuMetroTextbox8.TabIndex = 23;
            this.bunifuMetroTextbox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eco_Edge_System.Properties.Resources.group__1_;
            this.pictureBox1.Location = new System.Drawing.Point(321, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
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
            this.bunifuThinButton22.ButtonText = "Save";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuThinButton22.Location = new System.Drawing.Point(621, 402);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(89, 42);
            this.bunifuThinButton22.TabIndex = 11;
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(519, 402);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(89, 42);
            this.bunifuThinButton21.TabIndex = 0;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // add_new_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(757, 466);
            this.Controls.Add(this.special);
            this.Controls.Add(this.type);
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
            this.Name = "add_new_user";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "add_new_user";
            this.Load += new System.EventHandler(this.add_new_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox special;
        private Bunifu.Framework.UI.BunifuDropdown type;
        private Bunifu.Framework.UI.BunifuDatepicker bdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox adrs;
        private Bunifu.Framework.UI.BunifuMetroTextbox email;
        private Bunifu.Framework.UI.BunifuMetroTextbox cnum;
        private Bunifu.Framework.UI.BunifuMetroTextbox lname;
        private Bunifu.Framework.UI.BunifuMetroTextbox fname;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox7;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox8;
    }
}