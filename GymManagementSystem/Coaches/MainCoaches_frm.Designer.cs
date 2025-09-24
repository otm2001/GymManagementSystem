namespace GymManagementSystem
{
    partial class MainCoaches_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCoaches_frm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterGamesComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CoachesList_DGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DeleteCoach_Btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.UpdateCoach_Btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AddCoachBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleLable = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoachesList_DGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 56);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // FilterGamesComboBox
            // 
            this.FilterGamesComboBox.Animated = true;
            this.FilterGamesComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterGamesComboBox.BorderRadius = 10;
            this.FilterGamesComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterGamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterGamesComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.FilterGamesComboBox.FocusedState.Parent = this.FilterGamesComboBox;
            this.FilterGamesComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FilterGamesComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FilterGamesComboBox.FormattingEnabled = true;
            this.FilterGamesComboBox.HoverState.Parent = this.FilterGamesComboBox;
            this.FilterGamesComboBox.ItemHeight = 40;
            this.FilterGamesComboBox.Items.AddRange(new object[] {
            "None"});
            this.FilterGamesComboBox.ItemsAppearance.Parent = this.FilterGamesComboBox;
            this.FilterGamesComboBox.Location = new System.Drawing.Point(17, 162);
            this.FilterGamesComboBox.Name = "FilterGamesComboBox";
            this.FilterGamesComboBox.ShadowDecoration.Parent = this.FilterGamesComboBox;
            this.FilterGamesComboBox.Size = new System.Drawing.Size(174, 46);
            this.FilterGamesComboBox.StartIndex = 0;
            this.FilterGamesComboBox.TabIndex = 8;
            this.FilterGamesComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterGamesComboBox_SelectedIndexChanged);
            // 
            // CoachesList_DGrid
            // 
            this.CoachesList_DGrid.AllowUserToAddRows = false;
            this.CoachesList_DGrid.AllowUserToDeleteRows = false;
            this.CoachesList_DGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CoachesList_DGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CoachesList_DGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CoachesList_DGrid.BackgroundColor = System.Drawing.Color.White;
            this.CoachesList_DGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CoachesList_DGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CoachesList_DGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CoachesList_DGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CoachesList_DGrid.ColumnHeadersHeight = 40;
            this.CoachesList_DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CoachesList_DGrid.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CoachesList_DGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.CoachesList_DGrid.EnableHeadersVisualStyles = false;
            this.CoachesList_DGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CoachesList_DGrid.Location = new System.Drawing.Point(17, 228);
            this.CoachesList_DGrid.Name = "CoachesList_DGrid";
            this.CoachesList_DGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CoachesList_DGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CoachesList_DGrid.RowHeadersVisible = false;
            this.CoachesList_DGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.CoachesList_DGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CoachesList_DGrid.RowTemplate.Height = 50;
            this.CoachesList_DGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CoachesList_DGrid.Size = new System.Drawing.Size(1158, 473);
            this.CoachesList_DGrid.TabIndex = 9;
            this.CoachesList_DGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CoachesList_DGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CoachesList_DGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CoachesList_DGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CoachesList_DGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CoachesList_DGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CoachesList_DGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CoachesList_DGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CoachesList_DGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.CoachesList_DGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CoachesList_DGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CoachesList_DGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Empty;
            this.CoachesList_DGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CoachesList_DGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.CoachesList_DGrid.ThemeStyle.ReadOnly = true;
            this.CoachesList_DGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CoachesList_DGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CoachesList_DGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CoachesList_DGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CoachesList_DGrid.ThemeStyle.RowsStyle.Height = 50;
            this.CoachesList_DGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CoachesList_DGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DeleteCoach_Btn
            // 
            this.DeleteCoach_Btn.CheckedState.ImageSize = new System.Drawing.Size(0, 0);
            this.DeleteCoach_Btn.CheckedState.Parent = this.DeleteCoach_Btn;
            this.DeleteCoach_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteCoach_Btn.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.DeleteCoach_Btn.HoverState.Parent = this.DeleteCoach_Btn;
            this.DeleteCoach_Btn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCoach_Btn.Image")));
            this.DeleteCoach_Btn.ImageSize = new System.Drawing.Size(50, 50);
            this.DeleteCoach_Btn.Location = new System.Drawing.Point(916, 147);
            this.DeleteCoach_Btn.Name = "DeleteCoach_Btn";
            this.DeleteCoach_Btn.PressedState.Parent = this.DeleteCoach_Btn;
            this.DeleteCoach_Btn.Size = new System.Drawing.Size(71, 61);
            this.DeleteCoach_Btn.TabIndex = 7;
            this.DeleteCoach_Btn.Click += new System.EventHandler(this.DeleteCoach_Btn_Click_1);
            // 
            // UpdateCoach_Btn
            // 
            this.UpdateCoach_Btn.CheckedState.ImageSize = new System.Drawing.Size(0, 0);
            this.UpdateCoach_Btn.CheckedState.Parent = this.UpdateCoach_Btn;
            this.UpdateCoach_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateCoach_Btn.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.UpdateCoach_Btn.HoverState.Parent = this.UpdateCoach_Btn;
            this.UpdateCoach_Btn.Image = ((System.Drawing.Image)(resources.GetObject("UpdateCoach_Btn.Image")));
            this.UpdateCoach_Btn.ImageSize = new System.Drawing.Size(50, 50);
            this.UpdateCoach_Btn.Location = new System.Drawing.Point(1003, 147);
            this.UpdateCoach_Btn.Name = "UpdateCoach_Btn";
            this.UpdateCoach_Btn.PressedState.Parent = this.UpdateCoach_Btn;
            this.UpdateCoach_Btn.Size = new System.Drawing.Size(71, 61);
            this.UpdateCoach_Btn.TabIndex = 6;
            this.UpdateCoach_Btn.Click += new System.EventHandler(this.UpdateCoach_Btn_Click_1);
            // 
            // AddCoachBtn
            // 
            this.AddCoachBtn.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.AddCoachBtn.CheckedState.Parent = this.AddCoachBtn;
            this.AddCoachBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCoachBtn.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.AddCoachBtn.HoverState.Parent = this.AddCoachBtn;
            this.AddCoachBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddCoachBtn.Image")));
            this.AddCoachBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.AddCoachBtn.Location = new System.Drawing.Point(1090, 147);
            this.AddCoachBtn.Name = "AddCoachBtn";
            this.AddCoachBtn.PressedState.Parent = this.AddCoachBtn;
            this.AddCoachBtn.Size = new System.Drawing.Size(71, 61);
            this.AddCoachBtn.TabIndex = 5;
            this.AddCoachBtn.Click += new System.EventHandler(this.AddCoachBtn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 134;
            this.pictureBox1.TabStop = false;
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.TitleLable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TitleLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TitleLable.Location = new System.Drawing.Point(80, 28);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(178, 32);
            this.TitleLable.TabIndex = 132;
            this.TitleLable.Text = "Coaches List";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(-3, 86);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1178, 10);
            this.guna2Separator1.TabIndex = 133;
            // 
            // MainCoaches_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 775);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.CoachesList_DGrid);
            this.Controls.Add(this.FilterGamesComboBox);
            this.Controls.Add(this.DeleteCoach_Btn);
            this.Controls.Add(this.UpdateCoach_Btn);
            this.Controls.Add(this.AddCoachBtn);
            this.Name = "MainCoaches_frm";
            this.Text = "form2";
            this.Load += new System.EventHandler(this.form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoachesList_DGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton DeleteCoach_Btn;
        private Guna.UI2.WinForms.Guna2ImageButton UpdateCoach_Btn;
        private Guna.UI2.WinForms.Guna2ImageButton AddCoachBtn;
        private Guna.UI2.WinForms.Guna2ComboBox FilterGamesComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2DataGridView CoachesList_DGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLable;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}