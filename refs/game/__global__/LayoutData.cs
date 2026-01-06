internal struct LayoutData : IStyleDataGroup<LayoutData>, IEquatable<LayoutData> // TypeDefIndex: 6798
{
	// Fields
	public Align alignContent; // 0x0
	public Align alignItems; // 0x4
	public Align alignSelf; // 0x8
	public float borderBottomWidth; // 0xC
	public float borderLeftWidth; // 0x10
	public float borderRightWidth; // 0x14
	public float borderTopWidth; // 0x18
	public Length bottom; // 0x1C
	public DisplayStyle display; // 0x24
	public Length flexBasis; // 0x28
	public FlexDirection flexDirection; // 0x30
	public float flexGrow; // 0x34
	public float flexShrink; // 0x38
	public Wrap flexWrap; // 0x3C
	public Length height; // 0x40
	public Justify justifyContent; // 0x48
	public Length left; // 0x4C
	public Length marginBottom; // 0x54
	public Length marginLeft; // 0x5C
	public Length marginRight; // 0x64
	public Length marginTop; // 0x6C
	public Length maxHeight; // 0x74
	public Length maxWidth; // 0x7C
	public Length minHeight; // 0x84
	public Length minWidth; // 0x8C
	public Length paddingBottom; // 0x94
	public Length paddingLeft; // 0x9C
	public Length paddingRight; // 0xA4
	public Length paddingTop; // 0xAC
	public Position position; // 0xB4
	public Length right; // 0xB8
	public Length top; // 0xC0
	public Length width; // 0xC8

	// Methods

	// RVA: 0x2EFAB70 Offset: 0x2EF9570 VA: 0x182EFAB70 Slot: 4
	public LayoutData Copy() { }

	// RVA: 0x2EFAA60 Offset: 0x2EF9460 VA: 0x182EFAA60 Slot: 5
	public void CopyFrom(ref LayoutData other) { }

	// RVA: 0x2EFB190 Offset: 0x2EF9B90 VA: 0x182EFB190
	public static bool op_Equality(LayoutData lhs, LayoutData rhs) { }

	// RVA: 0x2EFAD20 Offset: 0x2EF9720 VA: 0x182EFAD20 Slot: 6
	public bool Equals(LayoutData other) { }

	// RVA: 0x2EFABF0 Offset: 0x2EF95F0 VA: 0x182EFABF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2EFAE50 Offset: 0x2EF9850 VA: 0x182EFAE50 Slot: 2
	public override int GetHashCode() { }
}
