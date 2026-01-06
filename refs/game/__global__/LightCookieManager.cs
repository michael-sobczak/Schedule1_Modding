internal class LightCookieManager : IDisposable // TypeDefIndex: 8899
{
	// Fields
	private static readonly Matrix4x4 s_DirLightProj; // 0x0
	private Texture2DAtlas m_AdditionalLightsCookieAtlas; // 0x10
	private LightCookieManager.LightCookieShaderData m_AdditionalLightsCookieShaderData; // 0x18
	private readonly LightCookieManager.Settings m_Settings; // 0x20
	private LightCookieManager.WorkMemory m_WorkMem; // 0x40
	private int[] m_VisibleLightIndexToShaderDataIndex; // 0x48
	private const int k_MaxCookieSizeDivisor = 16;
	private int m_CookieSizeDivisor; // 0x50
	private uint m_PrevCookieRequestPixelCount; // 0x54
	private int m_PrevWarnFrame; // 0x58
	[CompilerGenerated]
	private bool <IsKeywordLightCookieEnabled>k__BackingField; // 0x5C

	// Properties
	internal bool IsKeywordLightCookieEnabled { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4CD980 Offset: 0x4CC380 VA: 0x1804CD980
	internal bool get_IsKeywordLightCookieEnabled() { }

	[CompilerGenerated]
	// RVA: 0xCE3D60 Offset: 0xCE2760 VA: 0x180CE3D60
	private void set_IsKeywordLightCookieEnabled(bool value) { }

	// RVA: 0x2B05EE0 Offset: 0x2B048E0 VA: 0x182B05EE0
	public void .ctor(ref LightCookieManager.Settings settings) { }

	// RVA: 0x2B043A0 Offset: 0x2B02DA0 VA: 0x182B043A0
	private void InitAdditionalLights(int size) { }

	// RVA: 0x2A12F60 Offset: 0x2A11960 VA: 0x182A12F60
	public bool isInitialized() { }

	// RVA: 0x2B03420 Offset: 0x2B01E20 VA: 0x182B03420 Slot: 4
	public void Dispose() { }

	// RVA: 0x2B040A0 Offset: 0x2B02AA0 VA: 0x182B040A0
	public int GetLightCookieShaderDataIndex(int visibleLightIndex) { }

	// RVA: 0x2B04F00 Offset: 0x2B03900 VA: 0x182B04F00
	public void Setup(ScriptableRenderContext ctx, CommandBuffer cmd, ref LightData lightData) { }

	// RVA: 0x2B04830 Offset: 0x2B03230 VA: 0x182B04830
	private bool SetupMainLight(CommandBuffer cmd, ref VisibleLight visibleMainLight) { }

	// RVA: 0x2B040F0 Offset: 0x2B02AF0 VA: 0x182B040F0
	private LightCookieManager.LightCookieShaderFormat GetLightCookieShaderFormat(GraphicsFormat cookieFormat) { }

	// RVA: 0x2B04170 Offset: 0x2B02B70 VA: 0x182B04170
	private void GetLightUVScaleOffset(ref UniversalAdditionalLightData additionalLightData, ref Matrix4x4 uvTransform) { }

	// RVA: 0x2B04580 Offset: 0x2B02F80 VA: 0x182B04580
	private bool SetupAdditionalLights(CommandBuffer cmd, ref LightData lightData) { }

	// RVA: 0x2B03BF0 Offset: 0x2B025F0 VA: 0x182B03BF0
	private int FilterAndValidateAdditionalLights(ref LightData lightData, LightCookieManager.LightCookieMapping[] validLightMappings) { }

	// RVA: 0x2B05350 Offset: 0x2B03D50 VA: 0x182B05350
	private int UpdateAdditionalLightsAtlas(CommandBuffer cmd, ref LightCookieManager.WorkSlice<LightCookieManager.LightCookieMapping> validLightMappings, Vector4[] textureAtlasUVRects) { }

	// RVA: 0x2B038B0 Offset: 0x2B022B0 VA: 0x182B038B0
	private int FetchUVRects(CommandBuffer cmd, ref LightCookieManager.WorkSlice<LightCookieManager.LightCookieMapping> validLightMappings, Vector4[] textureAtlasUVRects, int cookieSizeDivisor) { }

	// RVA: 0x2B03220 Offset: 0x2B01C20 VA: 0x182B03220
	private uint ComputeCookieRequestPixelCount(ref LightCookieManager.WorkSlice<LightCookieManager.LightCookieMapping> validLightMappings) { }

	// RVA: 0x2B031E0 Offset: 0x2B01BE0 VA: 0x182B031E0
	private int ApproximateCookieSizeDivisor(float requestAtlasRatio) { }

	// RVA: 0x2B03490 Offset: 0x2B01E90 VA: 0x182B03490
	private Vector4 Fetch2D(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1) { }

	// RVA: 0x2B03640 Offset: 0x2B02040 VA: 0x182B03640
	private Vector4 FetchCube(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1) { }

	// RVA: 0x2B03310 Offset: 0x2B01D10 VA: 0x182B03310
	private int ComputeOctahedralCookieSize(Texture cookie) { }

	// RVA: 0x2B02F20 Offset: 0x2B01920 VA: 0x182B02F20
	private void AdjustUVRect(ref Vector4 uvScaleOffset, Texture cookie, ref Vector2 cookieSize) { }

	// RVA: 0x2B05210 Offset: 0x2B03C10 VA: 0x182B05210
	private void ShrinkUVRect(ref Vector4 uvScaleOffset, float amountPixels, ref Vector2 cookieSize) { }

	// RVA: 0x2B055C0 Offset: 0x2B03FC0 VA: 0x182B055C0
	private void UploadAdditionalLights(CommandBuffer cmd, ref LightData lightData, ref LightCookieManager.WorkSlice<LightCookieManager.LightCookieMapping> validLightMappings, ref LightCookieManager.WorkSlice<Vector4> validUvRects) { }

	// RVA: 0x2B05E50 Offset: 0x2B04850 VA: 0x182B05E50
	private static void .cctor() { }
}
