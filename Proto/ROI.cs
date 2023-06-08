using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class ROI
    {
        [ProtoMember(1)]
        public uint id;

        [ProtoMember(2)]
        public RectangleI roi;

        [ProtoMember(3)]
        public float confidence;
    }
}
