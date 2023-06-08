using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class Heading
    {
        [ProtoMember(1)]
        public double value;

        [ProtoMember(2)]
        public ReferenceNorth NorthType;
    }
}
