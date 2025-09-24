namespace GymManagementSystem
{
    partial class AddUpdateSubscription_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateSubscription_frm));
            this.SubIDTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Game_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SubscriptionsTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Game_Combox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericUpDown_Days = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.CoachesComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MemberID_Txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Start_DatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EndDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Fee_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AmountTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Calcolate_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.TitleLable = new System.Windows.Forms.Label();
            this.AddMemberBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Days)).BeginInit();
            this.SuspendLayout();
            // 
            // SubIDTxt
            // 
            this.SubIDTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.SubIDTxt.BorderRadius = 20;
            this.SubIDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SubIDTxt.DefaultText = "";
            this.SubIDTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SubIDTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SubIDTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SubIDTxt.DisabledState.Parent = this.SubIDTxt;
            this.SubIDTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SubIDTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SubIDTxt.FocusedState.Parent = this.SubIDTxt;
            this.SubIDTxt.ForeColor = System.Drawing.Color.Black;
            this.SubIDTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SubIDTxt.HoverState.Parent = this.SubIDTxt;
            this.SubIDTxt.Location = new System.Drawing.Point(194, 86);
            this.SubIDTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubIDTxt.Name = "SubIDTxt";
            this.SubIDTxt.PasswordChar = '\0';
            this.SubIDTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.SubIDTxt.PlaceholderText = "";
            this.SubIDTxt.ReadOnly = true;
            this.SubIDTxt.SelectedText = "";
            this.SubIDTxt.ShadowDecoration.Parent = this.SubIDTxt;
            this.SubIDTxt.Size = new System.Drawing.Size(63, 53);
            this.SubIDTxt.TabIndex = 37;
            // 
            // Game_ComboBox
            // 
            this.Game_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.Game_ComboBox.BorderColor = System.Drawing.Color.DarkGray;
            this.Game_ComboBox.BorderRadius = 20;
            this.Game_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Game_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Game_ComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.Game_ComboBox.FocusedState.Parent = this.Game_ComboBox;
            this.Game_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Game_ComboBox.ForeColor = System.Drawing.Color.Black;
            this.Game_ComboBox.FormattingEnabled = true;
            this.Game_ComboBox.HoverState.Parent = this.Game_ComboBox;
            this.Game_ComboBox.ItemHeight = 48;
            this.Game_ComboBox.ItemsAppearance.Parent = this.Game_ComboBox;
            this.Game_ComboBox.Location = new System.Drawing.Point(460, 168);
            this.Game_ComboBox.Name = "Game_ComboBox";
            this.Game_ComboBox.ShadowDecoration.Parent = this.Game_ComboBox;
            this.Game_ComboBox.Size = new System.Drawing.Size(281, 54);
            this.Game_ComboBox.TabIndex = 2;
            this.Game_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Game_ComboBox_SelectedIndexChanged);
            // 
            // SubscriptionsTypeComboBox
            // 
            this.SubscriptionsTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.SubscriptionsTypeComboBox.BorderColor = System.Drawing.Color.DarkGray;
            this.SubscriptionsTypeComboBox.BorderRadius = 20;
            this.SubscriptionsTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SubscriptionsTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubscriptionsTypeComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.SubscriptionsTypeComboBox.FocusedState.Parent = this.SubscriptionsTypeComboBox;
            this.SubscriptionsTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubscriptionsTypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.SubscriptionsTypeComboBox.FormattingEnabled = true;
            this.SubscriptionsTypeComboBox.HoverState.Parent = this.SubscriptionsTypeComboBox;
            this.SubscriptionsTypeComboBox.ItemHeight = 48;
            this.SubscriptionsTypeComboBox.Items.AddRange(new object[] {
            "Daily",
            "Monthly"});
            this.SubscriptionsTypeComboBox.ItemsAppearance.Parent = this.SubscriptionsTypeComboBox;
            this.SubscriptionsTypeComboBox.Location = new System.Drawing.Point(460, 286);
            this.SubscriptionsTypeComboBox.Name = "SubscriptionsTypeComboBox";
            this.SubscriptionsTypeComboBox.ShadowDecoration.Parent = this.SubscriptionsTypeComboBox;
            this.SubscriptionsTypeComboBox.Size = new System.Drawing.Size(120, 54);
            this.SubscriptionsTypeComboBox.TabIndex = 4;
            this.SubscriptionsTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.SubscriptionsTypeComboBox_SelectedIndexChanged);
            // 
            // Game_Combox
            // 
            this.Game_Combox.AutoSize = true;
            this.Game_Combox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Combox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Game_Combox.Location = new System.Drawing.Point(456, 128);
            this.Game_Combox.Name = "Game_Combox";
            this.Game_Combox.Size = new System.Drawing.Size(54, 20);
            this.Game_Combox.TabIndex = 51;
            this.Game_Combox.Text = "Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(54, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Subscriptions ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(456, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Subscriptions Type";
            // 
            // NumericUpDown_Days
            // 
            this.NumericUpDown_Days.BackColor = System.Drawing.Color.Transparent;
            this.NumericUpDown_Days.BorderColor = System.Drawing.Color.DarkGray;
            this.NumericUpDown_Days.BorderRadius = 20;
            this.NumericUpDown_Days.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericUpDown_Days.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumericUpDown_Days.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumericUpDown_Days.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumericUpDown_Days.DisabledState.Parent = this.NumericUpDown_Days;
            this.NumericUpDown_Days.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.NumericUpDown_Days.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.NumericUpDown_Days.Enabled = false;
            this.NumericUpDown_Days.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumericUpDown_Days.FocusedState.Parent = this.NumericUpDown_Days;
            this.NumericUpDown_Days.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown_Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NumericUpDown_Days.Location = new System.Drawing.Point(635, 286);
            this.NumericUpDown_Days.Name = "NumericUpDown_Days";
            this.NumericUpDown_Days.ShadowDecoration.Parent = this.NumericUpDown_Days;
            this.NumericUpDown_Days.Size = new System.Drawing.Size(106, 54);
            this.NumericUpDown_Days.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(54, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Coach Name";
            // 
            // CoachesComboBox
            // 
            this.CoachesComboBox.BackColor = System.Drawing.Color.Transparent;
            this.CoachesComboBox.BorderColor = System.Drawing.Color.DarkGray;
            this.CoachesComboBox.BorderRadius = 20;
            this.CoachesComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CoachesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoachesComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.CoachesComboBox.FocusedState.Parent = this.CoachesComboBox;
            this.CoachesComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CoachesComboBox.ForeColor = System.Drawing.Color.Black;
            this.CoachesComboBox.FormattingEnabled = true;
            this.CoachesComboBox.HoverState.Parent = this.CoachesComboBox;
            this.CoachesComboBox.ItemHeight = 48;
            this.CoachesComboBox.ItemsAppearance.Parent = this.CoachesComboBox;
            this.CoachesComboBox.Location = new System.Drawing.Point(58, 286);
            this.CoachesComboBox.Name = "CoachesComboBox";
            this.CoachesComboBox.ShadowDecoration.Parent = this.CoachesComboBox;
            this.CoachesComboBox.Size = new System.Drawing.Size(281, 54);
            this.CoachesComboBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(54, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Member ID";
            // 
            // MemberID_Txt
            // 
            this.MemberID_Txt.BorderColor = System.Drawing.Color.DarkGray;
            this.MemberID_Txt.BorderRadius = 20;
            this.MemberID_Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MemberID_Txt.DefaultText = "";
            this.MemberID_Txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MemberID_Txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MemberID_Txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MemberID_Txt.DisabledState.Parent = this.MemberID_Txt;
            this.MemberID_Txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MemberID_Txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MemberID_Txt.FocusedState.Parent = this.MemberID_Txt;
            this.MemberID_Txt.ForeColor = System.Drawing.Color.Black;
            this.MemberID_Txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MemberID_Txt.HoverState.Parent = this.MemberID_Txt;
            this.MemberID_Txt.Location = new System.Drawing.Point(194, 168);
            this.MemberID_Txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MemberID_Txt.Name = "MemberID_Txt";
            this.MemberID_Txt.PasswordChar = '\0';
            this.MemberID_Txt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.MemberID_Txt.PlaceholderText = "";
            this.MemberID_Txt.SelectedText = "";
            this.MemberID_Txt.ShadowDecoration.Parent = this.MemberID_Txt;
            this.MemberID_Txt.Size = new System.Drawing.Size(69, 53);
            this.MemberID_Txt.TabIndex = 1;
            // 
            // Start_DatePicker
            // 
            this.Start_DatePicker.BorderColor = System.Drawing.Color.DarkGray;
            this.Start_DatePicker.BorderRadius = 20;
            this.Start_DatePicker.BorderThickness = 1;
            this.Start_DatePicker.CheckedState.Parent = this.Start_DatePicker;
            this.Start_DatePicker.FillColor = System.Drawing.Color.White;
            this.Start_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Start_DatePicker.HoverState.Parent = this.Start_DatePicker;
            this.Start_DatePicker.Location = new System.Drawing.Point(58, 413);
            this.Start_DatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Start_DatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Start_DatePicker.Name = "Start_DatePicker";
            this.Start_DatePicker.ShadowDecoration.Parent = this.Start_DatePicker;
            this.Start_DatePicker.Size = new System.Drawing.Size(281, 53);
            this.Start_DatePicker.TabIndex = 5;
            this.Start_DatePicker.Value = new System.DateTime(2024, 10, 21, 13, 58, 2, 771);
            this.Start_DatePicker.ValueChanged += new System.EventHandler(this.Start_DatePicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(54, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(456, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 66;
            this.label7.Text = "End Date";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.BorderColor = System.Drawing.Color.DarkGray;
            this.EndDatePicker.BorderRadius = 20;
            this.EndDatePicker.BorderThickness = 1;
            this.EndDatePicker.CheckedState.Parent = this.EndDatePicker;
            this.EndDatePicker.FillColor = System.Drawing.Color.White;
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.EndDatePicker.HoverState.Parent = this.EndDatePicker;
            this.EndDatePicker.Location = new System.Drawing.Point(460, 410);
            this.EndDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.EndDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.ShadowDecoration.Parent = this.EndDatePicker;
            this.EndDatePicker.Size = new System.Drawing.Size(281, 53);
            this.EndDatePicker.TabIndex = 67;
            this.EndDatePicker.Value = new System.DateTime(2024, 10, 21, 13, 58, 2, 771);
            // 
            // Fee_TextBox
            // 
            this.Fee_TextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.Fee_TextBox.BorderRadius = 20;
            this.Fee_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Fee_TextBox.DefaultText = "";
            this.Fee_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Fee_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Fee_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Fee_TextBox.DisabledState.Parent = this.Fee_TextBox;
            this.Fee_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Fee_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Fee_TextBox.FocusedState.Parent = this.Fee_TextBox;
            this.Fee_TextBox.ForeColor = System.Drawing.Color.Black;
            this.Fee_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Fee_TextBox.HoverState.Parent = this.Fee_TextBox;
            this.Fee_TextBox.Location = new System.Drawing.Point(58, 539);
            this.Fee_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fee_TextBox.Name = "Fee_TextBox";
            this.Fee_TextBox.PasswordChar = '\0';
            this.Fee_TextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Fee_TextBox.PlaceholderText = "";
            this.Fee_TextBox.SelectedText = "";
            this.Fee_TextBox.ShadowDecoration.Parent = this.Fee_TextBox;
            this.Fee_TextBox.Size = new System.Drawing.Size(113, 53);
            this.Fee_TextBox.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(54, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 69;
            this.label8.Text = "Fee";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(456, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Amount";
            // 
            // AmountTxt
            // 
            this.AmountTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.AmountTxt.BorderRadius = 20;
            this.AmountTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AmountTxt.DefaultText = "";
            this.AmountTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AmountTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AmountTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AmountTxt.DisabledState.Parent = this.AmountTxt;
            this.AmountTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AmountTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AmountTxt.FocusedState.Parent = this.AmountTxt;
            this.AmountTxt.ForeColor = System.Drawing.Color.Black;
            this.AmountTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AmountTxt.HoverState.Parent = this.AmountTxt;
            this.AmountTxt.Location = new System.Drawing.Point(460, 530);
            this.AmountTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.PasswordChar = '\0';
            this.AmountTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.AmountTxt.PlaceholderText = "";
            this.AmountTxt.SelectedText = "";
            this.AmountTxt.ShadowDecoration.Parent = this.AmountTxt;
            this.AmountTxt.Size = new System.Drawing.Size(120, 53);
            this.AmountTxt.TabIndex = 6;
            // 
            // Calcolate_Btn
            // 
            this.Calcolate_Btn.BorderRadius = 10;
            this.Calcolate_Btn.CheckedState.Parent = this.Calcolate_Btn;
            this.Calcolate_Btn.CustomImages.Parent = this.Calcolate_Btn;
            this.Calcolate_Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Calcolate_Btn.ForeColor = System.Drawing.Color.White;
            this.Calcolate_Btn.HoverState.Parent = this.Calcolate_Btn;
            this.Calcolate_Btn.Location = new System.Drawing.Point(257, 540);
            this.Calcolate_Btn.Name = "Calcolate_Btn";
            this.Calcolate_Btn.ShadowDecoration.Parent = this.Calcolate_Btn;
            this.Calcolate_Btn.Size = new System.Drawing.Size(97, 53);
            this.Calcolate_Btn.TabIndex = 71;
            this.Calcolate_Btn.Text = "Calcolate";
            this.Calcolate_Btn.Click += new System.EventHandler(this.Calcolate_Btn_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.BorderRadius = 10;
            this.Btn_Save.CheckedState.Parent = this.Btn_Save;
            this.Btn_Save.CustomImages.Parent = this.Btn_Save;
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.HoverState.Parent = this.Btn_Save;
            this.Btn_Save.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Save.ImageSize = new System.Drawing.Size(30, 30);
            this.Btn_Save.Location = new System.Drawing.Point(590, 616);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.ShadowDecoration.Parent = this.Btn_Save;
            this.Btn_Save.Size = new System.Drawing.Size(151, 49);
            this.Btn_Save.TabIndex = 72;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TitleLable.Location = new System.Drawing.Point(52, 9);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(293, 32);
            this.TitleLable.TabIndex = 107;
            this.TitleLable.Text = "Add New Subscription";
            // 
            // AddMemberBtn
            // 
            this.AddMemberBtn.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.AddMemberBtn.CheckedState.Parent = this.AddMemberBtn;
            this.AddMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMemberBtn.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.AddMemberBtn.HoverState.Parent = this.AddMemberBtn;
            this.AddMemberBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddMemberBtn.Image")));
            this.AddMemberBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.AddMemberBtn.Location = new System.Drawing.Point(282, 168);
            this.AddMemberBtn.Name = "AddMemberBtn";
            this.AddMemberBtn.PressedState.Parent = this.AddMemberBtn;
            this.AddMemberBtn.Size = new System.Drawing.Size(43, 53);
            this.AddMemberBtn.TabIndex = 62;
            this.AddMemberBtn.Click += new System.EventHandler(this.AddMemberBtn_Click);
            // 
            // AddUpdateSubscription_frm
            // 
            this.AcceptButton = this.Btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 677);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Calcolate_Btn);
            this.Controls.Add(this.AmountTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Fee_TextBox);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Start_DatePicker);
            this.Controls.Add(this.AddMemberBtn);
            this.Controls.Add(this.MemberID_Txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CoachesComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumericUpDown_Days);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Game_Combox);
            this.Controls.Add(this.SubscriptionsTypeComboBox);
            this.Controls.Add(this.Game_ComboBox);
            this.Controls.Add(this.SubIDTxt);
            this.MaximizeBox = false;
            this.Name = "AddUpdateSubscription_frm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddUpdateSubscription_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Days)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox SubIDTxt;
        private Guna.UI2.WinForms.Guna2ComboBox Game_ComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox SubscriptionsTypeComboBox;
        private System.Windows.Forms.Label Game_Combox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericUpDown_Days;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox CoachesComboBox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox MemberID_Txt;
        private Guna.UI2.WinForms.Guna2ImageButton AddMemberBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker Start_DatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker EndDatePicker;
        private Guna.UI2.WinForms.Guna2TextBox Fee_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox AmountTxt;
        private Guna.UI2.WinForms.Guna2Button Calcolate_Btn;
        private Guna.UI2.WinForms.Guna2Button Btn_Save;
        private System.Windows.Forms.Label TitleLable;
    }
}