public class MecanimBridge : VersionedMonoBehaviour // TypeDefIndex: 13462
{
	// Fields
	public float velocitySmoothing; // 0x28
	private IAstarAI ai; // 0x30
	private Animator anim; // 0x38
	private Transform tr; // 0x40
	private Vector3 smoothedVelocity; // 0x48
	private Vector3[] prevFootPos; // 0x58
	private Transform[] footTransforms; // 0x60

	// Methods

	// RVA: 0xBCEB50 Offset: 0xBCD550 VA: 0x180BCEB50 Slot: 7
	protected override void Awake() { }

	// RVA: 0xBCFEF0 Offset: 0xBCE8F0 VA: 0x180BCFEF0
	private void Update() { }

	// RVA: 0xBCED00 Offset: 0xBCD700 VA: 0x180BCED00
	private Vector3 CalculateBlendPoint() { }

	// RVA: 0xBCF110 Offset: 0xBCDB10 VA: 0x180BCF110
	private void OnAnimatorMove() { }

	// RVA: 0xBCFBF0 Offset: 0xBCE5F0 VA: 0x180BCFBF0
	private static Vector3 RotatePointAround(Vector3 point, Vector3 around, Quaternion rotation) { }

	// RVA: 0xBCFCC0 Offset: 0xBCE6C0 VA: 0x180BCFCC0 Slot: 10
	protected virtual Quaternion RotateTowards(Vector3 direction, float maxDegrees) { }

	// RVA: 0xBCFF80 Offset: 0xBCE980 VA: 0x180BCFF80
	public void .ctor() { }
}
