public class TutorialTimeController : MonoBehaviour // TypeDefIndex: 650
{
	// Fields
	public AnimationCurve TimeProgressionCurve; // 0x20
	public TutorialTimeController.KeyFrame[] KeyFrames; // 0x28
	[SerializeField]
	private int currentKeyFrameIndex; // 0x30
	private bool disabled; // 0x34

	// Methods

	// RVA: 0xACB9C0 Offset: 0xACA3C0 VA: 0x180ACB9C0
	private void Awake() { }

	// RVA: 0xACBD20 Offset: 0xACA720 VA: 0x180ACBD20
	private void OnDestroy() { }

	// RVA: 0xACBE90 Offset: 0xACA890 VA: 0x180ACBE90
	private void Update() { }

	// RVA: 0xACBBB0 Offset: 0xACA5B0 VA: 0x180ACBBB0
	private int GetCurrentKeyFrameStart() { }

	[Button]
	// RVA: 0xACBC60 Offset: 0xACA660 VA: 0x180ACBC60
	public void IncrementKeyframe() { }

	// RVA: 0xACBB10 Offset: 0xACA510 VA: 0x180ACBB10
	public void Disable() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
