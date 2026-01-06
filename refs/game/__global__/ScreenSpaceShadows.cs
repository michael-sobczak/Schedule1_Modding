internal class ScreenSpaceShadows : ScriptableRendererFeature // TypeDefIndex: 9000
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private Shader m_Shader; // 0x20
	[SerializeField]
	private ScreenSpaceShadowsSettings m_Settings; // 0x28
	private Material m_Material; // 0x30
	private ScreenSpaceShadows.ScreenSpaceShadowsPass m_SSShadowsPass; // 0x38
	private ScreenSpaceShadows.ScreenSpaceShadowsPostPass m_SSShadowsPostPass; // 0x40
	private const string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceShadows";

	// Methods

	// RVA: 0x2B265E0 Offset: 0x2B24FE0 VA: 0x182B265E0 Slot: 5
	public override void Create() { }

	// RVA: 0x2B262D0 Offset: 0x2B24CD0 VA: 0x182B262D0 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0x2B26760 Offset: 0x2B25160 VA: 0x182B26760 Slot: 11
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2B267E0 Offset: 0x2B251E0 VA: 0x182B267E0
	private bool LoadMaterial() { }

	// RVA: 0x2B26940 Offset: 0x2B25340 VA: 0x182B26940
	public void .ctor() { }
}
