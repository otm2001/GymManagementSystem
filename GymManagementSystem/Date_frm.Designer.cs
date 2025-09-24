namespace GymManagementSystem
{
    partial class Date_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Date_frm));
            this.Start_DatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.EndDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Btn_Resume = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_DatePicker
            // 
            this.Start_DatePicker.CheckedState.Parent = this.Start_DatePicker;
            this.Start_DatePicker.FillColor = System.Drawing.Color.White;
            this.Start_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Start_DatePicker.HoverState.Parent = this.Start_DatePicker;
            this.Start_DatePicker.Location = new System.Drawing.Point(104, 69);
            this.Start_DatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Start_DatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Start_DatePicker.Name = "Start_DatePicker";
            this.Start_DatePicker.ShadowDecoration.Parent = this.Start_DatePicker;
            this.Start_DatePicker.Size = new System.Drawing.Size(264, 63);
            this.Start_DatePicker.TabIndex = 6;
            this.Start_DatePicker.Value = new System.DateTime(2024, 10, 21, 13, 58, 2, 771);
            this.Start_DatePicker.ValueChanged += new System.EventHandler(this.Start_DatePicker_ValueChanged);
            this.Start_DatePicker.TextChanged += new System.EventHandler(this.Start_DatePicker_TextChanged);
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.CheckedState.Parent = this.EndDateTimePicker;
            this.EndDateTimePicker.FillColor = System.Drawing.Color.White;
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.EndDateTimePicker.HoverState.Parent = this.EndDateTimePicker;
            this.EndDateTimePicker.Location = new System.Drawing.Point(104, 181);
            this.EndDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.EndDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.ShadowDecoration.Parent = this.EndDateTimePicker;
            this.EndDateTimePicker.Size = new System.Drawing.Size(264, 63);
            this.EndDateTimePicker.TabIndex = 7;
            this.EndDateTimePicker.Value = new System.DateTime(2024, 10, 21, 13, 58, 2, 771);
            // 
            // Btn_Resume
            // 
            this.Btn_Resume.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Resume.CheckedState.Parent = this.Btn_Resume;
            this.Btn_Resume.CustomImages.Parent = this.Btn_Resume;
            this.Btn_Resume.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(173)))), ((int)(((byte)(75)))));
            this.Btn_Resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Resume.ForeColor = System.Drawing.Color.White;
            this.Btn_Resume.HoverState.Parent = this.Btn_Resume;
            this.Btn_Resume.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Resume.Image")));
            this.Btn_Resume.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Resume.ImageSize = new System.Drawing.Size(30, 30);
            this.Btn_Resume.Location = new System.Drawing.Point(104, 296);
            this.Btn_Resume.Name = "Btn_Resume";
            this.Btn_Resume.ShadowDecoration.Parent = this.Btn_Resume;
            this.Btn_Resume.Size = new System.Drawing.Size(180, 45);
            this.Btn_Resume.TabIndex = 73;
            this.Btn_Resume.Text = "Resume";
            this.Btn_Resume.Click += new System.EventHandler(this.Btn_Resume_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "End Date";
            // 
            // Date_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Resume);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.Start_DatePicker);
            this.Name = "Date_frm";
            this.Text = "Date_frm";
            this.Load += new System.EventHandler(this.Date_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker Start_DatePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker EndDateTimePicker;
        private Guna.UI2.WinForms.Guna2Button Btn_Resume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}