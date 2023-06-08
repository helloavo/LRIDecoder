using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class IMUData
    {
        [ProtoMember(1)]
        public uint frame_index;

        [ProtoMember(2)]
        public List<Sample> accelerometer;

        [ProtoMember(3)]
        public List<Sample> gyroscope;
    }
}
