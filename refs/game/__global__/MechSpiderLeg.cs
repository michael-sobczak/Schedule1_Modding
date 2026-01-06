public class MechSpiderLeg : MonoBehaviour // TypeDefIndex: 14236
{
	// Fields
	public MechSpider mechSpider; // 0x20
	public MechSpiderLeg unSync; // 0x28
	public Vector3 offset; // 0x30
	public float minDelay; // 0x3C
	public float maxOffset; // 0x40
	public float stepSpeed; // 0x44
	public float footHeight; // 0x48
	public float velocityPrediction; // 0x4C
	public float raycastFocus; // 0x50
	public AnimationCurve yOffset; // 0x58
	public Transform foot; // 0x60
	public Vector3 footUpAxis; // 0x68
	public float footRotationSpeed; // 0x74
	public ParticleSystem sand; // 0x78
	private IK ik; // 0x80
	private float stepProgress; // 0x88
	private float lastStepTime; // 0x8C
	private Vector3 defaultPosition; // 0x90
	private RaycastHit hit; // 0x9C
	private Quaternion lastFootLocalRotation; // 0xC8
	private Vector3 smoothHitNormal; // 0xD8
	private Vector3 lastStepPosition; // 0xE4

	// Properties
	public bool isStepping { get; }
	public Vector3 position { get; set; }

	// Methods

	// RVA: 0x1F44190 Offset: 0x1F42B90 VA: 0x181F44190
	public bool get_isStepping() { }

	// RVA: 0x1F441B0 Offset: 0x1F42BB0 VA: 0x181F441B0
	public Vector3 get_position() { }

	// RVA: 0x1F44220 Offset: 0x1F42C20 VA: 0x181F44220
	public void set_position(Vector3 value) { }

	// RVA: 0x1F42E50 Offset: 0x1F41850 VA: 0x181F42E50
	private void Awake() { }

	// RVA: 0x1F42B10 Offset: 0x1F41510 VA: 0x181F42B10
	private void AfterIK() { }

	// RVA: 0x1F435C0 Offset: 0x1F41FC0 VA: 0x181F435C0
	private void Start() { }

	// RVA: 0x1F43130 Offset: 0x1F41B30 VA: 0x181F43130
	private Vector3 GetStepTarget(out bool stepFound, float focus, float distance) { }

	// RVA: 0x1F43A60 Offset: 0x1F42460 VA: 0x181F43A60
	private void UpdatePosition(float distance) { }

	// RVA: 0x1F43D70 Offset: 0x1F42770 VA: 0x181F43D70
	private void Update() { }

	[IteratorStateMachine(typeof(MechSpiderLeg.<Step>d__33))]
	// RVA: 0x1F439C0 Offset: 0x1F423C0 VA: 0x181F439C0
	private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition) { }

	// RVA: 0x1F440F0 Offset: 0x1F42AF0 VA: 0x181F440F0
	public void .ctor() { }
}
