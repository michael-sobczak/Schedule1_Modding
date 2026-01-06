internal struct TextureId // TypeDefIndex: 6756
{
	// Fields
	private readonly int m_Index; // 0x0
	public static readonly TextureId invalid; // 0x0

	// Properties
	public int index { get; }

	// Methods

	// RVA: 0x2EE17C0 Offset: 0x2EE01C0 VA: 0x182EE17C0
	public void .ctor(int index) { }

	// RVA: 0x2EE17D0 Offset: 0x2EE01D0 VA: 0x182EE17D0
	public int get_index() { }

	// RVA: 0x2EE1690 Offset: 0x2EE0090 VA: 0x182EE1690
	public float ConvertToGpu() { }

	// RVA: 0x2EE16E0 Offset: 0x2EE00E0 VA: 0x182EE16E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CD53B0 Offset: 0x2CD3DB0 VA: 0x182CD53B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CC3F40 Offset: 0x2CC2940 VA: 0x182CC3F40
	public static bool op_Equality(TextureId left, TextureId right) { }

	// RVA: 0x2EE17E0 Offset: 0x2EE01E0 VA: 0x182EE17E0
	public static bool op_Inequality(TextureId left, TextureId right) { }

	// RVA: 0x2EE1780 Offset: 0x2EE0180 VA: 0x182EE1780
	private static void .cctor() { }
}
