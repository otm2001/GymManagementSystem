namespace GymManagementSystem
{
    partial class AddUpdateExpense
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
            this.label7 = new System.Windows.Forms.Label();
            this.Amount_Txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ExpensesTypes_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpenseDataPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.TitleLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(101, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "Expense Type";
            // 
            // Amount_Txt
            // 
            this.Amount_Txt.BorderColor = System.Drawing.Color.DarkGray;
            this.Amount_Txt.BorderRadius = 20;
            this.Amount_Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Amount_Txt.DefaultText = "";
            this.Amount_Txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Amount_Txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Amount_Txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Amount_Txt.DisabledState.Parent = this.Amount_Txt;
            this.Amount_Txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Amount_Txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Amount_Txt.FocusedState.Parent = this.Amount_Txt;
            this.Amount_Txt.ForeColor = System.Drawing.Color.Black;
            this.Amount_Txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Amount_Txt.HoverState.Parent = this.Amount_Txt;
            this.Amount_Txt.Location = new System.Drawing.Point(105, 395);
            this.Amount_Txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Amount_Txt.Name = "Amount_Txt";
            this.Amount_Txt.PasswordChar = '\0';
            this.Amount_Txt.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Amount_Txt.PlaceholderText = "";
            this.Amount_Txt.SelectedText = "";
            this.Amount_Txt.ShadowDecoration.Parent = this.Amount_Txt;
            this.Amount_Txt.Size = new System.Drawing.Size(115, 53);
            this.Amount_Txt.TabIndex = 109;
            // 
            // ExpensesTypes_ComboBox
            // 
            this.ExpensesTypes_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ExpensesTypes_ComboBox.BorderColor = System.Drawing.Color.DarkGray;
            this.ExpensesTypes_ComboBox.BorderRadius = 20;
            this.ExpensesTypes_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ExpensesTypes_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpensesTypes_ComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.ExpensesTypes_ComboBox.FocusedState.Parent = this.ExpensesTypes_ComboBox;
            this.ExpensesTypes_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ExpensesTypes_ComboBox.ForeColor = System.Drawing.Color.Black;
            this.ExpensesTypes_ComboBox.FormattingEnabled = true;
            this.ExpensesTypes_ComboBox.HoverState.Parent = this.ExpensesTypes_ComboBox;
            this.ExpensesTypes_ComboBox.ItemHeight = 48;
            this.ExpensesTypes_ComboBox.ItemsAppearance.Parent = this.ExpensesTypes_ComboBox;
            this.ExpensesTypes_ComboBox.Location = new System.Drawing.Point(105, 153);
            this.ExpensesTypes_ComboBox.Name = "ExpensesTypes_ComboBox";
            this.ExpensesTypes_ComboBox.ShadowDecoration.Parent = this.ExpensesTypes_ComboBox;
            this.ExpensesTypes_ComboBox.Size = new System.Drawing.Size(299, 54);
            this.ExpensesTypes_ComboBox.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(101, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 111;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(101, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 112;
            this.label2.Text = "Expense Date";
            // 
            // ExpenseDataPicker
            // 
            this.ExpenseDataPicker.BackColor = System.Drawing.Color.Transparent;
            this.ExpenseDataPicker.BorderColor = System.Drawing.Color.DarkGray;
            this.ExpenseDataPicker.BorderRadius = 20;
            this.ExpenseDataPicker.BorderThickness = 1;
            this.ExpenseDataPicker.CheckedState.Parent = this.ExpenseDataPicker;
            this.ExpenseDataPicker.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExpenseDataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ExpenseDataPicker.HoverState.Parent = this.ExpenseDataPicker;
            this.ExpenseDataPicker.Location = new System.Drawing.Point(105, 277);
            this.ExpenseDataPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ExpenseDataPicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ExpenseDataPicker.Name = "ExpenseDataPicker";
            this.ExpenseDataPicker.ShadowDecoration.Parent = this.ExpenseDataPicker;
            this.ExpenseDataPicker.Size = new System.Drawing.Size(300, 53);
            this.ExpenseDataPicker.TabIndex = 113;
            this.ExpenseDataPicker.Value = new System.DateTime(2024, 11, 14, 16, 40, 36, 0);
            // 
            // Btn_Save
            // 
            this.Btn_Save.BorderRadius = 20;
            this.Btn_Save.CheckedState.Parent = this.Btn_Save;
            this.Btn_Save.CustomImages.Parent = this.Btn_Save;
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.HoverState.Parent = this.Btn_Save;
            this.Btn_Save.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Save.ImageSize = new System.Drawing.Size(30, 30);
            this.Btn_Save.Location = new System.Drawing.Point(240, 395);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.ShadowDecoration.Parent = this.Btn_Save;
            this.Btn_Save.Size = new System.Drawing.Size(165, 53);
            this.Btn_Save.TabIndex = 114;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TitleLable.Location = new System.Drawing.Point(99, 31);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(246, 32);
            this.TitleLable.TabIndex = 115;
            this.TitleLable.Text = "Add New Expense";
            // 
            // AddUpdateExpense
            // 
            this.AcceptButton = this.Btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 503);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.ExpenseDataPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExpensesTypes_ComboBox);
            this.Controls.Add(this.Amount_Txt);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.Name = "AddUpdateExpense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddUpdateExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox Amount_Txt;
        private Guna.UI2.WinForms.Guna2ComboBox ExpensesTypes_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker ExpenseDataPicker;
        private Guna.UI2.WinForms.Guna2Button Btn_Save;
        private System.Windows.Forms.Label TitleLable;
    }
}