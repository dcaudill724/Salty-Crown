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
        private Dictionary<string, Action<object[]>> events;
        
        public Asset(int x, int y, int width, int height, object[] animation, Dictionary<string, Action<object[]>> events) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.animation = animation;
            this.events = events;
            MessageSystem.AddHub(this);
        }

        public Asset(int x, int y, int width, int height, Texture2D texture, Dictionary<string, Action<object[]>> events) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.texture = texture;
            this.events = events;
            MessageSystem.AddHub(this);
        }

        public void Update(GameTime gameTime) {

        }

        public void Draw(GameTime gameTime, ref SpriteBatch spriteBatch) {
            // Rectangle spriteBorders = new Rectangle(x, y, width, height);
            //spriteBatch.Draw(texture, spriteBorders, Color.Black);

            
        }

        public void HandleMessage(string message, object[] parameters) {
            try {
                events[message](parameters);
            } catch { }
        }
    }
}
