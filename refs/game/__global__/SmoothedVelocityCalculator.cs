public class SmoothedVelocityCalculator : MonoBehaviour // TypeDefIndex: 2334
{
	// Fields
	private const int sampleCount = 20;
	public bool DEBUG; // 0x20
	[CompilerGenerated]
	private Transform <Target>k__BackingField; // 0x28
	[Header("Settings")]
	public float SampleLength; // 0x30
	public float MaxReasonableVelocity; // 0x34
	private RollingAverage<Vector3> velocityHistory; // 0x38
	private Vector3 lastSamplePosition; // 0x40
	private float timeOnLastSample; // 0x4C
	private float timeSinceLastSample; // 0x50
	private bool zeroOut; // 0x54
	private bool isTargetValid; // 0x55

	// Properties
	public Transform Target { get; set; }
	public virtual Vector3 Velocity { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Transform get_Target() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_Target(Transform value) { }

	// RVA: 0x86D1B0 Offset: 0x86BBB0 VA: 0x18086D1B0 Slot: 4
	public virtual Vector3 get_Velocity() { }

	// RVA: 0x86CD00 Offset: 0x86B700 VA: 0x18086CD00
	private void Start() { }

	// RVA: 0x86C860 Offset: 0x86B260 VA: 0x18086C860 Slot: 5
	protected virtual void FixedUpdate() { }

	// RVA: 0x86CB50 Offset: 0x86B550 VA: 0x18086CB50
	public void FlushBuffer() { }

	// RVA: 0x86CDB0 Offset: 0x86B7B0 VA: 0x18086CDB0
	public void ZeroOut(float duration) { }

	// RVA: 0x86CC00 Offset: 0x86B600 VA: 0x18086CC00
	public void SetTarget(Transform target) { }

	// RVA: 0x86CEA0 Offset: 0x86B8A0 VA: 0x18086CEA0
	public void .ctor() { }
}
