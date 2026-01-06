internal struct IndexField // TypeDefIndex: 12975
{
	// Fields
	public readonly DataColumn Column; // 0x0
	public readonly bool IsDescending; // 0x8

	// Methods

	// RVA: 0x1330BD0 Offset: 0x132F5D0 VA: 0x181330BD0
	internal void .ctor(DataColumn column, bool isDescending) { }

	// RVA: 0x209A120 Offset: 0x2098B20 VA: 0x18209A120
	public static bool op_Equality(IndexField if1, IndexField if2) { }

	// RVA: 0x2099FF0 Offset: 0x20989F0 VA: 0x182099FF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x209A0A0 Offset: 0x2098AA0 VA: 0x18209A0A0 Slot: 2
	public override int GetHashCode() { }
}
