using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class SpectralData
    {
        [ProtoMember(1)]
        public ChannelFormat format;

        [ProtoMember(2)]
        public List<SpectralSensitivity> channel_data;
    }
}
