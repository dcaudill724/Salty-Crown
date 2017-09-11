using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace SaltyCrown {
    public class AssetPool : MessageHub {
        private List<Asset> availableAssets = new List<Asset>();
        private List<Asset> activeAssets = new List<Asset>();

        public AssetPool() {
            MessageSystem.AddHub(this);
        }

        private void updateActiveAssets() {
            activeAssets = new List<Asset>();
            foreach(Asset a in availableAssets) {
                if (a.ParentScreen == Screen.CurrentScreenName) {
                    activeAssets.Add(a);
                }
            }
        }

        public void Draw(GameTime gameTime) {
            foreach(Asset a in activeAssets) {
                a.Draw(gameTime);
            }
        }

        public void Update(GameTime gameTime) {
            foreach (Asset a in activeAssets) {
                a.Update(gameTime);
            }
        }

        public void HandleMessage(Message message) {
            switch (message) {
                case Message.ScreenChange:
                    updateActiveAssets();
                    break;
            }
            foreach(Asset a in activeAssets) {
                HandleMessage(message);
            }
        }

        public void InitializeAvailableAssets(List<Asset> assets) {
            availableAssets = assets;
        }
    }
}
