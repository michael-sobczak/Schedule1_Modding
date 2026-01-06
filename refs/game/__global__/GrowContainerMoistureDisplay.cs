public class GrowContainerMoistureDisplay : MonoBehaviour // TypeDefIndex: 2363
{
	// Fields
	public const float MaxCameraDistance = 2.5;
	public const float MinCameraDistance = 0.5;
	public const float FadeInDistance = 0.7;
	public const float FadeOutDistance = 0.25;
	public bool SnapToRightAngles; // 0x20
	[Header("References")]
	public GrowContainer GrowContainer; // 0x28
	public Transform WaterCanvasContainer; // 0x30
	public Canvas WaterLevelCanvas; // 0x38
	public CanvasGroup WaterLevelCanvasGroup; // 0x40
	public Slider WaterLevelSlider; // 0x48
	public GameObject NoWaterIcon; // 0x50

	// Methods

	// RVA: 0x85A6B0 Offset: 0x8590B0 VA: 0x18085A6B0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x85A6E0 Offset: 0x8590E0 VA: 0x18085A6E0
	private void LateUpdate() { }

	// RVA: 0x85A780 Offset: 0x859180 VA: 0x18085A780
	private void UpdateCanvas() { }

	// RVA: 0x85A6F0 Offset: 0x8590F0 VA: 0x18085A6F0 Slot: 5
	protected virtual void UpdateCanvasContents() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
