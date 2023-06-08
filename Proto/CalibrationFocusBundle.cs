using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class CalibrationFocusBundle
    {
        [ProtoMember(1)]
        public float focus_distance;

        [ProtoMember(2)]
        public Intrinsics intrinsics;

        [ProtoMember(3)]
        public Extrinsics extrinsics;

        [ProtoMember(4)]
        public int sensor_temp;

        [ProtoMember(5)]
        public DeviceTemp device_temp;

        [ProtoMember(6)]
        public float focus_hall_code;
    }
}
