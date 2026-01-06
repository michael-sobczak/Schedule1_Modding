internal abstract class DecalDrawSystem // TypeDefIndex: 8842
{
	// Fields
	protected DecalEntityManager m_EntityManager; // 0x10
	private Matrix4x4[] m_WorldToDecals; // 0x18
	private Matrix4x4[] m_NormalToDecals; // 0x20
	private float[] m_DecalLayerMasks; // 0x28
	private ProfilingSampler m_Sampler; // 0x30
	[CompilerGenerated]
	private Material <overrideMaterial>k__BackingField; // 0x38

	// Properties
	public Material overrideMaterial { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public Material get_overrideMaterial() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_overrideMaterial(Material value) { }

	// RVA: 0x2AE1F20 Offset: 0x2AE0920 VA: 0x182AE1F20
	public void .ctor(string sampler, DecalEntityManager entityManager) { }

	// RVA: 0x2AE15B0 Offset: 0x2ADFFB0 VA: 0x182AE15B0
	public void Execute(CommandBuffer cmd) { }

	// RVA: 0x60A1E0 Offset: 0x608BE0 VA: 0x18060A1E0 Slot: 4
	protected virtual Material GetMaterial(DecalEntityChunk decalEntityChunk) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract int GetPassIndex(DecalCachedChunk decalCachedChunk);

	// RVA: 0x2AE1D80 Offset: 0x2AE0780 VA: 0x182AE1D80
	private void Execute(CommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int count) { }

	// RVA: 0x2AE12F0 Offset: 0x2ADFCF0 VA: 0x182AE12F0
	private void Draw(CommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int passIndex) { }

	// RVA: 0x2AE0C90 Offset: 0x2ADF690 VA: 0x182AE0C90
	private void DrawInstanced(CommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int passIndex) { }

	// RVA: 0x2AE1A60 Offset: 0x2AE0460 VA: 0x182AE1A60
	public void Execute(in CameraData cameraData) { }

	// RVA: 0x2AE18E0 Offset: 0x2AE02E0 VA: 0x182AE18E0
	private void Execute(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int count) { }

	// RVA: 0x2AE0FA0 Offset: 0x2ADF9A0 VA: 0x182AE0FA0
	private void Draw(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk) { }

	// RVA: 0x2AE0930 Offset: 0x2ADF330 VA: 0x182AE0930
	private void DrawInstanced(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk) { }
}
