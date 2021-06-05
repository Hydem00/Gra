
namespace Gra
{
    partial class Dzwiek
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
            this.DzwiekPanel = new System.Windows.Forms.Panel();
            this.ZmianaDzwiekPanel = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.DzwiekPanel.SuspendLayout();
            this.ZmianaDzwiekPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // DzwiekPanel
            // 
            this.DzwiekPanel.BackColor = System.Drawing.SystemColors.MenuText;
            this.DzwiekPanel.Controls.Add(this.ZmianaDzwiekPanel);
            this.DzwiekPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DzwiekPanel.Location = new System.Drawing.Point(0, 0);
            this.DzwiekPanel.Name = "DzwiekPanel";
            this.DzwiekPanel.Size = new System.Drawing.Size(922, 506);
            this.DzwiekPanel.TabIndex = 0;
            // 
            // ZmianaDzwiekPanel
            // 
            this.ZmianaDzwiekPanel.Controls.Add(this.trackBar1);
            this.ZmianaDzwiekPanel.Location = new System.Drawing.Point(322, 68);
            this.ZmianaDzwiekPanel.Name = "ZmianaDzwiekPanel";
            this.ZmianaDzwiekPanel.Size = new System.Drawing.Size(290, 366);
            this.ZmianaDzwiekPanel.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(91, 147);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Dzwiek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 506);
            this.Controls.Add(this.DzwiekPanel);
            this.Name = "Dzwiek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dzwiek";
            this.DzwiekPanel.ResumeLayout(false);
            this.ZmianaDzwiekPanel.ResumeLayout(false);
            this.ZmianaDzwiekPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DzwiekPanel;
        private System.Windows.Forms.Panel ZmianaDzwiekPanel;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}