using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class VignettingCharacterization
    {
        [ProtoMember(1)]
        public CrosstalkModel crosstalk;

        [ProtoMember(2)]
        public List<MirrorVignettingModel> vignetting;

        [ProtoMember(3)]
        public float relative_brightness;

        [ProtoMember(4)]
        public int lens_hall_code;
    }
}
