//Authors:
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
        AssetPool assetPool = new AssetPool();
        delegate void x(int y);

        public Engine() {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            x help = i => {Console.WriteLine(i);};
            help(20);
        }
        
        protected override void Initialize() {
            base.Initialize();
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
            assetPool.Update(gameTime);
            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            assetPool.Draw(gameTime);
            base.Draw(gameTime);
        }
    }
}