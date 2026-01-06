public abstract class NavGraph : IGraphInternals // TypeDefIndex: 13219
{
	// Fields
	public AstarPath active; // 0x10
	[JsonMember]
	public Guid guid; // 0x18
	[JsonMember]
	public uint initialPenalty; // 0x28
	[JsonMember]
	public bool open; // 0x2C
	public uint graphIndex; // 0x30
	[JsonMember]
	public string name; // 0x38
	[JsonMember]
	public bool drawGizmos; // 0x40
	[JsonMember]
	public bool infoScreenOpen; // 0x41
	[JsonMember]
	private string serializedEditorSettings; // 0x48
	[Obsolete("Use the transform field (only available on some graph types) instead", True)]
	public Matrix4x4 matrix; // 0x50
	[Obsolete("Use the transform field (only available on some graph types) instead", True)]
	public Matrix4x4 inverseMatrix; // 0x90

	// Properties
	internal bool exists { get; }
	private string Pathfinding.IGraphInternals.SerializedEditorSettings { get; set; }

	// Methods

	// RVA: 0xB1E4F0 Offset: 0xB1CEF0 VA: 0x180B1E4F0
	internal bool get_exists() { }

	// RVA: 0xB1D530 Offset: 0xB1BF30 VA: 0x180B1D530 Slot: 13
	public virtual int CountNodes() { }

	// RVA: 0xB1DCE0 Offset: 0xB1C6E0 VA: 0x180B1DCE0
	public void GetNodes(Func<GraphNode, bool> action) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void GetNodes(Action<GraphNode> action);

	[Obsolete("Use the transform field (only available on some graph types) instead", True)]
	// RVA: 0xB1E3C0 Offset: 0xB1CDC0 VA: 0x180B1E3C0
	public void SetMatrix(Matrix4x4 m) { }

	[Obsolete("Use RelocateNodes(Matrix4x4) instead. To keep the same behavior you can call RelocateNodes(newMatrix * oldMatrix.inverse).")]
	// RVA: 0xB1E2B0 Offset: 0xB1CCB0 VA: 0x180B1E2B0
	public void RelocateNodes(Matrix4x4 oldMatrix, Matrix4x4 newMatrix) { }

	// RVA: 0xB1D4A0 Offset: 0xB1BEA0 VA: 0x180B1D4A0
	protected void AssertSafeToUpdateGraph() { }

	// RVA: 0xB1E1D0 Offset: 0xB1CBD0 VA: 0x180B1E1D0 Slot: 15
	public virtual void RelocateNodes(Matrix4x4 deltaMatrix) { }

	// RVA: 0xB1DC40 Offset: 0xB1C640 VA: 0x180B1DC40
	public NNInfoInternal GetNearest(Vector3 position) { }

	// RVA: 0xB1D960 Offset: 0xB1C360 VA: 0x180B1D960
	public NNInfoInternal GetNearest(Vector3 position, NNConstraint constraint) { }

	// RVA: 0xB1D9D0 Offset: 0xB1C3D0 VA: 0x180B1D9D0 Slot: 16
	public virtual NNInfoInternal GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint) { }

	// RVA: 0xB1D960 Offset: 0xB1C360 VA: 0x180B1D960 Slot: 17
	public virtual NNInfoInternal GetNearestForce(Vector3 position, NNConstraint constraint) { }

	// RVA: 0xB1DDB0 Offset: 0xB1C7B0 VA: 0x180B1DDB0 Slot: 18
	protected virtual void OnDestroy() { }

	// RVA: 0xB1D720 Offset: 0xB1C120 VA: 0x180B1D720 Slot: 19
	protected virtual void DestroyAllNodes() { }

	[Obsolete("Use AstarPath.Scan instead")]
	// RVA: 0xB1E390 Offset: 0xB1CD90 VA: 0x180B1E390
	public void ScanGraph() { }

	// RVA: 0xB1E390 Offset: 0xB1CD90 VA: 0x180B1E390
	public void Scan() { }

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract IEnumerable<Progress> ScanInternal();

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 21
	protected virtual void SerializeExtraInfo(GraphSerializationContext ctx) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	protected virtual void DeserializeExtraInfo(GraphSerializationContext ctx) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 23
	protected virtual void PostDeserialization(GraphSerializationContext ctx) { }

	// RVA: 0xB1D600 Offset: 0xB1C000 VA: 0x180B1D600 Slot: 24
	protected virtual void DeserializeSettingsCompatibility(GraphSerializationContext ctx) { }

	// RVA: 0xB1DDD0 Offset: 0xB1C7D0 VA: 0x180B1DDD0 Slot: 25
	public virtual void OnDrawGizmos(RetainedGizmos gizmos, bool drawNodes) { }

	// RVA: 0xB1D840 Offset: 0xB1C240 VA: 0x180B1D840
	protected void DrawUnwalkableNodes(float size) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 4
	private string Pathfinding.IGraphInternals.get_SerializedEditorSettings() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30 Slot: 5
	private void Pathfinding.IGraphInternals.set_SerializedEditorSettings(string value) { }

	// RVA: 0xB1E170 Offset: 0xB1CB70 VA: 0x180B1E170 Slot: 6
	private void Pathfinding.IGraphInternals.OnDestroy() { }

	// RVA: 0xB1DDB0 Offset: 0xB1C7B0 VA: 0x180B1DDB0 Slot: 7
	private void Pathfinding.IGraphInternals.DestroyAllNodes() { }

	// RVA: 0x7722F0 Offset: 0x770CF0 VA: 0x1807722F0 Slot: 8
	private IEnumerable<Progress> Pathfinding.IGraphInternals.ScanInternal() { }

	// RVA: 0xB1E1B0 Offset: 0xB1CBB0 VA: 0x180B1E1B0 Slot: 9
	private void Pathfinding.IGraphInternals.SerializeExtraInfo(GraphSerializationContext ctx) { }

	// RVA: 0xB1E130 Offset: 0xB1CB30 VA: 0x180B1E130 Slot: 10
	private void Pathfinding.IGraphInternals.DeserializeExtraInfo(GraphSerializationContext ctx) { }

	// RVA: 0xB1E190 Offset: 0xB1CB90 VA: 0x180B1E190 Slot: 11
	private void Pathfinding.IGraphInternals.PostDeserialization(GraphSerializationContext ctx) { }

	// RVA: 0xB1E150 Offset: 0xB1CB50 VA: 0x180B1E150 Slot: 12
	private void Pathfinding.IGraphInternals.DeserializeSettingsCompatibility(GraphSerializationContext ctx) { }

	// RVA: 0xB1E430 Offset: 0xB1CE30 VA: 0x180B1E430
	protected void .ctor() { }
}
