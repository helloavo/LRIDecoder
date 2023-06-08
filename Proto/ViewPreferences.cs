using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class ViewPreferences
    {
        [ProtoMember(1)]
        public float f_number;

        [ProtoMember(2)]
        public float ev_offset;

        [ProtoMember(3)]
        public bool disable_cropping;

        [ProtoMember(4)]
        public HDRMode hdr_mode;
    }
}
