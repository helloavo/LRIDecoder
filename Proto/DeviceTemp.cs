using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class DeviceTemp
    {
        [ProtoMember(1)]
        public int sensor_1;

        [ProtoMember(2)]
        public int sensor_2;

        [ProtoMember(3)]
        public int sensor_3;

        [ProtoMember(4)]
        public int sensor_4;

        [ProtoMember(5)]
        public int flex_sensor_1;
    }
}
