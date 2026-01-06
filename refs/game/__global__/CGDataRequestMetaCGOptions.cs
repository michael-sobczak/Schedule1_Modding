public class CGDataRequestMetaCGOptions : CGDataRequestParameter // TypeDefIndex: 10614
{
	// Fields
	[Obsolete("This option is now always assumed to be true")]
	[UsedImplicitly]
	public bool CheckHardEdges; // 0x10
	[Obsolete("This option is now always assumed to be true")]
	[UsedImplicitly]
	public bool CheckMaterialID; // 0x11
	public bool IncludeControlPoints; // 0x12
	[Obsolete("This option is now always assumed to be true")]
	[UsedImplicitly]
	public bool CheckExtendedUV; // 0x13

	// Methods

	// RVA: 0x4D7650 Offset: 0x4D6050 VA: 0x1804D7650
	public void .ctor(bool checkEdges, bool checkMaterials, bool includeCP, bool extendedUV) { }

	// RVA: 0x4D7130 Offset: 0x4D5B30 VA: 0x1804D7130 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4D71D0 Offset: 0x4D5BD0 VA: 0x1804D71D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4D72A0 Offset: 0x4D5CA0 VA: 0x1804D72A0 Slot: 3
	public override string ToString() { }
}
