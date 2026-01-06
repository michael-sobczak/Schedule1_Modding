internal class ReusableCollectionItem // TypeDefIndex: 6201
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VisualElement <bindableElement>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ValueAnimation<StyleValues> <animator>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <index>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <id>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <isDragGhost>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<ReusableCollectionItem> onGeometryChanged; // 0x30
	protected EventCallback<GeometryChangedEvent> m_GeometryChangedEventCallback; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<ReusableCollectionItem> onDestroy; // 0x40

	// Properties
	public virtual VisualElement rootElement { get; }
	public VisualElement bindableElement { get; set; }
	public ValueAnimation<StyleValues> animator { get; set; }
	public int index { get; set; }
	public int id { get; set; }
	internal bool isDragGhost { get; set; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 4
	public virtual VisualElement get_rootElement() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public VisualElement get_bindableElement() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	protected void set_bindableElement(VisualElement value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public ValueAnimation<StyleValues> get_animator() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_animator(ValueAnimation<StyleValues> value) { }

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_index() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_index(int value) { }

	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_id() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_id(int value) { }

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	internal bool get_isDragGhost() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	private void set_isDragGhost(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2DBAB70 Offset: 0x2DB9570 VA: 0x182DBAB70
	public void add_onGeometryChanged(Action<ReusableCollectionItem> value) { }

	[CompilerGenerated]
	// RVA: 0x2DBACD0 Offset: 0x2DB96D0 VA: 0x182DBACD0
	public void remove_onGeometryChanged(Action<ReusableCollectionItem> value) { }

	[CompilerGenerated]
	// RVA: 0x2DBAAC0 Offset: 0x2DB94C0 VA: 0x182DBAAC0
	internal void add_onDestroy(Action<ReusableCollectionItem> value) { }

	[CompilerGenerated]
	// RVA: 0x2DBAC20 Offset: 0x2DB9620 VA: 0x182DBAC20
	internal void remove_onDestroy(Action<ReusableCollectionItem> value) { }

	// RVA: 0x2DBAA30 Offset: 0x2DB9430 VA: 0x182DBAA30
	public void .ctor() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0 Slot: 5
	public virtual void Init(VisualElement item) { }

	// RVA: 0x2DBA620 Offset: 0x2DB9020 VA: 0x182DBA620 Slot: 6
	public virtual void PreAttachElement() { }

	// RVA: 0x2DBA4D0 Offset: 0x2DB8ED0 VA: 0x182DBA4D0 Slot: 7
	public virtual void DetachElement() { }

	// RVA: 0x2DBA4B0 Offset: 0x2DB8EB0 VA: 0x182DBA4B0 Slot: 8
	public virtual void DestroyElement() { }

	// RVA: 0x2DBA8F0 Offset: 0x2DB92F0 VA: 0x182DBA8F0 Slot: 9
	public virtual void SetSelected(bool selected) { }

	// RVA: 0x2DBA6F0 Offset: 0x2DB90F0 VA: 0x182DBA6F0 Slot: 10
	public virtual void SetDragGhost(bool dragGhost) { }

	// RVA: 0x2DBA600 Offset: 0x2DB9000 VA: 0x182DBA600
	protected void OnGeometryChanged(GeometryChangedEvent evt) { }
}
