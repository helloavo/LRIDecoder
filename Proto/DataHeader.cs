using System.Runtime.InteropServices;

namespace LRIDecoder.Proto
{

    [StructLayout(LayoutKind.Explicit, Size = 32)]

    // Header in Date to mark the start of a LightHeader
    public unsafe struct DataHeader
    {
        [FieldOffset(0)]
        public fixed byte MAGIC_ID[4]; //  = { 76, 69, 76, 82 } Size:4
        [FieldOffset(4)]
        public long TotalHeaderSize; // LightHeader + Message 
        [FieldOffset(12)]
        public long LightHeaderLength; // LightHeader Size:8
        [FieldOffset(20)]
        public int messagelength; // MessageLength Size:4
        [FieldOffset(24)]
        public byte Type; 
        [FieldOffset(25)]
        public fixed byte RESERVED[7]; // Spaceing for RAM Allocation Size: 7
    }

}
