using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class ColorCalibration
    {
        [ProtoMember(1)]
        public IlluminantType type;

        [ProtoMember(2)]
        public Matrix3x3F forward_matrix;

        [ProtoMember(3)]
        public Matrix3x3F color_matrix;

        [ProtoMember(4)]
        public float rg_ratio;

        [ProtoMember(5)]
        public float bg_ratio;

        [ProtoMember(6)]
        public List<Point3F> macbeth_data;

        [ProtoMember(7)]
        public List<Point2F> illuminant_spd;

        [ProtoMember(8)]
        public SpectralData spectral_data;

    }
}
