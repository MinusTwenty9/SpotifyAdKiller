using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetFwTypeLib;

namespace SpotifyKiller
{
    public static class FWSpotifyKiller
    {
        private static Type net_fw_mgr_type = Type.GetTypeFromProgID("HNetCfg.FwMgr", false);
        private static INetFwMgr mgr;
        private static INetFwPolicy2 policy;

        public static void Initialize()
        {
            mgr = (INetFwMgr)Activator.CreateInstance(net_fw_mgr_type);
            policy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWPolicy2"));
        }

        public static bool Kill_Spotify()
        {
            if (!Is_Firewall_Enabled()) return false;
            if (!Spotify_Killer_Rule_Exists()) Add_Spotify_Killer();
            if (!Spotify_Killer_Rule_Exists()) return false;

            INetFwRule rl = policy.Rules.Item("SpotifyKiller");
            rl.Enabled = true;

            return true;
        }

        public static bool Revive_Spotify()
        {
            if (!Is_Firewall_Enabled()) return false;
            if (!Spotify_Killer_Rule_Exists()) Add_Spotify_Killer();
            if (!Spotify_Killer_Rule_Exists()) return false;

            INetFwRule rl = policy.Rules.Item("SpotifyKiller");
            rl.Enabled = false;

            return true;
        }

        public static void Add_Spotify_Killer()
        {
            if (!Is_Firewall_Enabled()) return;
            if (Spotify_Killer_Rule_Exists()) return;

            INetFwRule rl = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            rl.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            rl.Description = "Blocks spotify ads (audio and visual)";
            rl.Enabled = false;
            rl.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            rl.Name = "SpotifyKiller";
            rl.RemoteAddresses = "173.194.0.0-173.194.255.255,216.58.192.0-216.58.223.255,74.125.0.0-74.125.255.255,68.232.0.0-68.232.255.255";
            rl.ApplicationName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Spotify\Spotify.exe";

            policy.Rules.Add(rl);
        }

        public static void Remove_Spotify_Killer()
        {
            if (!Is_Firewall_Enabled()) return;
            if (!Spotify_Killer_Rule_Exists()) return;

            policy.Rules.Remove("SpotifyKiller");
        }

        public static void Enable_Firewall()
        {
            policy.set_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PUBLIC, true);
            policy.set_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PRIVATE, true);
            policy.set_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_DOMAIN, true);
        }

        public static void Disable_Firewall()
        {
            policy.set_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PUBLIC, false);
            policy.set_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PRIVATE, false);
            policy.set_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_DOMAIN, false);
        }

        public static bool Get_Spotify_Killer_State()
        {
            if (!Is_Firewall_Enabled()) return false;
            if (!Spotify_Killer_Rule_Exists()) return false;

            return policy.Rules.Item("SpotifyKiller").Enabled;
        }

        public static bool Spotify_Killer_Rule_Exists()
        {
            try
            {
                policy.Rules.Item("SpotifyKiller");
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public static bool Is_Firewall_Enabled()
        {
            return mgr.LocalPolicy.CurrentProfile.FirewallEnabled;
        }

    }
}
