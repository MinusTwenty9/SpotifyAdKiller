using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpotifyKiller
{
    public partial class SpotifyKillerForm : Form
    {
        public SpotifyKillerForm()
        {
            InitializeComponent();
            FWSpotifyKiller.Initialize();
            update_spotify_killer_states();
        }

        private void button_kill_revive_spotify_Click(object sender, EventArgs e)
        {
            if (FWSpotifyKiller.Get_Spotify_Killer_State()) FWSpotifyKiller.Revive_Spotify();
            else FWSpotifyKiller.Kill_Spotify();

            update_spotify_killer_states();
        }

        private void button_enable_disable_fw_Click(object sender, EventArgs e)
        {
            if (FWSpotifyKiller.Is_Firewall_Enabled()) FWSpotifyKiller.Disable_Firewall();
            else FWSpotifyKiller.Enable_Firewall();

            update_spotify_killer_states();
        }

        private void button_add_remove_spotify_killer_Click(object sender, EventArgs e)
        {
            if (FWSpotifyKiller.Spotify_Killer_Rule_Exists()) FWSpotifyKiller.Remove_Spotify_Killer();
            else FWSpotifyKiller.Add_Spotify_Killer();

            update_spotify_killer_states();
        }

        private void update_spotify_killer_states()
        {
            bool spotify_killer_added = FWSpotifyKiller.Spotify_Killer_Rule_Exists();
            bool fw_enabled = FWSpotifyKiller.Is_Firewall_Enabled();
            bool spotify_killed = FWSpotifyKiller.Get_Spotify_Killer_State();

            Color color_true = Color.Green;
            Color color_false = Color.Red;

            panel_spotify_killer_added.BackColor = (spotify_killer_added ? color_true : color_false);
            panel_firewall_enabled.BackColor = (fw_enabled ? color_true : color_false);
            panel_spotify_killed.BackColor = (spotify_killed ? color_true : color_false);

            button_add_remove_spotify_killer.Text = (spotify_killer_added ? "Remove Spotify Killer" : "Add Spotify Killer");
            button_enable_disable_fw.Text = (fw_enabled ? "Disable Firewall" : "Enable Firewall");
            button_kill_revive_spotify.Text = (spotify_killed ? "Revive Spotify" : "Kill Spotify");
        }

        private void timer_spotify_killer_state_Tick(object sender, EventArgs e)
        {
            update_spotify_killer_states();
        }

    }
}
