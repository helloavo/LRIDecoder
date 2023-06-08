using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class AFInfo
    {
        [ProtoMember(1)]
        public AFMode mode;

        [ProtoMember(2)]
        public Point2F roi_center;

        [ProtoMember(3)]
        public float disparity_focus_distance;

        [ProtoMember(4)]
        public float contrast_focus_distance;

        [ProtoMember(5)]
        public bool lens_timeout;

        [ProtoMember(6)]
        public bool mirror_timeout;

        [ProtoMember(7)]
        public int mirror_position;
    }
}
