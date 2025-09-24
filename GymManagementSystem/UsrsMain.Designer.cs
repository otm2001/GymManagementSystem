namespace GymManagementSystem
{
    partial class UsrsMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddNewUser_Save = new Guna.UI2.WinForms.Guna2Button();
            this.Edit_User = new Guna.UI2.WinForms.Guna2Button();
            this.UsersList_DGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UsersList_DGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewUser_Save
            // 
            this.AddNewUser_Save.BorderRadius = 15;
            this.AddNewUser_Save.CheckedState.Parent = this.AddNewUser_Save;
            this.AddNewUser_Save.CustomImages.Parent = this.AddNewUser_Save;
            this.AddNewUser_Save.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.AddNewUser_Save.ForeColor = System.Drawing.Color.White;
            this.AddNewUser_Save.HoverState.Parent = this.AddNewUser_Save;
            this.AddNewUser_Save.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddNewUser_Save.ImageSize = new System.Drawing.Size(30, 30);
            this.AddNewUser_Save.Location = new System.Drawing.Point(977, 163);
            this.AddNewUser_Save.Name = "AddNewUser_Save";
            this.AddNewUser_Save.ShadowDecoration.Parent = this.AddNewUser_Save;
            this.AddNewUser_Save.Size = new System.Drawing.Size(143, 45);
            this.AddNewUser_Save.TabIndex = 53;
            this.AddNewUser_Save.Text = "Add User";
            this.AddNewUser_Save.Click += new System.EventHandler(this.AddNewUser_Save_Click);
            // 
            // Edit_User
            // 
            this.Edit_User.BorderRadius = 15;
            this.Edit_User.CheckedState.Parent = this.Edit_User;
            this.Edit_User.CustomImages.Parent = this.Edit_User;
            this.Edit_User.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Edit_User.ForeColor = System.Drawing.Color.White;
            this.Edit_User.HoverState.Parent = this.Edit_User;
            this.Edit_User.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Edit_User.ImageSize = new System.Drawing.Size(30, 30);
            this.Edit_User.Location = new System.Drawing.Point(803, 163);
            this.Edit_User.Name = "Edit_User";
            this.Edit_User.ShadowDecoration.Parent = this.Edit_User;
            this.Edit_User.Size = new System.Drawing.Size(143, 45);
            this.Edit_User.TabIndex = 54;
            this.Edit_User.Text = "Edit User";
            this.Edit_User.Click += new System.EventHandler(this.Edit_User_Click);
            // 
            // UsersList_DGrid
            // 
            this.UsersList_DGrid.AllowUserToAddRows = false;
            this.UsersList_DGrid.AllowUserToDeleteRows = false;
            this.UsersList_DGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.UsersList_DGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.UsersList_DGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersList_DGrid.BackgroundColor = System.Drawing.Color.White;
            this.UsersList_DGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersList_DGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersList_DGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersList_DGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.UsersList_DGrid.ColumnHeadersHeight = 40;
            this.UsersList_DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersList_DGrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.UsersList_DGrid.EnableHeadersVisualStyles = false;
            this.UsersList_DGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersList_DGrid.Location = new System.Drawing.Point(126, 234);
            this.UsersList_DGrid.Name = "UsersList_DGrid";
            this.UsersList_DGrid.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersList_DGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.UsersList_DGrid.RowHeadersVisible = false;
            this.UsersList_DGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.UsersList_DGrid.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.UsersList_DGrid.RowTemplate.Height = 50;
            this.UsersList_DGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersList_DGrid.Size = new System.Drawing.Size(932, 366);
            this.UsersList_DGrid.TabIndex = 55;
            this.UsersList_DGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.UsersList_DGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersList_DGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UsersList_DGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UsersList_DGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UsersList_DGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UsersList_DGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UsersList_DGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersList_DGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UsersList_DGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.UsersList_DGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UsersList_DGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Empty;
            this.UsersList_DGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UsersList_DGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.UsersList_DGrid.ThemeStyle.ReadOnly = true;
            this.UsersList_DGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersList_DGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersList_DGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UsersList_DGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UsersList_DGrid.ThemeStyle.RowsStyle.Height = 50;
            this.UsersList_DGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersList_DGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UsrsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1142, 653);
            this.Controls.Add(this.UsersList_DGrid);
            this.Controls.Add(this.Edit_User);
            this.Controls.Add(this.AddNewUser_Save);
            this.MaximizeBox = false;
            this.Name = "UsrsMain";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.UsrsMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersList_DGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddNewUser_Save;
        private Guna.UI2.WinForms.Guna2Button Edit_User;
        private Guna.UI2.WinForms.Guna2DataGridView UsersList_DGrid;
    }
}