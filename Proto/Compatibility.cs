using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class Compatibility
    {
        [ProtoMember(1)]
        public uint version;

        [ProtoMember(2)]
        public List<string> features;
    }
}
