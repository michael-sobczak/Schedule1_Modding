internal class ByteBuffer // TypeDefIndex: 12826
{
	// Fields
	[CompilerGenerated]
	private byte[] <Data>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Length>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <Size>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <HasData>k__BackingField; // 0x20
	private int _reserve; // 0x24

	// Properties
	internal int Remaining { get; }
	internal byte[] Data { get; set; }
	internal int Length { get; set; }
	internal int Size { get; set; }
	internal bool HasData { get; set; }

	// Methods

	// RVA: 0xCF7290 Offset: 0xCF5C90 VA: 0x180CF7290
	internal int get_Remaining() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal byte[] get_Data() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_Data(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	internal int get_Length() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	private void set_Length(int value) { }

	[CompilerGenerated]
	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	internal int get_Size() { }

	[CompilerGenerated]
	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	private void set_Size(int value) { }

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	internal bool get_HasData() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_HasData(bool value) { }

	// RVA: 0xD90AF0 Offset: 0xD8F4F0 VA: 0x180D90AF0
	internal void .ctor(int size, int reserve = 0) { }

	// RVA: 0xD90A60 Offset: 0xD8F460 VA: 0x180D90A60
	public void Dispose() { }

	// RVA: 0xD90AE0 Offset: 0xD8F4E0 VA: 0x180D90AE0
	internal void Reset() { }

	// RVA: 0xD908C0 Offset: 0xD8F2C0 VA: 0x180D908C0
	internal void CopySegment(uint tick, ArraySegment<byte> segment) { }

	// RVA: 0xD909C0 Offset: 0xD8F3C0 VA: 0x180D909C0
	internal void CopySegment(ArraySegment<byte> segment) { }
}
