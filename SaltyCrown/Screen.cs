using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SaltyCrown {
    public static class Screen {
        public static string currentScreenName = "";

        public static void changeScreenName(string screenName) {
            currentScreenName = screenName;
            MessageSystem.SendMessage(new Message("Screen name : " + screenName, MessageType.Info));
        }
    }
}
