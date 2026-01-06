internal class VectorImageManager : IDisposable // TypeDefIndex: 7144
{
	// Fields
	public static List<VectorImageManager> instances; // 0x0
	private static ProfilerMarker s_MarkerRegister; // 0x8
	private static ProfilerMarker s_MarkerUnregister; // 0x10
	private readonly AtlasBase m_Atlas; // 0x10
	private Dictionary<VectorImage, VectorImageRenderInfo> m_Registered; // 0x18
	private VectorImageRenderInfoPool m_RenderInfoPool; // 0x20
	private GradientRemapPool m_GradientRemapPool; // 0x28
	private GradientSettingsAtlas m_GradientSettingsAtlas; // 0x30
	private bool m_LoggedExhaustedSettingsAtlas; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x39

	// Properties
	public Texture2D atlas { get; }
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x2E2E680 Offset: 0x2E2D080 VA: 0x182E2E680
	public Texture2D get_atlas() { }

	// RVA: 0x2E2E130 Offset: 0x2E2CB30 VA: 0x182E2E130
	public void .ctor(AtlasBase atlas) { }

	[CompilerGenerated]
	// RVA: 0x8D2180 Offset: 0x8D0B80 VA: 0x1808D2180
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0xCD74A0 Offset: 0xCD5EA0 VA: 0x180CD74A0
	private void set_disposed(bool value) { }

	// RVA: 0x2E2DB40 Offset: 0x2E2C540 VA: 0x182E2DB40 Slot: 4
	public void Dispose() { }

	// RVA: 0x2E2DA20 Offset: 0x2E2C420 VA: 0x182E2DA20 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2E2D9F0 Offset: 0x2E2C3F0 VA: 0x182E2D9F0
	public void Commit() { }

	// RVA: 0x2E2D8F0 Offset: 0x2E2C2F0 VA: 0x182E2D8F0
	public GradientRemap AddUser(VectorImage vi, VisualElement context) { }

	// RVA: 0x2E2DBB0 Offset: 0x2E2C5B0 VA: 0x182E2DBB0
	private VectorImageRenderInfo Register(VectorImage vi, VisualElement context) { }

	// RVA: 0x2E2E030 Offset: 0x2E2CA30 VA: 0x182E2E030
	private static void .cctor() { }
}
