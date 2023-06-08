using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class QuadraticModel
    {
        [ProtoMember(1)]
        public bool use_rplus_for_left_segment;

        [ProtoMember(2)]
        public bool use_rplus_for_right_segment;

        [ProtoMember(3)]
        public float inflection_value;

        [ProtoMember(4)] // packed = true
        public List<float> model_coeffs;
    }
}
