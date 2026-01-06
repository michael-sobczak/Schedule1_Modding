public struct ProfilerCategory // TypeDefIndex: 11489
{
	// Fields
	private readonly ushort m_CategoryId; // 0x0

	// Properties
	public string Name { get; }
	public static ProfilerCategory Scripts { get; }

	// Methods

	// RVA: 0xC81A60 Offset: 0xC80460 VA: 0x180C81A60
	internal void .ctor(ushort category) { }

	// RVA: 0x2C99B10 Offset: 0x2C98510 VA: 0x182C99B10
	public string get_Name() { }

	// RVA: 0x2C99B00 Offset: 0x2C98500 VA: 0x182C99B00 Slot: 3
	public override string ToString() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50
	public static ProfilerCategory get_Scripts() { }

	// RVA: 0x2C99C40 Offset: 0x2C98640 VA: 0x182C99C40
	public static ushort op_Implicit(ProfilerCategory category) { }
}
