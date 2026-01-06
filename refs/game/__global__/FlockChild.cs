public class FlockChild : MonoBehaviour // TypeDefIndex: 74
{
	// Fields
	[HideInInspector]
	public FlockController _spawner; // 0x20
	[HideInInspector]
	public Vector3 _wayPoint; // 0x28
	public float _speed; // 0x34
	[HideInInspector]
	public bool _dived; // 0x38
	[HideInInspector]
	public float _stuckCounter; // 0x3C
	[HideInInspector]
	public float _damping; // 0x40
	[HideInInspector]
	public bool _soar; // 0x44
	[HideInInspector]
	public bool _landing; // 0x45
	[HideInInspector]
	public float _targetSpeed; // 0x48
	[HideInInspector]
	public bool _move; // 0x4C
	public GameObject _model; // 0x50
	public Transform _modelT; // 0x58
	[HideInInspector]
	public float _avoidValue; // 0x60
	[HideInInspector]
	public float _avoidDistance; // 0x64
	private float _soarTimer; // 0x68
	private bool _instantiated; // 0x6C
	private static int _updateNextSeed; // 0x0
	private int _updateSeed; // 0x70
	[HideInInspector]
	public bool _avoid; // 0x74
	public Transform _thisT; // 0x78
	public Vector3 _landingPosOffset; // 0x80

	// Methods

	// RVA: 0x55B090 Offset: 0x559A90 VA: 0x18055B090
	public void Start() { }

	// RVA: 0x55B390 Offset: 0x559D90 VA: 0x18055B390
	public void Update() { }

	// RVA: 0x55A700 Offset: 0x559100 VA: 0x18055A700
	public void OnDisable() { }

	// RVA: 0x55A740 Offset: 0x559140 VA: 0x18055A740
	public void OnEnable() { }

	// RVA: 0x55A0D0 Offset: 0x558AD0 VA: 0x18055A0D0
	public void FindRequiredComponents() { }

	// RVA: 0x55A800 Offset: 0x559200 VA: 0x18055A800
	public void RandomizeStartAnimationFrame() { }

	// RVA: 0x55A300 Offset: 0x558D00 VA: 0x18055A300
	public void InitAvoidanceValues() { }

	// RVA: 0x55AF20 Offset: 0x559920 VA: 0x18055AF20
	public void SetRandomScale() { }

	// RVA: 0x55AF80 Offset: 0x559980 VA: 0x18055AF80
	public void SoarTimeLimit() { }

	// RVA: 0x559CD0 Offset: 0x5586D0 VA: 0x180559CD0
	public void CheckForDistanceToWaypoint() { }

	// RVA: 0x55AA20 Offset: 0x559420 VA: 0x18055AA20
	public void RotationBasedOnWaypointOrAvoidance() { }

	// RVA: 0x559390 Offset: 0x557D90 VA: 0x180559390
	public bool Avoidance() { }

	// RVA: 0x55A380 Offset: 0x558D80 VA: 0x18055A380
	public void LimitRotationOfModel() { }

	// RVA: 0x55B4F0 Offset: 0x559EF0 VA: 0x18055B4F0
	public void Wander(float delay) { }

	// RVA: 0x55ADD0 Offset: 0x5597D0 VA: 0x18055ADD0
	public void SetRandomMode() { }

	// RVA: 0x55A210 Offset: 0x558C10 VA: 0x18055A210
	public void Flap() { }

	// RVA: 0x55B830 Offset: 0x55A230 VA: 0x18055B830
	public Vector3 findWaypoint() { }

	// RVA: 0x55AFF0 Offset: 0x5599F0 VA: 0x18055AFF0
	public void Soar() { }

	// RVA: 0x559DA0 Offset: 0x5587A0 VA: 0x180559DA0
	public void Dive() { }

	// RVA: 0x55B5B0 Offset: 0x559FB0 VA: 0x18055B5B0
	public void animationSpeed() { }

	// RVA: 0x55B590 Offset: 0x559F90 VA: 0x18055B590
	public void .ctor() { }
}
