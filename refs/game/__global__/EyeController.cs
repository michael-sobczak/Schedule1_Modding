public class EyeController : MonoBehaviour // TypeDefIndex: 3115
{
	// Fields
	private static float eyeHeightMultiplier; // 0x0
	public bool DEBUG; // 0x20
	[CompilerGenerated]
	private bool <EyesOpen>k__BackingField; // 0x21
	[Header("References")]
	[SerializeField]
	public Eye leftEye; // 0x28
	[SerializeField]
	public Eye rightEye; // 0x30
	[Range(0, 45)]
	[Header("Location Settings")]
	[SerializeField]
	protected float eyeSpacing; // 0x38
	[Range(-1, 1)]
	[SerializeField]
	protected float eyeHeight; // 0x3C
	[Range(0.5, 1.5)]
	[SerializeField]
	protected float eyeSize; // 0x40
	[Header("Eyelid Settings")]
	public Eye.EyeLidConfiguration LeftRestingEyeState; // 0x44
	public Eye.EyeLidConfiguration RightRestingEyeState; // 0x4C
	[Header("Eyeball Settings")]
	[SerializeField]
	protected Material eyeBallMaterial; // 0x58
	[Range(0, 1)]
	[Header("Pupil State")]
	public float PupilDilation; // 0x60
	[Header("Blinking Settings")]
	public bool BlinkingEnabled; // 0x64
	[Range(0, 10)]
	[SerializeField]
	protected float blinkInterval; // 0x68
	[SerializeField]
	[Range(0, 2)]
	protected float blinkIntervalSpread; // 0x6C
	[SerializeField]
	[Range(0, 1)]
	protected float blinkDuration; // 0x70
	private Avatar avatar; // 0x78
	private Coroutine blinkRoutine; // 0x80
	private float timeUntilNextBlink; // 0x88
	private bool eyeBallTintOverridden; // 0x8C
	private bool eyeLidOverridden; // 0x8D
	private Eye.EyeLidConfiguration defaultLeftEyeRestingState; // 0x90
	private Eye.EyeLidConfiguration defaultRightEyeRestingState; // 0x98
	private float defaultDilation; // 0xA0
	private Color defaultEyeballColor; // 0xA4
	private Color currentEyeballColor; // 0xB4

	// Properties
	public bool EyesOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	public bool get_EyesOpen() { }

	[CompilerGenerated]
	// RVA: 0x563DA0 Offset: 0x5627A0 VA: 0x180563DA0
	protected void set_EyesOpen(bool value) { }

	// RVA: 0x9B8FF0 Offset: 0x9B79F0 VA: 0x1809B8FF0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x9B9AC0 Offset: 0x9B84C0 VA: 0x1809B9AC0
	protected void Update() { }

	// RVA: 0x9B8F90 Offset: 0x9B7990 VA: 0x1809B8F90
	private void OnEnable() { }

	// RVA: 0x9B97B0 Offset: 0x9B81B0 VA: 0x1809B97B0
	public void SetEyeballTint(Color col, bool overrideDefault = False) { }

	// RVA: 0x9B95D0 Offset: 0x9B7FD0 VA: 0x1809B95D0
	public void ResetEyeballTint() { }

	// RVA: 0x9B9410 Offset: 0x9B7E10 VA: 0x1809B9410
	public void OverrideEyeLids(Eye.EyeLidConfiguration eyeLidConfiguration) { }

	// RVA: 0x9B9560 Offset: 0x9B7F60 VA: 0x1809B9560
	public void ResetEyeLids() { }

	// RVA: 0x9B9440 Offset: 0x9B7E40 VA: 0x1809B9440
	private void RagdollChange(bool oldValue, bool newValue, bool playStandUpAnim) { }

	// RVA: 0x9B9850 Offset: 0x9B8250 VA: 0x1809B9850
	public void SetEyesOpen(bool open) { }

	// RVA: 0x9B8F20 Offset: 0x9B7920 VA: 0x1809B8F20
	private void ApplyDilation() { }

	// RVA: 0x9B99E0 Offset: 0x9B83E0 VA: 0x1809B99E0
	public void SetPupilDilation(float dilation, bool writeDefault = True) { }

	// RVA: 0x9B96E0 Offset: 0x9B80E0 VA: 0x1809B96E0
	public void SetEyeballMaterial(Material material) { }

	// RVA: 0x9B9580 Offset: 0x9B7F80 VA: 0x1809B9580
	public void ResetEyeballMaterial() { }

	// RVA: 0x9B9660 Offset: 0x9B8060 VA: 0x1809B9660
	public void ResetPupilDilation() { }

	// RVA: 0x9B8F90 Offset: 0x9B7990 VA: 0x1809B8F90
	private void ApplyRestingEyeLidState() { }

	// RVA: 0x9B92C0 Offset: 0x9B7CC0 VA: 0x1809B92C0
	public void ForceBlink() { }

	// RVA: 0x9B99A0 Offset: 0x9B83A0 VA: 0x1809B99A0
	public void SetLeftEyeRestingLidState(Eye.EyeLidConfiguration config) { }

	// RVA: 0x9B9A70 Offset: 0x9B8470 VA: 0x1809B9A70
	public void SetRightEyeRestingLidState(Eye.EyeLidConfiguration config) { }

	[IteratorStateMachine(typeof(EyeController.<BlinkRoutine>d__47))]
	// RVA: 0x9B9250 Offset: 0x9B7C50 VA: 0x1809B9250
	private IEnumerator BlinkRoutine() { }

	// RVA: 0x9B9510 Offset: 0x9B7F10 VA: 0x1809B9510
	private void ResetBlinkCounter() { }

	// RVA: 0x9B9380 Offset: 0x9B7D80 VA: 0x1809B9380
	public void LookAt(Vector3 position, bool instant = False) { }

	// RVA: 0x9B9C40 Offset: 0x9B8640 VA: 0x1809B9C40
	public void .ctor() { }

	// RVA: 0x9B9C00 Offset: 0x9B8600 VA: 0x1809B9C00
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x9B9AB0 Offset: 0x9B84B0 VA: 0x1809B9AB0
	private bool <BlinkRoutine>b__47_0() { }
}
