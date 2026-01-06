internal struct FrameRate : IEquatable<FrameRate> // TypeDefIndex: 12292
{
	// Fields
	[Ignore]
	public static readonly FrameRate k_24Fps; // 0x0
	[Ignore]
	public static readonly FrameRate k_23_976Fps; // 0x4
	[Ignore]
	public static readonly FrameRate k_25Fps; // 0x8
	[Ignore]
	public static readonly FrameRate k_30Fps; // 0xC
	[Ignore]
	public static readonly FrameRate k_29_97Fps; // 0x10
	[Ignore]
	public static readonly FrameRate k_50Fps; // 0x14
	[Ignore]
	public static readonly FrameRate k_60Fps; // 0x18
	[Ignore]
	public static readonly FrameRate k_59_94Fps; // 0x1C
	[SerializeField]
	private int m_Rate; // 0x0

	// Properties
	public bool dropFrame { get; }
	public double rate { get; }

	// Methods

	// RVA: 0x1CD9900 Offset: 0x1CD8300 VA: 0x181CD9900
	public bool get_dropFrame() { }

	// RVA: 0x2CEFD10 Offset: 0x2CEE710 VA: 0x182CEFD10
	public double get_rate() { }

	// RVA: 0x2CEFCF0 Offset: 0x2CEE6F0 VA: 0x182CEFCF0
	public void .ctor(uint frameRate = 0, bool drop = False) { }

	// RVA: 0x2CEF9C0 Offset: 0x2CEE3C0 VA: 0x182CEF9C0
	public bool IsValid() { }

	// RVA: 0x2CC3DD0 Offset: 0x2CC27D0 VA: 0x182CC3DD0 Slot: 4
	public bool Equals(FrameRate other) { }

	// RVA: 0x2CEF920 Offset: 0x2CEE320 VA: 0x182CEF920 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CEFD80 Offset: 0x2CEE780 VA: 0x182CEFD80
	public static bool op_Equality(FrameRate a, FrameRate b) { }

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CEFBD0 Offset: 0x2CEE5D0 VA: 0x182CEFBD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CEF9D0 Offset: 0x2CEE3D0 VA: 0x182CEF9D0
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2CEF7D0 Offset: 0x2CEE1D0 VA: 0x182CEF7D0
	internal static FrameRate DoubleToFrameRate(double framerate) { }

	// RVA: 0x2CEFC20 Offset: 0x2CEE620 VA: 0x182CEFC20
	private static void .cctor() { }
}
