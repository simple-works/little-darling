namespace LittleDarling
{
    partial class Form_About
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_nameVersion = new System.Windows.Forms.Label();
            this.label_copyright = new System.Windows.Forms.Label();
            this.linkLabel_email = new System.Windows.Forms.LinkLabel();
            this.linkLabel_website = new System.Windows.Forms.LinkLabel();
            this.textBox_thirdPartyLicenses = new System.Windows.Forms.TextBox();
            this.button_close = new System.Windows.Forms.Button();
            this.label_forThirdPartyLicenses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_nameVersion
            // 
            this.label_nameVersion.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.label_nameVersion.ForeColor = System.Drawing.Color.Gray;
            this.label_nameVersion.Location = new System.Drawing.Point(36, 34);
            this.label_nameVersion.Name = "label_nameVersion";
            this.label_nameVersion.Size = new System.Drawing.Size(648, 30);
            this.label_nameVersion.TabIndex = 3;
            this.label_nameVersion.Text = "{ NameVersion }";
            // 
            // label_copyright
            // 
            this.label_copyright.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.label_copyright.ForeColor = System.Drawing.Color.Gray;
            this.label_copyright.Location = new System.Drawing.Point(36, 68);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(648, 30);
            this.label_copyright.TabIndex = 4;
            this.label_copyright.Text = "{ Copyright }";
            // 
            // linkLabel_email
            // 
            this.linkLabel_email.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.linkLabel_email.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel_email.Location = new System.Drawing.Point(36, 102);
            this.linkLabel_email.Name = "linkLabel_email";
            this.linkLabel_email.Size = new System.Drawing.Size(648, 30);
            this.linkLabel_email.TabIndex = 5;
            this.linkLabel_email.TabStop = true;
            this.linkLabel_email.Text = "{ Email }";
            this.linkLabel_email.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_email_LinkClicked);
            // 
            // linkLabel_website
            // 
            this.linkLabel_website.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.linkLabel_website.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel_website.Location = new System.Drawing.Point(36, 136);
            this.linkLabel_website.Name = "linkLabel_website";
            this.linkLabel_website.Size = new System.Drawing.Size(648, 30);
            this.linkLabel_website.TabIndex = 6;
            this.linkLabel_website.TabStop = true;
            this.linkLabel_website.Text = "{ Website }";
            this.linkLabel_website.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_website_LinkClicked);
            // 
            // textBox_thirdPartyLicenses
            // 
            this.textBox_thirdPartyLicenses.BackColor = System.Drawing.Color.Black;
            this.textBox_thirdPartyLicenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_thirdPartyLicenses.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_thirdPartyLicenses.ForeColor = System.Drawing.Color.Gray;
            this.textBox_thirdPartyLicenses.Location = new System.Drawing.Point(36, 225);
            this.textBox_thirdPartyLicenses.Multiline = true;
            this.textBox_thirdPartyLicenses.Name = "textBox_thirdPartyLicenses";
            this.textBox_thirdPartyLicenses.ReadOnly = true;
            this.textBox_thirdPartyLicenses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_thirdPartyLicenses.Size = new System.Drawing.Size(648, 114);
            this.textBox_thirdPartyLicenses.TabIndex = 7;
            this.textBox_thirdPartyLicenses.Text = "{ ThirdPartyLicenses }";
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Courier New", 40F, System.Drawing.FontStyle.Bold);
            this.button_close.Location = new System.Drawing.Point(661, 15);
            this.button_close.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(64, 64);
            this.button_close.TabIndex = 8;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_forThirdPartyLicenses
            // 
            this.label_forThirdPartyLicenses.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.label_forThirdPartyLicenses.ForeColor = System.Drawing.Color.Gray;
            this.label_forThirdPartyLicenses.Location = new System.Drawing.Point(36, 192);
            this.label_forThirdPartyLicenses.Name = "label_forThirdPartyLicenses";
            this.label_forThirdPartyLicenses.Size = new System.Drawing.Size(648, 30);
            this.label_forThirdPartyLicenses.TabIndex = 4;
            this.label_forThirdPartyLicenses.Text = "Third Party Licenses:";
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(741, 373);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.textBox_thirdPartyLicenses);
            this.Controls.Add(this.linkLabel_website);
            this.Controls.Add(this.linkLabel_email);
            this.Controls.Add(this.label_forThirdPartyLicenses);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.label_nameVersion);
            this.Font = new System.Drawing.Font("Courier New", 20F);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_About";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Little Darling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nameVersion;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.LinkLabel linkLabel_email;
        private System.Windows.Forms.LinkLabel linkLabel_website;
        private System.Windows.Forms.TextBox textBox_thirdPartyLicenses;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_forThirdPartyLicenses;
    }
}

