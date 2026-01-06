public class NNConstraint // TypeDefIndex: 13113
{
	// Fields
	public GraphMask graphMask; // 0x10
	public bool constrainArea; // 0x14
	public int area; // 0x18
	public bool constrainWalkability; // 0x1C
	public bool walkable; // 0x1D
	public bool distanceXZ; // 0x1E
	public bool constrainTags; // 0x1F
	public int tags; // 0x20
	public bool constrainDistance; // 0x24

	// Properties
	public static NNConstraint Default { get; }
	public static NNConstraint None { get; }

	// Methods

	// RVA: 0xB0F260 Offset: 0xB0DC60 VA: 0x180B0F260 Slot: 4
	public virtual bool SuitableGraph(int graphIndex, NavGraph graph) { }

	// RVA: 0xB0F280 Offset: 0xB0DC80 VA: 0x180B0F280 Slot: 5
	public virtual bool Suitable(GraphNode node) { }

	// RVA: 0xB0F350 Offset: 0xB0DD50 VA: 0x180B0F350
	public static NNConstraint get_Default() { }

	// RVA: 0xB0F3C0 Offset: 0xB0DDC0 VA: 0x180B0F3C0
	public static NNConstraint get_None() { }

	// RVA: 0xB0F320 Offset: 0xB0DD20 VA: 0x180B0F320
	public void .ctor() { }
}
