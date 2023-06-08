using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class TimeStamp
    {
        [ProtoMember(1)]
        public uint year;

        [ProtoMember(2)]
        public uint month;

        [ProtoMember(3)]
        public uint day;

        [ProtoMember(4)]
        public uint hour;

        [ProtoMember(5)]
        public uint minute;

        [ProtoMember(6)]
        public uint second;

        [ProtoMember(7)]
        public int tz_offset;
    }
}
