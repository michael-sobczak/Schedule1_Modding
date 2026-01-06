public sealed class PhotoCaptureFrame : IDisposable // TypeDefIndex: 11939
{
	// Fields
	private IntPtr m_NativePtr; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <dataLength>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <hasLocationData>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private CapturePixelFormat <pixelFormat>k__BackingField; // 0x20

	// Properties
	public int dataLength { get; set; }
	private bool hasLocationData { set; }
	private CapturePixelFormat pixelFormat { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_dataLength() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	private void set_dataLength(int value) { }

	[CompilerGenerated]
	// RVA: 0xCDF8D0 Offset: 0xCDE2D0 VA: 0x180CDF8D0
	private void set_hasLocationData(bool value) { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	private void set_pixelFormat(CapturePixelFormat value) { }

	[ThreadAndSerializationSafe]
	// RVA: 0x2CE36E0 Offset: 0x2CE20E0 VA: 0x182CE36E0
	private int GetDataLength() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x2CE3720 Offset: 0x2CE2120 VA: 0x182CE3720
	private bool GetHasLocationData() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x2CE36A0 Offset: 0x2CE20A0 VA: 0x182CE36A0
	private CapturePixelFormat GetCapturePixelFormat() { }

	// RVA: 0x2CE3760 Offset: 0x2CE2160 VA: 0x182CE3760
	internal void .ctor(IntPtr nativePtr) { }

	// RVA: 0x2CE3500 Offset: 0x2CE1F00 VA: 0x182CE3500
	private void Cleanup() { }

	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeName("Dispose")]
	[ThreadAndSerializationSafe]
	// RVA: 0x2CE35A0 Offset: 0x2CE1FA0 VA: 0x182CE35A0
	private void Dispose_Internal() { }

	// RVA: 0x2CE35E0 Offset: 0x2CE1FE0 VA: 0x182CE35E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2CE3640 Offset: 0x2CE2040 VA: 0x182CE3640 Slot: 1
	protected override void Finalize() { }
}
