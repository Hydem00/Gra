
namespace Gra
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Menu = new System.Windows.Forms.Panel();
            this.panelStopka = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OpcjePanel = new System.Windows.Forms.Panel();
            this.InstrukcjaButton = new System.Windows.Forms.Button();
            this.GrafikaButton = new System.Windows.Forms.Button();
            this.DzwiekButton = new System.Windows.Forms.Button();
            this.OpcjeButton = new System.Windows.Forms.Button();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.RadioTrudny = new System.Windows.Forms.RadioButton();
            this.RadioSredni = new System.Windows.Forms.RadioButton();
            this.RadioLatwy = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WielkoscPlanszy = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ZatwierdzButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.panelNaglowek = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.Menu.SuspendLayout();
            this.OpcjePanel.SuspendLayout();
            this.StartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WielkoscPlanszy)).BeginInit();
            this.panelNaglowek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.InfoText;
            this.Menu.Controls.Add(this.panelStopka);
            this.Menu.Controls.Add(this.ExitButton);
            this.Menu.Controls.Add(this.OpcjePanel);
            this.Menu.Controls.Add(this.OpcjeButton);
            this.Menu.Controls.Add(this.StartPanel);
            this.Menu.Controls.Add(this.StartButton);
            this.Menu.Controls.Add(this.panelNaglowek);
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.Name = "Menu";
            // 
            // panelStopka
            // 
            resources.ApplyResources(this.panelStopka, "panelStopka");
            this.panelStopka.Name = "panelStopka";
            // 
            // ExitButton
            // 
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OpcjePanel
            // 
            this.OpcjePanel.BackColor = System.Drawing.Color.Gray;
            this.OpcjePanel.Controls.Add(this.InstrukcjaButton);
            this.OpcjePanel.Controls.Add(this.GrafikaButton);
            this.OpcjePanel.Controls.Add(this.DzwiekButton);
            resources.ApplyResources(this.OpcjePanel, "OpcjePanel");
            this.OpcjePanel.Name = "OpcjePanel";
            // 
            // InstrukcjaButton
            // 
            resources.ApplyResources(this.InstrukcjaButton, "InstrukcjaButton");
            this.InstrukcjaButton.Name = "InstrukcjaButton";
            this.InstrukcjaButton.UseVisualStyleBackColor = true;
            this.InstrukcjaButton.Click += new System.EventHandler(this.InstrukcjaButton_Click);
            // 
            // GrafikaButton
            // 
            resources.ApplyResources(this.GrafikaButton, "GrafikaButton");
            this.GrafikaButton.Name = "GrafikaButton";
            this.GrafikaButton.UseVisualStyleBackColor = true;
            this.GrafikaButton.Click += new System.EventHandler(this.GrafikaButton_Click);
            // 
            // DzwiekButton
            // 
            resources.ApplyResources(this.DzwiekButton, "DzwiekButton");
            this.DzwiekButton.Name = "DzwiekButton";
            this.DzwiekButton.UseVisualStyleBackColor = true;
            this.DzwiekButton.Click += new System.EventHandler(this.DzwiekButton_Click);
            // 
            // OpcjeButton
            // 
            resources.ApplyResources(this.OpcjeButton, "OpcjeButton");
            this.OpcjeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpcjeButton.Name = "OpcjeButton";
            this.OpcjeButton.UseVisualStyleBackColor = true;
            this.OpcjeButton.Click += new System.EventHandler(this.OpcjeButton_Click);
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.Color.Gray;
            this.StartPanel.Controls.Add(this.RadioTrudny);
            this.StartPanel.Controls.Add(this.RadioSredni);
            this.StartPanel.Controls.Add(this.RadioLatwy);
            this.StartPanel.Controls.Add(this.textBox1);
            this.StartPanel.Controls.Add(this.label3);
            this.StartPanel.Controls.Add(this.label2);
            this.StartPanel.Controls.Add(this.WielkoscPlanszy);
            this.StartPanel.Controls.Add(this.label1);
            this.StartPanel.Controls.Add(this.ZatwierdzButton);
            resources.ApplyResources(this.StartPanel, "StartPanel");
            this.StartPanel.Name = "StartPanel";
            // 
            // RadioTrudny
            // 
            resources.ApplyResources(this.RadioTrudny, "RadioTrudny");
            this.RadioTrudny.Name = "RadioTrudny";
            this.RadioTrudny.TabStop = true;
            this.RadioTrudny.UseVisualStyleBackColor = true;
            this.RadioTrudny.CheckedChanged += new System.EventHandler(this.RadioTrudny_CheckedChanged);
            // 
            // RadioSredni
            // 
            resources.ApplyResources(this.RadioSredni, "RadioSredni");
            this.RadioSredni.Name = "RadioSredni";
            this.RadioSredni.TabStop = true;
            this.RadioSredni.UseVisualStyleBackColor = true;
            this.RadioSredni.CheckedChanged += new System.EventHandler(this.RadioSredni_CheckedChanged);
            // 
            // RadioLatwy
            // 
            resources.ApplyResources(this.RadioLatwy, "RadioLatwy");
            this.RadioLatwy.Name = "RadioLatwy";
            this.RadioLatwy.TabStop = true;
            this.RadioLatwy.UseVisualStyleBackColor = true;
            this.RadioLatwy.CheckedChanged += new System.EventHandler(this.RadioLatwy_CheckedChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.UseMnemonic = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.UseMnemonic = false;
            // 
            // WielkoscPlanszy
            // 
            resources.ApplyResources(this.WielkoscPlanszy, "WielkoscPlanszy");
            this.WielkoscPlanszy.Name = "WielkoscPlanszy";
            this.WielkoscPlanszy.ValueChanged += new System.EventHandler(this.WielkoscPlanszy_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ZatwierdzButton
            // 
            resources.ApplyResources(this.ZatwierdzButton, "ZatwierdzButton");
            this.ZatwierdzButton.Name = "ZatwierdzButton";
            this.ZatwierdzButton.UseVisualStyleBackColor = true;
            this.ZatwierdzButton.Click += new System.EventHandler(this.ZatwierdzButton_Click);
            // 
            // StartButton
            // 
            resources.ApplyResources(this.StartButton, "StartButton");
            this.StartButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartButton.Name = "StartButton";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // panelNaglowek
            // 
            this.panelNaglowek.BackColor = System.Drawing.SystemColors.InfoText;
            this.panelNaglowek.Controls.Add(this.axWindowsMediaPlayer1);
            resources.ApplyResources(this.panelNaglowek, "panelNaglowek");
            this.panelNaglowek.Name = "panelNaglowek";
            // 
            // axWindowsMediaPlayer1
            // 
            resources.ApplyResources(this.axWindowsMediaPlayer1, "axWindowsMediaPlayer1");
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Menu);
            this.Name = "Form1";
            this.Menu.ResumeLayout(false);
            this.OpcjePanel.ResumeLayout(false);
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WielkoscPlanszy)).EndInit();
            this.panelNaglowek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

#pragma warning disable CS0108 // Składowa ukrywa dziedziczoną składową; brak słowa kluczowego new
        private System.Windows.Forms.Panel Menu;
#pragma warning restore CS0108 // Składowa ukrywa dziedziczoną składową; brak słowa kluczowego new
        private System.Windows.Forms.Panel panelNaglowek;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ZatwierdzButton;
        private System.Windows.Forms.NumericUpDown WielkoscPlanszy;
        private System.Windows.Forms.Button OpcjeButton;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Panel OpcjePanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button InstrukcjaButton;
        private System.Windows.Forms.Button GrafikaButton;
        private System.Windows.Forms.Button DzwiekButton;
        private System.Windows.Forms.Panel panelStopka;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton RadioTrudny;
        private System.Windows.Forms.RadioButton RadioSredni;
        private System.Windows.Forms.RadioButton RadioLatwy;
    }
}

