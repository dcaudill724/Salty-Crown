using System.Collections.Generic;

namespace SaltyCrown {
    public static class MessageSystem {
        private static List<MessageHub> messageHubs;

        static MessageSystem() {
            messageHubs = new List<MessageHub>();
        }

        public static void AddHub(params MessageHub[] hubs) {
            foreach (var hub in hubs) {
                messageHubs.Add(hub);
            }
        }

        public static void SendMessage(string message, object[] parameters) {
            for (var i = 0; i < messageHubs.Count; i++) {
                messageHubs[i].HandleMessage(message, parameters);
            }
        }
    }
}

/* ~~Message naming conventions~~
 * 
 * ~ mouseClick
 * ~ screenChange
 * ~ keyPress
 */
