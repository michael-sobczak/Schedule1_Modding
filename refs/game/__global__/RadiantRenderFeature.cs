public class RadiantRenderFeature : ScriptableRendererFeature // TypeDefIndex: 18585
{
	// Fields
	private static readonly List<ReflectionProbe> probes; // 0x0
	private static readonly List<RadiantVirtualEmitter> emitters; // 0x8
	private static bool emittersForceRefresh; // 0x10
	private static Mesh _fullScreenMesh; // 0x18
	public RenderPassEvent renderPassEvent; // 0x20
	[Tooltip("Select the rendering mode according to the URP asset.")]
	public RadiantRenderFeature.RenderingPath renderingPath; // 0x24
	[Tooltip("Allows Radiant to be executed even if camera has Post Processing option disabled.")]
	public bool ignorePostProcessingOption; // 0x28
	private RadiantRenderFeature.RadiantPass radiantPass; // 0x30
	private RadiantRenderFeature.RadiantComparePass comparePass; // 0x38
	public static bool needRTRefresh; // 0x20

	// Properties
	private static Mesh fullscreenMesh { get; }

	// Methods

	// RVA: 0x1E8FB20 Offset: 0x1E8E520 VA: 0x181E8FB20
	private static Mesh get_fullscreenMesh() { }

	// RVA: 0x1E8F490 Offset: 0x1E8DE90 VA: 0x181E8F490
	private void OnDisable() { }

	// RVA: 0x1E8F310 Offset: 0x1E8DD10 VA: 0x181E8F310 Slot: 5
	public override void Create() { }

	// RVA: 0x1E8F210 Offset: 0x1E8DC10 VA: 0x181E8F210 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0x1E8F510 Offset: 0x1E8DF10 VA: 0x181E8F510
	public static void RegisterReflectionProbe(ReflectionProbe probe) { }

	// RVA: 0x1E8F7E0 Offset: 0x1E8E1E0 VA: 0x181E8F7E0
	public static void UnregisterReflectionProbe(ReflectionProbe probe) { }

	// RVA: 0x1E8F670 Offset: 0x1E8E070 VA: 0x181E8F670
	public static void RegisterVirtualEmitter(RadiantVirtualEmitter emitter) { }

	// RVA: 0x1E8F8F0 Offset: 0x1E8E2F0 VA: 0x181E8F8F0
	public static void UnregisterVirtualEmitter(RadiantVirtualEmitter emitter) { }

	// RVA: 0x1E8FB00 Offset: 0x1E8E500 VA: 0x181E8FB00
	public void .ctor() { }

	// RVA: 0x1E8FA10 Offset: 0x1E8E410 VA: 0x181E8FA10
	private static void .cctor() { }
}
