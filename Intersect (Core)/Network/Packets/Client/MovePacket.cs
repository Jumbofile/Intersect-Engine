using System;

namespace Intersect.Network.Packets.Client
{

    public class MovePacket : CerasPacket
    {

        public MovePacket(Guid mapId, byte x, byte y, byte dir, byte jh, byte fc)
        {
            MapId = mapId;
            X = x;
            Y = y;
            Dir = dir;
            Jh = jh;
            Fc = fc;
        }

        public Guid MapId { get; set; }

        public byte X { get; set; }

        public byte Y { get; set; }

        public byte Dir { get; set; }

        public byte Jh { get; set; }

        public byte Fc { get; set; }

    }

}
