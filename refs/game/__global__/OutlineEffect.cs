public static class OutlineEffect // TypeDefIndex: 10827
{
	// Fields
	public static readonly int FillRefHash; // 0x0
	public static readonly int DilateShiftHash; // 0x4
	public static readonly int ColorMaskHash; // 0x8
	public static readonly int OutlineRefHash; // 0xC
	public static readonly int RefHash; // 0x10
	public static readonly int ZWriteHash; // 0x14
	public static readonly int EffectSizeHash; // 0x18
	public static readonly int CullHash; // 0x1C
	public static readonly int ZTestHash; // 0x20
	public static readonly int ColorHash; // 0x24
	public static readonly int ScaleHash; // 0x28
	public static readonly int ShiftHash; // 0x2C
	public static readonly int InitialTexHash; // 0x30
	public static readonly int InfoBufferHash; // 0x34
	public static readonly int ComparisonHash; // 0x38
	public static readonly int ReadMaskHash; // 0x3C
	public static readonly int WriteMaskHash; // 0x40
	public static readonly int OperationHash; // 0x44
	public static readonly int CutoutThresholdHash; // 0x48
	public static readonly int CutoutMaskHash; // 0x4C
	public static readonly int TextureIndexHash; // 0x50
	public static readonly int CutoutTextureHash; // 0x54
	public static readonly int CutoutTextureSTHash; // 0x58
	public static readonly int SrcBlendHash; // 0x5C
	public static readonly int DstBlendHash; // 0x60
	public static readonly int TargetHash; // 0x64
	public static readonly int InfoTargetHash; // 0x68
	public static readonly int PrimaryBufferHash; // 0x6C
	public static readonly int HelperBufferHash; // 0x70
	public static readonly int PrimaryInfoBufferHash; // 0x74
	public static readonly int HelperInfoBufferHash; // 0x78
	private static Material TransparentBlitMaterial; // 0x80
	private static Material EmptyFillMaterial; // 0x88
	private static Material OutlineMaterial; // 0x90
	private static Material PartialBlitMaterial; // 0x98
	private static Material ObstacleMaterial; // 0xA0
	private static Material FillMaskMaterial; // 0xA8
	private static Material ZPrepassMaterial; // 0xB0
	private static Material OutlineMaskMaterial; // 0xB8
	private static Material DilateMaterial; // 0xC0
	private static Material BlurMaterial; // 0xC8
	private static Material FinalBlitMaterial; // 0xD0
	private static Material BasicBlitMaterial; // 0xD8
	private static Material ClearStencilMaterial; // 0xE0
	private static List<OutlineEffect.OutlineTargetGroup> targets; // 0xE8
	private static List<string> keywords; // 0xF0

	// Methods

	// RVA: 0x545CC0 Offset: 0x5446C0 VA: 0x180545CC0
	public static Material LoadMaterial(string shaderName) { }

	[RuntimeInitializeOnLoadMethod]
	// RVA: 0x545360 Offset: 0x543D60 VA: 0x180545360
	private static void InitMaterials() { }

	// RVA: 0x545D80 Offset: 0x544780 VA: 0x180545D80
	private static void Postprocess(OutlineParameters parameters, int first, int second, Material material, int iterations, bool additionalShift, float shiftValue, ref int stencil, Rect viewport, float scale) { }

	// RVA: 0x5433E0 Offset: 0x541DE0 VA: 0x1805433E0
	private static void Blit(OutlineParameters parameters, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier destinationDepth, Material material, float effectSize, CommandBuffer buffer, int pass = -1, Nullable<Rect> viewport) { }

	// RVA: 0x545260 Offset: 0x543C60 VA: 0x180545260
	private static float GetBlurShift(BlurType blurType, int iterrationsCount) { }

	// RVA: 0x545330 Offset: 0x543D30 VA: 0x180545330
	private static float GetMaskingValueForMode(OutlinableDrawingMode mode) { }

	// RVA: 0x5436E0 Offset: 0x5420E0 VA: 0x1805436E0
	private static float ComputeEffectShift(OutlineParameters parameters) { }

	// RVA: 0x546420 Offset: 0x544E20 VA: 0x180546420
	private static void PrepareTargets(OutlineParameters parameters) { }

	// RVA: 0x5473F0 Offset: 0x545DF0 VA: 0x1805473F0
	public static void SetupOutline(OutlineParameters parameters) { }

	// RVA: 0x547160 Offset: 0x545B60 VA: 0x180547160
	private static void SetupDilateKeyword(OutlineParameters parameters) { }

	// RVA: 0x5467D0 Offset: 0x5451D0 VA: 0x1805467D0
	private static void SetupBlurKeyword(OutlineParameters parameters) { }

	// RVA: 0x544D40 Offset: 0x543740 VA: 0x180544D40
	private static int DrawOutlineables(OutlineParameters parameters, CompareFunction function, Func<Outlinable, bool> shouldRender, Func<Outlinable, Color> colorProvider, Func<Outlinable, Material> materialProvider, RenderStyle styleMask, OutlinableDrawingMode modeMask = 1) { }

	// RVA: 0x543830 Offset: 0x542230 VA: 0x180543830
	private static void DrawFill(OutlineParameters parameters, RenderTargetIdentifier targetSurface) { }

	// RVA: 0x546AA0 Offset: 0x5454A0 VA: 0x180546AA0
	private static void SetupCutout(OutlineParameters parameters, OutlineTarget target) { }

	// RVA: 0x546A10 Offset: 0x545410 VA: 0x180546A10
	private static void SetupCull(OutlineParameters parameters, OutlineTarget target) { }

	// RVA: 0x54AA90 Offset: 0x549490 VA: 0x18054AA90
	private static void .cctor() { }
}
