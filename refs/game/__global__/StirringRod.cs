public class StirringRod : MonoBehaviour // TypeDefIndex: 3245
{
	// Fields
	public const float MAX_STIR_RATE = 20;
	public const float MAX_PIVOT_ANGLE = 7;
	[CompilerGenerated]
	private bool <Interactable>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <CurrentStirringSpeed>k__BackingField; // 0x24
	public float LerpSpeed; // 0x28
	[Header("References")]
	public Clickable Clickable; // 0x30
	public Transform PlaneNormal; // 0x38
	public Transform Container; // 0x40
	public Transform RodPivot; // 0x48
	public AudioSourceController StirSound; // 0x50
	private Vector3 clickOffset; // 0x58
	private bool isMoving; // 0x64

	// Properties
	public bool Interactable { get; set; }
	public float CurrentStirringSpeed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_Interactable() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_Interactable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450
	public float get_CurrentStirringSpeed() { }

	[CompilerGenerated]
	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	private void set_CurrentStirringSpeed(float value) { }

	// RVA: 0xA15A70 Offset: 0xA14470 VA: 0x180A15A70
	private void Start() { }

	// RVA: 0xA15B90 Offset: 0xA14590 VA: 0x180A15B90
	private void Update() { }

	// RVA: 0xA15410 Offset: 0xA13E10 VA: 0x180A15410
	private void LateUpdate() { }

	// RVA: 0xA15A50 Offset: 0xA14450 VA: 0x180A15A50
	public void SetInteractable(bool e) { }

	// RVA: 0xA15060 Offset: 0xA13A60 VA: 0x180A15060
	public void ClickStart(RaycastHit hit) { }

	// RVA: 0xA15160 Offset: 0xA13B60 VA: 0x180A15160
	private Vector3 GetPlaneHit() { }

	// RVA: 0xA15050 Offset: 0xA13A50 VA: 0x180A15050
	public void ClickEnd() { }

	// RVA: 0xA15100 Offset: 0xA13B00 VA: 0x180A15100
	public void Destroy() { }

	// RVA: 0xA15CC0 Offset: 0xA146C0 VA: 0x180A15CC0
	public void .ctor() { }
}
