using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class Intrinsics
    {
        [ProtoMember(1)]
        public Matrix3x3F k_mat;

        [ProtoMember(2)]
        public float rms_error;
    }
}
