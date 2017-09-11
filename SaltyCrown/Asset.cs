using System;
using Microsoft.Xna.Framework;

namespace SaltyCrown {
    public abstract class Asset : MessageHub {
        public string ParentScreen;
        public int x;
        public int y;
        public int width;
        public int height;

        public void Update(GameTime gameTime) {

        }

        public void Draw(GameTime gameTime) {

        }

        public void HandleMessage(Message message) {
            
        }
    }
}
