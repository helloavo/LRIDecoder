using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class GPSData
    {
        [ProtoMember(1)]
        public double latitude;

        [ProtoMember(2)]
        public double longitude;

        [ProtoMember(3)]
        public ulong timestamp;

        [ProtoMember(4)]
        public double dop;

        [ProtoMember(5)]
        public Track track;

        [ProtoMember(6)]
        public Heading heading;

        [ProtoMember(7)]
        public Altitude altitude;

        [ProtoMember(8)]
        public double speed;

        [ProtoMember(9)]
        public ProcessingMethod processing_method;
    }
}
