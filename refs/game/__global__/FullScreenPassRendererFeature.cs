public class FullScreenPassRendererFeature : ScriptableRendererFeature, ISerializationCallbackReceiver // TypeDefIndex: 8644
{
	// Fields
	public FullScreenPassRendererFeature.InjectionPoint injectionPoint; // 0x20
	public bool fetchColorBuffer; // 0x24
	public ScriptableRenderPassInput requirements; // 0x28
	public Material passMaterial; // 0x30
	internal bool showAdditionalProperties; // 0x38
	public int passIndex; // 0x3C
	public bool bindDepthStencilAttachment; // 0x40
	private FullScreenPassRendererFeature.FullScreenRenderPass m_FullScreenPass; // 0x48
	[SerializeField]
	[HideInInspector]
	private FullScreenPassRendererFeature.Version m_Version; // 0x50

	// Methods

	// RVA: 0x2A72B50 Offset: 0x2A71550 VA: 0x182A72B50 Slot: 5
	public override void Create() { }

	// RVA: 0x2A72C70 Offset: 0x2A71670 VA: 0x182A72C70 Slot: 10
	internal override bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize) { }

	// RVA: 0x2A72860 Offset: 0x2A71260 VA: 0x182A72860 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0x2A72C40 Offset: 0x2A71640 VA: 0x182A72C40 Slot: 11
	protected override void Dispose(bool disposing) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void UpgradeIfNeeded() { }

	// RVA: 0x2A72CA0 Offset: 0x2A716A0 VA: 0x182A72CA0 Slot: 12
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x2A72C90 Offset: 0x2A71690 VA: 0x182A72C90 Slot: 13
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x2A72CB0 Offset: 0x2A716B0 VA: 0x182A72CB0
	public void .ctor() { }
}
