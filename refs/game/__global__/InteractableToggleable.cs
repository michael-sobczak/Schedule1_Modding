public class InteractableToggleable : MonoBehaviour // TypeDefIndex: 1369
{
	// Fields
	[CompilerGenerated]
	private bool <IsActivated>k__BackingField; // 0x20
	public string ActivateMessage; // 0x28
	public string DeactivateMessage; // 0x30
	public float CoolDown; // 0x38
	[Header("References")]
	public InteractableObject IntObj; // 0x40
	public UnityEvent onToggle; // 0x48
	public UnityEvent onActivate; // 0x50
	public UnityEvent onDeactivate; // 0x58
	private float lastActivated; // 0x60

	// Properties
	public bool IsActivated { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsActivated() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsActivated(bool value) { }

	// RVA: 0x65E750 Offset: 0x65D150 VA: 0x18065E750
	public void Start() { }

	// RVA: 0x65E5A0 Offset: 0x65CFA0 VA: 0x18065E5A0
	public void Hovered() { }

	// RVA: 0x65E620 Offset: 0x65D020 VA: 0x18065E620
	public void Interacted() { }

	// RVA: 0x65E620 Offset: 0x65D020 VA: 0x18065E620
	public void Toggle() { }

	// RVA: 0x65E6F0 Offset: 0x65D0F0 VA: 0x18065E6F0
	public void SetState(bool activated) { }

	// RVA: 0x65E680 Offset: 0x65D080 VA: 0x18065E680
	public void PoliceDetected() { }

	// RVA: 0x65E840 Offset: 0x65D240 VA: 0x18065E840
	public void .ctor() { }
}
