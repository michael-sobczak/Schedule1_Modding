public class XmlException : SystemException // TypeDefIndex: 8114
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private int lineNumber; // 0xA0
	private int linePosition; // 0xA4
	[OptionalField]
	private string sourceUri; // 0xA8
	private string message; // 0xB0

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }
	public override string Message { get; }
	internal string ResString { get; }

	// Methods

	// RVA: 0x253A6A0 Offset: 0x25390A0 VA: 0x18253A6A0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x253A420 Offset: 0x2538E20 VA: 0x18253A420 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x253AB90 Offset: 0x2539590 VA: 0x18253AB90
	public void .ctor() { }

	// RVA: 0x253AB60 Offset: 0x2539560 VA: 0x18253AB60
	public void .ctor(string message) { }

	// RVA: 0x253A670 Offset: 0x2539070 VA: 0x18253A670
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x253A570 Offset: 0x2538F70 VA: 0x18253A570
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x253AE50 Offset: 0x2539850 VA: 0x18253AE50
	internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x253B060 Offset: 0x2539A60 VA: 0x18253B060
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x253B2E0 Offset: 0x2539CE0 VA: 0x18253B2E0
	internal void .ctor(string res, string arg) { }

	// RVA: 0x253B220 Offset: 0x2539C20 VA: 0x18253B220
	internal void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x253ACF0 Offset: 0x25396F0 VA: 0x18253ACF0
	internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x253B160 Offset: 0x2539B60 VA: 0x18253B160
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

	// RVA: 0x253B390 Offset: 0x2539D90 VA: 0x18253B390
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x253A5A0 Offset: 0x2538FA0 VA: 0x18253A5A0
	internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x253ABF0 Offset: 0x25395F0 VA: 0x18253ABF0
	internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x253ACC0 Offset: 0x25396C0 VA: 0x18253ACC0
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x253AE10 Offset: 0x2539810 VA: 0x18253AE10
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x253ABC0 Offset: 0x25395C0 VA: 0x18253ABC0
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x253B090 Offset: 0x2539A90 VA: 0x18253B090
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x253A310 Offset: 0x2538D10 VA: 0x18253A310
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x253A150 Offset: 0x2538B50 VA: 0x18253A150
	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x2539DE0 Offset: 0x25387E0 VA: 0x182539DE0
	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x253A0F0 Offset: 0x2538AF0 VA: 0x18253A0F0
	internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex) { }

	// RVA: 0x2539E50 Offset: 0x2538850 VA: 0x182539E50
	internal static string[] BuildCharExceptionArgs(char invChar, char nextChar) { }

	// RVA: 0x5B3AE0 Offset: 0x5B24E0 VA: 0x1805B3AE0
	public int get_LineNumber() { }

	// RVA: 0xBBA760 Offset: 0xBB9160 VA: 0x180BBA760
	public int get_LinePosition() { }

	// RVA: 0x253B450 Offset: 0x2539E50 VA: 0x18253B450 Slot: 5
	public override string get_Message() { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	internal string get_ResString() { }
}
