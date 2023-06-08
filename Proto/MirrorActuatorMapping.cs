using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class MirrorActuatorMapping
    {
        [ProtoMember(1)]
        public TransformationType transformation_type;

        [ProtoMember(2)]
        public float actuator_length_offset = 2;

        [ProtoMember(3)]
        public float actuator_length_scale = 3;

        [ProtoMember(4)]
        public float mirror_angle_offset = 4;

        [ProtoMember(5)]
        public float mirror_angle_scale = 5;

        [ProtoMember(6)]
        public List<ActuatorAnglePair> actuator_angle_pair_vec;

        [ProtoMember(7)]
        public QuadraticModel quadratic_model;
    }
}
