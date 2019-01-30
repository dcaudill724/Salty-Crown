using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SaltyCrown {
    public class Screen { 
        private Asset[] assets;
        public string Name;

        public Screen(Asset[] assets, string name) {
            this.assets = assets;
            System.Console.WriteLine(name);
            Name = name;
        }

        public void Draw(GameTime gameTime, ref SpriteBatch spriteBatch) {
            foreach (Asset a in assets) {
                a.Draw(gameTime, ref spriteBatch);
            }
        }

        public void Update(GameTime gameTime) {
            foreach (Asset a in assets) {
                a.Update(gameTime);
            }
        }
    }
}
