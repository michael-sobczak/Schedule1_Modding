public class GrowContainerSurfaceCover : MonoBehaviour // TypeDefIndex: 2368
{
	// Fields
	public const int TextureSize = 128;
	public const int PourRadius = 32;
	public const int UpdatesPerSecond = 24;
	public const float CoveredPixelThreshold = 0.8;
	public const float Delay = 0.35;
	[CompilerGenerated]
	private float <CurrentCoverage>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <UseApplyOverTime>k__BackingField; // 0x24
	[Header("Settings")]
	public float SuccessfulCoverageThreshold; // 0x28
	[Header("References")]
	public GrowContainer GrowContainer; // 0x30
	public MeshRenderer MeshRenderer; // 0x38
	public Texture2D PourMask; // 0x40
	[Header("Pour Over time Settings")]
	[SerializeField]
	private float _applyPoutOverTimeDuration; // 0x48
	[SerializeField]
	private AnimationCurve _applyPoutOverTimeCurve; // 0x50
	public UnityEvent onSufficientCoverage; // 0x58
	private bool queued; // 0x60
	private Vector3 queuedWorldPos; // 0x64
	private Texture2D mainTex; // 0x70
	private Texture2D tempTex; // 0x78
	private Vector3 relative; // 0x80
	private Vector2 vector2; // 0x8C
	private Vector2 normalizedOffset; // 0x94
	private Vector2 originPixel; // 0x9C
	private float _pourApplicationStrength; // 0xA4

	// Properties
	public float CurrentCoverage { get; set; }
	public float PourApplicationStrength { get; set; }
	public bool UseApplyOverTime { get; set; }
	private float _sideLength { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_CurrentCoverage() { }

	[CompilerGenerated]
	// RVA: 0x49CD70 Offset: 0x49B770 VA: 0x18049CD70
	private void set_CurrentCoverage(float value) { }

	// RVA: 0x6A5290 Offset: 0x6A3C90 VA: 0x1806A5290
	public float get_PourApplicationStrength() { }

	// RVA: 0x85BA60 Offset: 0x85A460 VA: 0x18085BA60
	public void set_PourApplicationStrength(float value) { }

	[CompilerGenerated]
	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	public bool get_UseApplyOverTime() { }

	[CompilerGenerated]
	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	public void set_UseApplyOverTime(bool value) { }

	// RVA: 0x85BA30 Offset: 0x85A430 VA: 0x18085BA30
	private float get__sideLength() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Awake() { }

	// RVA: 0x85B8F0 Offset: 0x85A2F0 VA: 0x18085B8F0
	private void OnEnable() { }

	// RVA: 0x85B5D0 Offset: 0x859FD0 VA: 0x18085B5D0
	public void ConfigureAppearance(Color col, float transparency) { }

	// RVA: 0x85B990 Offset: 0x85A390 VA: 0x18085B990
	public void Reset() { }

	// RVA: 0x85B970 Offset: 0x85A370 VA: 0x18085B970
	public void QueuePour(Vector3 worldSpacePosition) { }

	// RVA: 0x85B860 Offset: 0x85A260 VA: 0x18085B860
	public float GetNormalizedProgress() { }

	[IteratorStateMachine(typeof(GrowContainerSurfaceCover.<CheckQueue>d__40))]
	// RVA: 0x85B560 Offset: 0x859F60 VA: 0x18085B560
	private IEnumerator CheckQueue() { }

	// RVA: 0x85B3B0 Offset: 0x859DB0 VA: 0x18085B3B0
	private void Blank() { }

	// RVA: 0x85B690 Offset: 0x85A090 VA: 0x18085B690
	private void DelayedApplyPour(Vector3 worldSpace) { }

	// RVA: 0x85B020 Offset: 0x859A20 VA: 0x18085B020
	private void ApplyPour(Vector3 worldSpace, bool applyOverTime = False) { }

	[IteratorStateMachine(typeof(GrowContainerSurfaceCover.<ApplyPourOverTime>d__44))]
	// RVA: 0x85AFB0 Offset: 0x8599B0 VA: 0x18085AFB0
	private IEnumerator ApplyPourOverTime() { }

	// RVA: 0x85B870 Offset: 0x85A270 VA: 0x18085B870
	private float GetPourMaskValue(int x, int y) { }

	// RVA: 0x85B780 Offset: 0x85A180 VA: 0x18085B780
	private float GetCoverage() { }

	// RVA: 0x85B9C0 Offset: 0x85A3C0 VA: 0x18085B9C0
	public void .ctor() { }
}
