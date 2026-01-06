public class ListView : BaseListView // TypeDefIndex: 6343
{
	// Fields
	private Func<VisualElement> m_MakeItem; // 0x550
	private Action<VisualElement, int> m_BindItem; // 0x558
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<VisualElement, int> <unbindItem>k__BackingField; // 0x560
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<VisualElement> <destroyItem>k__BackingField; // 0x568

	// Properties
	public Func<VisualElement> makeItem { get; }
	public Action<VisualElement, int> bindItem { get; }
	public Action<VisualElement, int> unbindItem { get; }
	public Action<VisualElement> destroyItem { get; }

	// Methods

	// RVA: 0x2E62EC0 Offset: 0x2E618C0 VA: 0x182E62EC0
	public Func<VisualElement> get_makeItem() { }

	// RVA: 0x2E62EA0 Offset: 0x2E618A0 VA: 0x182E62EA0
	public Action<VisualElement, int> get_bindItem() { }

	[CompilerGenerated]
	// RVA: 0x2E62ED0 Offset: 0x2E618D0 VA: 0x182E62ED0
	public Action<VisualElement, int> get_unbindItem() { }

	[CompilerGenerated]
	// RVA: 0x2E62EB0 Offset: 0x2E618B0 VA: 0x182E62EB0
	public Action<VisualElement> get_destroyItem() { }

	// RVA: 0x2E62DF0 Offset: 0x2E617F0 VA: 0x182E62DF0 Slot: 109
	internal override bool HasValidDataAndBindings() { }

	// RVA: 0x2E62DA0 Offset: 0x2E617A0 VA: 0x182E62DA0 Slot: 105
	protected override CollectionViewController CreateViewController() { }

	// RVA: 0x2E62E30 Offset: 0x2E61830 VA: 0x182E62E30
	public void .ctor() { }
}
