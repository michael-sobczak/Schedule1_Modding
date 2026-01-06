internal class HeaderInfoTable // TypeDefIndex: 9999
{
	// Fields
	private static Hashtable HeaderHashTable; // 0x0
	private static HeaderInfo UnknownHeaderInfo; // 0x8
	private static HeaderParser SingleParser; // 0x10
	private static HeaderParser MultiParser; // 0x18

	// Properties
	internal HeaderInfo Item { get; }

	// Methods

	// RVA: 0x26C3DB0 Offset: 0x26C27B0 VA: 0x1826C3DB0
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x26C3BA0 Offset: 0x26C25A0 VA: 0x1826C3BA0
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x26C3E30 Offset: 0x26C2830 VA: 0x1826C3E30
	private static void .cctor() { }

	// RVA: 0x26C6580 Offset: 0x26C4F80 VA: 0x1826C6580
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
