public class Volume : MonoBehaviour, IVolume // TypeDefIndex: 13884
{
	// Fields
	[FormerlySerializedAs("isGlobal")]
	[SerializeField]
	private bool m_IsGlobal; // 0x20
	[Delayed]
	[Tooltip("A value which determines which Volume is being used when Volumes have an equal amount of influence on the Scene. Volumes with a higher priority will override lower ones.")]
	public float priority; // 0x24
	[Tooltip("Sets the outer distance to start blending from. A value of 0 means no blending and Unity applies the Volume overrides immediately upon entry.")]
	public float blendDistance; // 0x28
	[Range(0, 1)]
	[Tooltip("Sets the total weight of this Volume in the Scene. 0 means no effect and 1 means full effect.")]
	public float weight; // 0x2C
	public VolumeProfile sharedProfile; // 0x30
	internal List<Collider> m_Colliders; // 0x38
	private int m_PreviousLayer; // 0x40
	private float m_PreviousPriority; // 0x44
	private VolumeProfile m_InternalProfile; // 0x48

	// Properties
	[Tooltip("When enabled, the Volume is applied to the entire Scene.")]
	public bool isGlobal { get; set; }
	public VolumeProfile profile { get; set; }
	public List<Collider> colliders { get; }
	internal VolumeProfile profileRef { get; }

	// Methods

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0 Slot: 4
	public bool get_isGlobal() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600 Slot: 5
	public void set_isGlobal(bool value) { }

	// RVA: 0x2A5EAB0 Offset: 0x2A5D4B0 VA: 0x182A5EAB0
	public VolumeProfile get_profile() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_profile(VolumeProfile value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 6
	public List<Collider> get_colliders() { }

	// RVA: 0x2A5EA30 Offset: 0x2A5D430 VA: 0x182A5EA30
	internal VolumeProfile get_profileRef() { }

	// RVA: 0x2A5E640 Offset: 0x2A5D040 VA: 0x182A5E640
	public bool HasInstantiatedProfile() { }

	// RVA: 0x2A5E720 Offset: 0x2A5D120 VA: 0x182A5E720
	private void OnEnable() { }

	// RVA: 0x2A5E690 Offset: 0x2A5D090 VA: 0x182A5E690
	private void OnDisable() { }

	// RVA: 0x2A5E870 Offset: 0x2A5D270 VA: 0x182A5E870
	private void Update() { }

	// RVA: 0x2A5E7C0 Offset: 0x2A5D1C0 VA: 0x182A5E7C0
	internal void UpdateLayer() { }

	// RVA: 0x2A5E9A0 Offset: 0x2A5D3A0 VA: 0x182A5E9A0
	public void .ctor() { }
}
