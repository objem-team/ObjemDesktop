using System;
using System.Runtime.InteropServices;
using ObjemDesktop.Shortcuts.Keyboard.Structs;

namespace ObjemDesktop.Shortcuts.Keyboard
{
    static class KeyStrokesGenerator
    {
        [DllImport("user32.dll", EntryPoint = "MapVirtualKeyA")]
        private static extern uint MapVirtualKey(uint wCode, uint wMapType);

        public static Input[] Generate(ushort[] keycodes)
        {
            var strokes = new Input[keycodes.Length * 2];
            for (int i = 0; i < keycodes.Length; i++)
            {
                strokes[keycodes.Length + i] = GenerateKeyUpInput(keycodes[0]);
                strokes[keycodes.Length + i] = GenerateKeyUpInput(keycodes[i]);
            }
            return strokes;
        }

        private static bool IsExtendedKey(uint keycode)
        {
            var scancode = MapVirtualKey(keycode, 4); //4 is MAP_VK_TO_VSC_EX, so return with prefix;
            if (scancode == 0) return false;
            const uint extendedkeyPrefix = 0xE0;
            return (scancode >> 8 & extendedkeyPrefix) > 0;
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
                        flags = (isExtendedKey ? KeyBoardInputFlags.Extendedkey : 0x0) | KeyBoardInputFlags.Down,
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
                        flags = (isExtendedKey ? KeyBoardInputFlags.Extendedkey : 0x0) | KeyBoardInputFlags.Keyup,
                        time = 0,
                        extraInfo = IntPtr.Zero
                    }
                }

            };
        }
    }
}
