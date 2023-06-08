using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class MirrorVignettingModel
    {
        [ProtoMember(1)]
        public int hall_code;

        [ProtoMember(2)]
        public VignettingModel vignetting;
    }
}
