internal class XmlTypeMapMemberElement : XmlTypeMapMember // TypeDefIndex: 8215
{
	// Fields
	private XmlTypeMapElementInfoList _elementInfo; // 0x58
	private string _choiceMember; // 0x60
	private bool _isTextCollector; // 0x68
	private TypeData _choiceTypeData; // 0x70

	// Properties
	public XmlTypeMapElementInfoList ElementInfo { get; set; }
	public string ChoiceMember { get; set; }
	public TypeData ChoiceTypeData { get; set; }
	public bool IsXmlTextCollector { get; set; }

	// Methods

	// RVA: 0x2573610 Offset: 0x2572010 VA: 0x182573610
	public void .ctor() { }

	// RVA: 0x25741E0 Offset: 0x2572BE0 VA: 0x1825741E0
	public XmlTypeMapElementInfoList get_ElementInfo() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public string get_ChoiceMember() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_ChoiceMember(string value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public TypeData get_ChoiceTypeData() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_ChoiceTypeData(TypeData value) { }

	// RVA: 0x2573B20 Offset: 0x2572520 VA: 0x182573B20
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	// RVA: 0x2574020 Offset: 0x2572A20 VA: 0x182574020
	public void SetChoice(object ob, object choice) { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	public bool get_IsXmlTextCollector() { }

	// RVA: 0xCE3E20 Offset: 0xCE2820 VA: 0x180CE3E20
	public void set_IsXmlTextCollector(bool value) { }
}
