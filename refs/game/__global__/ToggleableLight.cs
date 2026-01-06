public class ToggleableLight : MonoBehaviour // TypeDefIndex: 3318
{
	// Fields
	[FormerlySerializedAs("isOn")]
	[SerializeField]
	private bool _isOn; // 0x20
	[SerializeField]
	[Header("References")]
	protected OptimizedLight[] lightSources; // 0x28
	[SerializeField]
	protected MeshRenderer[] lightSurfacesMeshes; // 0x30
	public int MaterialIndex; // 0x38
	[SerializeField]
	[Header("Materials")]
	protected Material lightOnMat; // 0x40
	[SerializeField]
	protected Material lightOffMat; // 0x48
	private ToggleableLight.State state; // 0x50

	// Properties
	public bool isOn { get; set; }

	// Methods

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_isOn() { }

	// RVA: 0xA5CC30 Offset: 0xA5B630 VA: 0x180A5CC30
	public void set_isOn(bool value) { }

	// RVA: 0x618750 Offset: 0x617150 VA: 0x180618750 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0xA5CC10 Offset: 0xA5B610 VA: 0x180A5CC10
	public void TurnOn() { }

	// RVA: 0xA5CBF0 Offset: 0xA5B5F0 VA: 0x180A5CBF0
	public void TurnOff() { }

	// RVA: 0xA5C9E0 Offset: 0xA5B3E0 VA: 0x180A5C9E0 Slot: 5
	protected virtual void SetLights() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
