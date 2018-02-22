namespace EcoEdgeSystem
{
    partial class edit_password
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
            this.button2 = new System.Windows.Forms.Button();
            this.confirmedPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(182, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // confirmedPass
            // 
            this.confirmedPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmedPass.Location = new System.Drawing.Point(182, 144);
            this.confirmedPass.Multiline = true;
            this.confirmedPass.Name = "confirmedPass";
            this.confirmedPass.Size = new System.Drawing.Size(346, 39);
            this.confirmedPass.TabIndex = 4;
            this.confirmedPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmedPass.Enter += new System.EventHandler(this.confirmedPass_Enter);
            this.confirmedPass.Leave += new System.EventHandler(this.confirmedPass_Leave);
            // 
            // newPass
            // 
            this.newPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPass.Location = new System.Drawing.Point(182, 90);
            this.newPass.Multiline = true;
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(346, 39);
            this.newPass.TabIndex = 3;
            this.newPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPass.Enter += new System.EventHandler(this.newPass_Enter);
            this.newPass.Leave += new System.EventHandler(this.newPass_Leave);
            // 
            // oldPass
            // 
            this.oldPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPass.Location = new System.Drawing.Point(182, 34);
            this.oldPass.Multiline = true;
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(346, 39);
            this.oldPass.TabIndex = 2;
            this.oldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldPass.TextChanged += new System.EventHandler(this.oldPass_TextChanged);
            this.oldPass.Enter += new System.EventHandler(this.oldPass_Enter);
            this.oldPass.Leave += new System.EventHandler(this.oldPass_Leave_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(358, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.confirmedPass);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.oldPass);
            this.Name = "edit_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Password";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox confirmedPass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.Button button1;
    }
}