public class XmlSchemaException : SystemException // TypeDefIndex: 8434
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private string sourceUri; // 0xA0
	private int lineNumber; // 0xA8
	private int linePosition; // 0xAC
	private XmlSchemaObject sourceSchemaObject; // 0xB0
	private string message; // 0xB8

	// Properties
	internal string GetRes { get; }
	internal string[] Args { get; }
	public string SourceUri { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public XmlSchemaObject SourceSchemaObject { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x244ADD0 Offset: 0x24497D0 VA: 0x18244ADD0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x244AAF0 Offset: 0x24494F0 VA: 0x18244AAF0 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x244B320 Offset: 0x2449D20 VA: 0x18244B320
	public void .ctor() { }

	// RVA: 0x244B500 Offset: 0x2449F00 VA: 0x18244B500
	public void .ctor(string message) { }

	// RVA: 0x244B350 Offset: 0x2449D50 VA: 0x18244B350
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x244B570 Offset: 0x2449F70 VA: 0x18244B570
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x244B670 Offset: 0x244A070 VA: 0x18244B670
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x244B370 Offset: 0x2449D70 VA: 0x18244B370
	internal void .ctor(string res, string arg) { }

	// RVA: 0x244B250 Offset: 0x2449C50 VA: 0x18244B250
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x244AD40 Offset: 0x2449740 VA: 0x18244AD40
	internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x244AD00 Offset: 0x2449700 VA: 0x18244AD00
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x244AD80 Offset: 0x2449780 VA: 0x18244AD80
	internal void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x244B6A0 Offset: 0x244A0A0 VA: 0x18244B6A0
	internal void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x244B520 Offset: 0x2449F20 VA: 0x18244B520
	internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x244B430 Offset: 0x2449E30 VA: 0x18244B430
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x244AAA0 Offset: 0x24494A0 VA: 0x18244AAA0
	internal static string CreateMessage(string res, string[] args) { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	internal string get_GetRes() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	internal string[] get_Args() { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public string get_SourceUri() { }

	// RVA: 0x587050 Offset: 0x585A50 VA: 0x180587050
	public int get_LineNumber() { }

	// RVA: 0xBBA750 Offset: 0xBB9150 VA: 0x180BBA750
	public int get_LinePosition() { }

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	public XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x244AC40 Offset: 0x2449640 VA: 0x18244AC40
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80
	internal void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x244AC90 Offset: 0x2449690 VA: 0x18244AC90
	internal void SetSource(XmlSchemaObject source) { }

	// RVA: 0x244B780 Offset: 0x244A180 VA: 0x18244B780 Slot: 5
	public override string get_Message() { }
}
