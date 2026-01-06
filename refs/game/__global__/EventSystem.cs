public class EventSystem : UIBehaviour // TypeDefIndex: 16543
{
	// Fields
	private List<BaseInputModule> m_SystemInputModules; // 0x20
	private BaseInputModule m_CurrentInputModule; // 0x28
	private static List<EventSystem> m_EventSystems; // 0x0
	[FormerlySerializedAs("m_Selected")]
	[SerializeField]
	private GameObject m_FirstSelected; // 0x30
	[SerializeField]
	private bool m_sendNavigationEvents; // 0x38
	[SerializeField]
	private int m_DragThreshold; // 0x3C
	private GameObject m_CurrentSelected; // 0x40
	private bool m_HasFocus; // 0x48
	private bool m_SelectionGuard; // 0x49
	private BaseEventData m_DummyData; // 0x50
	private static readonly Comparison<RaycastResult> s_RaycastComparer; // 0x8
	private static EventSystem.UIToolkitOverrideConfig s_UIToolkitOverride; // 0x10
	private bool m_Started; // 0x58
	private bool m_IsTrackingUIToolkitPanels; // 0x59

	// Properties
	public static EventSystem current { get; set; }
	public bool sendNavigationEvents { get; set; }
	public int pixelDragThreshold { get; set; }
	public BaseInputModule currentInputModule { get; }
	public GameObject firstSelectedGameObject { get; set; }
	public GameObject currentSelectedGameObject { get; }
	[Obsolete("lastSelectedGameObject is no longer supported")]
	public GameObject lastSelectedGameObject { get; }
	public bool isFocused { get; }
	public bool alreadySelecting { get; }
	private BaseEventData baseEventDataCache { get; }
	private bool isUIToolkitActiveEventSystem { get; }
	private bool sendUIToolkitEvents { get; }
	private bool createUIToolkitPanelGameObjectsOnStart { get; }

	// Methods

	// RVA: 0x2F48230 Offset: 0x2F46C30 VA: 0x182F48230
	public static EventSystem get_current() { }

	// RVA: 0x2F48440 Offset: 0x2F46E40 VA: 0x182F48440
	public static void set_current(EventSystem value) { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_sendNavigationEvents() { }

	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	public void set_sendNavigationEvents(bool value) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public int get_pixelDragThreshold() { }

	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0
	public void set_pixelDragThreshold(int value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public GameObject get_firstSelectedGameObject() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public GameObject get_currentSelectedGameObject() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	public GameObject get_lastSelectedGameObject() { }

	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	public bool get_isFocused() { }

	// RVA: 0x2F480B0 Offset: 0x2F46AB0 VA: 0x182F480B0
	protected void .ctor() { }

	// RVA: 0x2F47BC0 Offset: 0x2F465C0 VA: 0x182F47BC0
	public void UpdateModules() { }

	// RVA: 0x4D6190 Offset: 0x4D4B90 VA: 0x1804D6190
	public bool get_alreadySelecting() { }

	// RVA: 0x2F47260 Offset: 0x2F45C60 VA: 0x182F47260
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x2F48140 Offset: 0x2F46B40 VA: 0x182F48140
	private BaseEventData get_baseEventDataCache() { }

	// RVA: 0x2F471C0 Offset: 0x2F45BC0 VA: 0x182F471C0
	public void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x2F46D40 Offset: 0x2F45740 VA: 0x182F46D40
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x2F46B40 Offset: 0x2F45540 VA: 0x182F46B40
	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	// RVA: 0x2F46790 Offset: 0x2F45190 VA: 0x182F46790
	public bool IsPointerOverGameObject() { }

	// RVA: 0x2F466F0 Offset: 0x2F450F0 VA: 0x182F466F0
	public bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x2F482E0 Offset: 0x2F46CE0 VA: 0x182F482E0
	private bool get_isUIToolkitActiveEventSystem() { }

	// RVA: 0x2F483D0 Offset: 0x2F46DD0 VA: 0x182F483D0
	private bool get_sendUIToolkitEvents() { }

	// RVA: 0x2F481C0 Offset: 0x2F46BC0 VA: 0x182F481C0
	private bool get_createUIToolkitPanelGameObjectsOnStart() { }

	// RVA: 0x2F47480 Offset: 0x2F45E80 VA: 0x182F47480
	public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = True, bool createPanelGameObjectsOnStart = True) { }

	// RVA: 0x2F47640 Offset: 0x2F46040 VA: 0x182F47640
	private void StartTrackingUIToolkitPanels() { }

	// RVA: 0x2F478C0 Offset: 0x2F462C0 VA: 0x182F478C0
	private void StopTrackingUIToolkitPanels() { }

	// RVA: 0x2F46430 Offset: 0x2F44E30 VA: 0x182F46430
	private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel) { }

	// RVA: 0x2F478B0 Offset: 0x2F462B0 VA: 0x182F478B0 Slot: 6
	protected override void Start() { }

	// RVA: 0x2F469D0 Offset: 0x2F453D0 VA: 0x182F469D0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F46830 Offset: 0x2F45230 VA: 0x182F46830 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F47960 Offset: 0x2F46360 VA: 0x182F47960
	private void TickModules() { }

	// RVA: 0x2F46820 Offset: 0x2F45220 VA: 0x182F46820 Slot: 17
	protected virtual void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x2F47D00 Offset: 0x2F46700 VA: 0x182F47D00 Slot: 18
	protected virtual void Update() { }

	// RVA: 0x2F46320 Offset: 0x2F44D20 VA: 0x182F46320
	private void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x2F47A60 Offset: 0x2F46460 VA: 0x182F47A60 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F47F70 Offset: 0x2F46970 VA: 0x182F47F70
	private static void .cctor() { }
}
