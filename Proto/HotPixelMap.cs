using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class HotPixelMap
    {
        [ProtoMember(1)]
        public List<HotPixelMeasurement> data;
    }
}
