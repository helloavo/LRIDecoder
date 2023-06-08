using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class Point2F
    {
        [ProtoMember(1)]
        public float x;

        [ProtoMember(2)]
        public float y;
    }
}
