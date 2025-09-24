namespace GymManagementSystem
{
    partial class addUpdateEmployee_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUpdateEmployee_frm));
            this.Btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.TitleLable = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Jobs_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Female_RBtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.Male_RBtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.DateOFBirth_DataPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Email_Txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Phone_Txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Address_Txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeName_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmployeeID_Txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.RemoveImge_Btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label11 = new System.Windows.Forms.Label();
            this.SalaryTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RemoveImage_Btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SetImage_Btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Employee_PictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Switch_IsActive = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_PictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.Btn_Save.Location = new System.Drawing.Point(982, 598);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.ShadowDecoration.Parent = this.Btn_Save;
            this.Btn_Save.Size = new System.Drawing.Size(174, 48);
            this.Btn_Save.TabIndex = 107;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TitleLable.Location = new System.Drawing.Point(31, 22);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(262, 32);
            this.TitleLable.TabIndex = 106;
            this.TitleLable.Text = "Add New Employee";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(33, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 102;
            this.label10.Text = "Employee ID\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(40, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 100;
            this.label9.Text = "Job";
            // 
            // Jobs_ComboBox
            // 
            this.Jobs_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.Jobs_ComboBox.BorderColor = System.Drawing.Color.DarkGray;
            this.Jobs_ComboBox.BorderRadius = 20;
            this.Jobs_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Jobs_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Jobs_ComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.Jobs_ComboBox.FocusedState.Parent = this.Jobs_ComboBox;
            this.Jobs_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Jobs_ComboBox.ForeColor = System.Drawing.Color.Black;
            this.Jobs_ComboBox.FormattingEnabled = true;
            this.Jobs_ComboBox.HoverState.Parent = this.Jobs_ComboBox;
            this.Jobs_ComboBox.ItemHeight = 48;
            this.Jobs_ComboBox.ItemsAppearance.Parent = this.Jobs_ComboBox;
            this.Jobs_ComboBox.Location = new System.Drawing.Point(37, 258);
            this.Jobs_ComboBox.Name = "Jobs_ComboBox";
            this.Jobs_ComboBox.ShadowDecoration.Parent = this.Jobs_ComboBox;
            this.Jobs_ComboBox.Size = new System.Drawing.Size(299, 54);
            this.Jobs_ComboBox.TabIndex = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(418, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 98;
            this.label8.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(1036, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "Female";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(878, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 96;
            this.label6.Text = "Male";
            // 
            // Female_RBtn
            // 
            this.Female_RBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Female_RBtn.CheckedState.BorderThickness = 0;
            this.Female_RBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Female_RBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Female_RBtn.CheckedState.Parent = this.Female_RBtn;
            this.Female_RBtn.Location = new System.Drawing.Point(991, 393);
            this.Female_RBtn.Name = "Female_RBtn";
            this.Female_RBtn.ShadowDecoration.Parent = this.Female_RBtn;
            this.Female_RBtn.Size = new System.Drawing.Size(22, 20);
            this.Female_RBtn.TabIndex = 95;
            this.Female_RBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Female_RBtn.UncheckedState.BorderThickness = 2;
            this.Female_RBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Female_RBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Female_RBtn.UncheckedState.Parent = this.Female_RBtn;
            // 
            // Male_RBtn
            // 
            this.Male_RBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Male_RBtn.CheckedState.BorderThickness = 0;
            this.Male_RBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Male_RBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Male_RBtn.CheckedState.Parent = this.Male_RBtn;
            this.Male_RBtn.Location = new System.Drawing.Point(832, 393);
            this.Male_RBtn.Name = "Male_RBtn";
            this.Male_RBtn.ShadowDecoration.Parent = this.Male_RBtn;
            this.Male_RBtn.Size = new System.Drawing.Size(22, 20);
            this.Male_RBtn.TabIndex = 94;
            this.Male_RBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Male_RBtn.UncheckedState.BorderThickness = 2;
            this.Male_RBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Male_RBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Male_RBtn.UncheckedState.Parent = this.Male_RBtn;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(827, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 93;
            this.label5.Text = "Gender";
            // 
            // DateOFBirth_DataPicker
            // 
            this.DateOFBirth_DataPicker.BackColor = System.Drawing.Color.Transparent;
            this.DateOFBirth_DataPicker.BorderColor = System.Drawing.Color.DarkGray;
            this.DateOFBirth_DataPicker.BorderRadius = 20;
            this.DateOFBirth_DataPicker.BorderThickness = 1;
            this.DateOFBirth_DataPicker.CheckedState.Parent = this.DateOFBirth_DataPicker;
            this.DateOFBirth_DataPicker.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateOFBirth_DataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateOFBirth_DataPicker.HoverState.Parent = this.DateOFBirth_DataPicker;
            this.DateOFBirth_DataPicker.Location = new System.Drawing.Point(422, 377);
            this.DateOFBirth_DataPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateOFBirth_DataPicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateOFBirth_DataPicker.Name = "DateOFBirth_DataPicker";
            this.DateOFBirth_DataPicker.ShadowDecoration.Parent = this.DateOFBirth_DataPicker;
            this.DateOFBirth_DataPicker.Size = new System.Drawing.Size(300, 53);
            this.DateOFBirth_DataPicker.TabIndex = 92;
            this.DateOFBirth_DataPicker.Value = new System.DateTime(2024, 10, 21, 13, 58, 2, 771);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(33, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 91;
            this.label4.Text = "Email";
            // 
            // Email_Txt
            // 
            this.Email_Txt.BorderColor = System.Drawing.Color.DarkGray;
            this.Email_Txt.BorderRadius = 20;
            this.Email_Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_Txt.DefaultText = "";
            this.Email_Txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email_Txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email_Txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_Txt.DisabledState.Parent = this.Email_Txt;
            this.Email_Txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_Txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_Txt.FocusedState.Parent = this.Email_Txt;
            this.Email_Txt.ForeColor = System.Drawing.Color.Black;
            this.Email_Txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_Txt.HoverState.Parent = this.Email_Txt;
            this.Email_Txt.Location = new System.Drawing.Point(46, 501);
            this.Email_Txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Email_Txt.Name = "Email_Txt";
            this.Email_Txt.PasswordChar = '\0';
            this.Email_Txt.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Email_Txt.PlaceholderText = "";
            this.Email_Txt.SelectedText = "";
            this.Email_Txt.ShadowDecoration.Parent = this.Email_Txt;
            this.Email_Txt.Size = new System.Drawing.Size(676, 53);
            this.Email_Txt.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(33, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 89;
            this.label3.Text = "Phone Number";
            // 
            // Phone_Txt
            // 
            this.Phone_Txt.BorderColor = System.Drawing.Color.DarkGray;
            this.Phone_Txt.BorderRadius = 20;
            this.Phone_Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Phone_Txt.DefaultText = "";
            this.Phone_Txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Phone_Txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Phone_Txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Phone_Txt.DisabledState.Parent = this.Phone_Txt;
            this.Phone_Txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Phone_Txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Phone_Txt.FocusedState.Parent = this.Phone_Txt;
            this.Phone_Txt.ForeColor = System.Drawing.Color.Black;
            this.Phone_Txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Phone_Txt.HoverState.Parent = this.Phone_Txt;
            this.Phone_Txt.Location = new System.Drawing.Point(37, 377);
            this.Phone_Txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Phone_Txt.Name = "Phone_Txt";
            this.Phone_Txt.PasswordChar = '\0';
            this.Phone_Txt.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Phone_Txt.PlaceholderText = "";
            this.Phone_Txt.SelectedText = "";
            this.Phone_Txt.ShadowDecoration.Parent = this.Phone_Txt;
            this.Phone_Txt.Size = new System.Drawing.Size(338, 53);
            this.Phone_Txt.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(827, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Address";
            // 
            // Address_Txt
            // 
            this.Address_Txt.BorderColor = System.Drawing.Color.DarkGray;
            this.Address_Txt.BorderRadius = 20;
            this.Address_Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address_Txt.DefaultText = "";
            this.Address_Txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Address_Txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Address_Txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Address_Txt.DisabledState.Parent = this.Address_Txt;
            this.Address_Txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Address_Txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Address_Txt.FocusedState.Parent = this.Address_Txt;
            this.Address_Txt.ForeColor = System.Drawing.Color.Black;
            this.Address_Txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Address_Txt.HoverState.Parent = this.Address_Txt;
            this.Address_Txt.Location = new System.Drawing.Point(831, 501);
            this.Address_Txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Address_Txt.Name = "Address_Txt";
            this.Address_Txt.PasswordChar = '\0';
            this.Address_Txt.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Address_Txt.PlaceholderText = "";
            this.Address_Txt.SelectedText = "";
            this.Address_Txt.ShadowDecoration.Parent = this.Address_Txt;
            this.Address_Txt.Size = new System.Drawing.Size(325, 53);
            this.Address_Txt.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(207, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Employee Name";
            // 
            // EmployeeName_TextBox
            // 
            this.EmployeeName_TextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeName_TextBox.BorderRadius = 20;
            this.EmployeeName_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmployeeName_TextBox.DefaultText = "";
            this.EmployeeName_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmployeeName_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmployeeName_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmployeeName_TextBox.DisabledState.Parent = this.EmployeeName_TextBox;
            this.EmployeeName_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmployeeName_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeName_TextBox.FocusedState.Parent = this.EmployeeName_TextBox;
            this.EmployeeName_TextBox.ForeColor = System.Drawing.Color.Black;
            this.EmployeeName_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeName_TextBox.HoverState.Parent = this.EmployeeName_TextBox;
            this.EmployeeName_TextBox.Location = new System.Drawing.Point(211, 142);
            this.EmployeeName_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmployeeName_TextBox.Name = "EmployeeName_TextBox";
            this.EmployeeName_TextBox.PasswordChar = '\0';
            this.EmployeeName_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmployeeName_TextBox.PlaceholderText = "";
            this.EmployeeName_TextBox.SelectedText = "";
            this.EmployeeName_TextBox.ShadowDecoration.Parent = this.EmployeeName_TextBox;
            this.EmployeeName_TextBox.Size = new System.Drawing.Size(338, 53);
            this.EmployeeName_TextBox.TabIndex = 84;
            // 
            // EmployeeID_Txt
            // 
            this.EmployeeID_Txt.BorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeID_Txt.BorderRadius = 20;
            this.EmployeeID_Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmployeeID_Txt.DefaultText = "";
            this.EmployeeID_Txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmployeeID_Txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmployeeID_Txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmployeeID_Txt.DisabledState.Parent = this.EmployeeID_Txt;
            this.EmployeeID_Txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmployeeID_Txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeID_Txt.FocusedState.Parent = this.EmployeeID_Txt;
            this.EmployeeID_Txt.ForeColor = System.Drawing.Color.Black;
            this.EmployeeID_Txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeID_Txt.HoverState.Parent = this.EmployeeID_Txt;
            this.EmployeeID_Txt.Location = new System.Drawing.Point(37, 142);
            this.EmployeeID_Txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmployeeID_Txt.Name = "EmployeeID_Txt";
            this.EmployeeID_Txt.PasswordChar = '\0';
            this.EmployeeID_Txt.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmployeeID_Txt.PlaceholderText = "";
            this.EmployeeID_Txt.ReadOnly = true;
            this.EmployeeID_Txt.SelectedText = "";
            this.EmployeeID_Txt.ShadowDecoration.Parent = this.EmployeeID_Txt;
            this.EmployeeID_Txt.Size = new System.Drawing.Size(91, 53);
            this.EmployeeID_Txt.TabIndex = 108;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RemoveImge_Btn
            // 
            this.RemoveImge_Btn.CheckedState.Parent = this.RemoveImge_Btn;
            this.RemoveImge_Btn.HoverState.Parent = this.RemoveImge_Btn;
            this.RemoveImge_Btn.Location = new System.Drawing.Point(0, 0);
            this.RemoveImge_Btn.Name = "RemoveImge_Btn";
            this.RemoveImge_Btn.PressedState.Parent = this.RemoveImge_Btn;
            this.RemoveImge_Btn.Size = new System.Drawing.Size(0, 0);
            this.RemoveImge_Btn.TabIndex = 111;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(418, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 110;
            this.label11.Text = "Salary";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.SalaryTextBox.BorderRadius = 20;
            this.SalaryTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalaryTextBox.DefaultText = "";
            this.SalaryTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SalaryTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SalaryTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalaryTextBox.DisabledState.Parent = this.SalaryTextBox;
            this.SalaryTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalaryTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalaryTextBox.FocusedState.Parent = this.SalaryTextBox;
            this.SalaryTextBox.ForeColor = System.Drawing.Color.Black;
            this.SalaryTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalaryTextBox.HoverState.Parent = this.SalaryTextBox;
            this.SalaryTextBox.Location = new System.Drawing.Point(422, 258);
            this.SalaryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.PasswordChar = '\0';
            this.SalaryTextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SalaryTextBox.PlaceholderText = "";
            this.SalaryTextBox.SelectedText = "";
            this.SalaryTextBox.ShadowDecoration.Parent = this.SalaryTextBox;
            this.SalaryTextBox.Size = new System.Drawing.Size(127, 53);
            this.SalaryTextBox.TabIndex = 109;
            // 
            // RemoveImage_Btn
            // 
            this.RemoveImage_Btn.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.RemoveImage_Btn.CheckedState.Parent = this.RemoveImage_Btn;
            this.RemoveImage_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveImage_Btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.RemoveImage_Btn.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.RemoveImage_Btn.HoverState.Parent = this.RemoveImage_Btn;
            this.RemoveImage_Btn.Image = ((System.Drawing.Image)(resources.GetObject("RemoveImage_Btn.Image")));
            this.RemoveImage_Btn.ImageSize = new System.Drawing.Size(45, 45);
            this.RemoveImage_Btn.Location = new System.Drawing.Point(1042, 258);
            this.RemoveImage_Btn.Name = "RemoveImage_Btn";
            this.RemoveImage_Btn.PressedState.Parent = this.RemoveImage_Btn;
            this.RemoveImage_Btn.Size = new System.Drawing.Size(65, 54);
            this.RemoveImage_Btn.TabIndex = 119;
            this.RemoveImage_Btn.Visible = false;
            this.RemoveImage_Btn.Click += new System.EventHandler(this.RemoveImage_Btn_Click);
            // 
            // SetImage_Btn
            // 
            this.SetImage_Btn.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.SetImage_Btn.CheckedState.Parent = this.SetImage_Btn;
            this.SetImage_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetImage_Btn.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.SetImage_Btn.HoverState.Parent = this.SetImage_Btn;
            this.SetImage_Btn.Image = ((System.Drawing.Image)(resources.GetObject("SetImage_Btn.Image")));
            this.SetImage_Btn.ImageSize = new System.Drawing.Size(45, 45);
            this.SetImage_Btn.Location = new System.Drawing.Point(902, 258);
            this.SetImage_Btn.Name = "SetImage_Btn";
            this.SetImage_Btn.PressedState.Parent = this.SetImage_Btn;
            this.SetImage_Btn.Size = new System.Drawing.Size(65, 54);
            this.SetImage_Btn.TabIndex = 104;
            this.SetImage_Btn.Click += new System.EventHandler(this.SetImage_Btn_Click);
            // 
            // Employee_PictureBox
            // 
            this.Employee_PictureBox.Image = global::GymManagementSystem.Properties.Resources.employeeDefultPic;
            this.Employee_PictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Employee_PictureBox.Location = new System.Drawing.Point(845, 22);
            this.Employee_PictureBox.Name = "Employee_PictureBox";
            this.Employee_PictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Employee_PictureBox.ShadowDecoration.Parent = this.Employee_PictureBox;
            this.Employee_PictureBox.Size = new System.Drawing.Size(311, 230);
            this.Employee_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Employee_PictureBox.TabIndex = 103;
            this.Employee_PictureBox.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(663, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 121;
            this.label12.Text = "Is Active";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Switch_IsActive
            // 
            this.Switch_IsActive.AutoRoundedCorners = true;
            this.Switch_IsActive.Checked = true;
            this.Switch_IsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Switch_IsActive.CheckedState.BorderRadius = 17;
            this.Switch_IsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Switch_IsActive.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Switch_IsActive.CheckedState.InnerBorderRadius = 13;
            this.Switch_IsActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Switch_IsActive.CheckedState.Parent = this.Switch_IsActive;
            this.Switch_IsActive.Location = new System.Drawing.Point(667, 258);
            this.Switch_IsActive.Name = "Switch_IsActive";
            this.Switch_IsActive.ShadowDecoration.Parent = this.Switch_IsActive;
            this.Switch_IsActive.Size = new System.Drawing.Size(68, 36);
            this.Switch_IsActive.TabIndex = 120;
            this.Switch_IsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Switch_IsActive.UncheckedState.BorderRadius = 17;
            this.Switch_IsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Switch_IsActive.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Switch_IsActive.UncheckedState.InnerBorderRadius = 13;
            this.Switch_IsActive.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.Switch_IsActive.UncheckedState.Parent = this.Switch_IsActive;
            this.Switch_IsActive.CheckedChanged += new System.EventHandler(this.Switch_IsActive_CheckedChanged);
            // 
            // addUpdateEmployee_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1177, 658);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Switch_IsActive);
            this.Controls.Add(this.RemoveImage_Btn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.EmployeeID_Txt);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.RemoveImge_Btn);
            this.Controls.Add(this.SetImage_Btn);
            this.Controls.Add(this.Employee_PictureBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Jobs_ComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Female_RBtn);
            this.Controls.Add(this.Male_RBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateOFBirth_DataPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email_Txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Phone_Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Address_Txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeName_TextBox);
            this.MaximizeBox = false;
            this.Name = "addUpdateEmployee_frm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.addUpdateEmployee_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Employee_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Btn_Save;
        private System.Windows.Forms.Label TitleLable;
        private Guna.UI2.WinForms.Guna2ImageButton RemoveImge_Btn;
        private Guna.UI2.WinForms.Guna2ImageButton SetImage_Btn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Employee_PictureBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox Jobs_ComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2CustomRadioButton Female_RBtn;
        private Guna.UI2.WinForms.Guna2CustomRadioButton Male_RBtn;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateOFBirth_DataPicker;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox Email_Txt;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Phone_Txt;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox Address_Txt;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox EmployeeName_TextBox;
        private Guna.UI2.WinForms.Guna2TextBox EmployeeID_Txt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox SalaryTextBox;
        private Guna.UI2.WinForms.Guna2ImageButton RemoveImage_Btn;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Switch_IsActive;
    }
}