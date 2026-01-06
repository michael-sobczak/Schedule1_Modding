public sealed class SecurityElement // TypeDefIndex: 4156
{
	// Fields
	private string text; // 0x10
	private string tag; // 0x18
	private ArrayList attributes; // 0x20
	private ArrayList children; // 0x28
	private static readonly char[] invalid_tag_chars; // 0x0
	private static readonly char[] invalid_text_chars; // 0x8
	private static readonly char[] invalid_attr_name_chars; // 0x10
	private static readonly char[] invalid_attr_value_chars; // 0x18
	private static readonly char[] invalid_chars; // 0x20

	// Properties
	public ArrayList Children { get; }
	public string Tag { get; }
	public string Text { set; }
	internal string m_strText { set; }

	// Methods

	// RVA: 0x1AD9580 Offset: 0x1AD7F80 VA: 0x181AD9580
	public void .ctor(string tag) { }

	// RVA: 0x1AD9590 Offset: 0x1AD7F90 VA: 0x181AD9590
	public void .ctor(string tag, string text) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public ArrayList get_Children() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Tag() { }

	// RVA: 0x1AD9860 Offset: 0x1AD8260 VA: 0x181AD9860
	public void set_Text(string value) { }

	// RVA: 0x1AD7F60 Offset: 0x1AD6960 VA: 0x181AD7F60
	public void AddAttribute(string name, string value) { }

	// RVA: 0x1AD8150 Offset: 0x1AD6B50 VA: 0x181AD8150
	public void AddChild(SecurityElement child) { }

	// RVA: 0x1AD8240 Offset: 0x1AD6C40 VA: 0x181AD8240
	public static string Escape(string str) { }

	// RVA: 0x1AD91E0 Offset: 0x1AD7BE0 VA: 0x181AD91E0
	private static string Unescape(string str) { }

	// RVA: 0x1AD8620 Offset: 0x1AD7020 VA: 0x181AD8620
	public static bool IsValidAttributeName(string name) { }

	// RVA: 0x1AD86A0 Offset: 0x1AD70A0 VA: 0x181AD86A0
	public static bool IsValidAttributeValue(string value) { }

	// RVA: 0x1AD8720 Offset: 0x1AD7120 VA: 0x181AD8720
	public static bool IsValidTag(string tag) { }

	// RVA: 0x1AD87A0 Offset: 0x1AD71A0 VA: 0x181AD87A0
	public static bool IsValidText(string text) { }

	// RVA: 0x1AD8820 Offset: 0x1AD7220 VA: 0x181AD8820
	public SecurityElement SearchForChildByTag(string tag) { }

	// RVA: 0x1AD8B80 Offset: 0x1AD7580 VA: 0x181AD8B80 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AD8C10 Offset: 0x1AD7610 VA: 0x181AD8C10
	private void ToXml(ref StringBuilder s, int level) { }

	// RVA: 0x1AD8460 Offset: 0x1AD6E60 VA: 0x181AD8460
	internal SecurityElement.SecurityAttribute GetAttribute(string name) { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	internal void set_m_strText(string value) { }

	// RVA: 0x1AD8980 Offset: 0x1AD7380 VA: 0x181AD8980
	internal string SearchForTextOfLocalName(string strLocalName) { }

	// RVA: 0x1AD9370 Offset: 0x1AD7D70 VA: 0x181AD9370
	private static void .cctor() { }
}
