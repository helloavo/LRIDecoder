using Microsoft.Extensions.Options;
using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class FlashData
    {
        [ProtoMember(1)]
        public FlashMode mode;

        [ProtoMember(2)]
        public uint ledcool_current = 2;

        [ProtoMember(3)]
        public uint ledwarm_current = 3;

        [ProtoMember(4)]
        public uint flash_duration = 4;

        [ProtoMember(5)]
        public int offset_duration = 5;
    }
}
