public class Glyph // TypeDefIndex: 18683
{
	// Fields
	[SerializeField]
	[NativeName("index")]
	private uint m_Index; // 0x10
	[SerializeField]
	[NativeName("metrics")]
	private GlyphMetrics m_Metrics; // 0x14
	[NativeName("glyphRect")]
	[SerializeField]
	private GlyphRect m_GlyphRect; // 0x28
	[NativeName("scale")]
	[SerializeField]
	private float m_Scale; // 0x38
	[NativeName("atlasIndex")]
	[SerializeField]
	private int m_AtlasIndex; // 0x3C
	[SerializeField]
	[NativeName("type")]
	private GlyphClassDefinitionType m_ClassDefinitionType; // 0x40

	// Properties
	public uint index { get; set; }
	public GlyphMetrics metrics { get; set; }
	public GlyphRect glyphRect { get; set; }
	public float scale { get; set; }
	public int atlasIndex { get; set; }

	// Methods

	// RVA: 0x1E13C60 Offset: 0x1E12660 VA: 0x181E13C60
	public uint get_index() { }

	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_index(uint value) { }

	// RVA: 0x1670D10 Offset: 0x166F710 VA: 0x181670D10
	public GlyphMetrics get_metrics() { }

	// RVA: 0x2D4AFD0 Offset: 0x2D499D0 VA: 0x182D4AFD0
	public void set_metrics(GlyphMetrics value) { }

	// RVA: 0x2D2C900 Offset: 0x2D2B300 VA: 0x182D2C900
	public GlyphRect get_glyphRect() { }

	// RVA: 0x4F58C0 Offset: 0x4F42C0 VA: 0x1804F58C0
	public void set_glyphRect(GlyphRect value) { }

	// RVA: 0x2BC3240 Offset: 0x2BC1C40 VA: 0x182BC3240
	public float get_scale() { }

	// RVA: 0x4E2CD0 Offset: 0x4E16D0 VA: 0x1804E2CD0
	public void set_scale(float value) { }

	// RVA: 0x2D4AFC0 Offset: 0x2D499C0 VA: 0x182D4AFC0
	public int get_atlasIndex() { }

	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0
	public void set_atlasIndex(int value) { }

	// RVA: 0x2D4AF80 Offset: 0x2D49980 VA: 0x182D4AF80
	public void .ctor() { }

	// RVA: 0x2D4AEC0 Offset: 0x2D498C0 VA: 0x182D4AEC0
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x2D4AF10 Offset: 0x2D49910 VA: 0x182D4AF10
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }
}
