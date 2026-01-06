public sealed class Icon : MarshalByRefObject, ISerializable, ICloneable, IDisposable // TypeDefIndex: 17154
{
	// Fields
	private Size iconSize; // 0x18
	private IntPtr handle; // 0x20
	private Icon.IconDir iconDir; // 0x28
	private ushort id; // 0x38
	private Icon.ImageData[] imageData; // 0x40
	private bool undisposable; // 0x48
	private bool disposed; // 0x49
	private Bitmap bitmap; // 0x50

	// Properties
	[Browsable(False)]
	public IntPtr Handle { get; }
	[Browsable(False)]
	public int Height { get; }
	public Size Size { get; }
	[Browsable(False)]
	public int Width { get; }

	// Methods

	// RVA: 0x2144760 Offset: 0x2143160 VA: 0x182144760
	private void .ctor() { }

	// RVA: 0x21449E0 Offset: 0x21433E0 VA: 0x1821449E0
	private void .ctor(IntPtr handle) { }

	// RVA: 0x2144BF0 Offset: 0x21435F0 VA: 0x182144BF0
	public void .ctor(Icon original, Size size) { }

	// RVA: 0x21452A0 Offset: 0x2143CA0 VA: 0x1821452A0
	public void .ctor(Stream stream) { }

	// RVA: 0x2144980 Offset: 0x2143380 VA: 0x182144980
	public void .ctor(Stream stream, int width, int height) { }

	// RVA: 0x2145070 Offset: 0x2143A70 VA: 0x182145070
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2144770 Offset: 0x2143170 VA: 0x182144770
	internal void .ctor(string resourceName, bool undisposable) { }

	// RVA: 0x2144480 Offset: 0x2142E80 VA: 0x182144480 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x21420A0 Offset: 0x2140AA0 VA: 0x1821420A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x2142030 Offset: 0x2140A30 VA: 0x182142030 Slot: 7
	public object Clone() { }

	// RVA: 0x21422E0 Offset: 0x2140CE0 VA: 0x1821422E0
	public static Icon FromHandle(IntPtr handle) { }

	// RVA: 0x2144090 Offset: 0x2142A90 VA: 0x182144090
	private void SaveIconImage(BinaryWriter writer, Icon.IconImage ii) { }

	// RVA: 0x2144050 Offset: 0x2142A50 VA: 0x182144050
	private void SaveIconDump(BinaryWriter writer, Icon.IconDump id) { }

	// RVA: 0x2143F20 Offset: 0x2142920 VA: 0x182143F20
	private void SaveIconDirEntry(BinaryWriter writer, Icon.IconDirEntry ide, uint offset) { }

	// RVA: 0x2143380 Offset: 0x2141D80 VA: 0x182143380
	private void SaveAll(BinaryWriter writer) { }

	// RVA: 0x2143790 Offset: 0x2142190 VA: 0x182143790
	private void SaveBestSingleIcon(BinaryWriter writer, int width, int height) { }

	// RVA: 0x2143A50 Offset: 0x2142450 VA: 0x182143A50
	private void SaveBitmapAsIcon(BinaryWriter writer) { }

	// RVA: 0x2144390 Offset: 0x2142D90 VA: 0x182144390
	private void Save(Stream outputStream, int width, int height) { }

	// RVA: 0x2144310 Offset: 0x2142D10 VA: 0x182144310
	public void Save(Stream outputStream) { }

	// RVA: 0x2141830 Offset: 0x2140230 VA: 0x182141830
	internal Bitmap BuildBitmapOnWin32() { }

	// RVA: 0x2142390 Offset: 0x2140D90 VA: 0x182142390
	internal Bitmap GetInternalBitmap() { }

	// RVA: 0x2144630 Offset: 0x2143030 VA: 0x182144630
	public Bitmap ToBitmap() { }

	// RVA: 0x2144730 Offset: 0x2143130 VA: 0x182144730 Slot: 3
	public override string ToString() { }

	// RVA: 0x21452F0 Offset: 0x2143CF0 VA: 0x1821452F0
	public IntPtr get_Handle() { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_Height() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Size get_Size() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Width() { }

	// RVA: 0x21421A0 Offset: 0x2140BA0 VA: 0x1821421A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2142570 Offset: 0x2140F70 VA: 0x182142570
	private void InitFromStreamWithSize(Stream stream, int width, int height) { }
}
