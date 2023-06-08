using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class MirrorSystem
    {
        [ProtoMember(1)]
        public Point3F real_camera_location;

        [ProtoMember(2)]
        public Matrix3x3F real_camera_orientation;

        [ProtoMember(3)]
        public Point3F rotation_axis;

        [ProtoMember(4)]
        public Point3F point_on_rotation_axis;

        [ProtoMember(5)]
        public float distance_mirror_plane_to_point_on_rotation_axis;

        [ProtoMember(6)]
        public Point3F mirror_normal_at_zero_degrees;

        [ProtoMember(7)]
        public bool flip_img_around_x;

        [ProtoMember(8)]
        public Range2F mirror_angle_range;

        [ProtoMember(9)]
        public float reprojection_error;
    }
}
