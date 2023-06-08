using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class Matrix4x4F
    {
        [ProtoMember(1)]
        public float x00;
        [ProtoMember(2)]
        public float x01;
        [ProtoMember(3)]
        public float x02;
        [ProtoMember(4)]
        public float x03;
        [ProtoMember(5)]
        public float x10;
        [ProtoMember(6)]
        public float x11;
        [ProtoMember(7)]
        public float x12;
        [ProtoMember(8)]
        public float x13;
        [ProtoMember(9)]
        public float x20;
        [ProtoMember(10)]
        public float x21;
        [ProtoMember(11)]
        public float x22;
        [ProtoMember(12)]
        public float x23;
        [ProtoMember(13)]
        public float x30;
        [ProtoMember(14)]
        public float x31;
        [ProtoMember(15)]
        public float x32;
        [ProtoMember(16)]
        public float x33;
    }
}
