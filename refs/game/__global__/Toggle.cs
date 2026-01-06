public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 16484
{
	// Fields
	public Toggle.ToggleTransition toggleTransition; // 0x100
	public Graphic graphic; // 0x108
	[SerializeField]
	private ToggleGroup m_Group; // 0x110
	public Toggle.ToggleEvent onValueChanged; // 0x118
	[Tooltip("Is the toggle currently on or off?")]
	[SerializeField]
	private bool m_IsOn; // 0x120

	// Properties
	public ToggleGroup group { get; set; }
	public bool isOn { get; set; }

	// Methods

	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	public ToggleGroup get_group() { }

	// RVA: 0x2F42440 Offset: 0x2F40E40 VA: 0x182F42440
	public void set_group(ToggleGroup value) { }

	// RVA: 0x2F42380 Offset: 0x2F40D80 VA: 0x182F42380
	protected void .ctor() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 46
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 47
	public virtual void LayoutComplete() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 48
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x2F41C40 Offset: 0x2F40640 VA: 0x182F41C40 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x2F41DD0 Offset: 0x2F407D0 VA: 0x182F41DD0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F41DA0 Offset: 0x2F407A0 VA: 0x182F41DA0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F41CD0 Offset: 0x2F406D0 VA: 0x182F41CD0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2F41F60 Offset: 0x2F40960 VA: 0x182F41F60
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170
	public bool get_isOn() { }

	// RVA: 0x2F42470 Offset: 0x2F40E70 VA: 0x182F42470
	public void set_isOn(bool value) { }

	// RVA: 0x2F41F50 Offset: 0x2F40950 VA: 0x182F41F50
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x2F421E0 Offset: 0x2F40BE0 VA: 0x182F421E0
	private void Set(bool value, bool sendCallback = True) { }

	// RVA: 0x2F41E90 Offset: 0x2F40890 VA: 0x182F41E90
	private void PlayEffect(bool instant) { }

	// RVA: 0x2F42370 Offset: 0x2F40D70 VA: 0x182F42370 Slot: 6
	protected override void Start() { }

	// RVA: 0x2F41BE0 Offset: 0x2F405E0 VA: 0x182F41BE0
	private void InternalToggle() { }

	// RVA: 0x2F41E10 Offset: 0x2F40810 VA: 0x182F41E10 Slot: 49
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2F41BE0 Offset: 0x2F405E0 VA: 0x182F41BE0 Slot: 50
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}
