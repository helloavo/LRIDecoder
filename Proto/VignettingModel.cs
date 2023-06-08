using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class VignettingModel
    {
        [ProtoMember(1)]
        public uint width;

        [ProtoMember(2)]
        public uint height;

        [ProtoMember(3, IsPacked = true)]
        public List<float> data;
    }
}
