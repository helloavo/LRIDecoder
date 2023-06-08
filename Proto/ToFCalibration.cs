using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class ToFCalibration
    {
        [ProtoMember(1)]
        public float offset_distance;

        [ProtoMember(2)]
        public float offset_measurement;

        [ProtoMember(3)]
        public float xtalk_distance;

        [ProtoMember(4)]
        public float xtalk_measurement;
    }
}
