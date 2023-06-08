using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class DeadPixelMap
    {
        [ProtoMember(1)]
        public ulong data_offset;

        [ProtoMember(2)]
        public uint data_size;

        [ProtoMember(3)]
        public float black_level_threshold;
    }
}
