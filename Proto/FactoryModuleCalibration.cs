using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class FactoryModuleCalibration
    {
        [ProtoMember(1)]
        public CameraID camera_id;

        [ProtoMember(2)]
        public List<ColorCalibration> color; // repeated

        [ProtoMember(3)]
        public GeometricCalibration geometry;

        [ProtoMember(4)]
        public VignettingCharacterization vignetting;

        [ProtoMember(5)]
        public HotPixelMap hot_pixel_map;

        [ProtoMember(6)]
        public DeadPixelMap dead_pixel_map;

        [ProtoMember(7)]
        public TimeStamp time_stamp;
    }
}
