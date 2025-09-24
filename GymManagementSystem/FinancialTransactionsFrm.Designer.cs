namespace GymManagementSystem
{
    partial class FinancialTransactionsFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Expences_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Payments_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Payments_btn);
            this.panel1.Controls.Add(this.Expences_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 61);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Expences_btn
            // 
            this.Expences_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Expences_btn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Expences_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Expences_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.Expences_btn.CheckedState.Parent = this.Expences_btn;
            this.Expences_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Expences_btn.CustomImages.Parent = this.Expences_btn;
            this.Expences_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Expences_btn.FillColor = System.Drawing.Color.White;
            this.Expences_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Expences_btn.ForeColor = System.Drawing.Color.DimGray;
            this.Expences_btn.HoverState.Parent = this.Expences_btn;
            this.Expences_btn.Location = new System.Drawing.Point(0, 0);
            this.Expences_btn.Name = "Expences_btn";
            this.Expences_btn.ShadowDecoration.Parent = this.Expences_btn;
            this.Expences_btn.Size = new System.Drawing.Size(119, 61);
            this.Expences_btn.TabIndex = 1;
            this.Expences_btn.Text = "Expences";
            this.Expences_btn.Click += new System.EventHandler(this.Expences_btn_Click);
            // 
            // Payments_btn
            // 
            this.Payments_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Payments_btn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Payments_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Payments_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.Payments_btn.CheckedState.Parent = this.Payments_btn;
            this.Payments_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Payments_btn.CustomImages.Parent = this.Payments_btn;
            this.Payments_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Payments_btn.FillColor = System.Drawing.Color.White;
            this.Payments_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Payments_btn.ForeColor = System.Drawing.Color.DimGray;
            this.Payments_btn.HoverState.Parent = this.Payments_btn;
            this.Payments_btn.Location = new System.Drawing.Point(119, 0);
            this.Payments_btn.Name = "Payments_btn";
            this.Payments_btn.ShadowDecoration.Parent = this.Payments_btn;
            this.Payments_btn.Size = new System.Drawing.Size(119, 61);
            this.Payments_btn.TabIndex = 2;
            this.Payments_btn.Text = "Payments";
            this.Payments_btn.Click += new System.EventHandler(this.Payments_btn_Click);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 61);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1173, 708);
            this.panel.TabIndex = 1;
            // 
            // FinancialTransactionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 771);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Name = "FinancialTransactionsFrm";
            this.Text = "FinancialTransactionsFrm";
            this.Load += new System.EventHandler(this.FinancialTransactionsFrm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Expences_btn;
        private Guna.UI2.WinForms.Guna2Button Payments_btn;
        private System.Windows.Forms.Panel panel;
    }
}