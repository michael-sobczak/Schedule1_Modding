public class IMGUIContainer : VisualElement, IDisposable // TypeDefIndex: 6694
{
	// Fields
	private Action m_OnGUIHandler; // 0x3C8
	private ObjectGUIState m_ObjectGUIState; // 0x3D0
	internal bool useOwnerObjectGUIState; // 0x3D8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Rect <lastWorldClip>k__BackingField; // 0x3DC
	private bool m_CullingEnabled; // 0x3EC
	private bool m_IsFocusDelegated; // 0x3ED
	private bool m_RefreshCachedLayout; // 0x3EE
	private GUILayoutUtility.LayoutCache m_Cache; // 0x3F0
	private Rect m_CachedClippingRect; // 0x3F8
	private Matrix4x4 m_CachedTransform; // 0x408
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ContextType <contextType>k__BackingField; // 0x448
	private bool lostFocus; // 0x44C
	private bool receivedFocus; // 0x44D
	private FocusChangeDirection focusChangeDirection; // 0x450
	private bool hasFocusableControls; // 0x458
	private int newKeyboardFocusControlID; // 0x45C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <focusOnlyIfHasFocusableControls>k__BackingField; // 0x460
	public static readonly string ussClassName; // 0x0
	internal static readonly string ussFoldoutChildDepthClassName; // 0x8
	internal static readonly List<string> ussFoldoutChildDepthClassNames; // 0x10
	private IMGUIContainer.GUIGlobals m_GUIGlobals; // 0x464
	private static readonly ProfilerMarker k_OnGUIMarker; // 0x18
	private static readonly ProfilerMarker k_ImmediateCallbackMarker; // 0x20
	private static Event s_DefaultMeasureEvent; // 0x28
	private static Event s_MeasureEvent; // 0x30
	private static Event s_CurrentEvent; // 0x38

	// Properties
	public Action onGUIHandler { get; set; }
	internal ObjectGUIState guiState { get; }
	internal Rect lastWorldClip { get; set; }
	public bool cullingEnabled { get; }
	private GUILayoutUtility.LayoutCache cache { get; }
	private float layoutMeasuredWidth { get; }
	private float layoutMeasuredHeight { get; }
	public ContextType contextType { get; set; }
	internal bool focusOnlyIfHasFocusableControls { get; }
	public override bool canGrabFocus { get; }

	// Methods

	// RVA: 0x1E05F20 Offset: 0x1E04920 VA: 0x181E05F20
	public Action get_onGUIHandler() { }

	// RVA: 0x2EA9810 Offset: 0x2EA8210 VA: 0x182EA9810
	public void set_onGUIHandler(Action value) { }

	// RVA: 0x2EA96D0 Offset: 0x2EA80D0 VA: 0x182EA96D0
	internal ObjectGUIState get_guiState() { }

	[CompilerGenerated]
	// RVA: 0x2EA9780 Offset: 0x2EA8180 VA: 0x182EA9780
	internal Rect get_lastWorldClip() { }

	[CompilerGenerated]
	// RVA: 0x2EA9800 Offset: 0x2EA8200 VA: 0x182EA9800
	internal void set_lastWorldClip(Rect value) { }

	// RVA: 0x2EA96B0 Offset: 0x2EA80B0 VA: 0x182EA96B0
	public bool get_cullingEnabled() { }

	// RVA: 0x2EA95F0 Offset: 0x2EA7FF0 VA: 0x182EA95F0
	private GUILayoutUtility.LayoutCache get_cache() { }

	// RVA: 0x2EA97C0 Offset: 0x2EA81C0 VA: 0x182EA97C0
	private float get_layoutMeasuredWidth() { }

	// RVA: 0x2EA9790 Offset: 0x2EA8190 VA: 0x182EA9790
	private float get_layoutMeasuredHeight() { }

	[CompilerGenerated]
	// RVA: 0x2EA96A0 Offset: 0x2EA80A0 VA: 0x182EA96A0
	public ContextType get_contextType() { }

	[CompilerGenerated]
	// RVA: 0x2EA97F0 Offset: 0x2EA81F0 VA: 0x182EA97F0
	public void set_contextType(ContextType value) { }

	[CompilerGenerated]
	// RVA: 0x2EA96C0 Offset: 0x2EA80C0 VA: 0x182EA96C0
	internal bool get_focusOnlyIfHasFocusableControls() { }

	// RVA: 0x2EA9670 Offset: 0x2EA8070 VA: 0x182EA9670 Slot: 16
	public override bool get_canGrabFocus() { }

	// RVA: 0x2EA8E20 Offset: 0x2EA7820 VA: 0x182EA8E20
	private static void .cctor() { }

	// RVA: 0x2EA95E0 Offset: 0x2EA7FE0 VA: 0x182EA95E0
	public void .ctor() { }

	// RVA: 0x2EA9300 Offset: 0x2EA7D00 VA: 0x182EA9300
	public void .ctor(Action onGUIHandler) { }

	// RVA: 0x2EA7F50 Offset: 0x2EA6950 VA: 0x182EA7F50
	private void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x2EA8380 Offset: 0x2EA6D80 VA: 0x182EA8380
	private void SaveGlobals() { }

	// RVA: 0x2EA8230 Offset: 0x2EA6C30 VA: 0x182EA8230
	private void RestoreGlobals() { }

	// RVA: 0x2EA5770 Offset: 0x2EA4170 VA: 0x182EA5770
	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = True) { }

	// RVA: 0x2EA7F30 Offset: 0x2EA6930 VA: 0x182EA7F30
	public void MarkDirtyLayout() { }

	// RVA: 0x2EA80A0 Offset: 0x2EA6AA0 VA: 0x182EA80A0
	internal void ProcessEvent(EventBase evt) { }

	// RVA: 0x2EA5120 Offset: 0x2EA3B20 VA: 0x182EA5120
	private void DoIMGUIRepaint() { }

	// RVA: 0x2EA8570 Offset: 0x2EA6F70 VA: 0x182EA8570
	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = True, bool verifyBounds = True) { }

	// RVA: 0x2EA8490 Offset: 0x2EA6E90 VA: 0x182EA8490
	private bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds) { }

	// RVA: 0x2EA89C0 Offset: 0x2EA73C0 VA: 0x182EA89C0
	private bool VerifyBounds(EventBase evt) { }

	// RVA: 0x2EA78E0 Offset: 0x2EA62E0 VA: 0x182EA78E0
	private bool IsContainerCapturingTheMouse() { }

	// RVA: 0x2EA7D50 Offset: 0x2EA6750 VA: 0x182EA7D50
	private bool IsLocalEvent(EventBase evt) { }

	// RVA: 0x2EA7B60 Offset: 0x2EA6560 VA: 0x182EA7B60
	private bool IsEventInsideLocalWindow(EventBase evt) { }

	// RVA: 0x2EA7A20 Offset: 0x2EA6420 VA: 0x182EA7A20
	private static bool IsDockAreaMouseUp(EventBase evt) { }

	// RVA: 0x2EA71D0 Offset: 0x2EA5BD0 VA: 0x182EA71D0
	private bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	// RVA: 0x2EA6F00 Offset: 0x2EA5900 VA: 0x182EA6F00
	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0x2EA74A0 Offset: 0x2EA5EA0 VA: 0x182EA74A0
	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	[EventInterest(new[] { typeof(BlurEvent), typeof(FocusEvent), typeof(DetachFromPanelEvent), typeof(AttachToPanelEvent) })]
	// RVA: 0x2EA6800 Offset: 0x2EA5200 VA: 0x182EA6800 Slot: 12
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x2EA8840 Offset: 0x2EA7240 VA: 0x182EA8840
	private void SetFoldoutDepthClass() { }

	// RVA: 0x2EA5470 Offset: 0x2EA3E70 VA: 0x182EA5470 Slot: 98
	protected internal override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode) { }

	// RVA: 0x2EA6C60 Offset: 0x2EA5660 VA: 0x182EA6C60
	private Rect GetCurrentClipRect() { }

	// RVA: 0x2EA6CE0 Offset: 0x2EA56E0 VA: 0x182EA6CE0
	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	// RVA: 0x2EA5090 Offset: 0x2EA3A90 VA: 0x182EA5090 Slot: 100
	public void Dispose() { }

	// RVA: 0x2EA5100 Offset: 0x2EA3B00 VA: 0x182EA5100 Slot: 101
	protected virtual void Dispose(bool disposeManaged) { }

	[CompilerGenerated]
	// RVA: 0x2EA89B0 Offset: 0x2EA73B0 VA: 0x182EA89B0
	private void <DoOnGUI>b__56_0() { }
}
