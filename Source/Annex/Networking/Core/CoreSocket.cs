﻿using Annex.Networking.Configuration;
using Annex.Networking.Packets;

namespace Annex.Networking.Core
{
    public abstract class CoreSocket
    {
        public delegate void ReceiveHandler(object baseConnection, byte[] data);
        public event ReceiveHandler OnReceive;

        private protected SocketConfiguration _config;

        public CoreSocket(SocketConfiguration config) {
            this._config = config;
        }

        public abstract void Start();
        public abstract void Destroy();
        public abstract void SendPacket(object baseConnection, int packetID, OutgoingPacket packet);

        private protected void PacketReceived(object baseConnection, byte[] data) {
            this.OnReceive?.Invoke(baseConnection, data);
        }
    }
}