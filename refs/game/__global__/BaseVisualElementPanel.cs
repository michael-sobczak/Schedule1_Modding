internal abstract class BaseVisualElementPanel : IPanel, IDisposable, IGroupBox // TypeDefIndex: 6725
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<BaseVisualElementPanel> panelDisposed; // 0x10
	private UIElementsBridge m_UIElementsBridge; // 0x18
	private float m_Scale; // 0x20
	internal YogaConfig yogaConfig; // 0x28
	private float m_PixelsPerPoint; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private float <referenceSpritePixelsPerUnit>k__BackingField; // 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private PanelClearSettings <clearSettings>k__BackingField; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <duringLayoutPhase>k__BackingField; // 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private RepaintData <repaintData>k__BackingField; // 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ICursorManager <cursorManager>k__BackingField; // 0x58
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ContextualMenuManager <contextualMenuManager>k__BackingField; // 0x60
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x68
	internal ElementUnderPointer m_TopElementUnderPointers; // 0x70
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action standardShaderChanged; // 0x78
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action standardWorldSpaceShaderChanged; // 0x80
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action atlasChanged; // 0x88
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<Material> updateMaterial; // 0x90
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private HierarchyEvent hierarchyChanged; // 0x98
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<IPanel> beforeUpdate; // 0xA0

	// Properties
	public abstract EventInterests IMGUIEventInterests { get; set; }
	public abstract ScriptableObject ownerObject { get; set; }
	public abstract SavePersistentViewData saveViewData { get; }
	public abstract GetViewDataDictionary getViewDataDictionary { get; }
	public abstract int IMGUIContainersCount { get; set; }
	public abstract FocusController focusController { get; set; }
	public abstract IMGUIContainer rootIMGUIContainer { get; }
	internal UIElementsBridge uiElementsBridge { get; }
	internal float scale { get; set; }
	internal float pixelsPerPoint { set; }
	public float scaledPixelsPerPoint { get; }
	public float referenceSpritePixelsPerUnit { get; set; }
	internal PanelClearSettings clearSettings { get; set; }
	internal bool duringLayoutPhase { get; set; }
	internal abstract uint version { get; }
	internal abstract uint hierarchyVersion { get; }
	internal virtual RepaintData repaintData { get; set; }
	internal virtual ICursorManager cursorManager { get; set; }
	public ContextualMenuManager contextualMenuManager { get; set; }
	public abstract VisualElement visualTree { get; }
	public abstract EventDispatcher dispatcher { get; set; }
	internal abstract IScheduler scheduler { get; }
	internal abstract IStylePropertyAnimationSystem styleAnimationSystem { get; set; }
	public abstract ContextType contextType { get; set; }
	internal bool disposed { get; set; }
	internal abstract Shader standardShader { get; }
	internal virtual Shader standardWorldSpaceShader { get; }
	public abstract AtlasBase atlas { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public abstract EventInterests get_IMGUIEventInterests();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_IMGUIEventInterests(EventInterests value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract ScriptableObject get_ownerObject();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void set_ownerObject(ScriptableObject value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract SavePersistentViewData get_saveViewData();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract GetViewDataDictionary get_getViewDataDictionary();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int get_IMGUIContainersCount();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void set_IMGUIContainersCount(int value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract FocusController get_focusController();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void set_focusController(FocusController value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IMGUIContainer get_rootIMGUIContainer();

	[CompilerGenerated]
	// RVA: 0x2EA01F0 Offset: 0x2E9EBF0 VA: 0x182EA01F0
	internal void add_panelDisposed(Action<BaseVisualElementPanel> value) { }

	[CompilerGenerated]
	// RVA: 0x2EA0600 Offset: 0x2E9F000 VA: 0x182EA0600
	internal void remove_panelDisposed(Action<BaseVisualElementPanel> value) { }

	// RVA: 0x2EA0430 Offset: 0x2E9EE30 VA: 0x182EA0430
	internal UIElementsBridge get_uiElementsBridge() { }

	// RVA: 0x2E9FF30 Offset: 0x2E9E930 VA: 0x182E9FF30
	protected void .ctor() { }

	// RVA: 0x2E9F760 Offset: 0x2E9E160 VA: 0x182E9F760 Slot: 9
	public void Dispose() { }

	// RVA: 0x2E9F7D0 Offset: 0x2E9E1D0 VA: 0x182E9F7D0 Slot: 23
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void Repaint(Event e);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void ValidateFocus();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void ValidateLayout();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void UpdateAnimations();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void UpdateBindings();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void ApplyStyles();

	// RVA: 0x2EA0410 Offset: 0x2E9EE10 VA: 0x182EA0410
	internal float get_scale() { }

	// RVA: 0x2EA08C0 Offset: 0x2E9F2C0 VA: 0x182EA08C0
	internal void set_scale(float value) { }

	// RVA: 0x2EA0810 Offset: 0x2E9F210 VA: 0x182EA0810
	internal void set_pixelsPerPoint(float value) { }

	// RVA: 0x2EA0420 Offset: 0x2E9EE20 VA: 0x182EA0420
	public float get_scaledPixelsPerPoint() { }

	[CompilerGenerated]
	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250
	public float get_referenceSpritePixelsPerUnit() { }

	[CompilerGenerated]
	// RVA: 0x8928D0 Offset: 0x8912D0 VA: 0x1808928D0
	public void set_referenceSpritePixelsPerUnit(float value) { }

	[CompilerGenerated]
	// RVA: 0x2EA03F0 Offset: 0x2E9EDF0 VA: 0x182EA03F0
	internal PanelClearSettings get_clearSettings() { }

	[CompilerGenerated]
	// RVA: 0x2EA0800 Offset: 0x2E9F200 VA: 0x182EA0800
	internal void set_clearSettings(PanelClearSettings value) { }

	[CompilerGenerated]
	// RVA: 0x4B5BF0 Offset: 0x4B45F0 VA: 0x1804B5BF0
	internal bool get_duringLayoutPhase() { }

	[CompilerGenerated]
	// RVA: 0xAEE590 Offset: 0xAECF90 VA: 0x180AEE590
	internal void set_duringLayoutPhase(bool value) { }

	// RVA: -1 Offset: -1 Slot: 30
	internal abstract uint get_version();

	// RVA: -1 Offset: -1 Slot: 31
	internal abstract uint get_hierarchyVersion();

	// RVA: -1 Offset: -1 Slot: 32
	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag);

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 33
	internal virtual RepaintData get_repaintData() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0 Slot: 34
	internal virtual void set_repaintData(RepaintData value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0 Slot: 35
	internal virtual ICursorManager get_cursorManager() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0 Slot: 36
	internal virtual void set_cursorManager(ICursorManager value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0 Slot: 37
	public ContextualMenuManager get_contextualMenuManager() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	internal void set_contextualMenuManager(ContextualMenuManager value) { }

	// RVA: -1 Offset: -1 Slot: 38
	public abstract VisualElement get_visualTree();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract EventDispatcher get_dispatcher();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract void set_dispatcher(EventDispatcher value);

	// RVA: 0x2E9FAF0 Offset: 0x2E9E4F0 VA: 0x182E9FAF0
	internal void SendEvent(EventBase e, DispatchMode dispatchMode = 1) { }

	// RVA: -1 Offset: -1 Slot: 41
	internal abstract IScheduler get_scheduler();

	// RVA: -1 Offset: -1 Slot: 42
	internal abstract IStylePropertyAnimationSystem get_styleAnimationSystem();

	// RVA: -1 Offset: -1 Slot: 43
	internal abstract void set_styleAnimationSystem(IStylePropertyAnimationSystem value);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract ContextType get_contextType();

	// RVA: -1 Offset: -1 Slot: 45
	protected abstract void set_contextType(ContextType value);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract VisualElement Pick(Vector2 point);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract VisualElement PickAll(Vector2 point, List<VisualElement> picked);

	[CompilerGenerated]
	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	internal bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0xCE3E20 Offset: 0xCE2820 VA: 0x180CE3E20
	private void set_disposed(bool value) { }

	// RVA: -1 Offset: -1 Slot: 48
	internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase);

	// RVA: 0x2E9F910 Offset: 0x2E9E310 VA: 0x182E9F910
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0x2E9F9C0 Offset: 0x2E9E3C0 VA: 0x182E9F9C0
	internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent) { }

	// RVA: 0x2E9F670 Offset: 0x2E9E070 VA: 0x182E9F670
	internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent) { }

	// RVA: 0x2E9F6A0 Offset: 0x2E9E0A0 VA: 0x182E9F6A0
	internal void CommitElementUnderPointers() { }

	// RVA: -1 Offset: -1 Slot: 49
	internal abstract Shader get_standardShader();

	// RVA: 0x1102840 Offset: 0x1101240 VA: 0x181102840 Slot: 50
	internal virtual Shader get_standardWorldSpaceShader() { }

	[CompilerGenerated]
	// RVA: 0x2EA02A0 Offset: 0x2E9ECA0 VA: 0x182EA02A0
	internal void add_standardShaderChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2EA06B0 Offset: 0x2E9F0B0 VA: 0x182EA06B0
	internal void remove_standardShaderChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2EA0340 Offset: 0x2E9ED40 VA: 0x182EA0340
	internal void add_standardWorldSpaceShaderChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2EA0750 Offset: 0x2E9F150 VA: 0x182EA0750
	internal void remove_standardWorldSpaceShaderChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2EA0090 Offset: 0x2E9EA90 VA: 0x182EA0090
	internal void add_atlasChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2EA04A0 Offset: 0x2E9EEA0 VA: 0x182EA04A0
	internal void remove_atlasChanged(Action value) { }

	// RVA: 0x2E9F930 Offset: 0x2E9E330 VA: 0x182E9F930
	protected void InvokeAtlasChanged() { }

	// RVA: -1 Offset: -1 Slot: 51
	public abstract AtlasBase get_atlas();

	// RVA: -1 Offset: -1 Slot: 52
	public abstract void set_atlas(AtlasBase value);

	// RVA: 0x2E9F9A0 Offset: 0x2E9E3A0 VA: 0x182E9F9A0
	internal void InvokeUpdateMaterial(Material mat) { }

	[CompilerGenerated]
	// RVA: 0x2EA0140 Offset: 0x2E9EB40 VA: 0x182EA0140
	internal void add_hierarchyChanged(HierarchyEvent value) { }

	[CompilerGenerated]
	// RVA: 0x2EA0550 Offset: 0x2E9EF50 VA: 0x182EA0550
	internal void remove_hierarchyChanged(HierarchyEvent value) { }

	// RVA: 0x2E9F970 Offset: 0x2E9E370 VA: 0x182E9F970
	internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) { }

	// RVA: 0x2E9F950 Offset: 0x2E9E350 VA: 0x182E9F950
	internal void InvokeBeforeUpdate() { }

	// RVA: 0x2E9FBB0 Offset: 0x2E9E5B0 VA: 0x182E9FBB0
	internal void UpdateElementUnderPointers() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	private void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	private void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	// RVA: 0x2E9F710 Offset: 0x2E9E110 VA: 0x182E9F710 Slot: 53
	internal virtual IGenericMenu CreateMenu() { }

	// RVA: 0x2E9FE70 Offset: 0x2E9E870 VA: 0x182E9FE70 Slot: 54
	public virtual void Update() { }
}
