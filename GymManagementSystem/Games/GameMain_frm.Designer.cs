namespace GymManagementSystem
{
    partial class GameMain_frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMain_frm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GamesList_DGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.UpdateGameBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AddGameBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleLable = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamesList_DGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // GamesList_DGrid
            // 
            this.GamesList_DGrid.AllowUserToAddRows = false;
            this.GamesList_DGrid.AllowUserToDeleteRows = false;
            this.GamesList_DGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.GamesList_DGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.GamesList_DGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GamesList_DGrid.BackgroundColor = System.Drawing.Color.White;
            this.GamesList_DGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GamesList_DGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GamesList_DGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GamesList_DGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GamesList_DGrid.ColumnHeadersHeight = 40;
            this.GamesList_DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GamesList_DGrid.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GamesList_DGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.GamesList_DGrid.EnableHeadersVisualStyles = false;
            this.GamesList_DGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GamesList_DGrid.Location = new System.Drawing.Point(25, 215);
            this.GamesList_DGrid.Name = "GamesList_DGrid";
            this.GamesList_DGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GamesList_DGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GamesList_DGrid.RowHeadersVisible = false;
            this.GamesList_DGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.GamesList_DGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.GamesList_DGrid.RowTemplate.Height = 50;
            this.GamesList_DGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GamesList_DGrid.Size = new System.Drawing.Size(970, 406);
            this.GamesList_DGrid.TabIndex = 8;
            this.GamesList_DGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.GamesList_DGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GamesList_DGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GamesList_DGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GamesList_DGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GamesList_DGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GamesList_DGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GamesList_DGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GamesList_DGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.GamesList_DGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GamesList_DGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GamesList_DGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Empty;
            this.GamesList_DGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GamesList_DGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.GamesList_DGrid.ThemeStyle.ReadOnly = true;
            this.GamesList_DGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GamesList_DGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GamesList_DGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GamesList_DGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GamesList_DGrid.ThemeStyle.RowsStyle.Height = 50;
            this.GamesList_DGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GamesList_DGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UpdateGameBtn
            // 
            this.UpdateGameBtn.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.UpdateGameBtn.CheckedState.Parent = this.UpdateGameBtn;
            this.UpdateGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateGameBtn.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.UpdateGameBtn.HoverState.Parent = this.UpdateGameBtn;
            this.UpdateGameBtn.Image = ((System.Drawing.Image)(resources.GetObject("UpdateGameBtn.Image")));
            this.UpdateGameBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.UpdateGameBtn.Location = new System.Drawing.Point(861, 129);
            this.UpdateGameBtn.Name = "UpdateGameBtn";
            this.UpdateGameBtn.PressedState.Parent = this.UpdateGameBtn;
            this.UpdateGameBtn.Size = new System.Drawing.Size(57, 61);
            this.UpdateGameBtn.TabIndex = 7;
            this.UpdateGameBtn.Click += new System.EventHandler(this.UpdateGameBtn_Click);
            // 
            // AddGameBtn
            // 
            this.AddGameBtn.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.AddGameBtn.CheckedState.Parent = this.AddGameBtn;
            this.AddGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddGameBtn.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.AddGameBtn.HoverState.Parent = this.AddGameBtn;
            this.AddGameBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddGameBtn.Image")));
            this.AddGameBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.AddGameBtn.Location = new System.Drawing.Point(938, 129);
            this.AddGameBtn.Name = "AddGameBtn";
            this.AddGameBtn.PressedState.Parent = this.AddGameBtn;
            this.AddGameBtn.Size = new System.Drawing.Size(57, 61);
            this.AddGameBtn.TabIndex = 6;
            this.AddGameBtn.Click += new System.EventHandler(this.AddGameBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.TitleLable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TitleLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TitleLable.Location = new System.Drawing.Point(77, 38);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(157, 32);
            this.TitleLable.TabIndex = 135;
            this.TitleLable.Text = "Games List";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(25, 86);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(970, 10);
            this.guna2Separator1.TabIndex = 136;
            // 
            // GameMain_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 719);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.GamesList_DGrid);
            this.Controls.Add(this.UpdateGameBtn);
            this.Controls.Add(this.AddGameBtn);
            this.Name = "GameMain_frm";
            this.Text = "GameMain_frm";
            this.Load += new System.EventHandler(this.GameMain_frm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GamesList_DGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton AddGameBtn;
        private Guna.UI2.WinForms.Guna2ImageButton UpdateGameBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2DataGridView GamesList_DGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLable;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}