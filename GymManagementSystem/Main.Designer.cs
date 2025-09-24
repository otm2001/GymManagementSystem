namespace GymManagementSystem
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Chip2 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Chip3 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Chip4 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Chip5 = new Guna.UI2.WinForms.Guna2Chip();
            this.Time_Lable = new System.Windows.Forms.Label();
            this.Welcome_Lable = new System.Windows.Forms.Label();
            this.label_Morning_Evening = new System.Windows.Forms.Label();
            this.guna2Chip6 = new Guna.UI2.WinForms.Guna2Chip();
            this.dataCard1 = new GymManagementSystem.dataCard();
            this.dataCard_ActiveMembers = new GymManagementSystem.dataCard();
            this.dataCard_Members = new GymManagementSystem.dataCard();
            this.dataCard_InActiveMembers = new GymManagementSystem.dataCard();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(40, 347);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "SubscriptionGames";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(439, 270);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // guna2Chip1
            // 
            this.guna2Chip1.BorderRadius = 15;
            this.guna2Chip1.FillColor = System.Drawing.Color.White;
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(21, 330);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(473, 311);
            this.guna2Chip1.TabIndex = 13;
            this.guna2Chip1.Text = "guna2Chip1";
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Chip2
            // 
            this.guna2Chip2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Chip2.BorderRadius = 15;
            this.guna2Chip2.FillColor = System.Drawing.Color.Gold;
            this.guna2Chip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Chip2.ForeColor = System.Drawing.Color.White;
            this.guna2Chip2.Location = new System.Drawing.Point(614, 128);
            this.guna2Chip2.Name = "guna2Chip2";
            this.guna2Chip2.ShadowDecoration.Parent = this.guna2Chip2;
            this.guna2Chip2.Size = new System.Drawing.Size(270, 171);
            this.guna2Chip2.TabIndex = 14;
            this.guna2Chip2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Chip3
            // 
            this.guna2Chip3.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Chip3.BorderRadius = 15;
            this.guna2Chip3.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2Chip3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Chip3.ForeColor = System.Drawing.Color.White;
            this.guna2Chip3.Location = new System.Drawing.Point(328, 128);
            this.guna2Chip3.Name = "guna2Chip3";
            this.guna2Chip3.ShadowDecoration.Parent = this.guna2Chip3;
            this.guna2Chip3.Size = new System.Drawing.Size(269, 171);
            this.guna2Chip3.TabIndex = 15;
            this.guna2Chip3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Chip4
            // 
            this.guna2Chip4.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Chip4.BorderRadius = 15;
            this.guna2Chip4.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Chip4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Chip4.ForeColor = System.Drawing.Color.White;
            this.guna2Chip4.Location = new System.Drawing.Point(23, 128);
            this.guna2Chip4.Name = "guna2Chip4";
            this.guna2Chip4.ShadowDecoration.Parent = this.guna2Chip4;
            this.guna2Chip4.Size = new System.Drawing.Size(274, 171);
            this.guna2Chip4.TabIndex = 16;
            this.guna2Chip4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Chip5
            // 
            this.guna2Chip5.BorderRadius = 15;
            this.guna2Chip5.FillColor = System.Drawing.Color.White;
            this.guna2Chip5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Chip5.ForeColor = System.Drawing.Color.White;
            this.guna2Chip5.Location = new System.Drawing.Point(21, 12);
            this.guna2Chip5.Name = "guna2Chip5";
            this.guna2Chip5.ShadowDecoration.Parent = this.guna2Chip5;
            this.guna2Chip5.Size = new System.Drawing.Size(1141, 100);
            this.guna2Chip5.TabIndex = 17;
            this.guna2Chip5.Text = "guna2Chip5";
            this.guna2Chip5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Time_Lable
            // 
            this.Time_Lable.AutoSize = true;
            this.Time_Lable.BackColor = System.Drawing.Color.White;
            this.Time_Lable.Font = new System.Drawing.Font("Digital-7 Italic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Lable.ForeColor = System.Drawing.Color.Gray;
            this.Time_Lable.Location = new System.Drawing.Point(979, 21);
            this.Time_Lable.Name = "Time_Lable";
            this.Time_Lable.Size = new System.Drawing.Size(174, 80);
            this.Time_Lable.TabIndex = 19;
            this.Time_Lable.Text = "12:00";
            // 
            // Welcome_Lable
            // 
            this.Welcome_Lable.AutoSize = true;
            this.Welcome_Lable.BackColor = System.Drawing.Color.White;
            this.Welcome_Lable.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_Lable.Location = new System.Drawing.Point(43, 53);
            this.Welcome_Lable.Name = "Welcome_Lable";
            this.Welcome_Lable.Size = new System.Drawing.Size(334, 43);
            this.Welcome_Lable.TabIndex = 20;
            this.Welcome_Lable.Text = "Welcome back,Othman";
            // 
            // label_Morning_Evening
            // 
            this.label_Morning_Evening.AutoSize = true;
            this.label_Morning_Evening.BackColor = System.Drawing.Color.White;
            this.label_Morning_Evening.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Morning_Evening.ForeColor = System.Drawing.Color.Gray;
            this.label_Morning_Evening.Location = new System.Drawing.Point(45, 21);
            this.label_Morning_Evening.Name = "label_Morning_Evening";
            this.label_Morning_Evening.Size = new System.Drawing.Size(160, 33);
            this.label_Morning_Evening.TabIndex = 21;
            this.label_Morning_Evening.Text = "Good Morning";
            // 
            // guna2Chip6
            // 
            this.guna2Chip6.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Chip6.BorderRadius = 15;
            this.guna2Chip6.FillColor = System.Drawing.Color.BlueViolet;
            this.guna2Chip6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Chip6.ForeColor = System.Drawing.Color.White;
            this.guna2Chip6.Location = new System.Drawing.Point(907, 130);
            this.guna2Chip6.Name = "guna2Chip6";
            this.guna2Chip6.ShadowDecoration.Parent = this.guna2Chip6;
            this.guna2Chip6.Size = new System.Drawing.Size(254, 169);
            this.guna2Chip6.TabIndex = 23;
            this.guna2Chip6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // dataCard1
            // 
            this.dataCard1.BackColor = System.Drawing.Color.BlueViolet;
            this.dataCard1.IconCard = ((System.Drawing.Image)(resources.GetObject("dataCard1.IconCard")));
            this.dataCard1.Location = new System.Drawing.Point(922, 138);
            this.dataCard1.Name = "dataCard1";
            this.dataCard1.Number = "8";
            this.dataCard1.Size = new System.Drawing.Size(231, 152);
            this.dataCard1.TabIndex = 22;
            this.dataCard1.TitleCard = "Subscriptions";
            // 
            // dataCard_ActiveMembers
            // 
            this.dataCard_ActiveMembers.BackColor = System.Drawing.Color.LimeGreen;
            this.dataCard_ActiveMembers.IconCard = ((System.Drawing.Image)(resources.GetObject("dataCard_ActiveMembers.IconCard")));
            this.dataCard_ActiveMembers.Location = new System.Drawing.Point(334, 138);
            this.dataCard_ActiveMembers.Name = "dataCard_ActiveMembers";
            this.dataCard_ActiveMembers.Number = "8";
            this.dataCard_ActiveMembers.Size = new System.Drawing.Size(257, 152);
            this.dataCard_ActiveMembers.TabIndex = 9;
            this.dataCard_ActiveMembers.TitleCard = "Active Members";
            // 
            // dataCard_Members
            // 
            this.dataCard_Members.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataCard_Members.IconCard = ((System.Drawing.Image)(resources.GetObject("dataCard_Members.IconCard")));
            this.dataCard_Members.Location = new System.Drawing.Point(31, 138);
            this.dataCard_Members.Name = "dataCard_Members";
            this.dataCard_Members.Number = "11";
            this.dataCard_Members.Size = new System.Drawing.Size(262, 152);
            this.dataCard_Members.TabIndex = 8;
            this.dataCard_Members.TitleCard = "Members";
            // 
            // dataCard_InActiveMembers
            // 
            this.dataCard_InActiveMembers.BackColor = System.Drawing.Color.Gold;
            this.dataCard_InActiveMembers.IconCard = ((System.Drawing.Image)(resources.GetObject("dataCard_InActiveMembers.IconCard")));
            this.dataCard_InActiveMembers.Location = new System.Drawing.Point(629, 138);
            this.dataCard_InActiveMembers.Name = "dataCard_InActiveMembers";
            this.dataCard_InActiveMembers.Number = "8";
            this.dataCard_InActiveMembers.Size = new System.Drawing.Size(255, 152);
            this.dataCard_InActiveMembers.TabIndex = 10;
            this.dataCard_InActiveMembers.TitleCard = "InActive Members";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1173, 675);
            this.Controls.Add(this.dataCard1);
            this.Controls.Add(this.guna2Chip6);
            this.Controls.Add(this.label_Morning_Evening);
            this.Controls.Add(this.Welcome_Lable);
            this.Controls.Add(this.Time_Lable);
            this.Controls.Add(this.guna2Chip5);
            this.Controls.Add(this.dataCard_ActiveMembers);
            this.Controls.Add(this.dataCard_Members);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.guna2Chip1);
            this.Controls.Add(this.dataCard_InActiveMembers);
            this.Controls.Add(this.guna2Chip2);
            this.Controls.Add(this.guna2Chip3);
            this.Controls.Add(this.guna2Chip4);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataCard dataCard_Members;
        private dataCard dataCard_ActiveMembers;
        private dataCard dataCard_InActiveMembers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip2;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip3;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip4;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip5;
        private System.Windows.Forms.Label Time_Lable;
        private System.Windows.Forms.Label Welcome_Lable;
        private System.Windows.Forms.Label label_Morning_Evening;
        private dataCard dataCard1;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip6;
    }
}