//Authors:
//Noah Tranbarger
//Dustin Caudill

using System;

namespace SaltyCrown {
#if WINDOWS || LINUX
    public static class Program {
        [STAThread]
        static void Main() {
            using (var game = new App()) {
                game.Run();
            }
        }
    }
#endif
}
