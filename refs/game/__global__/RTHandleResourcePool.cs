internal class RTHandleResourcePool // TypeDefIndex: 9006
{
	// Fields
	[TupleElementNames(new[] { "resource", "frameIndex" })]
	protected Dictionary<int, SortedList<int, ValueTuple<RTHandle, int>>> m_ResourcePool; // 0x10
	protected List<int> m_RemoveList; // 0x18
	protected static int s_CurrentStaleResourceCount; // 0x0
	protected static int s_StaleResourceLifetime; // 0x4
	protected static int s_StaleResourceMaxCapacity; // 0x8

	// Properties
	internal int staleResourceCapacity { get; set; }

	// Methods

	// RVA: 0x2B193C0 Offset: 0x2B17DC0 VA: 0x182B193C0
	internal int get_staleResourceCapacity() { }

	// RVA: 0x2B19410 Offset: 0x2B17E10 VA: 0x182B19410
	internal void set_staleResourceCapacity(int value) { }

	// RVA: 0x2B17F50 Offset: 0x2B16950 VA: 0x182B17F50
	internal bool AddResourceToPool(in TextureDesc texDesc, RTHandle resource, int currentFrameIndex) { }

	// RVA: 0x2B190D0 Offset: 0x2B17AD0 VA: 0x182B190D0
	internal bool TryGetResource(in TextureDesc texDesc, out RTHandle resource, bool usepool = True) { }

	// RVA: 0x2B18180 Offset: 0x2B16B80 VA: 0x182B18180
	internal void Cleanup() { }

	// RVA: 0x2B19060 Offset: 0x2B17A60 VA: 0x182B19060
	protected static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex) { }

	// RVA: 0x2B18C40 Offset: 0x2B17640 VA: 0x182B18C40
	internal void PurgeUnusedResources(int currentFrameIndex) { }

	// RVA: 0x2B18640 Offset: 0x2B17040 VA: 0x182B18640
	internal void LogDebugInfo() { }

	// RVA: 0x2B185A0 Offset: 0x2B16FA0 VA: 0x182B185A0
	internal int GetHashCodeWithNameHash(in TextureDesc texDesc) { }

	// RVA: 0x2B18460 Offset: 0x2B16E60 VA: 0x182B18460
	internal static TextureDesc CreateTextureDesc(RenderTextureDescriptor desc, TextureSizeMode textureSizeMode = 0, int anisoLevel = 1, float mipMapBias = 0, FilterMode filterMode = 0, TextureWrapMode wrapMode = 1, string name = "") { }

	// RVA: 0x2B192F0 Offset: 0x2B17CF0 VA: 0x182B192F0
	public void .ctor() { }

	// RVA: 0x2B19280 Offset: 0x2B17C80 VA: 0x182B19280
	private static void .cctor() { }
}
