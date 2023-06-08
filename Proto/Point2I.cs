using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class Point2I
    {
        [ProtoMember(1)]
        public int x;

        [ProtoMember(2)]
        public int y;
    }
}
