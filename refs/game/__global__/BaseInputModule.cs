public abstract class BaseInputModule : UIBehaviour // TypeDefIndex: 16551
{
	// Fields
	protected List<RaycastResult> m_RaycastResultCache; // 0x20
	[SerializeField]
	private bool m_SendPointerHoverToParent; // 0x28
	private AxisEventData m_AxisEventData; // 0x30
	private EventSystem m_EventSystem; // 0x38
	private BaseEventData m_BaseEventData; // 0x40
	protected BaseInput m_InputOverride; // 0x48
	private BaseInput m_DefaultInput; // 0x50

	// Properties
	internal bool sendPointerHoverToParent { get; set; }
	public BaseInput input { get; }
	public BaseInput inputOverride { get; set; }
	protected EventSystem eventSystem { get; }

	// Methods

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	internal bool get_sendPointerHoverToParent() { }

	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	internal void set_sendPointerHoverToParent(bool value) { }

	// RVA: 0x2F45810 Offset: 0x2F44210 VA: 0x182F45810
	public BaseInput get_input() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public BaseInput get_inputOverride() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_inputOverride(BaseInput value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	protected EventSystem get_eventSystem() { }

	// RVA: 0x2F456F0 Offset: 0x2F440F0 VA: 0x182F456F0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F456D0 Offset: 0x2F440D0 VA: 0x182F456D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Process();

	// RVA: 0x2F44860 Offset: 0x2F43260 VA: 0x182F44860
	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) { }

	// RVA: 0x2F44660 Offset: 0x2F43060 VA: 0x182F44660
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x2F445E0 Offset: 0x2F42FE0 VA: 0x182F445E0
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x2F446D0 Offset: 0x2F430D0 VA: 0x182F446D0
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x2F44BA0 Offset: 0x2F435A0 VA: 0x182F44BA0
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x2F449A0 Offset: 0x2F433A0 VA: 0x182F449A0 Slot: 18
	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x2F44AF0 Offset: 0x2F434F0 VA: 0x182F44AF0 Slot: 19
	protected virtual BaseEventData GetBaseEventData() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 20
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x2F45750 Offset: 0x2F44150 VA: 0x182F45750 Slot: 21
	public virtual bool ShouldActivateModule() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	public virtual void DeactivateModule() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 23
	public virtual void ActivateModule() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 24
	public virtual void UpdateModule() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 25
	public virtual bool IsModuleSupported() { }

	// RVA: 0x2F44540 Offset: 0x2F42F40 VA: 0x182F44540 Slot: 26
	public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x2F45790 Offset: 0x2F44190 VA: 0x182F45790
	protected void .ctor() { }
}
