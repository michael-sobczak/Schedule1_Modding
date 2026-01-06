public class EyelidOverlay : Singleton<EyelidOverlay> // TypeDefIndex: 2669
{
	// Fields
	public const float MaxTiredOpenAmount = 0.625;
	public bool AutoUpdate; // 0x28
	[Header("Settings")]
	public float Open; // 0x2C
	public float Closed; // 0x30
	[Header("References")]
	public RectTransform Upper; // 0x38
	public RectTransform Lower; // 0x40
	public Canvas Canvas; // 0x48
	[Range(0, 1)]
	public float CurrentOpen; // 0x50
	public FloatSmoother OpenMultiplier; // 0x58

	// Methods

	// RVA: 0x8F58D0 Offset: 0x8F42D0 VA: 0x1808F58D0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8F5A40 Offset: 0x8F4440 VA: 0x1808F5A40
	private void Update() { }

	// RVA: 0x8F5940 Offset: 0x8F4340 VA: 0x1808F5940
	public void SetOpen(float openness) { }

	// RVA: 0x8F5BD0 Offset: 0x8F45D0 VA: 0x1808F5BD0
	public void .ctor() { }
}
