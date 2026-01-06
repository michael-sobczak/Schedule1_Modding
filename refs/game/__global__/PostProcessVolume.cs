public sealed class PostProcessVolume : MonoBehaviour // TypeDefIndex: 17058
{
	// Fields
	public PostProcessProfile sharedProfile; // 0x20
	[Tooltip("Check this box to mark this volume as global. This volume's Profile will be applied to the whole Scene.")]
	public bool isGlobal; // 0x28
	[Tooltip("The distance (from the attached Collider) to start blending from. A value of 0 means there will be no blending and the Volume overrides will be applied immediatly upon entry to the attached Collider.")]
	[Min(0)]
	public float blendDistance; // 0x2C
	[Tooltip("The total weight of this Volume in the Scene. A value of 0 signifies that it will have no effect, 1 signifies full effect.")]
	[Range(0, 1)]
	public float weight; // 0x30
	[Tooltip("The volume priority in the stack. A higher value means higher priority. Negative values are supported.")]
	public float priority; // 0x34
	private int m_PreviousLayer; // 0x38
	private float m_PreviousPriority; // 0x3C
	private List<Collider> m_TempColliders; // 0x40
	private PostProcessProfile m_InternalProfile; // 0x48

	// Properties
	public PostProcessProfile profile { get; set; }
	internal PostProcessProfile profileRef { get; }
	internal int previousLayer { get; }

	// Methods

	// RVA: 0x29BABE0 Offset: 0x29B95E0 VA: 0x1829BABE0
	public PostProcessProfile get_profile() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_profile(PostProcessProfile value) { }

	// RVA: 0x29BAB60 Offset: 0x29B9560 VA: 0x1829BAB60
	internal PostProcessProfile get_profileRef() { }

	// RVA: 0x29BA0E0 Offset: 0x29B8AE0 VA: 0x1829BA0E0
	public bool HasInstantiatedProfile() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	internal int get_previousLayer() { }

	// RVA: 0x29BA9B0 Offset: 0x29B93B0 VA: 0x1829BA9B0
	private void OnEnable() { }

	// RVA: 0x29BA130 Offset: 0x29B8B30 VA: 0x1829BA130
	private void OnDisable() { }

	// RVA: 0x29BAA90 Offset: 0x29B9490 VA: 0x1829BAA90
	private void Update() { }

	// RVA: 0x29BA1A0 Offset: 0x29B8BA0 VA: 0x1829BA1A0
	private void OnDrawGizmos() { }

	// RVA: 0x29BAB50 Offset: 0x29B9550 VA: 0x1829BAB50
	public void .ctor() { }
}
