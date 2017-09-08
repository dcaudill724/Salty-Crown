using System.Collections.Generic;

namespace SaltyCrown {
    public static class MessageSystem {
        private static List<MessageHub> messageHubs;

        private static Dictionary<Message, List<MessageHub>> map = new Dictionary<Message, List<MessageHub>>{
            { Message.MouseClick, new List<MessageHub> {

            }},
        };

        static MessageSystem() {
            messageHubs = new List<MessageHub>();
        }

        public static void AddHub(params MessageHub[] hubs) {
            foreach (var hub in hubs) {
                messageHubs.Add(hub);
            }
        }

        public static void SendMessage(Message message) {
            for (var i = 0; i < messageHubs.Count; i++) {
                var hub = messageHubs[i];
                if (hub.Needs(message)) {
                    hub.HandleMessage(message);
                }
            }
        }
    }
}
