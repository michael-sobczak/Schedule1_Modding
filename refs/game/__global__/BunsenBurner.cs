public class BunsenBurner : MonoBehaviour // TypeDefIndex: 3238
{
	// Fields
	[CompilerGenerated]
	private bool <Interactable>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsDialHeld>k__BackingField; // 0x21
	[CompilerGenerated]
	private float <CurrentDialValue>k__BackingField; // 0x24
	[CompilerGenerated]
	private float <CurrentHeat>k__BackingField; // 0x28
	public bool LockDial; // 0x2C
	[Header("Settings")]
	public Gradient FlameColor; // 0x30
	public AnimationCurve LightIntensity; // 0x38
	public float HandleRotationSpeed; // 0x40
	public AnimationCurve FlamePitch; // 0x48
	[Header("References")]
	public ParticleSystem Flame; // 0x50
	public Light Light; // 0x58
	public Transform Handle; // 0x60
	public Clickable HandleClickable; // 0x68
	public Transform Handle_Min; // 0x70
	public Transform Handle_Max; // 0x78
	public Transform Highlight; // 0x80
	public Animation Anim; // 0x88
	public AudioSourceController FlameSound; // 0x90

	// Properties
	public bool Interactable { get; set; }
	public bool IsDialHeld { get; set; }
	public float CurrentDialValue { get; set; }
	public float CurrentHeat { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_Interactable() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_Interactable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	public bool get_IsDialHeld() { }

	[CompilerGenerated]
	// RVA: 0x563DA0 Offset: 0x5627A0 VA: 0x180563DA0
	private void set_IsDialHeld(bool value) { }

	[CompilerGenerated]
	// RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450
	public float get_CurrentDialValue() { }

	[CompilerGenerated]
	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	private void set_CurrentDialValue(float value) { }

	[CompilerGenerated]
	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_CurrentHeat() { }

	[CompilerGenerated]
	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	private void set_CurrentHeat(float value) { }

	// RVA: 0x9F9580 Offset: 0x9F7F80 VA: 0x1809F9580
	private void Start() { }

	// RVA: 0x9F9850 Offset: 0x9F8250 VA: 0x1809F9850
	private void Update() { }

	// RVA: 0x9F96D0 Offset: 0x9F80D0 VA: 0x1809F96D0
	private void UpdateEffects() { }

	// RVA: 0x9F9450 Offset: 0x9F7E50 VA: 0x1809F9450
	public void SetDialPosition(float pos) { }

	// RVA: 0x9F9530 Offset: 0x9F7F30 VA: 0x1809F9530
	public void SetInteractable(bool e) { }

	// RVA: 0x820C60 Offset: 0x81F660 VA: 0x180820C60
	public void ClickStart(RaycastHit hit) { }

	// RVA: 0x820C50 Offset: 0x81F650 VA: 0x180820C50
	public void ClickEnd() { }

	// RVA: 0x9F9AC0 Offset: 0x9F84C0 VA: 0x1809F9AC0
	public void .ctor() { }
}
