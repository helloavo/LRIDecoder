using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class VstNoiseModel
    {
        [ProtoMember(1)]
        public uint gain;

        [ProtoMember(2)]
        public float threshold;

        [ProtoMember(3)]
        public float scale;

        [ProtoMember(4)]
        public VstModel red;

        [ProtoMember(5)]
        public VstModel green;

        [ProtoMember(6)]
        public VstModel blue;

        [ProtoMember(7)]
        public VstModel panchromatic;
    }
}
