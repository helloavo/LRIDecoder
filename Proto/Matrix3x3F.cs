using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class Matrix3x3F
    {
        [ProtoMember(1)]
        public float x00;
        [ProtoMember(2)]
        public float x01;
        [ProtoMember(3)]
        public float x02;
        [ProtoMember(4)]
        public float x10;
        [ProtoMember(5)]
        public float x11;
        [ProtoMember(6)]
        public float x12;
        [ProtoMember(7)]
        public float x20;
        [ProtoMember(8)]
        public float x21;
        [ProtoMember(9)]
        public float x22;
    }
}
