public sealed class RenderSettings : Object // TypeDefIndex: 11667
{
	// Properties
	[NativeProperty("UseFog")]
	public static bool fog { get; set; }
	[NativeProperty("LinearFogStart")]
	public static float fogStartDistance { get; }
	[NativeProperty("LinearFogEnd")]
	public static float fogEndDistance { get; set; }
	public static FogMode fogMode { get; }
	public static Color fogColor { get; set; }
	public static float fogDensity { get; }
	public static AmbientMode ambientMode { get; set; }
	public static Color ambientSkyColor { get; set; }
	public static Color ambientEquatorColor { get; set; }
	public static Color ambientGroundColor { get; set; }
	public static float ambientIntensity { get; }
	[NativeProperty("AmbientSkyColor")]
	public static Color ambientLight { get; set; }
	public static Color subtractiveShadowColor { get; }
	[NativeProperty("SkyboxMaterial")]
	public static Material skybox { get; set; }
	public static Light sun { get; set; }
	public static SphericalHarmonicsL2 ambientProbe { get; }
	public static float reflectionIntensity { get; }

	// Methods

	// RVA: 0x2C9DC40 Offset: 0x2C9C640 VA: 0x182C9DC40
	public static bool get_fog() { }

	// RVA: 0x2C9E080 Offset: 0x2C9CA80 VA: 0x182C9E080
	public static void set_fog(bool value) { }

	// RVA: 0x2C9DC10 Offset: 0x2C9C610 VA: 0x182C9DC10
	public static float get_fogStartDistance() { }

	// RVA: 0x2C9DBB0 Offset: 0x2C9C5B0 VA: 0x182C9DBB0
	public static float get_fogEndDistance() { }

	// RVA: 0x2C9E040 Offset: 0x2C9CA40 VA: 0x182C9E040
	public static void set_fogEndDistance(float value) { }

	// RVA: 0x2C9DBE0 Offset: 0x2C9C5E0 VA: 0x182C9DBE0
	public static FogMode get_fogMode() { }

	// RVA: 0x2C9DB40 Offset: 0x2C9C540 VA: 0x182C9DB40
	public static Color get_fogColor() { }

	// RVA: 0x2C9E000 Offset: 0x2C9CA00 VA: 0x182C9E000
	public static void set_fogColor(Color value) { }

	// RVA: 0x2C9DB80 Offset: 0x2C9C580 VA: 0x182C9DB80
	public static float get_fogDensity() { }

	// RVA: 0x2C9D9B0 Offset: 0x2C9C3B0 VA: 0x182C9D9B0
	public static AmbientMode get_ambientMode() { }

	// RVA: 0x2C9DF00 Offset: 0x2C9C900 VA: 0x182C9DF00
	public static void set_ambientMode(AmbientMode value) { }

	// RVA: 0x2C9DAC0 Offset: 0x2C9C4C0 VA: 0x182C9DAC0
	public static Color get_ambientSkyColor() { }

	// RVA: 0x2C9DF80 Offset: 0x2C9C980 VA: 0x182C9DF80
	public static void set_ambientSkyColor(Color value) { }

	// RVA: 0x2C9D840 Offset: 0x2C9C240 VA: 0x182C9D840
	public static Color get_ambientEquatorColor() { }

	// RVA: 0x2C9DDC0 Offset: 0x2C9C7C0 VA: 0x182C9DDC0
	public static void set_ambientEquatorColor(Color value) { }

	// RVA: 0x2C9D8C0 Offset: 0x2C9C2C0 VA: 0x182C9D8C0
	public static Color get_ambientGroundColor() { }

	// RVA: 0x2C9DE40 Offset: 0x2C9C840 VA: 0x182C9DE40
	public static void set_ambientGroundColor(Color value) { }

	// RVA: 0x2C9D900 Offset: 0x2C9C300 VA: 0x182C9D900
	public static float get_ambientIntensity() { }

	// RVA: 0x2C9D970 Offset: 0x2C9C370 VA: 0x182C9D970
	public static Color get_ambientLight() { }

	// RVA: 0x2C9DEC0 Offset: 0x2C9C8C0 VA: 0x182C9DEC0
	public static void set_ambientLight(Color value) { }

	// RVA: 0x2C9DD10 Offset: 0x2C9C710 VA: 0x182C9DD10
	public static Color get_subtractiveShadowColor() { }

	// RVA: 0x2C9DCA0 Offset: 0x2C9C6A0 VA: 0x182C9DCA0
	public static Material get_skybox() { }

	// RVA: 0x2C9E0C0 Offset: 0x2C9CAC0 VA: 0x182C9E0C0
	public static void set_skybox(Material value) { }

	// RVA: 0x2C9DD50 Offset: 0x2C9C750 VA: 0x182C9DD50
	public static Light get_sun() { }

	// RVA: 0x2C9E100 Offset: 0x2C9CB00 VA: 0x182C9E100
	public static void set_sun(Light value) { }

	[NativeMethod("GetFinalAmbientProbe")]
	// RVA: 0x2C9DA20 Offset: 0x2C9C420 VA: 0x182C9DA20
	public static SphericalHarmonicsL2 get_ambientProbe() { }

	// RVA: 0x2C9DC70 Offset: 0x2C9C670 VA: 0x182C9DC70
	public static float get_reflectionIntensity() { }

	// RVA: 0x2C9DB00 Offset: 0x2C9C500 VA: 0x182C9DB00
	private static void get_fogColor_Injected(out Color ret) { }

	// RVA: 0x2C9DFC0 Offset: 0x2C9C9C0 VA: 0x182C9DFC0
	private static void set_fogColor_Injected(ref Color value) { }

	// RVA: 0x2C9DA80 Offset: 0x2C9C480 VA: 0x182C9DA80
	private static void get_ambientSkyColor_Injected(out Color ret) { }

	// RVA: 0x2C9DF40 Offset: 0x2C9C940 VA: 0x182C9DF40
	private static void set_ambientSkyColor_Injected(ref Color value) { }

	// RVA: 0x2C9D800 Offset: 0x2C9C200 VA: 0x182C9D800
	private static void get_ambientEquatorColor_Injected(out Color ret) { }

	// RVA: 0x2C9DD80 Offset: 0x2C9C780 VA: 0x182C9DD80
	private static void set_ambientEquatorColor_Injected(ref Color value) { }

	// RVA: 0x2C9D880 Offset: 0x2C9C280 VA: 0x182C9D880
	private static void get_ambientGroundColor_Injected(out Color ret) { }

	// RVA: 0x2C9DE00 Offset: 0x2C9C800 VA: 0x182C9DE00
	private static void set_ambientGroundColor_Injected(ref Color value) { }

	// RVA: 0x2C9D930 Offset: 0x2C9C330 VA: 0x182C9D930
	private static void get_ambientLight_Injected(out Color ret) { }

	// RVA: 0x2C9DE80 Offset: 0x2C9C880 VA: 0x182C9DE80
	private static void set_ambientLight_Injected(ref Color value) { }

	// RVA: 0x2C9DCD0 Offset: 0x2C9C6D0 VA: 0x182C9DCD0
	private static void get_subtractiveShadowColor_Injected(out Color ret) { }

	// RVA: 0x2C9D9E0 Offset: 0x2C9C3E0 VA: 0x182C9D9E0
	private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret) { }
}
