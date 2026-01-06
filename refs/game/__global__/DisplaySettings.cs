public struct DisplaySettings // TypeDefIndex: 1950
{
	// Fields
	public int ResolutionIndex; // 0x0
	public DisplaySettings.EDisplayMode DisplayMode; // 0x4
	public bool VSync; // 0x8
	public int TargetFPS; // 0xC
	public float UIScale; // 0x10
	public float CameraBobbing; // 0x14
	public int ActiveDisplayIndex; // 0x18
	public Settings.EUnitType UnitType; // 0x1C

	// Methods

	// RVA: 0x79AEC0 Offset: 0x7998C0 VA: 0x18079AEC0
	public static List<Resolution> GetResolutions() { }
}
