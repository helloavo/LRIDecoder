using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class CrosstalkModel
    {
        [ProtoMember(1)]
        public uint width = 1;

        [ProtoMember(2)]
        public uint height;

        [ProtoMember(3)]
        public List<Matrix4x4F> data;

        [ProtoMember(4, IsPacked = true)]
        public List<float> data_packed;
    }
}
