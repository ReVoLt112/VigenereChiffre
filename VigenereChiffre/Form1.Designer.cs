namespace VigenereChiffre
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allesMarkierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einfügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausschneidenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbChiffre = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.toolStripMenuItem1,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "&Datei";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.öffnenToolStripMenuItem.Text = "Ö&ffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Enabled = false;
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.speichernToolStripMenuItem.Text = "&Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allesMarkierenToolStripMenuItem,
            this.kopierenToolStripMenuItem,
            this.einfügenToolStripMenuItem,
            this.ausschneidenToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "&Bearbeiten";
            // 
            // allesMarkierenToolStripMenuItem
            // 
            this.allesMarkierenToolStripMenuItem.Name = "allesMarkierenToolStripMenuItem";
            this.allesMarkierenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.allesMarkierenToolStripMenuItem.Text = "&Alles markieren";
            this.allesMarkierenToolStripMenuItem.Click += new System.EventHandler(this.allesMarkierenToolStripMenuItem_Click);
            // 
            // kopierenToolStripMenuItem
            // 
            this.kopierenToolStripMenuItem.Name = "kopierenToolStripMenuItem";
            this.kopierenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.kopierenToolStripMenuItem.Text = "&Kopieren";
            this.kopierenToolStripMenuItem.Click += new System.EventHandler(this.kopierenToolStripMenuItem_Click);
            // 
            // einfügenToolStripMenuItem
            // 
            this.einfügenToolStripMenuItem.Name = "einfügenToolStripMenuItem";
            this.einfügenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.einfügenToolStripMenuItem.Text = "&Einfügen";
            this.einfügenToolStripMenuItem.Click += new System.EventHandler(this.einfügenToolStripMenuItem_Click);
            // 
            // ausschneidenToolStripMenuItem
            // 
            this.ausschneidenToolStripMenuItem.Name = "ausschneidenToolStripMenuItem";
            this.ausschneidenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ausschneidenToolStripMenuItem.Text = "A&usschneiden";
            this.ausschneidenToolStripMenuItem.Click += new System.EventHandler(this.ausschneidenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "&Hilfe";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "&Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Controls.Add(this.rbDecrypt);
            this.groupBox1.Controls.Add(this.rbEncrypt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbKey);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Einstellungen";
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(421, 71);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Encrypt";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(411, 35);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(89, 17);
            this.rbDecrypt.TabIndex = 3;
            this.rbDecrypt.Text = "entschlüsseln";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            this.rbDecrypt.CheckedChanged += new System.EventHandler(this.rbDecrypt_CheckedChanged);
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.Checked = true;
            this.rbEncrypt.Location = new System.Drawing.Point(411, 17);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(89, 17);
            this.rbEncrypt.TabIndex = 2;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "verschlüsseln";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schlüssel (min. 3 Zeichen):";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(5, 35);
            this.tbKey.Name = "tbKey";
            this.tbKey.PasswordChar = '*';
            this.tbKey.Size = new System.Drawing.Size(159, 20);
            this.tbKey.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbChiffre);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 202);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text / Geheimtext";
            // 
            // tbChiffre
            // 
            this.tbChiffre.AcceptsReturn = true;
            this.tbChiffre.AcceptsTab = true;
            this.tbChiffre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChiffre.Location = new System.Drawing.Point(3, 16);
            this.tbChiffre.MaxLength = 0;
            this.tbChiffre.Multiline = true;
            this.tbChiffre.Name = "tbChiffre";
            this.tbChiffre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbChiffre.Size = new System.Drawing.Size(496, 183);
            this.tbChiffre.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripProgressBar2});
            this.statusStrip1.Location = new System.Drawing.Point(3, 326);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(502, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel3.Text = "Fortschritt:";
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(100, 16);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "VigenereChiffre-Dateien|*.VIC";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "VigenereChiffre-Dateien|*.VIC";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "VigenereChiffre";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.RadioButton rbDecrypt;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.TextBox tbChiffre;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ToolStripMenuItem allesMarkierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einfügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausschneidenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

