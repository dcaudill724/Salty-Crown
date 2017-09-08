using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;

namespace SaltyCrown {
    public static class AssetPool {
        private static List<Asset> assets;

        static AssetPool() {
            assets = new List<Asset>();
        }

        public static void ParseAssets(string path) {
            if (!File.Exists(path)) {
                System.Console.WriteLine("File does not exist");
                return;
            }

            string rawText = File.ReadAllText(path);

            string[] lines = rawText.Split('\n');
            for (int i = 0; i < lines.Length; i++) {
                string[] items = lines[i].Split(' ');
                for (int o = 0; o < items.Length; o++) {
                    System.Console.WriteLine(items[o]);
                }
            }
        }
    }
}
