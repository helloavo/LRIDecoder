using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class SpectralSensitivity
    {
        [ProtoMember(1)]
        public uint start = 1;

        [ProtoMember(2)]
        public uint end = 2;

        [ProtoMember(3, IsPacked = true)]
        public List<float> data;
    }
}
