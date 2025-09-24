namespace GymManagementSystem
{
    partial class SuspendSub_frm
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
            this.StartDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_RemainingDays = new System.Windows.Forms.Label();
            this.Btn_Resume = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.StartDatePicker.BorderColor = System.Drawing.Color.DarkGray;
            this.StartDatePicker.BorderRadius = 20;
            this.StartDatePicker.BorderThickness = 1;
            this.StartDatePicker.CheckedState.Parent = this.StartDatePicker;
            this.StartDatePicker.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.StartDatePicker.HoverState.Parent = this.StartDatePicker;
            this.StartDatePicker.Location = new System.Drawing.Point(38, 142);
            this.StartDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.StartDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.ShadowDecoration.Parent = this.StartDatePicker;
            this.StartDatePicker.Size = new System.Drawing.Size(300, 53);
            this.StartDatePicker.TabIndex = 119;
            this.StartDatePicker.Value = new System.DateTime(2024, 11, 14, 16, 40, 36, 0);
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(34, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 118;
            this.label4.Text = "Start Date";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.EndDateTimePicker.BorderColor = System.Drawing.Color.DarkGray;
            this.EndDateTimePicker.BorderRadius = 20;
            this.EndDateTimePicker.BorderThickness = 1;
            this.EndDateTimePicker.CheckedState.Parent = this.EndDateTimePicker;
            this.EndDateTimePicker.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.EndDateTimePicker.HoverState.Parent = this.EndDateTimePicker;
            this.EndDateTimePicker.Location = new System.Drawing.Point(38, 248);
            this.EndDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.EndDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.ShadowDecoration.Parent = this.EndDateTimePicker;
            this.EndDateTimePicker.Size = new System.Drawing.Size(300, 53);
            this.EndDateTimePicker.TabIndex = 121;
            this.EndDateTimePicker.Value = new System.DateTime(2024, 11, 14, 16, 40, 36, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(34, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 120;
            this.label1.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(34, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 122;
            this.label2.Text = "Remaining Days:";
            // 
            // label_RemainingDays
            // 
            this.label_RemainingDays.AutoSize = true;
            this.label_RemainingDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label_RemainingDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_RemainingDays.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_RemainingDays.Location = new System.Drawing.Point(177, 53);
            this.label_RemainingDays.Name = "label_RemainingDays";
            this.label_RemainingDays.Size = new System.Drawing.Size(18, 20);
            this.label_RemainingDays.TabIndex = 123;
            this.label_RemainingDays.Text = "0";
            // 
            // Btn_Resume
            // 
            this.Btn_Resume.BorderRadius = 20;
            this.Btn_Resume.CheckedState.Parent = this.Btn_Resume;
            this.Btn_Resume.CustomImages.Parent = this.Btn_Resume;
            this.Btn_Resume.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Btn_Resume.ForeColor = System.Drawing.Color.White;
            this.Btn_Resume.HoverState.Parent = this.Btn_Resume;
            this.Btn_Resume.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Resume.ImageSize = new System.Drawing.Size(30, 30);
            this.Btn_Resume.Location = new System.Drawing.Point(103, 328);
            this.Btn_Resume.Name = "Btn_Resume";
            this.Btn_Resume.ShadowDecoration.Parent = this.Btn_Resume;
            this.Btn_Resume.Size = new System.Drawing.Size(145, 53);
            this.Btn_Resume.TabIndex = 124;
            this.Btn_Resume.Text = "Resume";
            this.Btn_Resume.Click += new System.EventHandler(this.Btn_Resume_Click);
            // 
            // SuspendSub_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 405);
            this.Controls.Add(this.Btn_Resume);
            this.Controls.Add(this.label_RemainingDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.Name = "SuspendSub_frm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SuspendSub_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_RemainingDays;
        private Guna.UI2.WinForms.Guna2Button Btn_Resume;
    }
}