public struct NNInfo // TypeDefIndex: 13116
{
	// Fields
	public readonly GraphNode node; // 0x0
	public readonly Vector3 position; // 0x8

	// Properties
	[Obsolete("This field has been renamed to 'position'")]
	public Vector3 clampedPosition { get; }

	// Methods

	// RVA: 0xB0F630 Offset: 0xB0E030 VA: 0x180B0F630
	public Vector3 get_clampedPosition() { }

	// RVA: 0xB0F5F0 Offset: 0xB0DFF0 VA: 0x180B0F5F0
	public void .ctor(NNInfoInternal internalInfo) { }

	// RVA: 0xB0F630 Offset: 0xB0E030 VA: 0x180B0F630
	public static Vector3 op_Explicit(NNInfo ob) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public static GraphNode op_Explicit(NNInfo ob) { }
}
