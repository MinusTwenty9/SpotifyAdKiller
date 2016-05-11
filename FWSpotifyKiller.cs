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

        private static string[] ip_ranges = new string[] 
        {
           "74.125.136.99-74.125.136.147","194.132.173.241",
            "23.235.43.246","193.182.244.241", "68.232.34.151","217.12.15.54",
            "216.74.32.88","216.58.212.142","162.248.18.210",
            "23.235.43.133","2a00:1450:400e:800::200e","216.58.212.226",
            "2a00:1450:4013:c01::69", "198.47.127.21", "2a00:1450:4013:c01::5f",
            "74.125.136.95","2a00:1450:400e:800::2001", "216.58.212.129", "216.58.212.130",
            "64.30.224.206", "2a03:2880:f006:21:face:b00c:0:3", "31.13.64.21",
            "80.252.91.41", "80.252.91.24", "31.13.64.4", "173.192.220.64", "77.66.54.155", "46.228.164.13",
            "51.255.231.130", "54.93.77.193"
        };

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

            string ips = "";
            for (int i = 0; i < ip_ranges.Length; i++)
                ips += ip_ranges[i] + (i+1 == ip_ranges.Length ? "" : ",");

            INetFwRule rl = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            rl.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            rl.Description = "Blocks spotify ads (audio and visual)";
            rl.Enabled = false;
            rl.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            rl.Name = "SpotifyKiller";
            rl.RemoteAddresses = ips;
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
