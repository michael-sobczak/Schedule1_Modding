public sealed class PostProcessManager // TypeDefIndex: 17049
{
	// Fields
	private static PostProcessManager s_Instance; // 0x0
	private const int k_MaxLayerCount = 32;
	private readonly Dictionary<int, List<PostProcessVolume>> m_SortedVolumes; // 0x10
	private readonly List<PostProcessVolume> m_Volumes; // 0x18
	private readonly Dictionary<int, bool> m_SortNeeded; // 0x20
	private readonly List<PostProcessEffectSettings> m_BaseSettings; // 0x28
	private readonly List<Collider> m_TempColliders; // 0x30
	public readonly Dictionary<Type, PostProcessAttribute> settingsTypes; // 0x38

	// Properties
	public static PostProcessManager instance { get; }

	// Methods

	// RVA: 0x29B8DB0 Offset: 0x29B77B0 VA: 0x1829B8DB0
	public static PostProcessManager get_instance() { }

	// RVA: 0x29B8BC0 Offset: 0x29B75C0 VA: 0x1829B8BC0
	private void .ctor() { }

	// RVA: 0x29B6680 Offset: 0x29B5080 VA: 0x1829B6680
	private void CleanBaseTypes() { }

	// RVA: 0x29B7960 Offset: 0x29B6360 VA: 0x1829B7960
	private void ReloadBaseTypes() { }

	// RVA: 0x29B6880 Offset: 0x29B5280 VA: 0x1829B6880
	public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = True, bool skipZeroWeight = True) { }

	// RVA: 0x29B6EA0 Offset: 0x29B58A0 VA: 0x1829B6EA0
	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer) { }

	// RVA: 0x29B6F60 Offset: 0x29B5960 VA: 0x1829B6F60
	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask) { }

	// RVA: 0x29B7510 Offset: 0x29B5F10 VA: 0x1829B7510
	public PostProcessVolume QuickVolume(int layer, float priority, PostProcessEffectSettings[] settings) { }

	// RVA: 0x29B8070 Offset: 0x29B6A70 VA: 0x1829B8070
	internal void SetLayerDirty(int layer) { }

	// RVA: 0x29B8B60 Offset: 0x29B7560 VA: 0x1829B8B60
	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer) { }

	// RVA: 0x29B7700 Offset: 0x29B6100 VA: 0x1829B7700
	private void Register(PostProcessVolume volume, int layer) { }

	// RVA: 0x29B7910 Offset: 0x29B6310 VA: 0x1829B7910
	internal void Register(PostProcessVolume volume) { }

	// RVA: 0x29B8350 Offset: 0x29B6D50 VA: 0x1829B8350
	private void Unregister(PostProcessVolume volume, int layer) { }

	// RVA: 0x29B82F0 Offset: 0x29B6CF0 VA: 0x1829B82F0
	internal void Unregister(PostProcessVolume volume) { }

	// RVA: 0x29B7E10 Offset: 0x29B6810 VA: 0x1829B7E10
	private void ReplaceData(PostProcessLayer postProcessLayer) { }

	// RVA: 0x29B84E0 Offset: 0x29B6EE0 VA: 0x1829B84E0
	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera) { }

	// RVA: 0x29B7100 Offset: 0x29B5B00 VA: 0x1829B7100
	private List<PostProcessVolume> GrabVolumes(LayerMask mask) { }

	// RVA: 0x29B81D0 Offset: 0x29B6BD0 VA: 0x1829B81D0
	private static void SortByPriority(List<PostProcessVolume> volumes) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera) { }
}
