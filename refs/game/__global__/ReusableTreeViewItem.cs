internal class ReusableTreeViewItem : ReusableCollectionItem // TypeDefIndex: 6205
{
	// Fields
	private Toggle m_Toggle; // 0x48
	private VisualElement m_Container; // 0x50
	private VisualElement m_IndentElement; // 0x58
	private VisualElement m_BindableContainer; // 0x60
	private VisualElement m_Checkmark; // 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<PointerUpEvent> onPointerUp; // 0x70
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<ChangeEvent<bool>> onToggleValueChanged; // 0x78
	private int m_Depth; // 0x80
	private float m_IndentWidth; // 0x84
	private EventCallback<PointerUpEvent> m_PointerUpCallback; // 0x88
	private EventCallback<ChangeEvent<bool>> m_ToggleValueChangedCallback; // 0x90
	private EventCallback<GeometryChangedEvent> m_ToggleGeometryChangedCallback; // 0x98

	// Properties
	public override VisualElement rootElement { get; }

	// Methods

	// RVA: 0x2DBC7E0 Offset: 0x2DBB1E0 VA: 0x182DBC7E0 Slot: 4
	public override VisualElement get_rootElement() { }

	[CompilerGenerated]
	// RVA: 0x2DBC680 Offset: 0x2DBB080 VA: 0x182DBC680
	public void add_onPointerUp(Action<PointerUpEvent> value) { }

	[CompilerGenerated]
	// RVA: 0x2DBC7F0 Offset: 0x2DBB1F0 VA: 0x182DBC7F0
	public void remove_onPointerUp(Action<PointerUpEvent> value) { }

	[CompilerGenerated]
	// RVA: 0x2DBC730 Offset: 0x2DBB130 VA: 0x182DBC730
	public void add_onToggleValueChanged(Action<ChangeEvent<bool>> value) { }

	[CompilerGenerated]
	// RVA: 0x2DBC8A0 Offset: 0x2DBB2A0 VA: 0x182DBC8A0
	public void remove_onToggleValueChanged(Action<ChangeEvent<bool>> value) { }

	// RVA: 0x2DBB930 Offset: 0x2DBA330 VA: 0x182DBB930
	public void .ctor() { }

	// RVA: 0x2DBC0B0 Offset: 0x2DBAAB0 VA: 0x182DBC0B0 Slot: 5
	public override void Init(VisualElement item) { }

	// RVA: 0x2DBBC30 Offset: 0x2DBA630 VA: 0x182DBBC30
	protected void InitExpandHierarchy(VisualElement root, VisualElement item) { }

	// RVA: 0x2DBC310 Offset: 0x2DBAD10 VA: 0x182DBC310 Slot: 6
	public override void PreAttachElement() { }

	// RVA: 0x2DBBA60 Offset: 0x2DBA460 VA: 0x182DBBA60 Slot: 7
	public override void DetachElement() { }

	// RVA: 0x2DBBC10 Offset: 0x2DBA610 VA: 0x182DBBC10
	public void Indent(int depth) { }

	// RVA: 0x2DBC4C0 Offset: 0x2DBAEC0 VA: 0x182DBC4C0
	public void SetExpandedWithoutNotify(bool expanded) { }

	// RVA: 0x2DBC4E0 Offset: 0x2DBAEE0 VA: 0x182DBC4E0
	public void SetToggleVisibility(bool visible) { }

	// RVA: 0x2DBC1C0 Offset: 0x2DBABC0 VA: 0x182DBC1C0
	private void OnToggleGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x2DBC500 Offset: 0x2DBAF00 VA: 0x182DBC500
	private void UpdateIndentLayout() { }

	// RVA: 0x2DBC1A0 Offset: 0x2DBABA0 VA: 0x182DBC1A0
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0xA81CB0 Offset: 0xA806B0 VA: 0x180A81CB0
	private void OnToggleValueChanged(ChangeEvent<bool> evt) { }
}
