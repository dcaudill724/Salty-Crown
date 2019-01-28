using Microsoft.Xna.Framework;

namespace SaltyCrown {
    public class Screen { 
        public string CurrentScreenName = "";
        Asset[] assets;

        public Screen(Asset[] assets) {
            this.assets = assets;
        }

        public void changeScreen(string screenName) {
            CurrentScreenName = screenName;
            MessageSystem.SendMessage("ScreenChange", new string[] {screenName});
        }

        public void Draw(GameTime gameTime) {
            foreach (Asset a in assets) {
                a.Draw(gameTime);
            }
        }

        public void Update(GameTime gameTime) {
            foreach (Asset a in assets) {
                a.Update(gameTime);
            }
        }
    }
}
