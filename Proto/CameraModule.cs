using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class CameraModule
    {
        [ProtoMember(1)]
        public AFInfo af_info;

        [ProtoMember(2)]
        public CameraID id;

        [ProtoMember(3)]
        public bool is_enabled = true;

        [ProtoMember(4)]
        public int mirror_position = 0;

        [ProtoMember(5)]
        public int lens_position;

        // reserved 6

        [ProtoMember(7)]
        public float sensor_analog_gain;

        [ProtoMember(8)]
        public ulong sensor_exposure;

        [ProtoMember(9)]
        public Surface sensor_data_surface;

        [ProtoMember(10)]
        public int sensor_temparature;

        [ProtoMember(11)]
        public bool sensor_is_horizontal_flip = false;

        [ProtoMember(12)]
        public bool sensor_is_vertical_flip = false;

        [ProtoMember(13)]
        public Point2I sensor_bayer_red_override;

        [ProtoMember(14)]
        public float sensor_digital_gain;

        [ProtoMember(15)]
        public uint frame_index;

        [ProtoMember(16)]
        public bool sensor_dpc_on = true;

        [ProtoMember(17)]
        public int sensor_exp_start_offset;

        [ProtoMember(18)]
        public float sensor_scan_speed;
    }
}
