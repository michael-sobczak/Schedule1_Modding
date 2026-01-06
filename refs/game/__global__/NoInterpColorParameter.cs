public class NoInterpColorParameter : VolumeParameter<Color> // TypeDefIndex: 13918
{
	// Fields
	public bool hdr; // 0x28
	public bool showAlpha; // 0x29
	public bool showEyeDropper; // 0x2A

	// Methods

	// RVA: 0x2A57660 Offset: 0x2A56060 VA: 0x182A57660
	public void .ctor(Color value, bool overrideState = False) { }

	// RVA: 0x2A576D0 Offset: 0x2A560D0 VA: 0x182A576D0
	public void .ctor(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = False) { }
}
