using ProtoBuf;
using System;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class RectangleI
    {
        [ProtoMember(1)]
        public int x;

        [ProtoMember(2)]
        public int y;

        [ProtoMember(3)]
        public int width;

        [ProtoMember(4)]
        public int height;
    }
}
