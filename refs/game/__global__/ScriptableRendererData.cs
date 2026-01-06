public abstract class ScriptableRendererData : ScriptableObject // TypeDefIndex: 9009
{
	// Fields
	[CompilerGenerated]
	private bool <isInvalidated>k__BackingField; // 0x18
	public ScriptableRendererData.DebugShaderResources debugShaders; // 0x20
	[SerializeField]
	internal List<ScriptableRendererFeature> m_RendererFeatures; // 0x28
	[SerializeField]
	internal List<long> m_RendererFeatureMap; // 0x30
	[SerializeField]
	private bool m_UseNativeRenderPass; // 0x38

	// Properties
	internal bool isInvalidated { get; set; }
	public List<ScriptableRendererFeature> rendererFeatures { get; }
	public bool useNativeRenderPass { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	internal bool get_isInvalidated() { }

	[CompilerGenerated]
	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000
	internal void set_isInvalidated(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract ScriptableRenderer Create();

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public List<ScriptableRendererFeature> get_rendererFeatures() { }

	// RVA: 0x4C5B80 Offset: 0x4C4580 VA: 0x1804C5B80
	public void SetDirty() { }

	// RVA: 0x2B269B0 Offset: 0x2B253B0 VA: 0x182B269B0
	internal ScriptableRenderer InternalCreateRenderer() { }

	// RVA: 0x4C5B80 Offset: 0x4C4580 VA: 0x1804C5B80 Slot: 5
	protected virtual void OnValidate() { }

	// RVA: 0x4C5B80 Offset: 0x4C4580 VA: 0x1804C5B80 Slot: 6
	protected virtual void OnEnable() { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_useNativeRenderPass() { }

	// RVA: 0x2B26AA0 Offset: 0x2B254A0 VA: 0x182B26AA0
	public void set_useNativeRenderPass(bool value) { }

	// RVA: -1 Offset: -1
	internal bool TryGetRendererFeature<T>(out T rendererFeature) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4A020 Offset: 0xF48A20 VA: 0x180F4A020
	|-ScriptableRendererData.TryGetRendererFeature<object>
	*/

	// RVA: 0x2B269D0 Offset: 0x2B253D0 VA: 0x182B269D0
	protected void .ctor() { }
}
