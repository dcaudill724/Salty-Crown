﻿//Authors:
//Noah Tranbarger
//Dustin Caudill

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.IO;

namespace SaltyCrown {
    public class Engine : Game {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Engine() {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        
        protected override void Initialize() {
            base.Initialize();
            Init.Execute(graphics.GraphicsDevice, spriteBatch, this);
        }

        protected override void LoadContent() {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }
        
        protected override void UnloadContent() {
        }
        
        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) {
                Exit();
            }
            Input.ReadInput();
           
            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            Graphics.Draw(gameTime, ref spriteBatch);
            BlendState blendState = new BlendState();
            spriteBatch.Begin();
            Texture2D rect = Content.Load<Texture2D>("Images/knight");
            spriteBatch.Draw(rect, new Rectangle(200, 200, 200, 200), Color.Transparent);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}