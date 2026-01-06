public sealed class DebugManager // TypeDefIndex: 13633
{
	// Fields
	private const string kEnableDebugBtn1 = "Enable Debug Button 1";
	private const string kEnableDebugBtn2 = "Enable Debug Button 2";
	private const string kDebugPreviousBtn = "Debug Previous";
	private const string kDebugNextBtn = "Debug Next";
	private const string kValidateBtn = "Debug Validate";
	private const string kPersistentBtn = "Debug Persistent";
	private const string kDPadVertical = "Debug Vertical";
	private const string kDPadHorizontal = "Debug Horizontal";
	private const string kMultiplierBtn = "Debug Multiplier";
	private const string kResetBtn = "Debug Reset";
	private const string kEnableDebug = "Enable Debug";
	private DebugActionDesc[] m_DebugActions; // 0x10
	private DebugActionState[] m_DebugActionStates; // 0x18
	private InputActionMap debugActionMap; // 0x20
	private static readonly Lazy<DebugManager> s_Instance; // 0x0
	private ReadOnlyCollection<DebugUI.Panel> m_ReadOnlyPanels; // 0x28
	private readonly List<DebugUI.Panel> m_Panels; // 0x30
	[CompilerGenerated]
	private Action<bool> onDisplayRuntimeUIChanged; // 0x38
	[CompilerGenerated]
	private Action onSetDirty; // 0x40
	[CompilerGenerated]
	private Action resetData; // 0x48
	public bool refreshEditorRequested; // 0x50
	private Nullable<int> m_RequestedPanelIndex; // 0x54
	private GameObject m_Root; // 0x60
	private DebugUIHandlerCanvas m_RootUICanvas; // 0x68
	private GameObject m_PersistentRoot; // 0x70
	private DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas; // 0x78
	[CompilerGenerated]
	private static Action<DebugManager.UIMode, bool> windowStateChanged; // 0x8
	private DebugManager.UIState editorUIState; // 0x80
	private bool m_EnableRuntimeUI; // 0x88
	private DebugManager.UIState runtimeUIState; // 0x90

	// Properties
	public static DebugManager instance { get; }
	public ReadOnlyCollection<DebugUI.Panel> panels { get; }
	public bool isAnyDebugUIActive { get; }
	public bool displayEditorUI { get; set; }
	public bool enableRuntimeUI { get; set; }
	public bool displayRuntimeUI { get; set; }
	public bool displayPersistentRuntimeUI { get; set; }

	// Methods

	// RVA: 0x29EC900 Offset: 0x29EB300 VA: 0x1829EC900
	private void RegisterActions() { }

	// RVA: 0x29EB060 Offset: 0x29E9A60 VA: 0x1829EB060
	internal void EnableInputActions() { }

	// RVA: 0x29EAF20 Offset: 0x29E9920 VA: 0x1829EAF20
	private void AddAction(DebugAction action, DebugActionDesc desc) { }

	// RVA: 0x29EDBC0 Offset: 0x29EC5C0 VA: 0x1829EDBC0
	private void SampleAction(int actionIndex) { }

	// RVA: 0x29EE330 Offset: 0x29ECD30 VA: 0x1829EE330
	private void UpdateAction(int actionIndex) { }

	// RVA: 0x29EE510 Offset: 0x29ECF10 VA: 0x1829EE510
	internal void UpdateActions() { }

	// RVA: 0x29EB8F0 Offset: 0x29EA2F0 VA: 0x1829EB8F0
	internal float GetAction(DebugAction action) { }

	// RVA: 0x29EB690 Offset: 0x29EA090 VA: 0x1829EB690
	internal bool GetActionToggleDebugMenuWithTouch() { }

	// RVA: 0x29EB500 Offset: 0x29E9F00 VA: 0x1829EB500
	internal bool GetActionReleaseScrollTarget() { }

	// RVA: 0x29ECEC0 Offset: 0x29EB8C0 VA: 0x1829ECEC0
	private void RegisterInputs() { }

	// RVA: 0x29EEE10 Offset: 0x29ED810 VA: 0x1829EEE10
	public static DebugManager get_instance() { }

	// RVA: 0x29EE570 Offset: 0x29ECF70 VA: 0x1829EE570
	private void UpdateReadOnlyCollection() { }

	// RVA: 0x29EEF10 Offset: 0x29ED910 VA: 0x1829EEF10
	public ReadOnlyCollection<DebugUI.Panel> get_panels() { }

	[CompilerGenerated]
	// RVA: 0x29EE9F0 Offset: 0x29ED3F0 VA: 0x1829EE9F0
	public void add_onDisplayRuntimeUIChanged(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x29EEF40 Offset: 0x29ED940 VA: 0x1829EEF40
	public void remove_onDisplayRuntimeUIChanged(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x29EEAA0 Offset: 0x29ED4A0 VA: 0x1829EEAA0
	public void add_onSetDirty(Action value) { }

	[CompilerGenerated]
	// RVA: 0x29EEFF0 Offset: 0x29ED9F0 VA: 0x1829EEFF0
	public void remove_onSetDirty(Action value) { }

	[CompilerGenerated]
	// RVA: 0x29EEB40 Offset: 0x29ED540 VA: 0x1829EEB40
	private void add_resetData(Action value) { }

	[CompilerGenerated]
	// RVA: 0x29EF090 Offset: 0x29EDA90 VA: 0x1829EF090
	private void remove_resetData(Action value) { }

	// RVA: 0x29EEE80 Offset: 0x29ED880 VA: 0x1829EEE80
	public bool get_isAnyDebugUIActive() { }

	// RVA: 0x29EE700 Offset: 0x29ED100 VA: 0x1829EE700
	private void .ctor() { }

	// RVA: 0x508680 Offset: 0x507080 VA: 0x180508680
	public void RefreshEditor() { }

	// RVA: 0x29EDB70 Offset: 0x29EC570 VA: 0x1829EDB70
	public void Reset() { }

	// RVA: 0x29EC8D0 Offset: 0x29EB2D0 VA: 0x1829EC8D0
	public void ReDrawOnScreenDebug() { }

	// RVA: 0x29ECDD0 Offset: 0x29EB7D0 VA: 0x1829ECDD0
	public void RegisterData(IDebugData data) { }

	// RVA: 0x29EE240 Offset: 0x29ECC40 VA: 0x1829EE240
	public void UnregisterData(IDebugData data) { }

	// RVA: 0x29EC5D0 Offset: 0x29EAFD0 VA: 0x1829EC5D0
	public int GetState() { }

	// RVA: 0x29ED860 Offset: 0x29EC260 VA: 0x1829ED860
	internal void RegisterRootCanvas(DebugUIHandlerCanvas root) { }

	// RVA: 0x29EB040 Offset: 0x29E9A40 VA: 0x1829EB040
	internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext) { }

	// RVA: 0x29EDD70 Offset: 0x29EC770 VA: 0x1829EDD70
	internal void SetScrollTarget(DebugUIHandlerWidget widget) { }

	// RVA: 0x29EB200 Offset: 0x29E9C00 VA: 0x1829EB200
	private void EnsurePersistentCanvas() { }

	// RVA: 0x29EDE30 Offset: 0x29EC830 VA: 0x1829EDE30
	internal void TogglePersistent(DebugUI.Widget widget, Nullable<int> forceTupleIndex) { }

	// RVA: 0x29EC700 Offset: 0x29EB100 VA: 0x1829EC700
	private void OnPanelDirty(DebugUI.Panel panel) { }

	// RVA: 0x29EC7E0 Offset: 0x29EB1E0 VA: 0x1829EC7E0
	public int PanelIndex(string displayName) { }

	// RVA: 0x29EC730 Offset: 0x29EB130 VA: 0x1829EC730
	public string PanelDiplayName(int panelIndex) { }

	// RVA: 0x29EDB10 Offset: 0x29EC510 VA: 0x1829EDB10
	public void RequestEditorWindowPanelIndex(int index) { }

	// RVA: 0x29EC5C0 Offset: 0x29EAFC0 VA: 0x1829EC5C0
	internal Nullable<int> GetRequestedEditorWindowPanelIndex() { }

	// RVA: 0x29EC250 Offset: 0x29EAC50 VA: 0x1829EC250
	public DebugUI.Panel GetPanel(string displayName, bool createIfNull = False, int groupIndex = 0, bool overrideIfExist = False) { }

	// RVA: 0x29EB420 Offset: 0x29E9E20 VA: 0x1829EB420
	public int FindPanelIndex(string displayName) { }

	// RVA: 0x29ED8B0 Offset: 0x29EC2B0 VA: 0x1829ED8B0
	public void RemovePanel(string displayName) { }

	// RVA: 0x29EDAA0 Offset: 0x29EC4A0 VA: 0x1829EDAA0
	public void RemovePanel(DebugUI.Panel panel) { }

	// RVA: 0x29EC000 Offset: 0x29EAA00 VA: 0x1829EC000
	public DebugUI.Widget[] GetItems(DebugUI.Flags flags) { }

	// RVA: 0x29EBC70 Offset: 0x29EA670 VA: 0x1829EBC70
	internal DebugUI.Widget[] GetItemsFromContainer(DebugUI.Flags flags, DebugUI.IContainer container) { }

	// RVA: 0x29EBB30 Offset: 0x29EA530 VA: 0x1829EBB30
	public DebugUI.Widget GetItem(string queryPath) { }

	// RVA: 0x29EB930 Offset: 0x29EA330 VA: 0x1829EB930
	private DebugUI.Widget GetItem(string queryPath, DebugUI.IContainer container) { }

	[CompilerGenerated]
	// RVA: 0x29EEBE0 Offset: 0x29ED5E0 VA: 0x1829EEBE0
	public static void add_windowStateChanged(Action<DebugManager.UIMode, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x29EF130 Offset: 0x29EDB30 VA: 0x1829EF130
	public static void remove_windowStateChanged(Action<DebugManager.UIMode, bool> value) { }

	// RVA: 0x29EECF0 Offset: 0x29ED6F0 VA: 0x1829EECF0
	public bool get_displayEditorUI() { }

	// RVA: 0x29EDE00 Offset: 0x29EC800 VA: 0x1829EDE00
	public void set_displayEditorUI(bool value) { }

	// RVA: 0xDA2600 Offset: 0xDA1000 VA: 0x180DA2600
	public bool get_enableRuntimeUI() { }

	// RVA: 0x29EF560 Offset: 0x29EDF60 VA: 0x1829EF560
	public void set_enableRuntimeUI(bool value) { }

	// RVA: 0x29EED90 Offset: 0x29ED790 VA: 0x1829EED90
	public bool get_displayRuntimeUI() { }

	// RVA: 0x29EF2E0 Offset: 0x29EDCE0 VA: 0x1829EF2E0
	public void set_displayRuntimeUI(bool value) { }

	// RVA: 0x29EED10 Offset: 0x29ED710 VA: 0x1829EED10
	public bool get_displayPersistentRuntimeUI() { }

	// RVA: 0x29EF240 Offset: 0x29EDC40 VA: 0x1829EF240
	public void set_displayPersistentRuntimeUI(bool value) { }

	[Obsolete("Use DebugManager.instance.displayEditorUI.open property instead. #from(23.1)")]
	// RVA: 0x29EDE00 Offset: 0x29EC800 VA: 0x1829EDE00
	public void ToggleEditorUI(bool open) { }

	// RVA: 0x29EE5F0 Offset: 0x29ECFF0 VA: 0x1829EE5F0
	private static void .cctor() { }
}
