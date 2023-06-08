using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class Extrinsics
    {
        [ProtoMember(1)]
        public CanonicalFormat canonical;

        [ProtoMember(2)]
        public MovableMirrorFormat moveable_mirror;
    }
}
