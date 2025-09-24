namespace GymManagementSystem
{
    partial class PaymentsMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsMain));
            this.PaymentsList_DGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Search_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleLable = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsList_DGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentsList_DGrid
            // 
            this.PaymentsList_DGrid.AllowUserToAddRows = false;
            this.PaymentsList_DGrid.AllowUserToDeleteRows = false;
            this.PaymentsList_DGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.PaymentsList_DGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.PaymentsList_DGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PaymentsList_DGrid.BackgroundColor = System.Drawing.Color.White;
            this.PaymentsList_DGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentsList_DGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PaymentsList_DGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentsList_DGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.PaymentsList_DGrid.ColumnHeadersHeight = 40;
            this.PaymentsList_DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PaymentsList_DGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.PaymentsList_DGrid.EnableHeadersVisualStyles = false;
            this.PaymentsList_DGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PaymentsList_DGrid.Location = new System.Drawing.Point(12, 216);
            this.PaymentsList_DGrid.Name = "PaymentsList_DGrid";
            this.PaymentsList_DGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentsList_DGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.PaymentsList_DGrid.RowHeadersVisible = false;
            this.PaymentsList_DGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.PaymentsList_DGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.PaymentsList_DGrid.RowTemplate.Height = 50;
            this.PaymentsList_DGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaymentsList_DGrid.Size = new System.Drawing.Size(1113, 473);
            this.PaymentsList_DGrid.TabIndex = 2;
            this.PaymentsList_DGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.PaymentsList_DGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PaymentsList_DGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PaymentsList_DGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PaymentsList_DGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PaymentsList_DGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PaymentsList_DGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PaymentsList_DGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PaymentsList_DGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.PaymentsList_DGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.PaymentsList_DGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PaymentsList_DGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Empty;
            this.PaymentsList_DGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PaymentsList_DGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.PaymentsList_DGrid.ThemeStyle.ReadOnly = true;
            this.PaymentsList_DGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PaymentsList_DGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PaymentsList_DGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PaymentsList_DGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PaymentsList_DGrid.ThemeStyle.RowsStyle.Height = 50;
            this.PaymentsList_DGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PaymentsList_DGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.Search_TextBox.BorderRadius = 10;
            this.Search_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_TextBox.DefaultText = "";
            this.Search_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_TextBox.DisabledState.Parent = this.Search_TextBox;
            this.Search_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_TextBox.FocusedState.Parent = this.Search_TextBox;
            this.Search_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_TextBox.HoverState.Parent = this.Search_TextBox;
            this.Search_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Search_TextBox.IconLeft")));
            this.Search_TextBox.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.Search_TextBox.Location = new System.Drawing.Point(291, 151);
            this.Search_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.PasswordChar = '\0';
            this.Search_TextBox.PlaceholderText = " Search....";
            this.Search_TextBox.SelectedText = "";
            this.Search_TextBox.ShadowDecoration.Parent = this.Search_TextBox;
            this.Search_TextBox.Size = new System.Drawing.Size(517, 47);
            this.Search_TextBox.TabIndex = 7;
            this.Search_TextBox.TextChanged += new System.EventHandler(this.Search_TextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.TitleLable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TitleLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TitleLable.Location = new System.Drawing.Point(75, 28);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(192, 32);
            this.TitleLable.TabIndex = 129;
            this.TitleLable.Text = "Payments List";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 86);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1113, 10);
            this.guna2Separator1.TabIndex = 130;
            // 
            // PaymentsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1142, 701);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.Search_TextBox);
            this.Controls.Add(this.PaymentsList_DGrid);
            this.Name = "PaymentsMain";
            this.Text = "PaymentsMain";
            this.Load += new System.EventHandler(this.PaymentsMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsList_DGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView PaymentsList_DGrid;
        private Guna.UI2.WinForms.Guna2TextBox Search_TextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLable;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}