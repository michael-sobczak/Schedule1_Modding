public class EditorIKPose : ScriptableObject // TypeDefIndex: 14186
{
	// Fields
	public Vector3[] localPositions; // 0x18
	public Quaternion[] localRotations; // 0x20

	// Properties
	public bool poseStored { get; }

	// Methods

	// RVA: 0x1F1E850 Offset: 0x1F1D250 VA: 0x181F1E850
	public bool get_poseStored() { }

	// RVA: 0x1F1E660 Offset: 0x1F1D060 VA: 0x181F1E660
	public void Store(Transform[] T) { }

	// RVA: 0x1F1E4E0 Offset: 0x1F1CEE0 VA: 0x181F1E4E0
	public bool Restore(Transform[] T) { }

	// RVA: 0x1F1E7D0 Offset: 0x1F1D1D0 VA: 0x181F1E7D0
	public void .ctor() { }
}
