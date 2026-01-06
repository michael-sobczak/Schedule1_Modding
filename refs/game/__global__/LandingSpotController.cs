public class LandingSpotController : MonoBehaviour // TypeDefIndex: 84
{
	// Fields
	public bool _randomRotate; // 0x20
	public Vector2 _autoCatchDelay; // 0x24
	public Vector2 _autoDismountDelay; // 0x2C
	public float _maxBirdDistance; // 0x34
	public float _minBirdDistance; // 0x38
	public bool _takeClosest; // 0x3C
	public FlockController _flock; // 0x40
	public bool _landOnStart; // 0x48
	public bool _soarLand; // 0x49
	public bool _onlyBirdsAbove; // 0x4A
	public float _landingSpeedModifier; // 0x4C
	public float _landingTurnSpeedModifier; // 0x50
	public Transform _featherPS; // 0x58
	public Transform _thisT; // 0x60
	public int _activeLandingSpots; // 0x68
	public float _snapLandDistance; // 0x6C
	public float _landedRotateSpeed; // 0x70
	public float _gizmoSize; // 0x74

	// Methods

	// RVA: 0x55FC20 Offset: 0x55E620 VA: 0x18055FC20
	public void Start() { }

	// RVA: 0x55FAD0 Offset: 0x55E4D0 VA: 0x18055FAD0
	public void ScareAll() { }

	// RVA: 0x55F970 Offset: 0x55E370 VA: 0x18055F970
	public void ScareAll(float minDelay, float maxDelay) { }

	// RVA: 0x55F820 Offset: 0x55E220 VA: 0x18055F820
	public void LandAll() { }

	[IteratorStateMachine(typeof(LandingSpotController.<InstantLandOnStart>d__22))]
	// RVA: 0x55F720 Offset: 0x55E120 VA: 0x18055F720
	public IEnumerator InstantLandOnStart(float delay) { }

	[IteratorStateMachine(typeof(LandingSpotController.<InstantLand>d__23))]
	// RVA: 0x55F7A0 Offset: 0x55E1A0 VA: 0x18055F7A0
	public IEnumerator InstantLand(float delay) { }

	// RVA: 0x55FEA0 Offset: 0x55E8A0 VA: 0x18055FEA0
	public void .ctor() { }
}
