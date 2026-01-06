public abstract class ScriptableRendererFeature : ScriptableObject, IDisposable // TypeDefIndex: 9010
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private bool m_Active; // 0x18

	// Properties
	public bool isActive { get; }

	// Methods

	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_isActive() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Create();

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	public virtual void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData);

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public virtual void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData) { }

	// RVA: 0x618750 Offset: 0x617150 VA: 0x180618750
	private void OnEnable() { }

	// RVA: 0x618750 Offset: 0x617150 VA: 0x180618750
	private void OnValidate() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	internal virtual bool SupportsNativeRenderPass() { }

	// RVA: 0x2B26B20 Offset: 0x2B25520 VA: 0x182B26B20 Slot: 10
	internal virtual bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize) { }

	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000
	public void SetActive(bool active) { }

	// RVA: 0x2B26AB0 Offset: 0x2B254B0 VA: 0x182B26AB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD7C9F0 Offset: 0xD7B3F0 VA: 0x180D7C9F0
	protected void .ctor() { }
}
