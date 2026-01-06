public class FlockController : MonoBehaviour // TypeDefIndex: 76
{
	// Fields
	public FlockChild _childPrefab; // 0x20
	public int _childAmount; // 0x28
	public bool _slowSpawn; // 0x2C
	public float _spawnSphere; // 0x30
	public float _spawnSphereHeight; // 0x34
	public float _spawnSphereDepth; // 0x38
	public float _minSpeed; // 0x3C
	public float _maxSpeed; // 0x40
	public float _minScale; // 0x44
	public float _maxScale; // 0x48
	public float _soarFrequency; // 0x4C
	public string _soarAnimation; // 0x50
	public string _flapAnimation; // 0x58
	public string _idleAnimation; // 0x60
	public float _diveValue; // 0x68
	public float _diveFrequency; // 0x6C
	public float _minDamping; // 0x70
	public float _maxDamping; // 0x74
	public float _waypointDistance; // 0x78
	public float _minAnimationSpeed; // 0x7C
	public float _maxAnimationSpeed; // 0x80
	public float _randomPositionTimer; // 0x84
	public float _positionSphere; // 0x88
	public float _positionSphereHeight; // 0x8C
	public float _positionSphereDepth; // 0x90
	public bool _childTriggerPos; // 0x94
	public bool _forceChildWaypoints; // 0x95
	public float _forcedRandomDelay; // 0x98
	public bool _flatFly; // 0x9C
	public bool _flatSoar; // 0x9D
	public bool _birdAvoid; // 0x9E
	public int _birdAvoidHorizontalForce; // 0xA0
	public bool _birdAvoidDown; // 0xA4
	public bool _birdAvoidUp; // 0xA5
	public int _birdAvoidVerticalForce; // 0xA8
	public float _birdAvoidDistanceMax; // 0xAC
	public float _birdAvoidDistanceMin; // 0xB0
	public float _soarMaxTime; // 0xB4
	public LayerMask _avoidanceMask; // 0xB8
	public List<FlockChild> _roamers; // 0xC0
	public Vector3 _posBuffer; // 0xC8
	public int _updateDivisor; // 0xD4
	public float _newDelta; // 0xD8
	public int _updateCounter; // 0xDC
	public float _activeChildren; // 0xE0
	public bool _groupChildToNewTransform; // 0xE4
	public Transform _groupTransform; // 0xE8
	public string _groupName; // 0xF0
	public bool _groupChildToFlock; // 0xF8
	public Vector3 _startPosOffset; // 0xFC
	public Transform _thisT; // 0x108

	// Methods

	// RVA: 0x55C4E0 Offset: 0x55AEE0 VA: 0x18055C4E0
	public void Start() { }

	// RVA: 0x55B9A0 Offset: 0x55A3A0 VA: 0x18055B9A0
	public void AddChild(int amount) { }

	// RVA: 0x55B930 Offset: 0x55A330 VA: 0x18055B930
	public void AddChildToParent(Transform obj) { }

	// RVA: 0x55C150 Offset: 0x55AB50 VA: 0x18055C150
	public void RemoveChild(int amount) { }

	// RVA: 0x55C790 Offset: 0x55B190 VA: 0x18055C790
	public void Update() { }

	// RVA: 0x55BC90 Offset: 0x55A690 VA: 0x18055BC90
	public void InstantiateGroup() { }

	// RVA: 0x55C610 Offset: 0x55B010 VA: 0x18055C610
	public void UpdateChildAmount() { }

	// RVA: 0x55BE20 Offset: 0x55A820 VA: 0x18055BE20
	public void OnDrawGizmos() { }

	// RVA: 0x55C270 Offset: 0x55AC70 VA: 0x18055C270
	public void SetFlockRandomPosition() { }

	// RVA: 0x55CB20 Offset: 0x55B520 VA: 0x18055CB20
	public void destroyBirds() { }

	// RVA: 0x55C970 Offset: 0x55B370 VA: 0x18055C970
	public void .ctor() { }
}
