public sealed class FrameDimension // TypeDefIndex: 17209
{
	// Fields
	private static FrameDimension s_time; // 0x0
	private static FrameDimension s_resolution; // 0x8
	private static FrameDimension s_page; // 0x10
	private Guid _guid; // 0x10

	// Properties
	public Guid Guid { get; }
	public static FrameDimension Time { get; }

	// Methods

	// RVA: 0x1086450 Offset: 0x1084E50 VA: 0x181086450
	public void .ctor(Guid guid) { }

	// RVA: 0x49CD30 Offset: 0x49B730 VA: 0x18049CD30
	public Guid get_Guid() { }

	// RVA: 0x21509D0 Offset: 0x214F3D0 VA: 0x1821509D0
	public static FrameDimension get_Time() { }

	// RVA: 0x2150660 Offset: 0x214F060 VA: 0x182150660 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x21506F0 Offset: 0x214F0F0 VA: 0x1821506F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2150700 Offset: 0x214F100 VA: 0x182150700 Slot: 3
	public override string ToString() { }

	// RVA: 0x2150840 Offset: 0x214F240 VA: 0x182150840
	private static void .cctor() { }
}
