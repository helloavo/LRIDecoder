using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class Track
    {
        [ProtoMember(1)]
        public double value;

        [ProtoMember(2)]
        public ReferenceNorth NorthType;
    }
}
