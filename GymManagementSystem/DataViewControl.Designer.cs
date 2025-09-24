namespace GymManagementSystem
{
    partial class DataViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.squareChip = new Guna.UI2.WinForms.Guna2Chip();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Number = new System.Windows.Forms.Label();
            this._Icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._Icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // squareChip
            // 
            this.squareChip.BorderRadius = 10;
            this.squareChip.FillColor = System.Drawing.Color.White;
            this.squareChip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.squareChip.ForeColor = System.Drawing.Color.White;
            this.squareChip.Location = new System.Drawing.Point(3, 49);
            this.squareChip.Name = "squareChip";
            this.squareChip.ShadowDecoration.Parent = this.squareChip;
            this.squareChip.Size = new System.Drawing.Size(454, 163);
            this.squareChip.TabIndex = 4;
            this.squareChip.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(335, 85);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(41, 20);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Text";
            // 
            // label_Number
            // 
            this.label_Number.AutoSize = true;
            this.label_Number.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Number.Location = new System.Drawing.Point(387, 132);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(30, 32);
            this.label_Number.TabIndex = 2;
            this.label_Number.Text = "0";
            // 
            // _Icon
            // 
           
            this._Icon.Location = new System.Drawing.Point(34, 24);
            this._Icon.Name = "_Icon";
            this._Icon.Size = new System.Drawing.Size(77, 67);
            this._Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._Icon.TabIndex = 0;
            this._Icon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._Icon);
            this.panel1.Location = new System.Drawing.Point(23, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 130);
            this.panel1.TabIndex = 5;
            // 
            // DataViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label_Number);
            this.Controls.Add(this.squareChip);
            this.Name = "DataViewControl";
            this.Size = new System.Drawing.Size(463, 222);
            ((System.ComponentModel.ISupportInitialize)(this._Icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Chip squareChip;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.PictureBox _Icon;
        private System.Windows.Forms.Panel panel1;
    }
}
