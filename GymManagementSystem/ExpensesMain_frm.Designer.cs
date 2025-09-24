namespace GymManagementSystem
{
    partial class ExpensesMain_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpensesMain_frm));
            this.ExpensesList_DGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Delete_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Edit_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleLable = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesList_DGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpensesList_DGrid
            // 
            this.ExpensesList_DGrid.AllowUserToAddRows = false;
            this.ExpensesList_DGrid.AllowUserToDeleteRows = false;
            this.ExpensesList_DGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.ExpensesList_DGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ExpensesList_DGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExpensesList_DGrid.BackgroundColor = System.Drawing.Color.White;
            this.ExpensesList_DGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpensesList_DGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ExpensesList_DGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesList_DGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ExpensesList_DGrid.ColumnHeadersHeight = 40;
            this.ExpensesList_DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpensesList_DGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.ExpensesList_DGrid.EnableHeadersVisualStyles = false;
            this.ExpensesList_DGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ExpensesList_DGrid.Location = new System.Drawing.Point(13, 207);
            this.ExpensesList_DGrid.Name = "ExpensesList_DGrid";
            this.ExpensesList_DGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesList_DGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ExpensesList_DGrid.RowHeadersVisible = false;
            this.ExpensesList_DGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.ExpensesList_DGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ExpensesList_DGrid.RowTemplate.Height = 50;
            this.ExpensesList_DGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpensesList_DGrid.Size = new System.Drawing.Size(1117, 473);
            this.ExpensesList_DGrid.TabIndex = 2;
            this.ExpensesList_DGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ExpensesList_DGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ExpensesList_DGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ExpensesList_DGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ExpensesList_DGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ExpensesList_DGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ExpensesList_DGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ExpensesList_DGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ExpensesList_DGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.ExpensesList_DGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ExpensesList_DGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ExpensesList_DGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Empty;
            this.ExpensesList_DGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ExpensesList_DGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.ExpensesList_DGrid.ThemeStyle.ReadOnly = true;
            this.ExpensesList_DGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ExpensesList_DGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ExpensesList_DGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ExpensesList_DGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ExpensesList_DGrid.ThemeStyle.RowsStyle.Height = 50;
            this.ExpensesList_DGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ExpensesList_DGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.BorderRadius = 5;
            this.Delete_Btn.CheckedState.Parent = this.Delete_Btn;
            this.Delete_Btn.CustomImages.Parent = this.Delete_Btn;
            this.Delete_Btn.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Delete_Btn.ForeColor = System.Drawing.Color.White;
            this.Delete_Btn.HoverState.Parent = this.Delete_Btn;
            this.Delete_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Btn.Image")));
            this.Delete_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Delete_Btn.Location = new System.Drawing.Point(766, 134);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.ShadowDecoration.Parent = this.Delete_Btn;
            this.Delete_Btn.Size = new System.Drawing.Size(97, 48);
            this.Delete_Btn.TabIndex = 113;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.BorderRadius = 5;
            this.Edit_Btn.CheckedState.Parent = this.Edit_Btn;
            this.Edit_Btn.CustomImages.Parent = this.Edit_Btn;
            this.Edit_Btn.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Edit_Btn.ForeColor = System.Drawing.Color.White;
            this.Edit_Btn.HoverState.Parent = this.Edit_Btn;
            this.Edit_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Btn.Image")));
            this.Edit_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Edit_Btn.Location = new System.Drawing.Point(889, 134);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.ShadowDecoration.Parent = this.Edit_Btn;
            this.Edit_Btn.Size = new System.Drawing.Size(97, 48);
            this.Edit_Btn.TabIndex = 112;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.TextOffset = new System.Drawing.Point(5, 0);
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.BorderRadius = 5;
            this.Btn_Add.CheckedState.Parent = this.Btn_Add;
            this.Btn_Add.CustomImages.Parent = this.Btn_Add;
            this.Btn_Add.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.HoverState.Parent = this.Btn_Add;
            this.Btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Add.Image")));
            this.Btn_Add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Add.Location = new System.Drawing.Point(1009, 134);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.ShadowDecoration.Parent = this.Btn_Add;
            this.Btn_Add.Size = new System.Drawing.Size(97, 48);
            this.Btn_Add.TabIndex = 111;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.TextOffset = new System.Drawing.Point(6, 0);
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
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
            this.TitleLable.Location = new System.Drawing.Point(73, 28);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(191, 32);
            this.TitleLable.TabIndex = 129;
            this.TitleLable.Text = "Expenses List";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(13, 86);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1117, 10);
            this.guna2Separator1.TabIndex = 130;
            // 
            // ExpensesMain_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1142, 701);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Edit_Btn);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.ExpensesList_DGrid);
            this.Name = "ExpensesMain_frm";
            this.Text = "ExpensesMain_frm";
            this.Load += new System.EventHandler(this.ExpensesMain_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesList_DGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView ExpensesList_DGrid;
        private Guna.UI2.WinForms.Guna2Button Delete_Btn;
        private Guna.UI2.WinForms.Guna2Button Edit_Btn;
        private Guna.UI2.WinForms.Guna2Button Btn_Add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLable;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}