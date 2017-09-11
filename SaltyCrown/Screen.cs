namespace SaltyCrown {
    public static class Screen {
        public static string CurrentScreenName = "";

        public static void changeScreenName(string screenName) {
            CurrentScreenName = screenName;
            MessageSystem.SendMessage(Message.ScreenChange);
        }
    }
}
