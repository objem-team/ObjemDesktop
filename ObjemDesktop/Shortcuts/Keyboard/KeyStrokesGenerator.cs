using System;
using System.Runtime.InteropServices;

namespace ObjemDesktop.Shortcuts.Keyboard
{
    class KeyStrokesGenerator
    {
        [DllImport("user32.dll", EntryPoint = "MapVirtualKeyA")]
        private extern static uint MapVirtualKey(uint wCode, uint wMapType);

        public static Input[] Generate(ushort[] keycodes)
        {
            var strokes = new Input[keycodes.Length * 2];
            for (int i = 0; i < 2; i++)
            {                
                strokes[i] = GenerateKeyDownInput(keycodes[i]);
                strokes[keycodes.Length + i] = GenerateKeyUpInput(keycodes[i]);
            }
            return strokes;
        }

        private static bool IsExtendedKey(uint keycode)
        {
            var scancode = MapVirtualKey(keycode, 4); //4 is MAPVK_VK_TO_VSC_EX, so return with prefix;
            if (scancode == 0) return false;
            const uint EXTENDEDKEY_PREFIX = 0xE0;
            return (scancode >> 8 & EXTENDEDKEY_PREFIX) > 0;
        }
        private static Input GenerateKeyDownInput(uint keycode)
        {
            bool isExtendedKey = IsExtendedKey(keycode);
            return new Input()
            {
                type = 1,
                userInput = new UserInput()
                {
                    keyboardInput = new KeyboardInput
                    {
                        keyCode = (ushort)keycode,
                        scanCode = (ushort)MapVirtualKey(keycode, 1),
                        flags = (isExtendedKey ? KeyBoardInputFlags.KEYEVENTF_EXTENDEDKEY : 0x0) | KeyBoardInputFlags.KEYEVENTF_DOWN,
                        time = 0,
                        extraInfo = IntPtr.Zero
                    }
                }

            };
        }
        private static Input GenerateKeyUpInput(uint keycode)
        {
            bool isExtendedKey = IsExtendedKey(keycode);
            return new Input()
            {
                type = 1,
                userInput = new UserInput()
                {
                    keyboardInput = new KeyboardInput
                    {
                        keyCode = (ushort)keycode,
                        scanCode = (ushort)MapVirtualKey(keycode, 1),
                        flags = (isExtendedKey ? KeyBoardInputFlags.KEYEVENTF_EXTENDEDKEY : 0x0) | KeyBoardInputFlags.KEYEVENTF_KEYUP,
                        time = 0,
                        extraInfo = IntPtr.Zero
                    }
                }

            };
        }
    }
}
