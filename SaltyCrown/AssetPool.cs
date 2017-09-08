using System;
using System.IO;

namespace SaltyCrown {
    public static class AssetPool {
        public static void ParseAssets(string path) {
            if (!File.Exists(path)) {
                System.Console.WriteLine("File does not exist");
                return;
            }

            string[] lines = path.Split('\n');
            for (int i = 0; i < lines.Length; i++) {
                string[] items = lines[i].Split(' ');
            }
        }
    }
}
