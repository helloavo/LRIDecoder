using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class MovableMirrorFormat
    {
        [ProtoMember(1)]
        public MirrorSystem mirror_system;

        [ProtoMember(2)]
        public MirrorActuatorMapping mirror_actuator_mapping;
    }
}
