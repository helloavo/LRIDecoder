using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class HwInfo
    {
        [ProtoMember(1)]
        public List<CameraModuleHwInfo> camera;

        [ProtoMember(2)]
        public FlashType flash = FlashType.FLASH_UNKNOWN;
    }
}
