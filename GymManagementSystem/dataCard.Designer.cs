namespace GymManagementSystem
{
    partial class dataCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.Card_Icon = new System.Windows.Forms.PictureBox();
            this.Number_Lable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Card_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Card_Icon
            // 
            this.Card_Icon.Location = new System.Drawing.Point(137, 37);
            this.Card_Icon.Name = "Card_Icon";
            this.Card_Icon.Size = new System.Drawing.Size(106, 91);
            this.Card_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Card_Icon.TabIndex = 0;
            this.Card_Icon.TabStop = false;
            // 
            // Number_Lable
            // 
            this.Number_Lable.AutoSize = true;
            this.Number_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Lable.ForeColor = System.Drawing.Color.White;
            this.Number_Lable.Location = new System.Drawing.Point(16, 37);
            this.Number_Lable.Name = "Number_Lable";
            this.Number_Lable.Size = new System.Drawing.Size(76, 32);
            this.Number_Lable.TabIndex = 2;
            this.Number_Lable.Text = "Num";
            this.Number_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Number_Lable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Card_Icon);
            this.Name = "dataCard";
            this.Size = new System.Drawing.Size(258, 149);
            ((System.ComponentModel.ISupportInitialize)(this.Card_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Card_Icon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Number_Lable;
    }
}
