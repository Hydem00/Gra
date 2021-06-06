
namespace Gra
{
    partial class Gra
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
            this.panelGra = new System.Windows.Forms.Panel();
            this.buttonRozpocznij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelGra
            // 
            this.panelGra.AutoSize = true;
            this.panelGra.Location = new System.Drawing.Point(38, 12);
            this.panelGra.Name = "panelGra";
            this.panelGra.Size = new System.Drawing.Size(222, 193);
            this.panelGra.TabIndex = 0;
            // 
            // buttonRozpocznij
            // 
            this.buttonRozpocznij.Location = new System.Drawing.Point(427, 224);
            this.buttonRozpocznij.Name = "buttonRozpocznij";
            this.buttonRozpocznij.Size = new System.Drawing.Size(75, 23);
            this.buttonRozpocznij.TabIndex = 1;
            this.buttonRozpocznij.Text = "Rozpocznij";
            this.buttonRozpocznij.UseVisualStyleBackColor = true;
            this.buttonRozpocznij.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(782, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Współrzędne";
            // 
            // Gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(922, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRozpocznij);
            this.Controls.Add(this.panelGra);
            this.Name = "Gra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGra;
        private System.Windows.Forms.Button buttonRozpocznij;
        private System.Windows.Forms.Label label1;
    }
}