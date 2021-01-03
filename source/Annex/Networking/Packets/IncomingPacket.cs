﻿using System.IO;

namespace Annex.Networking.Packets
{
    public class IncomingPacket : IPacket
    {
        private byte[] _data;
        private MemoryStream _memoryStream;
        private BinaryReader _reader;

        public long Length => this._memoryStream.Length;

        public IncomingPacket(byte[] data) {
            this._data = data;
            this._memoryStream = new MemoryStream(data);
            this._reader = new BinaryReader(this._memoryStream);
        }

        public string ReadString() {
            return this._reader.ReadString();
        }

        public int ReadInt32() {
            return this._reader.ReadInt32();
        }

        public float ReadFloat() {
            return this._reader.ReadSingle();
        }

        public bool ReadBool() {
            return this._reader.ReadBoolean();
        }

        public byte ReadByte() {
            return this._reader.ReadByte();
        }

        public void Dispose() {
            _reader.Dispose();
            _memoryStream.Dispose();
        }
    }
}
