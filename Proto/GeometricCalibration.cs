using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class GeometricCalibration
    {
        [ProtoMember(1)]
        public MirrorType mirror_type;

        [ProtoMember(2)]
        public List<CalibrationFocusBundle> per_focus_calibration;
    }
}
