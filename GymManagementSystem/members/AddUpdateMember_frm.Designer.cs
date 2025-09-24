namespace GymManagementSystem
{
    partial class AddUpdateMember_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateMember_frm));
            this.Name_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Phone_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Address_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Email_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ENumber_textBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MemberID_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateOFBirth_DataPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Switch_IsActive = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Female_RBtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.Male_RBtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.TitleLable = new System.Windows.Forms.Label();
            this.RemoveImge_Btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SetImage_Btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Member_PictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Btn_Saves = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Member_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_TextBox
            // 
            resources.ApplyResources(this.Name_TextBox, "Name_TextBox");
            this.Name_TextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.Name_TextBox.BorderRadius = 20;
            this.Name_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name_TextBox.DefaultText = "";
            this.Name_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Name_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Name_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Name_TextBox.DisabledState.Parent = this.Name_TextBox;
            this.Name_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.errorProvider1.SetError(this.Name_TextBox, resources.GetString("Name_TextBox.Error"));
            this.Name_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Name_TextBox.FocusedState.Parent = this.Name_TextBox;
            this.Name_TextBox.ForeColor = System.Drawing.Color.Black;
            this.Name_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Name_TextBox.HoverState.Parent = this.Name_TextBox;
            this.errorProvider1.SetIconAlignment(this.Name_TextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Name_TextBox.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Name_TextBox, ((int)(resources.GetObject("Name_TextBox.IconPadding"))));
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.PasswordChar = '\0';
            this.Name_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Name_TextBox.PlaceholderText = "";
            this.Name_TextBox.SelectedText = "";
            this.Name_TextBox.ShadowDecoration.Parent = this.Name_TextBox;
            this.Name_TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_TextBox_Validating);
            // 
            // Phone_TextBox
            // 
            resources.ApplyResources(this.Phone_TextBox, "Phone_TextBox");
            this.Phone_TextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.Phone_TextBox.BorderRadius = 20;
            this.Phone_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Phone_TextBox.DefaultText = "";
            this.Phone_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Phone_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Phone_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Phone_TextBox.DisabledState.Parent = this.Phone_TextBox;
            this.Phone_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.errorProvider1.SetError(this.Phone_TextBox, resources.GetString("Phone_TextBox.Error"));
            this.Phone_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Phone_TextBox.FocusedState.Parent = this.Phone_TextBox;
            this.Phone_TextBox.ForeColor = System.Drawing.Color.Black;
            this.Phone_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Phone_TextBox.HoverState.Parent = this.Phone_TextBox;
            this.errorProvider1.SetIconAlignment(this.Phone_TextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Phone_TextBox.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Phone_TextBox, ((int)(resources.GetObject("Phone_TextBox.IconPadding"))));
            this.Phone_TextBox.Name = "Phone_TextBox";
            this.Phone_TextBox.PasswordChar = '\0';
            this.Phone_TextBox.PlaceholderText = "";
            this.Phone_TextBox.SelectedText = "";
            this.Phone_TextBox.ShadowDecoration.Parent = this.Phone_TextBox;
            this.Phone_TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.Phone_TextBox_Validating);
            // 
            // Address_TextBox
            // 
            resources.ApplyResources(this.Address_TextBox, "Address_TextBox");
            this.Address_TextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.Address_TextBox.BorderRadius = 20;
            this.Address_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address_TextBox.DefaultText = "";
            this.Address_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Address_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Address_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Address_TextBox.DisabledState.Parent = this.Address_TextBox;
            this.Address_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.errorProvider1.SetError(this.Address_TextBox, resources.GetString("Address_TextBox.Error"));
            this.Address_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Address_TextBox.FocusedState.Parent = this.Address_TextBox;
            this.Address_TextBox.ForeColor = System.Drawing.Color.Black;
            this.Address_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Address_TextBox.HoverState.Parent = this.Address_TextBox;
            this.errorProvider1.SetIconAlignment(this.Address_TextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Address_TextBox.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Address_TextBox, ((int)(resources.GetObject("Address_TextBox.IconPadding"))));
            this.Address_TextBox.Name = "Address_TextBox";
            this.Address_TextBox.PasswordChar = '\0';
            this.Address_TextBox.PlaceholderText = "";
            this.Address_TextBox.SelectedText = "";
            this.Address_TextBox.ShadowDecoration.Parent = this.Address_TextBox;
            // 
            // Email_TextBox
            // 
            resources.ApplyResources(this.Email_TextBox, "Email_TextBox");
            this.Email_TextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.Email_TextBox.BorderRadius = 20;
            this.Email_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_TextBox.DefaultText = "";
            this.Email_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_TextBox.DisabledState.Parent = this.Email_TextBox;
            this.Email_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.errorProvider1.SetError(this.Email_TextBox, resources.GetString("Email_TextBox.Error"));
            this.Email_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_TextBox.FocusedState.Parent = this.Email_TextBox;
            this.Email_TextBox.ForeColor = System.Drawing.Color.Black;
            this.Email_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_TextBox.HoverState.Parent = this.Email_TextBox;
            this.errorProvider1.SetIconAlignment(this.Email_TextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Email_TextBox.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Email_TextBox, ((int)(resources.GetObject("Email_TextBox.IconPadding"))));
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.PasswordChar = '\0';
            this.Email_TextBox.PlaceholderText = "";
            this.Email_TextBox.SelectedText = "";
            this.Email_TextBox.ShadowDecoration.Parent = this.Email_TextBox;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // ENumber_textBox
            // 
            resources.ApplyResources(this.ENumber_textBox, "ENumber_textBox");
            this.ENumber_textBox.BorderColor = System.Drawing.Color.DarkGray;
            this.ENumber_textBox.BorderRadius = 20;
            this.ENumber_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ENumber_textBox.DefaultText = "";
            this.ENumber_textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ENumber_textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ENumber_textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ENumber_textBox.DisabledState.Parent = this.ENumber_textBox;
            this.ENumber_textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.errorProvider1.SetError(this.ENumber_textBox, resources.GetString("ENumber_textBox.Error"));
            this.ENumber_textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ENumber_textBox.FocusedState.Parent = this.ENumber_textBox;
            this.ENumber_textBox.ForeColor = System.Drawing.Color.Black;
            this.ENumber_textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ENumber_textBox.HoverState.Parent = this.ENumber_textBox;
            this.errorProvider1.SetIconAlignment(this.ENumber_textBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ENumber_textBox.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ENumber_textBox, ((int)(resources.GetObject("ENumber_textBox.IconPadding"))));
            this.ENumber_textBox.Name = "ENumber_textBox";
            this.ENumber_textBox.PasswordChar = '\0';
            this.ENumber_textBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.ENumber_textBox.PlaceholderText = "";
            this.ENumber_textBox.SelectedText = "";
            this.ENumber_textBox.ShadowDecoration.Parent = this.ENumber_textBox;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // MemberID_TextBox
            // 
            resources.ApplyResources(this.MemberID_TextBox, "MemberID_TextBox");
            this.MemberID_TextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.MemberID_TextBox.BorderRadius = 20;
            this.MemberID_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MemberID_TextBox.DefaultText = "";
            this.MemberID_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MemberID_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MemberID_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MemberID_TextBox.DisabledState.Parent = this.MemberID_TextBox;
            this.MemberID_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.errorProvider1.SetError(this.MemberID_TextBox, resources.GetString("MemberID_TextBox.Error"));
            this.MemberID_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MemberID_TextBox.FocusedState.Parent = this.MemberID_TextBox;
            this.MemberID_TextBox.ForeColor = System.Drawing.Color.Black;
            this.MemberID_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MemberID_TextBox.HoverState.Parent = this.MemberID_TextBox;
            this.errorProvider1.SetIconAlignment(this.MemberID_TextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("MemberID_TextBox.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.MemberID_TextBox, ((int)(resources.GetObject("MemberID_TextBox.IconPadding"))));
            this.MemberID_TextBox.Name = "MemberID_TextBox";
            this.MemberID_TextBox.PasswordChar = '\0';
            this.MemberID_TextBox.PlaceholderText = "";
            this.MemberID_TextBox.ReadOnly = true;
            this.MemberID_TextBox.SelectedText = "";
            this.MemberID_TextBox.ShadowDecoration.Parent = this.MemberID_TextBox;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error"));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error"));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errorProvider1.SetError(this.label5, resources.GetString("label5.Error"));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errorProvider1.SetError(this.label6, resources.GetString("label6.Error"));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errorProvider1.SetError(this.label7, resources.GetString("label7.Error"));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            // 
            // DateOFBirth_DataPicker
            // 
            resources.ApplyResources(this.DateOFBirth_DataPicker, "DateOFBirth_DataPicker");
            this.DateOFBirth_DataPicker.BorderColor = System.Drawing.Color.DarkGray;
            this.DateOFBirth_DataPicker.BorderRadius = 20;
            this.DateOFBirth_DataPicker.BorderThickness = 1;
            this.DateOFBirth_DataPicker.CheckedState.Parent = this.DateOFBirth_DataPicker;
            this.errorProvider1.SetError(this.DateOFBirth_DataPicker, resources.GetString("DateOFBirth_DataPicker.Error"));
            this.DateOFBirth_DataPicker.FillColor = System.Drawing.Color.White;
            this.DateOFBirth_DataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateOFBirth_DataPicker.HoverState.Parent = this.DateOFBirth_DataPicker;
            this.errorProvider1.SetIconAlignment(this.DateOFBirth_DataPicker, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("DateOFBirth_DataPicker.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.DateOFBirth_DataPicker, ((int)(resources.GetObject("DateOFBirth_DataPicker.IconPadding"))));
            this.DateOFBirth_DataPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateOFBirth_DataPicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateOFBirth_DataPicker.Name = "DateOFBirth_DataPicker";
            this.DateOFBirth_DataPicker.ShadowDecoration.Parent = this.DateOFBirth_DataPicker;
            this.DateOFBirth_DataPicker.Value = new System.DateTime(2024, 10, 21, 13, 58, 2, 771);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Switch_IsActive
            // 
            resources.ApplyResources(this.Switch_IsActive, "Switch_IsActive");
            this.Switch_IsActive.AutoRoundedCorners = true;
            this.Switch_IsActive.Checked = true;
            this.Switch_IsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Switch_IsActive.CheckedState.BorderRadius = 17;
            this.Switch_IsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Switch_IsActive.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Switch_IsActive.CheckedState.InnerBorderRadius = 13;
            this.Switch_IsActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Switch_IsActive.CheckedState.Parent = this.Switch_IsActive;
            this.errorProvider1.SetError(this.Switch_IsActive, resources.GetString("Switch_IsActive.Error"));
            this.errorProvider1.SetIconAlignment(this.Switch_IsActive, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Switch_IsActive.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Switch_IsActive, ((int)(resources.GetObject("Switch_IsActive.IconPadding"))));
            this.Switch_IsActive.Name = "Switch_IsActive";
            this.Switch_IsActive.ShadowDecoration.Parent = this.Switch_IsActive;
            this.Switch_IsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Switch_IsActive.UncheckedState.BorderRadius = 17;
            this.Switch_IsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Switch_IsActive.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Switch_IsActive.UncheckedState.InnerBorderRadius = 13;
            this.Switch_IsActive.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.Switch_IsActive.UncheckedState.Parent = this.Switch_IsActive;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.errorProvider1.SetError(this.label8, resources.GetString("label8.Error"));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.label8.Name = "label8";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // Female_RBtn
            // 
            resources.ApplyResources(this.Female_RBtn, "Female_RBtn");
            this.Female_RBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Female_RBtn.CheckedState.BorderThickness = 0;
            this.Female_RBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Female_RBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Female_RBtn.CheckedState.Parent = this.Female_RBtn;
            this.errorProvider1.SetError(this.Female_RBtn, resources.GetString("Female_RBtn.Error"));
            this.errorProvider1.SetIconAlignment(this.Female_RBtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Female_RBtn.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Female_RBtn, ((int)(resources.GetObject("Female_RBtn.IconPadding"))));
            this.Female_RBtn.Name = "Female_RBtn";
            this.Female_RBtn.ShadowDecoration.Parent = this.Female_RBtn;
            this.Female_RBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Female_RBtn.UncheckedState.BorderThickness = 2;
            this.Female_RBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Female_RBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Female_RBtn.UncheckedState.Parent = this.Female_RBtn;
            // 
            // Male_RBtn
            // 
            resources.ApplyResources(this.Male_RBtn, "Male_RBtn");
            this.Male_RBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Male_RBtn.CheckedState.BorderThickness = 0;
            this.Male_RBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Male_RBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Male_RBtn.CheckedState.Parent = this.Male_RBtn;
            this.errorProvider1.SetError(this.Male_RBtn, resources.GetString("Male_RBtn.Error"));
            this.errorProvider1.SetIconAlignment(this.Male_RBtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Male_RBtn.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Male_RBtn, ((int)(resources.GetObject("Male_RBtn.IconPadding"))));
            this.Male_RBtn.Name = "Male_RBtn";
            this.Male_RBtn.ShadowDecoration.Parent = this.Male_RBtn;
            this.Male_RBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Male_RBtn.UncheckedState.BorderThickness = 2;
            this.Male_RBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Male_RBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Male_RBtn.UncheckedState.Parent = this.Male_RBtn;
            // 
            // TitleLable
            // 
            resources.ApplyResources(this.TitleLable, "TitleLable");
            this.errorProvider1.SetError(this.TitleLable, resources.GetString("TitleLable.Error"));
            this.TitleLable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorProvider1.SetIconAlignment(this.TitleLable, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TitleLable.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.TitleLable, ((int)(resources.GetObject("TitleLable.IconPadding"))));
            this.TitleLable.Name = "TitleLable";
            // 
            // RemoveImge_Btn
            // 
            resources.ApplyResources(this.RemoveImge_Btn, "RemoveImge_Btn");
            this.RemoveImge_Btn.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.RemoveImge_Btn.CheckedState.Parent = this.RemoveImge_Btn;
            this.RemoveImge_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveImge_Btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.errorProvider1.SetError(this.RemoveImge_Btn, resources.GetString("RemoveImge_Btn.Error"));
            this.RemoveImge_Btn.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.RemoveImge_Btn.HoverState.Parent = this.RemoveImge_Btn;
            this.errorProvider1.SetIconAlignment(this.RemoveImge_Btn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("RemoveImge_Btn.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.RemoveImge_Btn, ((int)(resources.GetObject("RemoveImge_Btn.IconPadding"))));
            this.RemoveImge_Btn.Image = ((System.Drawing.Image)(resources.GetObject("RemoveImge_Btn.Image")));
            this.RemoveImge_Btn.ImageSize = new System.Drawing.Size(50, 50);
            this.RemoveImge_Btn.Name = "RemoveImge_Btn";
            this.RemoveImge_Btn.PressedState.Parent = this.RemoveImge_Btn;
            this.RemoveImge_Btn.Click += new System.EventHandler(this.RemoveImge_Btn_Click);
            // 
            // SetImage_Btn
            // 
            resources.ApplyResources(this.SetImage_Btn, "SetImage_Btn");
            this.SetImage_Btn.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.SetImage_Btn.CheckedState.Parent = this.SetImage_Btn;
            this.SetImage_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetError(this.SetImage_Btn, resources.GetString("SetImage_Btn.Error"));
            this.SetImage_Btn.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.SetImage_Btn.HoverState.Parent = this.SetImage_Btn;
            this.errorProvider1.SetIconAlignment(this.SetImage_Btn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("SetImage_Btn.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.SetImage_Btn, ((int)(resources.GetObject("SetImage_Btn.IconPadding"))));
            this.SetImage_Btn.Image = ((System.Drawing.Image)(resources.GetObject("SetImage_Btn.Image")));
            this.SetImage_Btn.ImageSize = new System.Drawing.Size(50, 50);
            this.SetImage_Btn.Name = "SetImage_Btn";
            this.SetImage_Btn.PressedState.Parent = this.SetImage_Btn;
            this.SetImage_Btn.Click += new System.EventHandler(this.SetImage_Btn_Click);
            // 
            // Member_PictureBox
            // 
            resources.ApplyResources(this.Member_PictureBox, "Member_PictureBox");
            this.errorProvider1.SetError(this.Member_PictureBox, resources.GetString("Member_PictureBox.Error"));
            this.errorProvider1.SetIconAlignment(this.Member_PictureBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Member_PictureBox.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Member_PictureBox, ((int)(resources.GetObject("Member_PictureBox.IconPadding"))));
            this.Member_PictureBox.Image = global::GymManagementSystem.Resource1.DefultPersonPic;
            this.Member_PictureBox.Name = "Member_PictureBox";
            this.Member_PictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Member_PictureBox.ShadowDecoration.Parent = this.Member_PictureBox;
            this.Member_PictureBox.TabStop = false;
            this.Member_PictureBox.Click += new System.EventHandler(this.Member_PictureBox_Click);
            // 
            // Btn_Saves
            // 
            resources.ApplyResources(this.Btn_Saves, "Btn_Saves");
            this.Btn_Saves.BorderRadius = 20;
            this.Btn_Saves.CheckedState.Parent = this.Btn_Saves;
            this.Btn_Saves.CustomImages.Parent = this.Btn_Saves;
            this.errorProvider1.SetError(this.Btn_Saves, resources.GetString("Btn_Saves.Error"));
            this.Btn_Saves.ForeColor = System.Drawing.Color.White;
            this.Btn_Saves.HoverState.Parent = this.Btn_Saves;
            this.errorProvider1.SetIconAlignment(this.Btn_Saves, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Btn_Saves.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Btn_Saves, ((int)(resources.GetObject("Btn_Saves.IconPadding"))));
            this.Btn_Saves.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Saves.ImageSize = new System.Drawing.Size(30, 30);
            this.Btn_Saves.Name = "Btn_Saves";
            this.Btn_Saves.ShadowDecoration.Parent = this.Btn_Saves;
            this.Btn_Saves.Click += new System.EventHandler(this.Btn_Saves_Click);
            // 
            // AddUpdateMember_frm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Btn_Saves);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.Female_RBtn);
            this.Controls.Add(this.Male_RBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Switch_IsActive);
            this.Controls.Add(this.RemoveImge_Btn);
            this.Controls.Add(this.SetImage_Btn);
            this.Controls.Add(this.DateOFBirth_DataPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MemberID_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ENumber_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Member_PictureBox);
            this.Controls.Add(this.Email_TextBox);
            this.Controls.Add(this.Address_TextBox);
            this.Controls.Add(this.Phone_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddUpdateMember_frm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AddUpdate_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Member_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox Name_TextBox;
        private Guna.UI2.WinForms.Guna2TextBox Phone_TextBox;
        private Guna.UI2.WinForms.Guna2TextBox Address_TextBox;
        private Guna.UI2.WinForms.Guna2TextBox Email_TextBox;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Member_PictureBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox ENumber_textBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox MemberID_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateOFBirth_DataPicker;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2ImageButton SetImage_Btn;
        private Guna.UI2.WinForms.Guna2ImageButton RemoveImge_Btn;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Switch_IsActive;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton Female_RBtn;
        private Guna.UI2.WinForms.Guna2CustomRadioButton Male_RBtn;
        private System.Windows.Forms.Label TitleLable;
        private Guna.UI2.WinForms.Guna2Button Btn_Saves;
    }
}