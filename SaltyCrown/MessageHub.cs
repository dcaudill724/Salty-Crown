namespace SaltyCrown {
    public interface MessageHub {
        void HandleMessage(Message message);
        bool Needs(Message message);
    }
}
