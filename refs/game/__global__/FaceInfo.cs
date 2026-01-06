public struct FaceInfo // TypeDefIndex: 18679
{
	// Fields
	[SerializeField]
	[NativeName("faceIndex")]
	private int m_FaceIndex; // 0x0
	[SerializeField]
	[NativeName("familyName")]
	private string m_FamilyName; // 0x8
	[SerializeField]
	[NativeName("styleName")]
	private string m_StyleName; // 0x10
	[NativeName("pointSize")]
	[SerializeField]
	private int m_PointSize; // 0x18
	[NativeName("scale")]
	[SerializeField]
	private float m_Scale; // 0x1C
	[NativeName("unitsPerEM")]
	[SerializeField]
	private int m_UnitsPerEM; // 0x20
	[SerializeField]
	[NativeName("lineHeight")]
	private float m_LineHeight; // 0x24
	[SerializeField]
	[NativeName("ascentLine")]
	private float m_AscentLine; // 0x28
	[SerializeField]
	[NativeName("capLine")]
	private float m_CapLine; // 0x2C
	[NativeName("meanLine")]
	[SerializeField]
	private float m_MeanLine; // 0x30
	[SerializeField]
	[NativeName("baseline")]
	private float m_Baseline; // 0x34
	[SerializeField]
	[NativeName("descentLine")]
	private float m_DescentLine; // 0x38
	[NativeName("superscriptOffset")]
	[SerializeField]
	private float m_SuperscriptOffset; // 0x3C
	[SerializeField]
	[NativeName("superscriptSize")]
	private float m_SuperscriptSize; // 0x40
	[NativeName("subscriptOffset")]
	[SerializeField]
	private float m_SubscriptOffset; // 0x44
	[NativeName("subscriptSize")]
	[SerializeField]
	private float m_SubscriptSize; // 0x48
	[NativeName("underlineOffset")]
	[SerializeField]
	private float m_UnderlineOffset; // 0x4C
	[SerializeField]
	[NativeName("underlineThickness")]
	private float m_UnderlineThickness; // 0x50
	[NativeName("strikethroughOffset")]
	[SerializeField]
	private float m_StrikethroughOffset; // 0x54
	[NativeName("strikethroughThickness")]
	[SerializeField]
	private float m_StrikethroughThickness; // 0x58
	[NativeName("tabWidth")]
	[SerializeField]
	private float m_TabWidth; // 0x5C

	// Properties
	internal int faceIndex { get; }
	public string familyName { get; }
	public string styleName { get; }
	public int pointSize { get; }
	public float scale { get; set; }
	internal int unitsPerEM { get; set; }
	public float lineHeight { get; }
	public float ascentLine { get; }
	public float capLine { get; set; }
	public float meanLine { get; set; }
	public float baseline { get; }
	public float descentLine { get; }
	public float superscriptOffset { get; }
	public float superscriptSize { get; }
	public float subscriptOffset { get; }
	public float subscriptSize { get; }
	public float underlineOffset { get; }
	public float underlineThickness { get; }
	public float strikethroughOffset { get; set; }
	public float tabWidth { get; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	internal int get_faceIndex() { }

	// RVA: 0x1CD2DF0 Offset: 0x1CD17F0 VA: 0x181CD2DF0
	public string get_familyName() { }

	// RVA: 0x180D270 Offset: 0x180BC70 VA: 0x18180D270
	public string get_styleName() { }

	// RVA: 0x10EB2A0 Offset: 0x10E9CA0 VA: 0x1810EB2A0
	public int get_pointSize() { }

	// RVA: 0x2D2B190 Offset: 0x2D29B90 VA: 0x182D2B190
	public float get_scale() { }

	// RVA: 0x49D820 Offset: 0x49C220 VA: 0x18049D820
	public void set_scale(float value) { }

	// RVA: 0x1263FA0 Offset: 0x12629A0 VA: 0x181263FA0
	internal int get_unitsPerEM() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	internal void set_unitsPerEM(int value) { }

	// RVA: 0x2CD4100 Offset: 0x2CD2B00 VA: 0x182CD4100
	public float get_lineHeight() { }

	// RVA: 0x2D47440 Offset: 0x2D45E40 VA: 0x182D47440
	public float get_ascentLine() { }

	// RVA: 0x2D2B1E0 Offset: 0x2D29BE0 VA: 0x182D2B1E0
	public float get_capLine() { }

	// RVA: 0x5A9D40 Offset: 0x5A8740 VA: 0x1805A9D40
	public void set_capLine(float value) { }

	// RVA: 0x2D2B1A0 Offset: 0x2D29BA0 VA: 0x182D2B1A0
	public float get_meanLine() { }

	// RVA: 0x49D320 Offset: 0x49BD20 VA: 0x18049D320
	public void set_meanLine(float value) { }

	// RVA: 0x2D2B1F0 Offset: 0x2D29BF0 VA: 0x182D2B1F0
	public float get_baseline() { }

	// RVA: 0x2BC3240 Offset: 0x2BC1C40 VA: 0x182BC3240
	public float get_descentLine() { }

	// RVA: 0x2BC30D0 Offset: 0x2BC1AD0 VA: 0x182BC30D0
	public float get_superscriptOffset() { }

	// RVA: 0x2D2B180 Offset: 0x2D29B80 VA: 0x182D2B180
	public float get_superscriptSize() { }

	// RVA: 0x2D47460 Offset: 0x2D45E60 VA: 0x182D47460
	public float get_subscriptOffset() { }

	// RVA: 0x2D47470 Offset: 0x2D45E70 VA: 0x182D47470
	public float get_subscriptSize() { }

	// RVA: 0x2D47490 Offset: 0x2D45E90 VA: 0x182D47490
	public float get_underlineOffset() { }

	// RVA: 0x2D474A0 Offset: 0x2D45EA0 VA: 0x182D474A0
	public float get_underlineThickness() { }

	// RVA: 0x2D47450 Offset: 0x2D45E50 VA: 0x182D47450
	public float get_strikethroughOffset() { }

	// RVA: 0x66B050 Offset: 0x669A50 VA: 0x18066B050
	public void set_strikethroughOffset(float value) { }

	// RVA: 0x2D47480 Offset: 0x2D45E80 VA: 0x182D47480
	public float get_tabWidth() { }
}
