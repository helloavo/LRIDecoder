using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class ActuatorAnglePair
    {
        [ProtoMember(1)]
        public int hall_code;

        [ProtoMember(2)]
        public float angle;
    }
}
