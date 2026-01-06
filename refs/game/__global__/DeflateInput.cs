internal sealed class DeflateInput // TypeDefIndex: 17635
{
	// Fields
	[CompilerGenerated]
	private byte[] <Buffer>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <StartIndex>k__BackingField; // 0x1C

	// Properties
	internal byte[] Buffer { get; set; }
	internal int Count { get; set; }
	internal int StartIndex { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal byte[] get_Buffer() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	internal void set_Buffer(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	internal int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	internal void set_Count(int value) { }

	[CompilerGenerated]
	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	internal int get_StartIndex() { }

	[CompilerGenerated]
	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	internal void set_StartIndex(int value) { }

	// RVA: 0x21696B0 Offset: 0x21680B0 VA: 0x1821696B0
	internal void ConsumeBytes(int n) { }

	// RVA: 0x21696C0 Offset: 0x21680C0 VA: 0x1821696C0
	internal DeflateInput.InputState DumpState() { }

	// RVA: 0x21696E0 Offset: 0x21680E0 VA: 0x1821696E0
	internal void RestoreState(DeflateInput.InputState state) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
