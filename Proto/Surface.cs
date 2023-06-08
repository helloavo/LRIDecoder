using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class Surface
    {
        [ProtoMember(1)]
        public Point2I start;

        [ProtoMember(2)]
        public Point2I size;

        [ProtoMember(3)]
        public FormatType format;

        [ProtoMember(4)]
        public uint row_stride;

        [ProtoMember(5)]
        public ulong data_offset;

        [ProtoMember(6)]
        public Point2F data_scale;
    }
}
