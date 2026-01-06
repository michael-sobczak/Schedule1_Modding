public sealed class ReflectionProbe : Behaviour // TypeDefIndex: 11611
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged; // 0x0
	private static Dictionary<int, Action<Texture>> registeredDefaultReflectionSetActions; // 0x8
	private static List<Action<Texture>> registeredDefaultReflectionTextureActions; // 0x10

	// Properties
	[NativeName("GlobalAABB")]
	public Bounds bounds { get; }
	public float blendDistance { get; }
	public int importance { get; }
	public ReflectionProbeRefreshMode refreshMode { get; }
	public ReflectionProbeTimeSlicingMode timeSlicingMode { get; }
	public Texture texture { get; }
	public Vector4 textureHDRDecodeValues { get; }
	[StaticAccessor("GetReflectionProbes()")]
	public static Vector4 defaultTextureHDRDecodeValues { get; }
	[StaticAccessor("GetReflectionProbes()")]
	public static Texture defaultTexture { get; }

	// Methods

	// RVA: 0x2C9D3C0 Offset: 0x2C9BDC0 VA: 0x182C9D3C0
	public Bounds get_bounds() { }

	// RVA: 0x2C9D330 Offset: 0x2C9BD30 VA: 0x182C9D330
	public float get_blendDistance() { }

	// RVA: 0x2C9D500 Offset: 0x2C9BF00 VA: 0x182C9D500
	public int get_importance() { }

	// RVA: 0x2C9D540 Offset: 0x2C9BF40 VA: 0x182C9D540
	public ReflectionProbeRefreshMode get_refreshMode() { }

	// RVA: 0x2C9D660 Offset: 0x2C9C060 VA: 0x182C9D660
	public ReflectionProbeTimeSlicingMode get_timeSlicingMode() { }

	// RVA: 0x2C9D620 Offset: 0x2C9C020 VA: 0x182C9D620
	public Texture get_texture() { }

	[NativeName("CalculateHDRDecodeValues")]
	// RVA: 0x2C9D5D0 Offset: 0x2C9BFD0 VA: 0x182C9D5D0
	public Vector4 get_textureHDRDecodeValues() { }

	// RVA: 0x2C9D100 Offset: 0x2C9BB00 VA: 0x182C9D100
	public int RenderProbe() { }

	// RVA: 0x2C9D170 Offset: 0x2C9BB70 VA: 0x182C9D170
	public int RenderProbe(RenderTexture targetTexture) { }

	// RVA: 0x2C9D1F0 Offset: 0x2C9BBF0 VA: 0x182C9D1F0
	private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) { }

	// RVA: 0x2C9D460 Offset: 0x2C9BE60 VA: 0x182C9D460
	public static Vector4 get_defaultTextureHDRDecodeValues() { }

	// RVA: 0x2C9D4D0 Offset: 0x2C9BED0 VA: 0x182C9D4D0
	public static Texture get_defaultTexture() { }

	[RequiredByNativeCode]
	// RVA: 0x2C9CF30 Offset: 0x2C9B930 VA: 0x182C9CF30
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCode]
	// RVA: 0x2C9CFB0 Offset: 0x2C9B9B0 VA: 0x182C9CFB0
	private static void CallSetDefaultReflection(Texture defaultReflectionCubemap) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2C9D240 Offset: 0x2C9BC40 VA: 0x182C9D240
	private static void .cctor() { }

	// RVA: 0x2C9D370 Offset: 0x2C9BD70 VA: 0x182C9D370
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x2C9D580 Offset: 0x2C9BF80 VA: 0x182C9D580
	private void get_textureHDRDecodeValues_Injected(out Vector4 ret) { }

	// RVA: 0x2C9D420 Offset: 0x2C9BE20 VA: 0x182C9D420
	private static void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret) { }
}
