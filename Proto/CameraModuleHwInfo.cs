using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class CameraModuleHwInfo
    {
        [ProtoMember(1)]
        public CameraID id;

        [ProtoMember(2)]
        public SensorType sensor;
    }
}
