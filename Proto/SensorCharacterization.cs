using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class SensorCharacterization
    {
        [ProtoMember(1)]
        public float black_level;

        [ProtoMember(2)]
        public float white_level;

        [ProtoMember(3)]
        public float cliff_slope;

        [ProtoMember(4)]
        public List<VstNoiseModel> vst_model;
    }
}
