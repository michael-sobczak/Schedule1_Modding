public class PolyNode // TypeDefIndex: 18126
{
	// Fields
	internal PolyNode m_Parent; // 0x10
	internal List<IntPoint> m_polygon; // 0x18
	internal int m_Index; // 0x20
	internal List<PolyNode> m_Childs; // 0x28
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x30

	// Properties
	public int ChildCount { get; }
	public List<IntPoint> Contour { get; }
	public List<PolyNode> Childs { get; }
	public PolyNode Parent { get; }
	public bool IsHole { get; }
	public bool IsOpen { get; set; }

	// Methods

	// RVA: 0x1E2CF80 Offset: 0x1E2B980 VA: 0x181E2CF80
	public void .ctor() { }

	// RVA: 0xC41750 Offset: 0xC40150 VA: 0x180C41750
	private bool IsHoleNode() { }

	// RVA: 0x1E2D040 Offset: 0x1E2BA40 VA: 0x181E2D040
	public int get_ChildCount() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public List<IntPoint> get_Contour() { }

	// RVA: 0x1E2CDA0 Offset: 0x1E2B7A0 VA: 0x181E2CDA0
	internal void AddChild(PolyNode Child) { }

	// RVA: 0x1E2CF10 Offset: 0x1E2B910 VA: 0x181E2CF10
	public PolyNode GetNext() { }

	// RVA: 0x1E2CE80 Offset: 0x1E2B880 VA: 0x181E2CE80
	internal PolyNode GetNextSiblingUp() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public List<PolyNode> get_Childs() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public PolyNode get_Parent() { }

	// RVA: 0xC41750 Offset: 0xC40150 VA: 0x180C41750
	public bool get_IsHole() { }

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	public void set_IsOpen(bool value) { }
}
