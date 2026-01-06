public class TreeView : BaseTreeView // TypeDefIndex: 6427
{
	// Fields
	private Func<VisualElement> m_MakeItem; // 0x4D0
	private Action<VisualElement, int> m_BindItem; // 0x4D8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<VisualElement, int> <unbindItem>k__BackingField; // 0x4E0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<VisualElement> <destroyItem>k__BackingField; // 0x4E8

	// Properties
	public Func<VisualElement> makeItem { get; set; }
	public Action<VisualElement, int> bindItem { get; set; }
	public Action<VisualElement, int> unbindItem { get; }
	public Action<VisualElement> destroyItem { get; }

	// Methods

	// RVA: 0x2E69C50 Offset: 0x2E68650 VA: 0x182E69C50
	public Func<VisualElement> get_makeItem() { }

	// RVA: 0x2E7E820 Offset: 0x2E7D220 VA: 0x182E7E820
	public void set_makeItem(Func<VisualElement> value) { }

	// RVA: 0x2E7E7A0 Offset: 0x2E7D1A0 VA: 0x182E7E7A0
	public Action<VisualElement, int> get_bindItem() { }

	// RVA: 0x2E7E7C0 Offset: 0x2E7D1C0 VA: 0x182E7E7C0
	public void set_bindItem(Action<VisualElement, int> value) { }

	[CompilerGenerated]
	// RVA: 0x28171B0 Offset: 0x2815BB0 VA: 0x1828171B0
	public Action<VisualElement, int> get_unbindItem() { }

	[CompilerGenerated]
	// RVA: 0x2E7E7B0 Offset: 0x2E7D1B0 VA: 0x182E7E7B0
	public Action<VisualElement> get_destroyItem() { }

	// RVA: 0x2E7E5B0 Offset: 0x2E7CFB0 VA: 0x182E7E5B0 Slot: 109
	internal override bool HasValidDataAndBindings() { }

	// RVA: 0x2E7E550 Offset: 0x2E7CF50 VA: 0x182E7E550 Slot: 105
	protected override CollectionViewController CreateViewController() { }

	// RVA: 0x2E7E5F0 Offset: 0x2E7CFF0 VA: 0x182E7E5F0
	public void .ctor() { }

	// RVA: 0x2E7E6C0 Offset: 0x2E7D0C0 VA: 0x182E7E6C0
	public void .ctor(Func<VisualElement> makeItem, Action<VisualElement, int> bindItem) { }
}
