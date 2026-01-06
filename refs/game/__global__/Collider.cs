public class Collider : Component // TypeDefIndex: 18470
{
	// Properties
	public bool enabled { get; set; }
	public Rigidbody attachedRigidbody { get; }
	public bool isTrigger { get; set; }
	public Bounds bounds { get; }
	public PhysicMaterial material { set; }

	// Methods

	// RVA: 0x2D32BD0 Offset: 0x2D315D0 VA: 0x182D32BD0
	public bool get_enabled() { }

	// RVA: 0x2D32C50 Offset: 0x2D31650 VA: 0x182D32C50
	public void set_enabled(bool value) { }

	[NativeMethod("GetRigidbody")]
	// RVA: 0x2D32AE0 Offset: 0x2D314E0 VA: 0x182D32AE0
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x2D32C10 Offset: 0x2D31610 VA: 0x182D32C10
	public bool get_isTrigger() { }

	// RVA: 0x2D32CA0 Offset: 0x2D316A0 VA: 0x182D32CA0
	public void set_isTrigger(bool value) { }

	// RVA: 0x2D328C0 Offset: 0x2D312C0 VA: 0x182D328C0
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x2D32B70 Offset: 0x2D31570 VA: 0x182D32B70
	public Bounds get_bounds() { }

	[NativeMethod("SetMaterial")]
	// RVA: 0x2D32CF0 Offset: 0x2D316F0 VA: 0x182D32CF0
	public void set_material(PhysicMaterial value) { }

	// RVA: 0x2D32990 Offset: 0x2D31390 VA: 0x182D32990
	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	// RVA: 0x2D32A10 Offset: 0x2D31410 VA: 0x182D32A10
	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2D32860 Offset: 0x2D31260 VA: 0x182D32860
	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2D32B20 Offset: 0x2D31520 VA: 0x182D32B20
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x2D32920 Offset: 0x2D31320 VA: 0x182D32920
	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }
}
