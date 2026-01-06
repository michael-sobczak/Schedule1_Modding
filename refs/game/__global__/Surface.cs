public class Surface : MonoBehaviour, IGUIDRegisterable // TypeDefIndex: 2123
{
	// Fields
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x20
	[SerializeField]
	[CompilerGenerated]
	private Property <ParentProperty>k__BackingField; // 0x30
	[Header("Settings")]
	public Surface.ESurfaceType SurfaceType; // 0x38
	public List<Surface.EFace> ValidFaces; // 0x40
	[SerializeField]
	protected string BakedGUID; // 0x48

	// Properties
	public Guid GUID { get; set; }
	public Transform Container { get; }
	public Property ParentProperty { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4976D0 Offset: 0x4960D0 VA: 0x1804976D0 Slot: 4
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x4976E0 Offset: 0x4960E0 VA: 0x1804976E0
	protected void set_GUID(Guid value) { }

	// RVA: 0x80CE40 Offset: 0x80B840 VA: 0x18080CE40
	public Transform get_Container() { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public Property get_ParentProperty() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_ParentProperty(Property value) { }

	[Button]
	// RVA: 0x80CC80 Offset: 0x80B680 VA: 0x18080CC80
	public void RegenerateGUID() { }

	// RVA: 0x80CBB0 Offset: 0x80B5B0 VA: 0x18080CBB0
	private void OnValidate() { }

	// RVA: 0x80C6F0 Offset: 0x80B0F0 VA: 0x18080C6F0
	private void OnDrawGizmos() { }

	// RVA: 0x80BE70 Offset: 0x80A870 VA: 0x18080BE70 Slot: 7
	protected virtual void Awake() { }

	// RVA: 0x80CCD0 Offset: 0x80B6D0 VA: 0x18080CCD0 Slot: 6
	public void SetGUID(Guid guid) { }

	// RVA: 0x80C030 Offset: 0x80AA30 VA: 0x18080C030
	public Vector3 GetRelativePosition(Vector3 worldPosition) { }

	// RVA: 0x80C0A0 Offset: 0x80AAA0 VA: 0x18080C0A0
	public Quaternion GetRelativeRotation(Quaternion worldRotation) { }

	// RVA: 0x80C280 Offset: 0x80AC80 VA: 0x18080C280
	public bool IsFrontFace(Vector3 point, Collider collider) { }

	// RVA: 0x80C2E0 Offset: 0x80ACE0 VA: 0x18080C2E0
	public bool IsPointValid(Vector3 point, Collider hitCollider) { }

	// RVA: 0x80CD30 Offset: 0x80B730 VA: 0x18080CD30
	public void .ctor() { }
}
