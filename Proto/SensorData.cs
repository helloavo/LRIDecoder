using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class SensorData
    {
        [ProtoMember(1)]
        public SensorType type;

        [ProtoMember(2)]
        public SensorCharacterization data;

        [ProtoMember(3)]
        public TimeStamp time_stamp;
    }
}
