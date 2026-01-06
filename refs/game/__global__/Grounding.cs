public class Grounding // TypeDefIndex: 14073
{
	// Fields
	[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
	public LayerMask layers; // 0x10
	[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
	public float maxStep; // 0x14
	[Tooltip("The height offset of the root.")]
	public float heightOffset; // 0x18
	[Tooltip("The speed of moving the feet up/down.")]
	public float footSpeed; // 0x1C
	[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
	public float footRadius; // 0x20
	[Tooltip("Offset of the foot center along character forward axis.")]
	[HideInInspector]
	public float footCenterOffset; // 0x24
	[Tooltip("Amount of velocity based prediction of the foot positions.")]
	public float prediction; // 0x28
	[Tooltip("Weight of rotating the feet to the ground normal offset.")]
	[Range(0, 1)]
	public float footRotationWeight; // 0x2C
	[Tooltip("Speed of slerping the feet to their grounded rotations.")]
	public float footRotationSpeed; // 0x30
	[Range(0, 90)]
	[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
	public float maxFootRotationAngle; // 0x34
	[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
	public bool rotateSolver; // 0x38
	[Tooltip("The speed of moving the character up/down.")]
	public float pelvisSpeed; // 0x3C
	[Range(0, 1)]
	[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
	public float pelvisDamper; // 0x40
	[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
	public float lowerPelvisWeight; // 0x44
	[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
	public float liftPelvisWeight; // 0x48
	[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
	public float rootSphereCastRadius; // 0x4C
	[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
	public bool overstepFallsDown; // 0x50
	[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
	public Grounding.Quality quality; // 0x54
	[CompilerGenerated]
	private Grounding.Leg[] <legs>k__BackingField; // 0x58
	[CompilerGenerated]
	private Grounding.Pelvis <pelvis>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <isGrounded>k__BackingField; // 0x68
	[CompilerGenerated]
	private Transform <root>k__BackingField; // 0x70
	[CompilerGenerated]
	private RaycastHit <rootHit>k__BackingField; // 0x78
	public Grounding.OnRaycastDelegate Raycast; // 0xA8
	public Grounding.OnCapsuleCastDelegate CapsuleCast; // 0xB0
	public Grounding.OnSphereCastDelegate SphereCast; // 0xB8
	private bool initiated; // 0xC0

	// Properties
	public Grounding.Leg[] legs { get; set; }
	public Grounding.Pelvis pelvis { get; set; }
	public bool isGrounded { get; set; }
	public Transform root { get; set; }
	public RaycastHit rootHit { get; set; }
	public bool rootGrounded { get; }
	public Vector3 up { get; }
	private bool useRootRotation { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public Grounding.Leg[] get_legs() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	private void set_legs(Grounding.Leg[] value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public Grounding.Pelvis get_pelvis() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	private void set_pelvis(Grounding.Pelvis value) { }

	[CompilerGenerated]
	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	public bool get_isGrounded() { }

	[CompilerGenerated]
	// RVA: 0xCE3E20 Offset: 0xCE2820 VA: 0x180CE3E20
	private void set_isGrounded(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public Transform get_root() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	private void set_root(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x1EC4420 Offset: 0x1EC2E20 VA: 0x181EC4420
	public RaycastHit get_rootHit() { }

	[CompilerGenerated]
	// RVA: 0x1EC45B0 Offset: 0x1EC2FB0 VA: 0x181EC45B0
	private void set_rootHit(RaycastHit value) { }

	// RVA: 0x1EC43C0 Offset: 0x1EC2DC0 VA: 0x181EC43C0
	public bool get_rootGrounded() { }

	// RVA: 0x1EC2FC0 Offset: 0x1EC19C0 VA: 0x181EC2FC0
	public RaycastHit GetRootHit(float maxDistanceMlp = 10) { }

	// RVA: 0x1EC3AE0 Offset: 0x1EC24E0 VA: 0x181EC3AE0
	public bool IsValid(ref string errorMessage) { }

	// RVA: 0x1EC35C0 Offset: 0x1EC1FC0 VA: 0x181EC35C0
	public void Initiate(Transform root, Transform[] feet) { }

	// RVA: 0x1EC3E20 Offset: 0x1EC2820 VA: 0x181EC3E20
	public void Update() { }

	// RVA: 0x1EC2D10 Offset: 0x1EC1710 VA: 0x181EC2D10
	public Vector3 GetLegsPlaneNormal() { }

	// RVA: 0x1EC3C20 Offset: 0x1EC2620 VA: 0x181EC3C20
	public void Reset() { }

	// RVA: 0x1EC3C00 Offset: 0x1EC2600 VA: 0x181EC3C00
	public void LogWarning(string message) { }

	// RVA: 0x1EC4450 Offset: 0x1EC2E50 VA: 0x181EC4450
	public Vector3 get_up() { }

	// RVA: 0x1EC34C0 Offset: 0x1EC1EC0 VA: 0x181EC34C0
	public float GetVerticalOffset(Vector3 p1, Vector3 p2) { }

	// RVA: 0x1EC2A50 Offset: 0x1EC1450 VA: 0x181EC2A50
	public Vector3 Flatten(Vector3 v) { }

	// RVA: 0x1EC44E0 Offset: 0x1EC2EE0 VA: 0x181EC44E0
	private bool get_useRootRotation() { }

	// RVA: 0x1EC2C30 Offset: 0x1EC1630 VA: 0x181EC2C30
	public Vector3 GetFootCenterOffset() { }

	// RVA: 0x1EC40F0 Offset: 0x1EC2AF0 VA: 0x181EC40F0
	public void .ctor() { }
}
