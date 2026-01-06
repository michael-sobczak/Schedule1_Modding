public class HDROutputSettings // TypeDefIndex: 11655
{
	// Fields
	private int m_DisplayIndex; // 0x10
	public static HDROutputSettings[] displays; // 0x0
	private static HDROutputSettings _mainDisplay; // 0x8

	// Properties
	public static HDROutputSettings main { get; }
	public bool active { get; }
	public bool available { get; }
	public bool automaticHDRTonemapping { set; }
	public ColorGamut displayColorGamut { get; }
	public float paperWhiteNits { get; }
	public int maxFullFrameToneMapLuminance { get; }
	public int maxToneMapLuminance { get; }
	public int minToneMapLuminance { get; }

	// Methods

	[VisibleToOtherModules(new[] { "UnityEngine.XRModule" })]
	// RVA: 0xD236B0 Offset: 0xD220B0 VA: 0x180D236B0
	internal void .ctor() { }

	[VisibleToOtherModules(new[] { "UnityEngine.XRModule" })]
	// RVA: 0x445F80 Offset: 0x444980 VA: 0x180445F80
	internal void .ctor(int displayIndex) { }

	// RVA: 0x2C8F4C0 Offset: 0x2C8DEC0 VA: 0x182C8F4C0
	public static HDROutputSettings get_main() { }

	// RVA: 0x2C8F370 Offset: 0x2C8DD70 VA: 0x182C8F370
	public bool get_active() { }

	// RVA: 0x2C8F3E0 Offset: 0x2C8DDE0 VA: 0x182C8F3E0
	public bool get_available() { }

	// RVA: 0x2C8F6D0 Offset: 0x2C8E0D0 VA: 0x182C8F6D0
	public void set_automaticHDRTonemapping(bool value) { }

	// RVA: 0x2C8F450 Offset: 0x2C8DE50 VA: 0x182C8F450
	public ColorGamut get_displayColorGamut() { }

	// RVA: 0x2C8F660 Offset: 0x2C8E060 VA: 0x182C8F660
	public float get_paperWhiteNits() { }

	// RVA: 0x2C8F510 Offset: 0x2C8DF10 VA: 0x182C8F510
	public int get_maxFullFrameToneMapLuminance() { }

	// RVA: 0x2C8F580 Offset: 0x2C8DF80 VA: 0x182C8F580
	public int get_maxToneMapLuminance() { }

	// RVA: 0x2C8F5F0 Offset: 0x2C8DFF0 VA: 0x182C8F5F0
	public int get_minToneMapLuminance() { }

	// RVA: 0x2C8F180 Offset: 0x2C8DB80 VA: 0x182C8F180
	public void RequestHDRModeChange(bool enabled) { }

	[FreeFunction("HDROutputSettingsBindings::GetActive", HasExplicitThis = False, ThrowsException = True)]
	// RVA: 0x2C8EF80 Offset: 0x2C8D980 VA: 0x182C8EF80
	private static bool GetActive(int displayIndex) { }

	[FreeFunction("HDROutputSettingsBindings::GetAvailable", HasExplicitThis = False, ThrowsException = True)]
	// RVA: 0x2C8EFC0 Offset: 0x2C8D9C0 VA: 0x182C8EFC0
	private static bool GetAvailable(int displayIndex) { }

	[FreeFunction("HDROutputSettingsBindings::SetAutomaticHDRTonemapping", HasExplicitThis = False, ThrowsException = True)]
	// RVA: 0x2C8F200 Offset: 0x2C8DC00 VA: 0x182C8F200
	private static void SetAutomaticHDRTonemapping(int displayIndex, bool scripted) { }

	[FreeFunction("HDROutputSettingsBindings::GetDisplayColorGamut", HasExplicitThis = False, ThrowsException = True)]
	// RVA: 0x2C8F000 Offset: 0x2C8DA00 VA: 0x182C8F000
	private static ColorGamut GetDisplayColorGamut(int displayIndex) { }

	[FreeFunction("HDROutputSettingsBindings::GetPaperWhiteNits", HasExplicitThis = False, ThrowsException = True)]
	// RVA: 0x2C8F100 Offset: 0x2C8DB00 VA: 0x182C8F100
	private static float GetPaperWhiteNits(int displayIndex) { }

	[FreeFunction("HDROutputSettingsBindings::GetMaxFullFrameToneMapLuminance", HasExplicitThis = False, ThrowsException = True)]
	// RVA: 0x2C8F040 Offset: 0x2C8DA40 VA: 0x182C8F040
	private static int GetMaxFullFrameToneMapLuminance(int displayIndex) { }

	[FreeFunction("HDROutputSettingsBindings::GetMaxToneMapLuminance", HasExplicitThis = False, ThrowsException = True)]
	// RVA: 0x2C8F080 Offset: 0x2C8DA80 VA: 0x182C8F080
	private static int GetMaxToneMapLuminance(int displayIndex) { }

	[FreeFunction("HDROutputSettingsBindings::GetMinToneMapLuminance", HasExplicitThis = False, ThrowsException = True)]
	// RVA: 0x2C8F0C0 Offset: 0x2C8DAC0 VA: 0x182C8F0C0
	private static int GetMinToneMapLuminance(int displayIndex) { }

	[FreeFunction("HDROutputSettingsBindings::RequestHDRModeChange", HasExplicitThis = False, ThrowsException = True)]
	// RVA: 0x2C8F140 Offset: 0x2C8DB40 VA: 0x182C8F140
	private static void RequestHDRModeChangeInternal(int displayIndex, bool enabled) { }

	// RVA: 0x2C8F240 Offset: 0x2C8DC40 VA: 0x182C8F240
	private static void .cctor() { }
}
