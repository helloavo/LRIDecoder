using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class CanonicalFormat
    {
        [ProtoMember(1)]
        public Matrix3x3F rotation;

        [ProtoMember(2)]
        public Point3F translation;

        [ProtoMember(3)]
        public float stereo_error;

        [ProtoMember(4)]
        public float reprojection_error;
    }
}
