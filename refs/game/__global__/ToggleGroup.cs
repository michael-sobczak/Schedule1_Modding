public class ToggleGroup : UIBehaviour // TypeDefIndex: 16486
{
	// Fields
	[SerializeField]
	private bool m_AllowSwitchOff; // 0x20
	protected List<Toggle> m_Toggles; // 0x28

	// Properties
	public bool allowSwitchOff { get; set; }

	// Methods

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_allowSwitchOff() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x2F41B60 Offset: 0x2F40560 VA: 0x182F41B60
	protected void .ctor() { }

	// RVA: 0x2F41780 Offset: 0x2F40180 VA: 0x182F41780 Slot: 6
	protected override void Start() { }

	// RVA: 0x2F41780 Offset: 0x2F40180 VA: 0x182F41780 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F41A10 Offset: 0x2F40410 VA: 0x182F41A10
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x2F41520 Offset: 0x2F3FF20 VA: 0x182F41520
	public void NotifyToggleOn(Toggle toggle, bool sendCallback = True) { }

	// RVA: 0x2F41990 Offset: 0x2F40390 VA: 0x182F41990
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x2F417A0 Offset: 0x2F401A0 VA: 0x182F417A0
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x2F410B0 Offset: 0x2F3FAB0 VA: 0x182F410B0
	public void EnsureValidState() { }

	// RVA: 0x2F40F60 Offset: 0x2F3F960 VA: 0x182F40F60
	public bool AnyTogglesOn() { }

	// RVA: 0x2F40E40 Offset: 0x2F3F840 VA: 0x182F40E40
	public IEnumerable<Toggle> ActiveToggles() { }

	// RVA: 0x2F414B0 Offset: 0x2F3FEB0 VA: 0x182F414B0
	public Toggle GetFirstActiveToggle() { }

	// RVA: 0x2F41880 Offset: 0x2F40280 VA: 0x182F41880
	public void SetAllTogglesOff(bool sendCallback = True) { }
}
