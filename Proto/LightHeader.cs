using ProtoBuf;

namespace LRIDecoder.Proto
{
    [ProtoContract]
    public class LightHeader
    {
        [ProtoMember(1)]
        public ulong image_unique_id_low;

        [ProtoMember(2)]
        public ulong image_unique_id_high;

        [ProtoMember(3)]
        public TimeStamp image_time_stamp;

        [ProtoMember(4)]
        public uint image_focal_length;

        [ProtoMember(5)]
        public CameraID image_reference_camera; // Missing proto class

        [ProtoMember(6)]
        public ulong device_unique_id_low;

        [ProtoMember(7)]
        public ulong device_unique_id_high;

        [ProtoMember(8)]
        public string device_model_name;

        [ProtoMember(9)]
        public string device_fw_version;

        [ProtoMember(10)]
        public string device_asic_fw_version;

        [ProtoMember(11)]
        public DeviceTemp device_temperature; // Missing proto class

        [ProtoMember(12)]
        public List<CameraModule> modules;

        [ProtoMember(13)]
        public List<FactoryModuleCalibration> module_calibration;

        [ProtoMember(14)]
        public FactoryDeviceCalibration device_calibration;

        [ProtoMember(15)]
        public List<ColorCalibrationGold> gold_cc;

        [ProtoMember(16)]
        public List<SensorData> sensor_data;

        [ProtoMember(17)]
        public float tof_range;

        [ProtoMember(18)]
        public HwInfo hw_info;

        [ProtoMember(19)]
        public ViewPreferences view_preferences;

        [ProtoMember(20)]
        public ProximitySensors proximity_sensors;

        // 21 is reserved
        [ProtoMember(22)]
        public FlashData flash_data;

        [ProtoMember(23)]
        public List<IMUData> imu_data;

        [ProtoMember(24)]
        public AFDebugInfo af_info;

        [ProtoMember(25)]
        public GPSData gps_data;

        [ProtoMember(26)]
        public Compatibility compatibility;

        [ProtoMember(27)]
        public List<FaceData> face_data;

        public static LightHeader Load(string LRILocation)
        {
            if (File.Exists(LRILocation))
            {
                using (var file = File.OpenRead(LRILocation))
                {
                    LightHeader LRI = Serializer.Deserialize<LightHeader>(file);
                    return LRI;
                }
            }
            return new();
        }
    }
}
