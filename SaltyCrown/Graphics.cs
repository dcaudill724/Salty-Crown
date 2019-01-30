using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace SaltyCrown {
    public static class Graphics {
        private static Dictionary<string, Screen> screens;
        private static string currentScreen;

        public static void Initialize() {
            screens = new Dictionary<string, Screen>();
        }

        public static void ChangeScreen(string screenName) {
            currentScreen = screenName;
        }

        public static void AddScreen(Screen screen) {
            screens[screen.Name] = screen;
        }

        public static void Draw(GameTime gameTime, ref SpriteBatch spriteBatch) {
            spriteBatch.Begin();
            try {
                screens[currentScreen].Draw(gameTime, ref spriteBatch);
            } catch { /*If stuff stops drawing, check here*/ }
            spriteBatch.End();
        }
    }
}
