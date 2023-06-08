using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class FaceData
    {
        [ProtoMember(1)]
        public CameraID id;

        [ProtoMember(2)]
        public uint frame_index;

        [ProtoMember(3)]
        public List<ROI> rois;
    }
}
