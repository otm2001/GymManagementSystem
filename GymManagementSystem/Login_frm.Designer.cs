namespace GymManagementSystem
{
    partial class Login_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_frm));
            this.Login_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.HideShowPass_btn = new Guna.UI2.WinForms.Guna2Button();
            this.UserName_Txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Password_Txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.label_IncorrectMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_Btn
            // 
            this.Login_Btn.BorderRadius = 10;
            this.Login_Btn.CheckedState.Parent = this.Login_Btn;
            this.Login_Btn.CustomImages.Parent = this.Login_Btn;
            this.Login_Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Login_Btn.ForeColor = System.Drawing.Color.White;
            this.Login_Btn.HoverState.Parent = this.Login_Btn;
            this.Login_Btn.Location = new System.Drawing.Point(480, 326);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.ShadowDecoration.Parent = this.Login_Btn;
            this.Login_Btn.Size = new System.Drawing.Size(295, 45);
            this.Login_Btn.TabIndex = 3;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            this.Login_Btn.MouseHover += new System.EventHandler(this.Login_Btn_MouseHover);
            // 
            // HideShowPass_btn
            // 
            this.HideShowPass_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.HideShowPass_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.HideShowPass_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.HideShowPass_btn.CheckedState.Parent = this.HideShowPass_btn;
            this.HideShowPass_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideShowPass_btn.CustomImages.Parent = this.HideShowPass_btn;
            this.HideShowPass_btn.FillColor = System.Drawing.Color.White;
            this.HideShowPass_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HideShowPass_btn.ForeColor = System.Drawing.Color.White;
            this.HideShowPass_btn.HoverState.BorderColor = System.Drawing.Color.White;
            this.HideShowPass_btn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.HideShowPass_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.HideShowPass_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.HideShowPass_btn.HoverState.Parent = this.HideShowPass_btn;
            this.HideShowPass_btn.Image = global::GymManagementSystem.Properties.Resources.hide__1_;
            this.HideShowPass_btn.ImageSize = new System.Drawing.Size(35, 35);
            this.HideShowPass_btn.Location = new System.Drawing.Point(782, 232);
            this.HideShowPass_btn.Name = "HideShowPass_btn";
            this.HideShowPass_btn.ShadowDecoration.Parent = this.HideShowPass_btn;
            this.HideShowPass_btn.Size = new System.Drawing.Size(54, 53);
            this.HideShowPass_btn.TabIndex = 6;
            this.HideShowPass_btn.Visible = false;
            this.HideShowPass_btn.Click += new System.EventHandler(this.HideShowPass_btn_Click);
            // 
            // UserName_Txt
            // 
            this.UserName_Txt.BorderColor = System.Drawing.Color.DarkGray;
            this.UserName_Txt.BorderRadius = 15;
            this.UserName_Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName_Txt.DefaultText = "";
            this.UserName_Txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserName_Txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserName_Txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName_Txt.DisabledState.Parent = this.UserName_Txt;
            this.UserName_Txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserName_Txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName_Txt.FocusedState.Parent = this.UserName_Txt;
            this.UserName_Txt.ForeColor = System.Drawing.Color.Black;
            this.UserName_Txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserName_Txt.HoverState.Parent = this.UserName_Txt;
            this.UserName_Txt.IconLeft = ((System.Drawing.Image)(resources.GetObject("UserName_Txt.IconLeft")));
            this.UserName_Txt.IconLeftOffset = new System.Drawing.Point(-1, -2);
            this.UserName_Txt.IconLeftSize = new System.Drawing.Size(30, 30);
            this.UserName_Txt.Location = new System.Drawing.Point(480, 147);
            this.UserName_Txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserName_Txt.Name = "UserName_Txt";
            this.UserName_Txt.PasswordChar = '\0';
            this.UserName_Txt.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserName_Txt.PlaceholderText = "UserName";
            this.UserName_Txt.SelectedText = "";
            this.UserName_Txt.ShadowDecoration.Parent = this.UserName_Txt;
            this.UserName_Txt.Size = new System.Drawing.Size(295, 53);
            this.UserName_Txt.TabIndex = 1;
            this.UserName_Txt.MouseEnter += new System.EventHandler(this.UserName_Txt_MouseEnter);
            this.UserName_Txt.MouseHover += new System.EventHandler(this.UserName_Txt_MouseHover);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(401, 532);
            this.guna2Panel1.TabIndex = 4;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // Password_Txt
            // 
            this.Password_Txt.BorderColor = System.Drawing.Color.DarkGray;
            this.Password_Txt.BorderRadius = 15;
            this.Password_Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_Txt.DefaultText = "";
            this.Password_Txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_Txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_Txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_Txt.DisabledState.Parent = this.Password_Txt;
            this.Password_Txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_Txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_Txt.FocusedState.Parent = this.Password_Txt;
            this.Password_Txt.ForeColor = System.Drawing.Color.Black;
            this.Password_Txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_Txt.HoverState.Parent = this.Password_Txt;
            this.Password_Txt.IconLeft = ((System.Drawing.Image)(resources.GetObject("Password_Txt.IconLeft")));
            this.Password_Txt.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.Password_Txt.IconLeftSize = new System.Drawing.Size(30, 30);
            this.Password_Txt.Location = new System.Drawing.Point(480, 232);
            this.Password_Txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password_Txt.Name = "Password_Txt";
            this.Password_Txt.PasswordChar = '\0';
            this.Password_Txt.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Password_Txt.PlaceholderText = "Password";
            this.Password_Txt.SelectedText = "";
            this.Password_Txt.ShadowDecoration.Parent = this.Password_Txt;
            this.Password_Txt.Size = new System.Drawing.Size(295, 53);
            this.Password_Txt.TabIndex = 2;
            this.Password_Txt.UseSystemPasswordChar = true;
            this.Password_Txt.TextChanged += new System.EventHandler(this.Password_Txt_TextChanged);
            // 
            // ToolTip1
            // 
            this.ToolTip1.AllowLinksHandling = true;
            this.ToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // label_IncorrectMessage
            // 
            this.label_IncorrectMessage.AutoSize = true;
            this.label_IncorrectMessage.BackColor = System.Drawing.Color.White;
            this.label_IncorrectMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IncorrectMessage.ForeColor = System.Drawing.Color.Red;
            this.label_IncorrectMessage.Location = new System.Drawing.Point(477, 111);
            this.label_IncorrectMessage.Name = "label_IncorrectMessage";
            this.label_IncorrectMessage.Size = new System.Drawing.Size(0, 18);
            this.label_IncorrectMessage.TabIndex = 0;
            // 
            // Login_frm
            // 
            this.AcceptButton = this.Login_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 532);
            this.Controls.Add(this.label_IncorrectMessage);
            this.Controls.Add(this.HideShowPass_btn);
            this.Controls.Add(this.UserName_Txt);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.Password_Txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login_frm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox UserName_Txt;
        private Guna.UI2.WinForms.Guna2TextBox Password_Txt;
        private Guna.UI2.WinForms.Guna2Button Login_Btn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button HideShowPass_btn;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip1;
        private System.Windows.Forms.Label label_IncorrectMessage;
    }
}