public class DataFormats // TypeDefIndex: 5307
{
	// Fields
	public static readonly string Bitmap; // 0x0
	public static readonly string CommaSeparatedValue; // 0x8
	public static readonly string Dib; // 0x10
	public static readonly string Dif; // 0x18
	public static readonly string EnhancedMetafile; // 0x20
	public static readonly string FileDrop; // 0x28
	public static readonly string Html; // 0x30
	public static readonly string Locale; // 0x38
	public static readonly string MetafilePict; // 0x40
	public static readonly string OemText; // 0x48
	public static readonly string Palette; // 0x50
	public static readonly string PenData; // 0x58
	public static readonly string Riff; // 0x60
	public static readonly string Rtf; // 0x68
	public static readonly string Serializable; // 0x70
	public static readonly string StringFormat; // 0x78
	public static readonly string SymbolicLink; // 0x80
	public static readonly string Text; // 0x88
	public static readonly string Tiff; // 0x90
	public static readonly string UnicodeText; // 0x98
	public static readonly string WaveAudio; // 0xA0
	private static object lock_object; // 0xA8
	private static bool initialized; // 0xB0

	// Methods

	// RVA: 0x2314600 Offset: 0x2313000 VA: 0x182314600
	private static void .cctor() { }

	// RVA: 0x2313BD0 Offset: 0x23125D0 VA: 0x182313BD0
	internal static bool ContainsFormat(int id) { }

	// RVA: 0x2313E70 Offset: 0x2312870 VA: 0x182313E70
	public static DataFormats.Format GetFormat(int id) { }

	// RVA: 0x2313D40 Offset: 0x2312740 VA: 0x182313D40
	public static DataFormats.Format GetFormat(string format) { }

	// RVA: 0x2313FE0 Offset: 0x23129E0 VA: 0x182313FE0
	private static void Init() { }
}
