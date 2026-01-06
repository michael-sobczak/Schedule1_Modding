public class PendulumExample : MonoBehaviour // TypeDefIndex: 14267
{
	// Fields
	[Range(0, 1)]
	[Tooltip("The master weight of this script.")]
	public float weight; // 0x20
	[Tooltip("Multiplier for the distance of the root to the target.")]
	public float hangingDistanceMlp; // 0x24
	[HideInInspector]
	[Tooltip("Where does the root of the character land when weight is blended out?")]
	public Vector3 rootTargetPosition; // 0x28
	[HideInInspector]
	[Tooltip("How is the root of the character rotated when weight is blended out?")]
	public Quaternion rootTargetRotation; // 0x34
	public Transform target; // 0x48
	public Transform leftHandTarget; // 0x50
	public Transform rightHandTarget; // 0x58
	public Transform leftFootTarget; // 0x60
	public Transform rightFootTarget; // 0x68
	public Transform pelvisTarget; // 0x70
	public Transform bodyTarget; // 0x78
	public Transform headTarget; // 0x80
	public Vector3 pelvisDownAxis; // 0x88
	private FullBodyBipedIK ik; // 0x98
	private Quaternion rootRelativeToPelvis; // 0xA0
	private Vector3 pelvisToRoot; // 0xB0
	private float lastWeight; // 0xBC

	// Methods

	// RVA: 0x1F489C0 Offset: 0x1F473C0 VA: 0x181F489C0
	private void Start() { }

	// RVA: 0x1F47CF0 Offset: 0x1F466F0 VA: 0x181F47CF0
	private void LateUpdate() { }

	// RVA: 0x1F48E90 Offset: 0x1F47890 VA: 0x181F48E90
	public void .ctor() { }
}
