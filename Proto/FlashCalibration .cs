using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class FlashCalibration
    {
        [ProtoMember(1)]
        public float ledcool_lux;

        [ProtoMember(2)]
        public float ledcool_max_lumens;

        [ProtoMember(3)]
        public float ledcool_cct;

        [ProtoMember(4)]
        public float ledwarm_lux;

        [ProtoMember(5)]
        public float ledwarm_max_lumens;

        [ProtoMember(6)]
        public float ledwarm_cct;
    }
}
