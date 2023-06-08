using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class FactoryDeviceCalibration
    {
        [ProtoMember(1)]
        public FlashCalibration flash;

        [ProtoMember(2)]
        public ToFCalibration tof;

        [ProtoMember(3)]
        public TimeStamp time_stamp;
    }
}
