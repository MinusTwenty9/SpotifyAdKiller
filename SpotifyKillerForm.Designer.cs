namespace SpotifyKiller
{
    partial class SpotifyKillerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpotifyKillerForm));
            this.button_add_remove_spotify_killer = new System.Windows.Forms.Button();
            this.label_spotify_killer = new System.Windows.Forms.Label();
            this.button_kill_revive_spotify = new System.Windows.Forms.Button();
            this.button_enable_disable_fw = new System.Windows.Forms.Button();
            this.panel_spotify_killer_added = new System.Windows.Forms.Panel();
            this.panel_firewall_enabled = new System.Windows.Forms.Panel();
            this.label_firewall_enabled = new System.Windows.Forms.Label();
            this.panel_spotify_killed = new System.Windows.Forms.Panel();
            this.label_spotify_killed = new System.Windows.Forms.Label();
            this.timer_spotify_killer_state = new System.Windows.Forms.Timer(this.components);
            this.panel_spotify_killer_added.SuspendLayout();
            this.panel_firewall_enabled.SuspendLayout();
            this.panel_spotify_killed.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_add_remove_spotify_killer
            // 
            this.button_add_remove_spotify_killer.Location = new System.Drawing.Point(12, 12);
            this.button_add_remove_spotify_killer.Name = "button_add_remove_spotify_killer";
            this.button_add_remove_spotify_killer.Size = new System.Drawing.Size(122, 23);
            this.button_add_remove_spotify_killer.TabIndex = 0;
            this.button_add_remove_spotify_killer.Text = "Add Spotify Killer";
            this.button_add_remove_spotify_killer.UseVisualStyleBackColor = true;
            this.button_add_remove_spotify_killer.Click += new System.EventHandler(this.button_add_remove_spotify_killer_Click);
            // 
            // label_spotify_killer
            // 
            this.label_spotify_killer.AutoSize = true;
            this.label_spotify_killer.Location = new System.Drawing.Point(7, 6);
            this.label_spotify_killer.Name = "label_spotify_killer";
            this.label_spotify_killer.Size = new System.Drawing.Size(98, 13);
            this.label_spotify_killer.TabIndex = 1;
            this.label_spotify_killer.Text = "Spotify Killer Added";
            // 
            // button_kill_revive_spotify
            // 
            this.button_kill_revive_spotify.Location = new System.Drawing.Point(12, 70);
            this.button_kill_revive_spotify.Name = "button_kill_revive_spotify";
            this.button_kill_revive_spotify.Size = new System.Drawing.Size(122, 23);
            this.button_kill_revive_spotify.TabIndex = 3;
            this.button_kill_revive_spotify.Text = "Kill Spotify";
            this.button_kill_revive_spotify.UseVisualStyleBackColor = true;
            this.button_kill_revive_spotify.Click += new System.EventHandler(this.button_kill_revive_spotify_Click);
            // 
            // button_enable_disable_fw
            // 
            this.button_enable_disable_fw.Location = new System.Drawing.Point(12, 41);
            this.button_enable_disable_fw.Name = "button_enable_disable_fw";
            this.button_enable_disable_fw.Size = new System.Drawing.Size(122, 23);
            this.button_enable_disable_fw.TabIndex = 4;
            this.button_enable_disable_fw.Text = "Enable Firewall";
            this.button_enable_disable_fw.UseVisualStyleBackColor = true;
            this.button_enable_disable_fw.Click += new System.EventHandler(this.button_enable_disable_fw_Click);
            // 
            // panel_spotify_killer_added
            // 
            this.panel_spotify_killer_added.BackColor = System.Drawing.Color.Red;
            this.panel_spotify_killer_added.Controls.Add(this.label_spotify_killer);
            this.panel_spotify_killer_added.Location = new System.Drawing.Point(150, 12);
            this.panel_spotify_killer_added.Name = "panel_spotify_killer_added";
            this.panel_spotify_killer_added.Size = new System.Drawing.Size(113, 23);
            this.panel_spotify_killer_added.TabIndex = 5;
            // 
            // panel_firewall_enabled
            // 
            this.panel_firewall_enabled.BackColor = System.Drawing.Color.Red;
            this.panel_firewall_enabled.Controls.Add(this.label_firewall_enabled);
            this.panel_firewall_enabled.Location = new System.Drawing.Point(150, 41);
            this.panel_firewall_enabled.Name = "panel_firewall_enabled";
            this.panel_firewall_enabled.Size = new System.Drawing.Size(113, 23);
            this.panel_firewall_enabled.TabIndex = 6;
            // 
            // label_firewall_enabled
            // 
            this.label_firewall_enabled.AutoSize = true;
            this.label_firewall_enabled.Location = new System.Drawing.Point(15, 5);
            this.label_firewall_enabled.Name = "label_firewall_enabled";
            this.label_firewall_enabled.Size = new System.Drawing.Size(84, 13);
            this.label_firewall_enabled.TabIndex = 1;
            this.label_firewall_enabled.Text = "Firewall Enabled";
            // 
            // panel_spotify_killed
            // 
            this.panel_spotify_killed.BackColor = System.Drawing.Color.Red;
            this.panel_spotify_killed.Controls.Add(this.label_spotify_killed);
            this.panel_spotify_killed.Location = new System.Drawing.Point(150, 70);
            this.panel_spotify_killed.Name = "panel_spotify_killed";
            this.panel_spotify_killed.Size = new System.Drawing.Size(113, 23);
            this.panel_spotify_killed.TabIndex = 7;
            // 
            // label_spotify_killed
            // 
            this.label_spotify_killed.AutoSize = true;
            this.label_spotify_killed.Location = new System.Drawing.Point(24, 5);
            this.label_spotify_killed.Name = "label_spotify_killed";
            this.label_spotify_killed.Size = new System.Drawing.Size(67, 13);
            this.label_spotify_killed.TabIndex = 1;
            this.label_spotify_killed.Text = "Spotify Killed";
            // 
            // timer_spotify_killer_state
            // 
            this.timer_spotify_killer_state.Enabled = true;
            this.timer_spotify_killer_state.Interval = 1000;
            this.timer_spotify_killer_state.Tick += new System.EventHandler(this.timer_spotify_killer_state_Tick);
            // 
            // SpotifyKillerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 105);
            this.Controls.Add(this.panel_spotify_killed);
            this.Controls.Add(this.panel_firewall_enabled);
            this.Controls.Add(this.panel_spotify_killer_added);
            this.Controls.Add(this.button_enable_disable_fw);
            this.Controls.Add(this.button_kill_revive_spotify);
            this.Controls.Add(this.button_add_remove_spotify_killer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpotifyKillerForm";
            this.Text = "Spotify Killer";
            this.panel_spotify_killer_added.ResumeLayout(false);
            this.panel_spotify_killer_added.PerformLayout();
            this.panel_firewall_enabled.ResumeLayout(false);
            this.panel_firewall_enabled.PerformLayout();
            this.panel_spotify_killed.ResumeLayout(false);
            this.panel_spotify_killed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add_remove_spotify_killer;
        private System.Windows.Forms.Label label_spotify_killer;
        private System.Windows.Forms.Button button_kill_revive_spotify;
        private System.Windows.Forms.Button button_enable_disable_fw;
        private System.Windows.Forms.Panel panel_spotify_killer_added;
        private System.Windows.Forms.Panel panel_firewall_enabled;
        private System.Windows.Forms.Label label_firewall_enabled;
        private System.Windows.Forms.Panel panel_spotify_killed;
        private System.Windows.Forms.Label label_spotify_killed;
        private System.Windows.Forms.Timer timer_spotify_killer_state;
    }
}

