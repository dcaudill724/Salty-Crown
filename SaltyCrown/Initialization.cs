using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace SaltyCrown {
    public static class Init {
        private static List<Screen> screens = new List<Screen>();

        public static bool Execute(GraphicsDevice graphics) {

            Asset test = new Asset(200, 200, 200, 200, new Texture2D(graphics, 2, 2), new Dictionary<string, Action<object[]>>() {
                {"mouseClick", new Action<object[]>(delegate(object[] parameters){
                    Console.WriteLine("hello");
                })},
                {"keyPress", new Action<object[]>(delegate(object[] parameters){
                    if(parameters[0].ToString() == "D") {
                        Console.WriteLine("Gang");
                    }
                })}
            });
            return true;
        }
    }
}
