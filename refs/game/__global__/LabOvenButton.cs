public class LabOvenButton : MonoBehaviour // TypeDefIndex: 3257
{
	// Fields
	private const float ANIMATION_TIME = 0.2;
	[CompilerGenerated]
	private bool <Pressed>k__BackingField; // 0x20
	public Transform Button; // 0x28
	public Transform PressedTransform; // 0x30
	public Transform DepressedTransform; // 0x38
	public ToggleableLight Light; // 0x40
	public Clickable Clickable; // 0x48
	private float animationTimer; // 0x50
	private Vector3 animationStartPos; // 0x54
	private Vector3 animationEndPos; // 0x60

	// Properties
	public bool Pressed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_Pressed() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_Pressed(bool value) { }

	// RVA: 0xA167B0 Offset: 0xA151B0 VA: 0x180A167B0
	private void Start() { }

	// RVA: 0xA166F0 Offset: 0xA150F0 VA: 0x180A166F0
	public void SetInteractable(bool interactable) { }

	// RVA: 0xA16660 Offset: 0xA15060 VA: 0x180A16660
	public void Press(RaycastHit hit) { }

	// RVA: 0xA16710 Offset: 0xA15110 VA: 0x180A16710
	public void SetPressed(bool pressed) { }

	// RVA: 0xA168C0 Offset: 0xA152C0 VA: 0x180A168C0
	private void Update() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
