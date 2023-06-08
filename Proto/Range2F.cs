using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class Range2F
    {
        [ProtoMember(1)]
        public float min_val;

        [ProtoMember(2)]
        public float max_val;
    }
}
