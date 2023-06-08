using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class ColorCalibrationGold
    {
        [ProtoMember(1)]
        public CameraID camera_id;

        [ProtoMember(2)]
        public List<ColorCalibration> data;

        [ProtoMember(3)]
        public TimeStamp time_stamp;
    }
}
