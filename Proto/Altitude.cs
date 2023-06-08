using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class Altitude
    {
        [ProtoMember(1)]
        public double value;

        [ProtoMember(2)]
        public ReferenceAltitude AltitudeType;
    }
}
