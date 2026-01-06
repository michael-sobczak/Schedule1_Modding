public class RollbackManager : MonoBehaviour // TypeDefIndex: 12654
{
	// Fields
	private Nullable<int> _boundingBoxLayerNumber; // 0x20
	[Tooltip("Layer to use when creating and checking against bounding boxes. This should be different from any layer used.")]
	[SerializeField]
	private LayerMask _boundingBoxLayer; // 0x28
	[Tooltip("Maximum time in the past colliders can be rolled back to.")]
	[SerializeField]
	private float _maximumRollbackTime; // 0x2C
	[Tooltip("Interpolation value for the NetworkTransforms or objects being rolled back.")]
	[Range(0, 250)]
	[SerializeField]
	internal ushort Interpolation; // 0x30

	// Properties
	internal Nullable<int> BoundingBoxLayerNumber { get; }
	internal LayerMask BoundingBoxLayer { get; }
	internal float MaximumRollbackTime { get; }

	// Methods

	// RVA: 0xD3ACB0 Offset: 0xD396B0 VA: 0x180D3ACB0
	internal Nullable<int> get_BoundingBoxLayerNumber() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	internal LayerMask get_BoundingBoxLayer() { }

	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0
	internal float get_MaximumRollbackTime() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void InitializeOnce_Internal(NetworkManager manager) { }

	[Obsolete("Use Rollback(PreciseTick, RollbackPhysicsType, bool)")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Rollback(PreciseTick pt, RollbackManager.PhysicsType physicsType, bool asOwner = False) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Rollback(PreciseTick pt, RollbackPhysicsType physicsType, bool asOwner = False) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Rollback(Scene scene, PreciseTick pt, RollbackPhysicsType physicsType, bool asOwner = False) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Rollback(int sceneHandle, PreciseTick pt, RollbackPhysicsType physicsType, bool asOwner = False) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Rollback(Vector3 origin, Vector3 normalizedDirection, float distance, PreciseTick pt, bool asOwner = False) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Rollback(Scene scene, Vector3 origin, Vector3 normalizedDirection, float distance, PreciseTick pt, bool asOwner = False) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Rollback(int sceneHandle, Vector3 origin, Vector3 normalizedDirection, float distance, PreciseTick pt, bool asOwner = False) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Rollback(Vector2 origin, Vector2 normalizedDirection, float distance, PreciseTick pt, bool asOwner = False) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Return() { }

	// RVA: 0xD3AC70 Offset: 0xD39670 VA: 0x180D3AC70
	public void .ctor() { }
}
