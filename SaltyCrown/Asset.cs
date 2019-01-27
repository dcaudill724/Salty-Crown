using System;
using Microsoft.Xna.Framework;

namespace SaltyCrown {
    public class Asset : MessageHub {
        private int x;
        private int y;
        private int width;
        private int height;
        private object[] animation = {
            new {filePath="MainMenuButton", },
        };
        
        public Asset(int x, int y, int width, int height) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void AnimationSetup(object[] animation) {

        }

        public void Update(GameTime gameTime) {

        }

        public void Draw(GameTime gameTime) {

        }

        public void HandleMessage(Message message) {
            
        }
    }
}
