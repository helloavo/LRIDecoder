using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class VstModel
    {
        [ProtoMember(1)]
        public float a;

        [ProtoMember(2)]
        public float b;
    }
}
