public class CinemachineTargetGroup : MonoBehaviour, ICinemachineTargetGroup // TypeDefIndex: 16090
{
	// Fields
	[Tooltip("How the group's position is calculated.  Select GroupCenter for the center of the bounding box, and GroupAverage for a weighted average of the positions of the members.")]
	public CinemachineTargetGroup.PositionMode m_PositionMode; // 0x20
	[Tooltip("How the group's rotation is calculated.  Select Manual to use the value in the group's transform, and GroupAverage for a weighted average of the orientations of the members.")]
	public CinemachineTargetGroup.RotationMode m_RotationMode; // 0x24
	[Tooltip("When to update the group's transform based on the position of the group members")]
	public CinemachineTargetGroup.UpdateMethod m_UpdateMethod; // 0x28
	[NoSaveDuringPlay]
	[Tooltip("The target objects, together with their weights and radii, that will contribute to the group's average position, orientation, and size.")]
	public CinemachineTargetGroup.Target[] m_Targets; // 0x30
	private float m_MaxWeight; // 0x38
	private float m_WeightSum; // 0x3C
	private Vector3 m_AveragePos; // 0x40
	private Bounds m_BoundingBox; // 0x4C
	private BoundingSphere m_BoundingSphere; // 0x64
	private int m_LastUpdateFrame; // 0x74
	private List<int> m_ValidMembers; // 0x78
	private List<bool> m_MemberValidity; // 0x80

	// Properties
	public Transform Transform { get; }
	public Bounds BoundingBox { get; set; }
	public BoundingSphere Sphere { get; set; }
	public bool IsEmpty { get; }
	private bool CachedCountIsValid { get; }

	// Methods

	// RVA: 0xC08A60 Offset: 0xC07460 VA: 0x180C08A60
	private void OnValidate() { }

	// RVA: 0xC08C60 Offset: 0xC07660 VA: 0x180C08C60
	private void Reset() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 4
	public Transform get_Transform() { }

	// RVA: 0xC09260 Offset: 0xC07C60 VA: 0x180C09260 Slot: 5
	public Bounds get_BoundingBox() { }

	// RVA: 0xC093E0 Offset: 0xC07DE0 VA: 0x180C093E0
	private void set_BoundingBox(Bounds value) { }

	// RVA: 0xC09390 Offset: 0xC07D90 VA: 0x180C09390 Slot: 6
	public BoundingSphere get_Sphere() { }

	// RVA: 0xC09400 Offset: 0xC07E00 VA: 0x180C09400
	private void set_Sphere(BoundingSphere value) { }

	// RVA: 0xC09320 Offset: 0xC07D20 VA: 0x180C09320 Slot: 7
	public bool get_IsEmpty() { }

	// RVA: 0xC06760 Offset: 0xC05160 VA: 0x180C06760
	public void AddMember(Transform t, float weight, float radius) { }

	// RVA: 0xC08AF0 Offset: 0xC074F0 VA: 0x180C08AF0
	public void RemoveMember(Transform t) { }

	// RVA: 0xC07940 Offset: 0xC06340 VA: 0x180C07940
	public int FindMember(Transform t) { }

	// RVA: 0xC088F0 Offset: 0xC072F0 VA: 0x180C088F0
	public BoundingSphere GetWeightedBoundsForMember(int index) { }

	// RVA: 0xC08490 Offset: 0xC06E90 VA: 0x180C08490 Slot: 8
	public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer) { }

	// RVA: 0xC092C0 Offset: 0xC07CC0 VA: 0x180C092C0
	private bool get_CachedCountIsValid() { }

	// RVA: 0xC08A30 Offset: 0xC07430 VA: 0x180C08A30
	private bool IndexIsValid(int index) { }

	// RVA: 0xC09000 Offset: 0xC07A00 VA: 0x180C09000
	private static BoundingSphere WeightedMemberBoundsForValidMember(ref CinemachineTargetGroup.Target t, Vector3 avgPos, float maxWeight) { }

	// RVA: 0xC077E0 Offset: 0xC061E0 VA: 0x180C077E0
	public void DoUpdate() { }

	// RVA: 0xC08CC0 Offset: 0xC076C0 VA: 0x180C08CC0
	private void UpdateMemberValidity() { }

	// RVA: 0xC06D20 Offset: 0xC05720 VA: 0x180C06D20
	private Vector3 CalculateAveragePosition() { }

	// RVA: 0xC06F00 Offset: 0xC05900 VA: 0x180C06F00
	private Bounds CalculateBoundingBox() { }

	// RVA: 0xC07420 Offset: 0xC05E20 VA: 0x180C07420
	private BoundingSphere CalculateBoundingSphere() { }

	// RVA: 0xC068B0 Offset: 0xC052B0 VA: 0x180C068B0
	private Quaternion CalculateAverageOrientation() { }

	// RVA: 0xC07A20 Offset: 0xC06420 VA: 0x180C07A20
	private void FixedUpdate() { }

	// RVA: 0xC08FA0 Offset: 0xC079A0 VA: 0x180C08FA0
	private void Update() { }

	// RVA: 0xC08A50 Offset: 0xC07450 VA: 0x180C08A50
	private void LateUpdate() { }

	// RVA: 0xC07A30 Offset: 0xC06430 VA: 0x180C07A30 Slot: 9
	public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange) { }

	// RVA: 0xC09160 Offset: 0xC07B60 VA: 0x180C09160
	public void .ctor() { }
}
