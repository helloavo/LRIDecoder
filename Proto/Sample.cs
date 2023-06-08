using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class Sample
    {
        [ProtoMember(1)]
        public uint row_idx;

        [ProtoMember(2)]
        public Point3F data;
    }
}
