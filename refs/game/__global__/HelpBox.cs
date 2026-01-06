public class HelpBox : VisualElement // TypeDefIndex: 6314
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string iconUssClassName; // 0x10
	public static readonly string iconInfoUssClassName; // 0x18
	public static readonly string iconwarningUssClassName; // 0x20
	public static readonly string iconErrorUssClassName; // 0x28
	private HelpBoxMessageType m_HelpBoxMessageType; // 0x3C8
	private VisualElement m_Icon; // 0x3D0
	private string m_IconClass; // 0x3D8
	private Label m_Label; // 0x3E0

	// Properties
	public string text { set; }
	public HelpBoxMessageType messageType { set; }

	// Methods

	// RVA: 0x2DD33E0 Offset: 0x2DD1DE0 VA: 0x182DD33E0
	public void set_text(string value) { }

	// RVA: 0x2DD33C0 Offset: 0x2DD1DC0 VA: 0x182DD33C0
	public void set_messageType(HelpBoxMessageType value) { }

	// RVA: 0x2DD3060 Offset: 0x2DD1A60 VA: 0x182DD3060
	public void .ctor() { }

	// RVA: 0x2DD3220 Offset: 0x2DD1C20 VA: 0x182DD3220
	public void .ctor(string text, HelpBoxMessageType messageType) { }

	// RVA: 0x2DD2BF0 Offset: 0x2DD15F0 VA: 0x182DD2BF0
	private string GetIconClass(HelpBoxMessageType messageType) { }

	// RVA: 0x2DD2CC0 Offset: 0x2DD16C0 VA: 0x182DD2CC0
	private void UpdateIcon(HelpBoxMessageType messageType) { }

	// RVA: 0x2DD2E40 Offset: 0x2DD1840 VA: 0x182DD2E40
	private static void .cctor() { }
}
