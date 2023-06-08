using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class Point3F
    {
        [ProtoMember(1)]
        public float x;

        [ProtoMember(2)]
        public float y;

        [ProtoMember(3)]
        public float z;
    }
}
