internal class ForwardAxis // TypeDefIndex: 8237
{
	// Fields
	private DoubleLinkAxis _topNode; // 0x10
	private DoubleLinkAxis _rootNode; // 0x18
	private bool _isAttribute; // 0x20
	private bool _isDss; // 0x21
	private bool _isSelfAxis; // 0x22

	// Properties
	internal DoubleLinkAxis RootNode { get; }
	internal DoubleLinkAxis TopNode { get; }
	internal bool IsAttribute { get; }
	internal bool IsDss { get; }
	internal bool IsSelfAxis { get; }

	// Methods

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal DoubleLinkAxis get_RootNode() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal DoubleLinkAxis get_TopNode() { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	internal bool get_IsAttribute() { }

	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	internal bool get_IsDss() { }

	// RVA: 0x563D70 Offset: 0x562770 VA: 0x180563D70
	internal bool get_IsSelfAxis() { }

	// RVA: 0x2564290 Offset: 0x2562C90 VA: 0x182564290
	public void .ctor(DoubleLinkAxis axis, bool isdesorself) { }
}
