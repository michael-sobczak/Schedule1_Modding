internal struct ReflectionProbeManager : IDisposable // TypeDefIndex: 8976
{
	// Fields
	private int2 m_Resolution; // 0x0
	private RenderTexture m_AtlasTexture0; // 0x8
	private RenderTexture m_AtlasTexture1; // 0x10
	private BuddyAllocator m_AtlasAllocator; // 0x18
	private Dictionary<int, ReflectionProbeManager.CachedProbe> m_Cache; // 0x40
	private Dictionary<int, int> m_WarningCache; // 0x48
	private List<int> m_NeedsUpdate; // 0x50
	private List<int> m_NeedsRemove; // 0x58
	private Vector4[] m_BoxMax; // 0x60
	private Vector4[] m_BoxMin; // 0x68
	private Vector4[] m_ProbePosition; // 0x70
	private Vector4[] m_MipScaleOffset; // 0x78
	private const int k_MaxMipCount = 7;
	private const string k_ReflectionProbeAtlasName = "URP Reflection Probe Atlas";

	// Properties
	public RenderTexture atlasRT { get; }

	// Methods

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public RenderTexture get_atlasRT() { }

	// RVA: 0x2B194A0 Offset: 0x2B17EA0 VA: 0x182B194A0
	public static ReflectionProbeManager Create() { }

	// RVA: 0x2B19780 Offset: 0x2B18180 VA: 0x182B19780
	private void Init() { }

	// RVA: 0x2B19C50 Offset: 0x2B18650 VA: 0x182B19C50
	public void UpdateGpuData(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B195B0 Offset: 0x2B17FB0 VA: 0x182B195B0
	private float4 GetScaleOffset(int level, int dataIndex, bool includePadding, bool yflip) { }

	// RVA: 0x2B194E0 Offset: 0x2B17EE0 VA: 0x182B194E0 Slot: 4
	public void Dispose() { }
}
