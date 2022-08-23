namespace Astronomiekatalog
{
    partial class FormKatalog
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxGalaxie = new System.Windows.Forms.ComboBox();
            this.comboBoxSternsystem = new System.Windows.Forms.ComboBox();
            this.listBoxGalaxie = new System.Windows.Forms.ListBox();
            this.listBoxSternsystem = new System.Windows.Forms.ListBox();
            this.comboBoxPlanet = new System.Windows.Forms.ComboBox();
            this.listBoxPlanet = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonWechselDich = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxGalaxie
            // 
            this.comboBoxGalaxie.FormattingEnabled = true;
            this.comboBoxGalaxie.Location = new System.Drawing.Point(30, 43);
            this.comboBoxGalaxie.Name = "comboBoxGalaxie";
            this.comboBoxGalaxie.Size = new System.Drawing.Size(129, 21);
            this.comboBoxGalaxie.TabIndex = 0;
            this.comboBoxGalaxie.SelectedIndexChanged += new System.EventHandler(this.listBoxGalaxie_SelectedIndexChanged);
            // 
            // comboBoxSternsystem
            // 
            this.comboBoxSternsystem.FormattingEnabled = true;
            this.comboBoxSternsystem.Location = new System.Drawing.Point(457, 43);
            this.comboBoxSternsystem.Name = "comboBoxSternsystem";
            this.comboBoxSternsystem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSternsystem.TabIndex = 1;
            // 
            // listBoxGalaxie
            // 
            this.listBoxGalaxie.FormattingEnabled = true;
            this.listBoxGalaxie.Location = new System.Drawing.Point(165, 43);
            this.listBoxGalaxie.Name = "listBoxGalaxie";
            this.listBoxGalaxie.Size = new System.Drawing.Size(286, 342);
            this.listBoxGalaxie.TabIndex = 2;
            this.listBoxGalaxie.SelectedIndexChanged += new System.EventHandler(this.listBoxGalaxie_SelectedIndexChanged);
            // 
            // listBoxSternsystem
            // 
            this.listBoxSternsystem.FormattingEnabled = true;
            this.listBoxSternsystem.Location = new System.Drawing.Point(585, 43);
            this.listBoxSternsystem.Name = "listBoxSternsystem";
            this.listBoxSternsystem.Size = new System.Drawing.Size(329, 342);
            this.listBoxSternsystem.TabIndex = 3;
            // 
            // comboBoxPlanet
            // 
            this.comboBoxPlanet.FormattingEnabled = true;
            this.comboBoxPlanet.Location = new System.Drawing.Point(921, 43);
            this.comboBoxPlanet.Name = "comboBoxPlanet";
            this.comboBoxPlanet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlanet.TabIndex = 4;
            // 
            // listBoxPlanet
            // 
            this.listBoxPlanet.FormattingEnabled = true;
            this.listBoxPlanet.Location = new System.Drawing.Point(1049, 43);
            this.listBoxPlanet.Name = "listBoxPlanet";
            this.listBoxPlanet.Size = new System.Drawing.Size(275, 342);
            this.listBoxPlanet.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Auswahl Galaxien:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Auswahl Sternsysteme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(918, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Auswahl Planeten:";
            // 
            // buttonWechselDich
            // 
            this.buttonWechselDich.Location = new System.Drawing.Point(30, 325);
            this.buttonWechselDich.Name = "buttonWechselDich";
            this.buttonWechselDich.Size = new System.Drawing.Size(129, 51);
            this.buttonWechselDich.TabIndex = 9;
            this.buttonWechselDich.Text = "Wechsel zur Grafischen Ansicht";
            this.buttonWechselDich.UseVisualStyleBackColor = true;
            this.buttonWechselDich.Click += new System.EventHandler(this.buttonWechselDich_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Information über ausgewählte Galaxie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Information über ausgewähltes Sternsystem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1049, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Information über ausgewählten Planeten:";
            // 
            // FormKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 388);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonWechselDich);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPlanet);
            this.Controls.Add(this.comboBoxPlanet);
            this.Controls.Add(this.listBoxSternsystem);
            this.Controls.Add(this.listBoxGalaxie);
            this.Controls.Add(this.comboBoxSternsystem);
            this.Controls.Add(this.comboBoxGalaxie);
            this.Name = "FormKatalog";
            this.Text = "Astronomiekatalog - Katalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGalaxie;
        private System.Windows.Forms.ComboBox comboBoxSternsystem;
        private System.Windows.Forms.ListBox listBoxGalaxie;
        private System.Windows.Forms.ListBox listBoxSternsystem;
        private System.Windows.Forms.ComboBox comboBoxPlanet;
        private System.Windows.Forms.ListBox listBoxPlanet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonWechselDich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

