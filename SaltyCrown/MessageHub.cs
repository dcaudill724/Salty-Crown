namespace SaltyCrown {
    public interface MessageHub {
        void HandleMessage(string message, object[] parameters);
    }
}