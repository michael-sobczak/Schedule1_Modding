public class FloatingContainer : CanvasGroupFader // TypeDefIndex: 18209
{
	// Fields
	[Tooltip("RectTransform to move.")]
	[SerializeField]
	[Group("Components", False)]
	protected RectTransform RectTransform; // 0x40
	[Tooltip("True to use edge avoidance.")]
	[SerializeField]
	[Group("Sizing", False)]
	protected bool UseEdgeAvoidance; // 0x48
	[Tooltip("How much to avoid screen edges when being moved.")]
	[SerializeField]
	[Group("Sizing", False)]
	[ShowIf("UseEdgeAvoidance", True, 3)]
	protected Vector2 EdgeAvoidance; // 0x4C
	private Vector3 _positionGoal; // 0x54
	private Quaternion _rotationGoal; // 0x60
	private Vector3 _scaleGoal; // 0x70
	private Nullable<Vector2> _edgeAvoidance; // 0x7C

	// Methods

	// RVA: 0xDA4730 Offset: 0xDA3130 VA: 0x180DA4730
	public void AttachGameObject(GameObject go) { }

	// RVA: 0xDA4F40 Offset: 0xDA3940 VA: 0x180DA4F40 Slot: 15
	public virtual void Show(Vector3 position, Quaternion rotation, Vector3 scale, Vector2 pivot, Nullable<Vector2> edgeAvoidanceOverride) { }

	// RVA: 0xDA4CF0 Offset: 0xDA36F0 VA: 0x180DA4CF0 Slot: 16
	public virtual void Show(Vector3 position, Nullable<Vector2> edgeAvoidanceOverride) { }

	// RVA: 0xDA4E30 Offset: 0xDA3830 VA: 0x180DA4E30 Slot: 17
	public virtual void Show(Vector3 position, Quaternion rotation, Nullable<Vector2> edgeAvoidanceOverride) { }

	// RVA: 0xDA4B20 Offset: 0xDA3520 VA: 0x180DA4B20 Slot: 18
	public virtual void Show(Transform startingPoint, Nullable<Vector2> edgeAvoidanceOverride) { }

	// RVA: 0xDA5160 Offset: 0xDA3B60 VA: 0x180DA5160 Slot: 19
	public virtual void UpdatePivot(Vector2 pivot, bool move = True) { }

	// RVA: 0xDA52F0 Offset: 0xDA3CF0 VA: 0x180DA52F0 Slot: 20
	public virtual void UpdatePosition(Vector3 position, bool move = True) { }

	// RVA: 0xDA5320 Offset: 0xDA3D20 VA: 0x180DA5320 Slot: 21
	public virtual void UpdateRotation(Quaternion rotation, bool move = True) { }

	// RVA: 0xDA5350 Offset: 0xDA3D50 VA: 0x180DA5350 Slot: 22
	public virtual void UpdateScale(Vector3 scale, bool move = True) { }

	// RVA: 0xDA51B0 Offset: 0xDA3BB0 VA: 0x180DA51B0 Slot: 23
	public virtual void UpdatePositionAndRotation(Vector3 position, Quaternion rotation, bool move = True) { }

	// RVA: 0xDA5250 Offset: 0xDA3C50 VA: 0x180DA5250 Slot: 24
	public virtual void UpdatePositionRotationAndScale(Vector3 position, Quaternion rotation, Vector3 scale, bool move = True) { }

	// RVA: 0xDA5070 Offset: 0xDA3A70 VA: 0x180DA5070 Slot: 25
	public virtual void UpdateEdgeAvoidance(Nullable<Vector2> edgeAvoidanceOverride, bool move = True) { }

	// RVA: 0xDA48B0 Offset: 0xDA32B0 VA: 0x180DA48B0 Slot: 26
	protected virtual void Move() { }

	// RVA: 0xDA5380 Offset: 0xDA3D80 VA: 0x180DA5380
	public void .ctor() { }
}
