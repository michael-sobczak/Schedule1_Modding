public class TextureOutput // TypeDefIndex: 18786
{
	// Fields
	[SerializeField]
	public int Index; // 0x10
	[SerializeField]
	public OverrideMask OverrideMask; // 0x14
	public bool Active; // 0x18
	public string Name; // 0x20
	public TextureScale Scale; // 0x28
	public bool SRGB; // 0x2C
	public TextureChannels Channels; // 0x30
	public TextureCompression Compression; // 0x34
	public ImageFormat ImageFormat; // 0x38

	// Methods

	// RVA: 0x452800 Offset: 0x451200 VA: 0x180452800
	public void .ctor() { }

	// RVA: 0x452880 Offset: 0x451280 VA: 0x180452880
	public void .ctor(bool a, string n, TextureScale s, bool sr, TextureChannels c, TextureCompression nc, ImageFormat i) { }

	// RVA: 0x452780 Offset: 0x451180 VA: 0x180452780
	public TextureOutput Clone() { }
}
