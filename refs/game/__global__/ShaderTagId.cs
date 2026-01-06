public struct ShaderTagId : IEquatable<ShaderTagId> // TypeDefIndex: 12267
{
	// Fields
	public static readonly ShaderTagId none; // 0x0
	private int m_Id; // 0x0

	// Properties
	internal int id { get; set; }

	// Methods

	// RVA: 0x2CFCA60 Offset: 0x2CFB460 VA: 0x182CFCA60
	public void .ctor(string name) { }

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	internal int get_id() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	internal void set_id(int value) { }

	// RVA: 0x2CFC9B0 Offset: 0x2CFB3B0 VA: 0x182CFC9B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CC3DD0 Offset: 0x2CC27D0 VA: 0x182CC3DD0 Slot: 4
	public bool Equals(ShaderTagId other) { }

	// RVA: 0x2CFCA40 Offset: 0x2CFB440 VA: 0x182CFCA40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CC3F40 Offset: 0x2CC2940 VA: 0x182CC3F40
	public static bool op_Equality(ShaderTagId tag1, ShaderTagId tag2) { }

	// RVA: 0x2CEA9E0 Offset: 0x2CE93E0 VA: 0x182CEA9E0
	public static bool op_Inequality(ShaderTagId tag1, ShaderTagId tag2) { }
}
