public class MeleeWeaponTrail : MonoBehaviour // TypeDefIndex: 98
{
	// Fields
	[SerializeField]
	private bool _emit; // 0x20
	private bool _use; // 0x21
	[SerializeField]
	private float _emitTime; // 0x24
	[SerializeField]
	private Material _material; // 0x28
	[SerializeField]
	private float _lifeTime; // 0x30
	[SerializeField]
	private Color[] _colors; // 0x38
	[SerializeField]
	private float[] _sizes; // 0x40
	[SerializeField]
	private float _minVertexDistance; // 0x48
	[SerializeField]
	private float _maxVertexDistance; // 0x4C
	private float _minVertexDistanceSqr; // 0x50
	private float _maxVertexDistanceSqr; // 0x54
	[SerializeField]
	private float _maxAngle; // 0x58
	[SerializeField]
	private bool _autoDestruct; // 0x5C
	[SerializeField]
	private int subdivisions; // 0x60
	[SerializeField]
	private Transform _base; // 0x68
	[SerializeField]
	private Transform _tip; // 0x70
	private List<MeleeWeaponTrail.Point> _points; // 0x78
	private List<MeleeWeaponTrail.Point> _smoothedPoints; // 0x80
	private GameObject _trailObject; // 0x88
	private Mesh _trailMesh; // 0x90
	private Vector3 _lastPosition; // 0x98

	// Properties
	public bool Emit { set; }
	public bool Use { set; }

	// Methods

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_Emit(bool value) { }

	// RVA: 0x563DA0 Offset: 0x5627A0 VA: 0x180563DA0
	public void set_Use(bool value) { }

	// RVA: 0x577320 Offset: 0x575D20 VA: 0x180577320
	private void Start() { }

	// RVA: 0x577060 Offset: 0x575A60 VA: 0x180577060
	private void OnDisable() { }

	// RVA: 0x577700 Offset: 0x576100 VA: 0x180577700
	private void Update() { }

	// RVA: 0x5770B0 Offset: 0x575AB0 VA: 0x1805770B0
	private void RemoveOldPoints(List<MeleeWeaponTrail.Point> pointList) { }

	// RVA: 0x578C40 Offset: 0x577640 VA: 0x180578C40
	public void .ctor() { }
}
