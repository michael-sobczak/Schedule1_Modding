public sealed class ImageCodecInfo // TypeDefIndex: 17212
{
	// Fields
	private Guid _clsid; // 0x10
	private Guid _formatID; // 0x20
	private string _codecName; // 0x30
	private string _dllName; // 0x38
	private string _formatDescription; // 0x40
	private string _filenameExtension; // 0x48
	private string _mimeType; // 0x50
	private ImageCodecFlags _flags; // 0x58
	private int _version; // 0x5C
	private byte[][] _signaturePatterns; // 0x60
	private byte[][] _signatureMasks; // 0x68

	// Properties
	public Guid Clsid { get; set; }
	public Guid FormatID { get; set; }
	public string CodecName { set; }
	public string DllName { set; }
	public string FormatDescription { set; }
	public string FilenameExtension { set; }
	public string MimeType { set; }
	public ImageCodecFlags Flags { set; }
	public int Version { set; }
	[CLSCompliant(False)]
	public byte[][] SignaturePatterns { get; set; }
	[CLSCompliant(False)]
	public byte[][] SignatureMasks { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x49CD30 Offset: 0x49B730 VA: 0x18049CD30
	public Guid get_Clsid() { }

	// RVA: 0x49CD50 Offset: 0x49B750 VA: 0x18049CD50
	public void set_Clsid(Guid value) { }

	// RVA: 0x4976D0 Offset: 0x4960D0 VA: 0x1804976D0
	public Guid get_FormatID() { }

	// RVA: 0x4976E0 Offset: 0x4960E0 VA: 0x1804976E0
	public void set_FormatID(Guid value) { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_CodecName(string value) { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_DllName(string value) { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_FormatDescription(string value) { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_FilenameExtension(string value) { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_MimeType(string value) { }

	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	public void set_Flags(ImageCodecFlags value) { }

	// RVA: 0x8E6930 Offset: 0x8E5330 VA: 0x1808E6930
	public void set_Version(int value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public byte[][] get_SignaturePatterns() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_SignaturePatterns(byte[][] value) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public byte[][] get_SignatureMasks() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_SignatureMasks(byte[][] value) { }

	// RVA: 0x215A8B0 Offset: 0x21592B0 VA: 0x18215A8B0
	public static ImageCodecInfo[] GetImageEncoders() { }

	// RVA: 0x215A320 Offset: 0x2158D20 VA: 0x18215A320
	private static ImageCodecInfo[] ConvertFromMemory(IntPtr memoryStart, int numCodecs) { }
}
