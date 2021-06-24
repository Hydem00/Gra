
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
            this.components = new System.ComponentModel.Container();
            this.panelGra = new System.Windows.Forms.Panel();
            this.buttonRozpocznij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDalej = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Usun = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            this.buttonRozpocznij.Location = new System.Drawing.Point(587, 193);
            this.buttonRozpocznij.Name = "buttonRozpocznij";
            this.buttonRozpocznij.Size = new System.Drawing.Size(75, 23);
            this.buttonRozpocznij.TabIndex = 1;
            this.buttonRozpocznij.Text = "Rozpocznij";
            this.buttonRozpocznij.UseVisualStyleBackColor = true;
            this.buttonRozpocznij.Click += new System.EventHandler(this.buttonRozpocznij_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(782, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Współrzędne";
            // 
            // buttonDalej
            // 
            this.buttonDalej.Location = new System.Drawing.Point(587, 193);
            this.buttonDalej.Name = "buttonDalej";
            this.buttonDalej.Size = new System.Drawing.Size(75, 23);
            this.buttonDalej.TabIndex = 3;
            this.buttonDalej.Text = "Dalej";
            this.buttonDalej.UseVisualStyleBackColor = true;
            this.buttonDalej.Click += new System.EventHandler(this.buttonDalej_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(683, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 290);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(711, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tablica Rekordów";
            // 
            // Usun
            // 
            this.Usun.Location = new System.Drawing.Point(760, 399);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(75, 23);
            this.Usun.TabIndex = 7;
            this.Usun.Text = "Usuń";
            this.Usun.UseVisualStyleBackColor = true;
            this.Usun.Click += new System.EventHandler(this.Usun_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(922, 506);
            this.Controls.Add(this.Usun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonDalej);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRozpocznij);
            this.Controls.Add(this.panelGra);
            this.Name = "Gra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gra";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gra_FormClosed);
            //this.Load += new System.EventHandler(this.Gra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGra;
        private System.Windows.Forms.Button buttonRozpocznij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDalej;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Usun;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}