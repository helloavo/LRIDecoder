using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class HotPixelMeasurement
    {
        [ProtoMember(1)]
        public ulong data_offset;

        [ProtoMember(2)]
        public uint data_size;

        [ProtoMember(3)]
        public uint data_exposure;

        [ProtoMember(4)]
        public int sensor_temparature;

        [ProtoMember(5)]
        public float sensor_gain;

        [ProtoMember(6)]
        public float pixel_variance;

        [ProtoMember(7)]
        public float threshold;
    }
}
