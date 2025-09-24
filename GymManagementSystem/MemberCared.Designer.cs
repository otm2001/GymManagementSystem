namespace GymManagementSystem
{
    partial class MemberCared
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
            this.uclPersonCard1 = new GymManagementSystem.UclPersonCard();
            this.SuspendLayout();
            // 
            // uclPersonCard1
            // 
            this.uclPersonCard1.Location = new System.Drawing.Point(32, -1);
            this.uclPersonCard1.Name = "uclPersonCard1";
            this.uclPersonCard1.Size = new System.Drawing.Size(872, 445);
            this.uclPersonCard1.TabIndex = 0;
            // 
            // MemberCared
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 456);
            this.Controls.Add(this.uclPersonCard1);
            this.Name = "MemberCared";
            this.Text = "MemberCared";
            this.ResumeLayout(false);

        }

        #endregion

        private UclPersonCard uclPersonCard1;
    }
}