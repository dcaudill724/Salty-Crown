﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SaltyCrown {
    public class Asset : MessageHub {
        private int x;
        private int y;
        private int width;
        private int height;
        private object[] animation; //[spritesheet.png, rows, columns, animation speed]
        private Texture2D texture;
        private Dictionary<string, Action> events;
        
        public Asset(int x, int y, int width, int height, object[] animation, Dictionary<string, Action> events) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.animation = animation;
            this.events = events;
        }

        public Asset(int x, int y, int width, int height, Texture2D texture, Dictionary<string, Action> events) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.texture = texture;
            this.events = events;
        }

        public void Update(GameTime gameTime) {
            //update position
            //update animation
        }

        public void Draw(GameTime gameTime) {

        }

        public void HandleMessage(string message, object[] parameters) {
            try {

            } catch { }
        }
    }
}
