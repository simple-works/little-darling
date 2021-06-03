namespace LittleDarling
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuItem_stop = new System.Windows.Forms.ToolStripMenuItem();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.label_message = new System.Windows.Forms.Label();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.audioPlayer_main = new LittleDarling.AudioPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.contextMenuStrip_main.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_icon.ContextMenuStrip = this.contextMenuStrip_main;
            this.pictureBox_icon.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox_icon.Image = global::LittleDarling.Properties.Resources.icon;
            this.pictureBox_icon.Location = new System.Drawing.Point(19, 18);
            this.pictureBox_icon.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_icon.TabIndex = 0;
            this.pictureBox_icon.TabStop = false;
            // 
            // contextMenuStrip_main
            // 
            this.contextMenuStrip_main.BackColor = System.Drawing.Color.Black;
            this.contextMenuStrip_main.Font = new System.Drawing.Font("Courier New", 20F);
            this.contextMenuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItem_about,
            this.toolStripSeparator1,
            this.contextMenuItem_stop});
            this.contextMenuStrip_main.Name = "contextMenuStrip_main";
            this.contextMenuStrip_main.ShowImageMargin = false;
            this.contextMenuStrip_main.Size = new System.Drawing.Size(142, 82);
            // 
            // contextMenuItem_about
            // 
            this.contextMenuItem_about.ForeColor = System.Drawing.Color.White;
            this.contextMenuItem_about.Name = "contextMenuItem_about";
            this.contextMenuItem_about.Size = new System.Drawing.Size(141, 36);
            this.contextMenuItem_about.Text = "About";
            this.contextMenuItem_about.Click += new System.EventHandler(this.contextMenuItem_about_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // contextMenuItem_stop
            // 
            this.contextMenuItem_stop.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.contextMenuItem_stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.contextMenuItem_stop.Name = "contextMenuItem_stop";
            this.contextMenuItem_stop.Size = new System.Drawing.Size(141, 36);
            this.contextMenuItem_stop.Text = "Stop";
            this.contextMenuItem_stop.Click += new System.EventHandler(this.contextMenuItem_stop_Click);
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.Black;
            this.button_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ok.Font = new System.Drawing.Font("Courier New", 40F);
            this.button_ok.Location = new System.Drawing.Point(258, 226);
            this.button_ok.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(293, 103);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Maroon;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_close.Font = new System.Drawing.Font("Courier New", 40F, System.Drawing.FontStyle.Bold);
            this.button_close.Location = new System.Drawing.Point(732, 18);
            this.button_close.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(64, 64);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Black;
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_main.Controls.Add(this.label_title);
            this.panel_main.Controls.Add(this.button_close);
            this.panel_main.Controls.Add(this.pictureBox_icon);
            this.panel_main.Location = new System.Drawing.Point(-5, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(815, 103);
            this.panel_main.TabIndex = 2;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Courier New", 40F);
            this.label_title.Location = new System.Drawing.Point(97, 21);
            this.label_title.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(473, 59);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Little Darling";
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Courier New", 20F);
            this.label_message.ForeColor = System.Drawing.Color.White;
            this.label_message.Location = new System.Drawing.Point(38, 152);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(733, 30);
            this.label_message.TabIndex = 3;
            this.label_message.Text = "Take good care of my beloved little darling !";
            // 
            // timer_main
            // 
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // audioPlayer_main
            // 
            this.audioPlayer_main.Position = System.TimeSpan.Parse("00:00:00");
            this.audioPlayer_main.Volume = 100;
            // 
            // Form_Main
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.button_close;
            this.ClientSize = new System.Drawing.Size(809, 373);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Courier New", 20F);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Little Darling";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.contextMenuStrip_main.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_icon;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Timer timer_main;
        private AudioPlayer audioPlayer_main;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_about;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_stop;
    }
}

