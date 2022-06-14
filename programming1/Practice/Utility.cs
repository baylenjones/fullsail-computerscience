using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;


namespace FSPG
{
    public static class Utility
    {
        [DllImport("user32.dll")]
        private static extern bool LockWindowUpdate(IntPtr hWndLock);
        [DllImport("user32.dll")]
        private static extern ushort GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(int nIndex);        
        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, uint wFlags);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        // class fields
        private static Random mPRNG = new Random();
        private static bool mGoodRead = true;

        public static void SetupWindow(string title, int width, int height, bool center = true)
        {
            Console.Title = title;

            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);

            if (center)
            {
                RECT rect;
                if (!GetWindowRect(new HandleRef(
                    Process.GetCurrentProcess().GetLifetimeService(),
                    Process.GetCurrentProcess().MainWindowHandle), out rect))
                    return;

                const int SM_CXSCREEN = 0;
                const int SM_CYSCREEN = 1;
                const int SWP_NOSIZE  = 1;
                int sw = GetSystemMetrics(SM_CXSCREEN);
                int sh = GetSystemMetrics(SM_CYSCREEN);
                int ww = rect.Right - rect.Left;
                int wh = rect.Bottom - rect.Top;
                int x = sw / 2 - ww / 2;
                int y = sh / 2 - wh / 2;
                SetWindowPos(Process.GetCurrentProcess().MainWindowHandle,
                    0, x, y, 0, 0, SWP_NOSIZE);
            }
        }

        public static void WriteCentered(string msg, int rowOffset = 0)
        {
            int colOffset = (Console.WindowWidth / 2) - (msg.Length / 2);
            rowOffset = (Console.WindowHeight / 2) + rowOffset;

            if (colOffset < 0)
                colOffset = 0;
            else if (colOffset >= Console.WindowWidth)
                colOffset = Console.WindowWidth - 1;

            if (rowOffset < 0)
                rowOffset = 0;
            else if (rowOffset >= Console.WindowHeight)
                rowOffset = Console.WindowHeight - 1;

            Console.SetCursorPosition(colOffset, rowOffset);
            Console.Write(msg); 
        }

        public static bool GetKeyState(ConsoleKey key)
        {
            return (GetAsyncKeyState((int)key) != 0);
        }

        public static bool GetKeyOnce(ConsoleKey key)
        {
            return (((GetAsyncKeyState((int)key) & 0x01)) > 0);
        }

        public static void WaitForEnterKey(bool msg = true)
        {
            if (msg)
            {
                WriteCentered("Press Enter to Continue", Console.WindowHeight / 2);
            }

            //while (!GetKeyState(ConsoleKey.Enter))
            //{
            //    Thread.Sleep(1);
            //}

            ConsoleKeyInfo key = new ConsoleKeyInfo('Z', ConsoleKey.Z, false, false, false);

            while (key.Key != ConsoleKey.Enter)
            {
                while (!Console.KeyAvailable)
                {
                    Thread.Sleep(1);
                }

                key = Console.ReadKey();
            }
        }

        // Locks/unlocks the memory used by Console to display output.
        // Helps reduce screen flicker when:
        // lock applied before Clear(), and unlock applied after Write(s)
        public static void LockConsole(bool applyLock)
        {
            if (applyLock)
            {
                LockWindowUpdate(Process.GetCurrentProcess().MainWindowHandle);
            }
            else
            {
                LockWindowUpdate(IntPtr.Zero);
            }
        }

        // A Unix timestamp.
        // Returns the number of seconds since The Epoch (January 1 1970).
        public static int UnixNow()
        {
            return (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }

        // Seeds the pseudo-random number generator.
        public static void SeedPRNG(int seed)
        {
            mPRNG = new Random(seed);
        }

        // Returns the next random number from the pseudo-random number generator.
        public static int Rand()
        {
            return mPRNG.Next();
        }

        // The success of the last Read call.
        // False if last Read failed, True otherwise.
        public static bool IsReadGood()
        {
            return mGoodRead;
        }

        public static byte ReadByte()
        {
            string raw = "";
            byte result = 0;

            try
            {
                raw = Console.ReadLine();
                result = Convert.ToByte(raw);
                mGoodRead = true;
            }
            catch (Exception)
            {
                mGoodRead = false;
            }

            return result;
        }

        public static sbyte ReadSByte()
        {
            string raw = "";
            sbyte result = 0;

            try
            {
                raw = Console.ReadLine();
                result = Convert.ToSByte(raw);
                mGoodRead = true;
            }
            catch (Exception)
            {
                mGoodRead = false;
            }

            return result;
        }

        public static short ReadShort()
        {
            string raw = "";
            short result = 0;

            try
            {
                raw = Console.ReadLine();
                result = Convert.ToInt16(raw);
                mGoodRead = true;
            }
            catch (Exception)
            {
                mGoodRead = false;
            }

            return result;
        }

        public static ushort ReadUShort()
        {
            string raw = "";
            ushort result = 0;

            try
            {
                raw = Console.ReadLine();
                result = Convert.ToUInt16(raw);
                mGoodRead = true;
            }
            catch (Exception)
            {
                mGoodRead = false;
            }

            return result;
        }

        public static int ReadInt()
        {
            string raw = "";
            int result = 0;

            try
            {
                raw = Console.ReadLine();
                result = Convert.ToInt32(raw);
                mGoodRead = true;
            }
            catch (Exception)
            {
                mGoodRead = false;
            }

            return result;
        }

        public static uint ReadUInt()
        {
            string raw = "";
            uint result = 0;

            try
            {
                raw = Console.ReadLine();
                result = Convert.ToUInt32(raw);
                mGoodRead = true;
            }
            catch (Exception)
            {
                mGoodRead = false;
            }

            return result;
        }

        public static long ReadLong()
        {
            string raw = "";
            long result = 0;

            try
            {
                raw = Console.ReadLine();
                result = Convert.ToInt64(raw);
                mGoodRead = true;
            }
            catch (Exception)
            {
                mGoodRead = false;
            }

            return result;
        }

        public static ulong ReadULong()
        {
            string raw = "";
            ulong result = 0;

            try
            {
                raw = Console.ReadLine();
                result = Convert.ToUInt64(raw);
                mGoodRead = true;
            }
            catch (Exception)
            {
                mGoodRead = false;
            }

            return result;
        }

        public static float ReadFloat()
        {
            string raw = "";
            float result = 0.0f;

            try
            {
                raw = Console.ReadLine();
                result = Convert.ToSingle(raw);
                mGoodRead = true;
            }
            catch (Exception)
            {
                mGoodRead = false;
            }

            return result;
        }

        public static double ReadDouble()
        {
            string raw = "";
            double result = 0.0;

            try
            {
                raw = Console.ReadLine();
                result = Convert.ToDouble(raw);
                mGoodRead = true;
            }
            catch (Exception)
            {
                mGoodRead = false;
            }

            return result;
        }
    }
}
