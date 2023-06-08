using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class AFDebugInfo
    {
        [ProtoMember(1)]
        public bool focus_achieved;

        [ProtoMember(2)]
        public int image_focal_length;
    }
}
