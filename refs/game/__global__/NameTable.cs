public class NameTable : XmlNameTable // TypeDefIndex: 8081
{
	// Fields
	private NameTable.Entry[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private int hashCodeRandomizer; // 0x20

	// Methods

	// RVA: 0x250C2E0 Offset: 0x250ACE0 VA: 0x18250C2E0
	public void .ctor() { }

	// RVA: 0x250BC60 Offset: 0x250A660 VA: 0x18250BC60 Slot: 6
	public override string Add(string key) { }

	// RVA: 0x250BDE0 Offset: 0x250A7E0 VA: 0x18250BDE0 Slot: 5
	public override string Add(char[] key, int start, int len) { }

	// RVA: 0x250BFF0 Offset: 0x250A9F0 VA: 0x18250BFF0 Slot: 4
	public override string Get(string value) { }

	// RVA: 0x250B9F0 Offset: 0x250A3F0 VA: 0x18250B9F0
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x250C170 Offset: 0x250AB70 VA: 0x18250C170
	private void Grow() { }

	// RVA: 0x1D089E0 Offset: 0x1D073E0 VA: 0x181D089E0
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }
}
