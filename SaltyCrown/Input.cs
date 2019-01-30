using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaltyCrown {
    public static class Input {
        public static void ReadInput() {
            Keys[] keys = Keyboard.GetState().GetPressedKeys();
            for (int i = 0; i < keys.Length; i++) {
                
            }

            foreach (Keys key in keys)
                MessageSystem.SendMessage("keyPress", new string[] { key.ToString() });
            
            if(Mouse.GetState().LeftButton == ButtonState.Pressed)
                MessageSystem.SendMessage("mouseClick", new object[] { Mouse.GetState().X, Mouse.GetState().Y });
        }
    }
}
