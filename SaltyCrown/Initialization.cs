using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
namespace SaltyCrown {
    public static class Init {
        private static List<Screen> screens = new List<Screen>();

        public static bool Execute(GraphicsDevice graphics, SpriteBatch spriteBatch, Game game) {
            Graphics.Initialize();

            Graphics.AddScreen(
                new Screen(new Asset[] {
                    #region supernova
                    new Asset(200, 200, 200, 200,
                        game.Content.Load<Texture2D>("Images/supernova"),
                        new Dictionary<string, Action<object[]>>() {
                            { "mouseClick", new Action<object[]>(
                                delegate(object[] parameters) {
                                    Console.WriteLine("hello");
                                }
                            )},
                            { "keyPress", new Action<object[]> (
                                delegate(object[] parameters) {
                                    if(parameters[0].ToString() == "D") {
                                        Console.WriteLine("Gang");
                                    }
                                }
                            )}
                        }
                    ),
                    #endregion
                }, "mainMenu")
                    
            );
            
            Graphics.ChangeScreen("mainMenu");
            return true;
        }
    }
}
