public class XmlParserContext // TypeDefIndex: 7962
{
	// Fields
	private XmlNameTable _nt; // 0x10
	private XmlNamespaceManager _nsMgr; // 0x18
	private string _docTypeName; // 0x20
	private string _pubId; // 0x28
	private string _sysId; // 0x30
	private string _internalSubset; // 0x38
	private string _xmlLang; // 0x40
	private XmlSpace _xmlSpace; // 0x48
	private string _baseURI; // 0x50
	private Encoding _encoding; // 0x58

	// Properties
	public XmlNameTable NameTable { get; }
	public XmlNamespaceManager NamespaceManager { get; }
	public string DocTypeName { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string BaseURI { get; }
	public string InternalSubset { get; }
	public string XmlLang { get; }
	public XmlSpace XmlSpace { get; }
	public Encoding Encoding { get; }
	internal bool HasDtdInfo { get; }

	// Methods

	// RVA: 0x24CE200 Offset: 0x24CCC00 VA: 0x1824CE200
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x24CE2B0 Offset: 0x24CCCB0 VA: 0x1824CE2B0
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x24CE320 Offset: 0x24CCD20 VA: 0x1824CE320
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_DocTypeName() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_PublicId() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_SystemId() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_BaseURI() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_InternalSubset() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_XmlLang() { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public Encoding get_Encoding() { }

	// RVA: 0x24CE600 Offset: 0x24CD000 VA: 0x1824CE600
	internal bool get_HasDtdInfo() { }
}
