using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class ProximitySensors
    {
        [ProtoMember(1)]
        public bool sensor_1;

        [ProtoMember(2)]
        public bool sensor_2;

        [ProtoMember(3)]
        public bool sensor_3;

        [ProtoMember(4)]
        public bool sensor_4;

        [ProtoMember(5)]
        public bool sensor_5;
    }
}
