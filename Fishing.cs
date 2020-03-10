using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Memory;

namespace Foosh
{

    public static class Fishing
    {
        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        const uint WM_KEYDOWN = 0x0100;
        const uint WM_KEYUP = 0x0101;

        public static Mem mem = new Mem();
        public static System.Threading.Timer scan;
        public static int fishStatus = 0;
        public static bool statusChanged = false;
        public static bool isFishing = false;
        public static bool catchSmall = false;
        public static bool catchMedium = false;
        public static bool catchLarge = false;
        public static bool isRelease = false;
        public static bool isReleaseSet = false;
        public static bool isChum = false;
        public static int CastKey, HookKey, ReleaseKey,ChumKey = 0;
        public static int minDelay, maxDelay = 0;
        public static string playerSig = Properties.Settings.Default.playerObjectSig;
        public static int playerStartOffset = Properties.Settings.Default.playerStartOffset;
        public static int currentGPOffset = Properties.Settings.Default.currentGPOffset;
        public static long currentGPAddress = 0L;
        public static int currentGP = -1;

        public static int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(minDelay, maxDelay);
        }

        public static bool SendKey(string window, int key, int delay = 100)
        {
            try
            {
                PostMessage(FindWindow(null, "FINAL FANTASY XIV"), WM_KEYDOWN, key, 0);
                System.Threading.Thread.Sleep(delay);
                PostMessage(FindWindow(null, "FINAL FANTASY XIV"), WM_KEYUP, key, 0);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Attach()
        {
            bool code = mem.OpenProcess("ffxiv_dx11.exe");
            currentGPAddress = mem.AoBScan(playerSig,true,true,"").Result.FirstOrDefault();
            currentGPAddress += playerStartOffset + currentGPOffset;
            while (currentGPAddress == 0) { }
            scan = new System.Threading.Timer(new TimerCallback(TickTimer), null, 100, 100);
            return code;
        }

        static void TickTimer(object state)
        { 
            Scan();
            Thread.Sleep(100);
        }


        public static void Scan()
        {
            int newStatus = mem.ReadInt(Properties.Settings.Default.enumPath, "");
            if(newStatus!=fishStatus) { statusChanged = true; }
            currentGP = mem.Read2Byte(currentGPAddress.ToString("X"), "");
            fishStatus = mem.ReadInt(Properties.Settings.Default.enumPath, "");
            if(isFishing)
            {
                switch(Status.GetFishingStatus(fishStatus))
                {
                    case FishingStatus.FISHING_CHUM_NOT_CAST:
                        SendKey(Properties.Settings.Default.windowName, CastKey);
                        break;
                    case FishingStatus.FISHING_NOT_CAST:
                        if (isChum && currentGP >= Properties.Settings.Default.chumGPCost)
                        {
                            SendKey(Properties.Settings.Default.windowName, ChumKey);
                        }
                        if (isRelease)
                        {
                            System.Threading.Thread.Sleep(500);
                            SendKey(Properties.Settings.Default.windowName, ReleaseKey);
                        }
                        System.Threading.Thread.Sleep(250);
                        SendKey(Properties.Settings.Default.windowName, CastKey);
                        break;
                    case FishingStatus.FISHING_BITE_SM:
                        if (statusChanged && catchSmall)
                        {
                            System.Threading.Thread.Sleep(GetRandomNumber());
                            SendKey(Properties.Settings.Default.windowName, HookKey);
                        }
                        break;
                    case FishingStatus.FISHING_BITE_MD:
                        if (statusChanged && catchMedium)
                        {
                            System.Threading.Thread.Sleep(GetRandomNumber());
                            SendKey(Properties.Settings.Default.windowName, HookKey);
                        }
                        break;
                    case FishingStatus.FISHING_BITE_LG:
                        if (statusChanged && catchLarge)
                        {
                            System.Threading.Thread.Sleep(GetRandomNumber());
                            SendKey(Properties.Settings.Default.windowName, HookKey);
                        }
                        break;
                    default:
                        break;
                }
                statusChanged = false;
            }
        }
        public static int GetGP()
        {
            return currentGP;
        }
    }


}
