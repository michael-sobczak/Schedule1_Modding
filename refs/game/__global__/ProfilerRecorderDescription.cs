public struct ProfilerRecorderDescription // TypeDefIndex: 11504
{
	// Fields
	private readonly ProfilerCategory category; // 0x0
	private readonly MarkerFlags flags; // 0x2
	private readonly ProfilerMarkerDataType dataType; // 0x4
	private readonly ProfilerMarkerDataUnit unitType; // 0x5
	private readonly int reserved0; // 0x8
	private readonly int nameUtf8Len; // 0xC
	private readonly byte* nameUtf8; // 0x10

	// Properties
	public MarkerFlags Flags { get; }

	// Methods

	// RVA: 0xCBDFC0 Offset: 0xCBC9C0 VA: 0x180CBDFC0
	public MarkerFlags get_Flags() { }
}
