internal struct RareData : IStyleDataGroup<RareData>, IEquatable<RareData> // TypeDefIndex: 6799
{
	// Fields
	public Cursor cursor; // 0x0
	public TextOverflow textOverflow; // 0x18
	public Color unityBackgroundImageTintColor; // 0x1C
	public OverflowClipBox unityOverflowClipBox; // 0x2C
	public int unitySliceBottom; // 0x30
	public int unitySliceLeft; // 0x34
	public int unitySliceRight; // 0x38
	public float unitySliceScale; // 0x3C
	public int unitySliceTop; // 0x40
	public TextOverflowPosition unityTextOverflowPosition; // 0x44

	// Methods

	// RVA: 0x2EFE740 Offset: 0x2EFD140 VA: 0x182EFE740 Slot: 4
	public RareData Copy() { }

	// RVA: 0x2EFE710 Offset: 0x2EFD110 VA: 0x182EFE710 Slot: 5
	public void CopyFrom(ref RareData other) { }

	// RVA: 0x2EFEAC0 Offset: 0x2EFD4C0 VA: 0x182EFEAC0
	public static bool op_Equality(RareData lhs, RareData rhs) { }

	// RVA: 0x2EFE830 Offset: 0x2EFD230 VA: 0x182EFE830 Slot: 6
	public bool Equals(RareData other) { }

	// RVA: 0x2EFE770 Offset: 0x2EFD170 VA: 0x182EFE770 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2EFEA30 Offset: 0x2EFD430 VA: 0x182EFEA30 Slot: 2
	public override int GetHashCode() { }
}
