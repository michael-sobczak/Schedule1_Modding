internal struct Zip64ExtraField // TypeDefIndex: 17664
{
	// Fields
	private ushort _size; // 0x0
	private Nullable<long> _uncompressedSize; // 0x8
	private Nullable<long> _compressedSize; // 0x18
	private Nullable<long> _localHeaderOffset; // 0x28
	private Nullable<int> _startDiskNumber; // 0x38

	// Properties
	public ushort TotalSize { get; }
	public Nullable<long> UncompressedSize { get; set; }
	public Nullable<long> CompressedSize { get; set; }
	public Nullable<long> LocalHeaderOffset { get; set; }
	public Nullable<int> StartDiskNumber { get; }

	// Methods

	// RVA: 0x2174600 Offset: 0x2173000 VA: 0x182174600
	public ushort get_TotalSize() { }

	// RVA: 0x46EE40 Offset: 0x46D840 VA: 0x18046EE40
	public Nullable<long> get_UncompressedSize() { }

	// RVA: 0x21746F0 Offset: 0x21730F0 VA: 0x1821746F0
	public void set_UncompressedSize(Nullable<long> value) { }

	// RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	public Nullable<long> get_CompressedSize() { }

	// RVA: 0x2174610 Offset: 0x2173010 VA: 0x182174610
	public void set_CompressedSize(Nullable<long> value) { }

	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public Nullable<long> get_LocalHeaderOffset() { }

	// RVA: 0x2174680 Offset: 0x2173080 VA: 0x182174680
	public void set_LocalHeaderOffset(Nullable<long> value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public Nullable<int> get_StartDiskNumber() { }

	// RVA: 0x21743F0 Offset: 0x2172DF0 VA: 0x1821743F0
	private void UpdateSize() { }

	// RVA: 0x2173A10 Offset: 0x2172410 VA: 0x182173A10
	public static Zip64ExtraField GetJustZip64Block(Stream extraFieldStream, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber) { }

	// RVA: 0x2173EB0 Offset: 0x21728B0 VA: 0x182173EB0
	private static bool TryGetZip64BlockFromGenericExtraField(ZipGenericExtraField extraField, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber, out Zip64ExtraField zip64Block) { }

	// RVA: 0x21736E0 Offset: 0x21720E0 VA: 0x1821736E0
	public static Zip64ExtraField GetAndRemoveZip64Block(List<ZipGenericExtraField> extraFields, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber) { }

	// RVA: 0x2173C60 Offset: 0x2172660 VA: 0x182173C60
	public static void RemoveZip64Blocks(List<ZipGenericExtraField> extraFields) { }

	// RVA: 0x2174460 Offset: 0x2172E60 VA: 0x182174460
	public void WriteBlock(Stream stream) { }
}
