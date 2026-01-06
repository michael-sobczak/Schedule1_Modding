public class POI : MonoBehaviour // TypeDefIndex: 3356
{
	// Fields
	[CompilerGenerated]
	private bool <UISetup>k__BackingField; // 0x20
	public POI.TextShowMode MainTextVisibility; // 0x24
	public string DefaultMainText; // 0x28
	public bool AutoUpdatePosition; // 0x30
	public bool Rotate; // 0x31
	[CompilerGenerated]
	private string <MainText>k__BackingField; // 0x38
	[SerializeField]
	protected GameObject UIPrefab; // 0x40
	[CompilerGenerated]
	private RectTransform <UI>k__BackingField; // 0x48
	[CompilerGenerated]
	private RectTransform <IconContainer>k__BackingField; // 0x50
	protected Text mainLabel; // 0x58
	protected Button button; // 0x60
	protected EventTrigger eventTrigger; // 0x68
	private bool mainTextSet; // 0x70
	public UnityEvent onUICreated; // 0x78

	// Properties
	public bool UISetup { get; set; }
	public string MainText { get; set; }
	public RectTransform UI { get; set; }
	public RectTransform IconContainer { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_UISetup() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_UISetup(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_MainText() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	protected void set_MainText(string value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public RectTransform get_UI() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	protected void set_UI(RectTransform value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public RectTransform get_IconContainer() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	protected void set_IconContainer(RectTransform value) { }

	// RVA: 0xA52070 Offset: 0xA50A70 VA: 0x180A52070
	private void OnEnable() { }

	// RVA: 0xA51FC0 Offset: 0xA509C0 VA: 0x180A51FC0
	private void OnDisable() { }

	// RVA: 0xA52740 Offset: 0xA51140 VA: 0x180A52740
	private void Update() { }

	// RVA: 0xA52290 Offset: 0xA50C90 VA: 0x180A52290
	public void SetMainText(string text) { }

	// RVA: 0xA523B0 Offset: 0xA50DB0 VA: 0x180A523B0 Slot: 4
	public virtual void UpdatePosition() { }

	// RVA: 0xA51A70 Offset: 0xA50470 VA: 0x180A51A70 Slot: 5
	public virtual void InitializeUI() { }

	// RVA: 0xA51A40 Offset: 0xA50440 VA: 0x180A51A40 Slot: 6
	protected virtual void HoverStart() { }

	// RVA: 0xA51A10 Offset: 0xA50410 VA: 0x180A51A10 Slot: 7
	protected virtual void HoverEnd() { }

	// RVA: 0xA51970 Offset: 0xA50370 VA: 0x180A51970 Slot: 8
	protected virtual void Clicked() { }

	// RVA: 0xA516B0 Offset: 0xA500B0 VA: 0x180A516B0
	public void .ctor() { }

	[IteratorStateMachine(typeof(POI.<<OnEnable>g__Wait|27_0>d))]
	[CompilerGenerated]
	// RVA: 0xA52340 Offset: 0xA50D40 VA: 0x180A52340
	private IEnumerator <OnEnable>g__Wait|27_0() { }

	[CompilerGenerated]
	// RVA: 0x5FF4F0 Offset: 0x5FDEF0 VA: 0x1805FF4F0
	private void <InitializeUI>b__32_0(BaseEventData data) { }

	[CompilerGenerated]
	// RVA: 0x493100 Offset: 0x491B00 VA: 0x180493100
	private void <InitializeUI>b__32_1(BaseEventData data) { }

	[CompilerGenerated]
	// RVA: 0x7BFF30 Offset: 0x7BE930 VA: 0x1807BFF30
	private void <InitializeUI>b__32_2() { }
}
