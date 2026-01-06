public class DefaultJsonNameTable : JsonNameTable // TypeDefIndex: 10978
{
	// Fields
	private static readonly int HashCodeRandomizer; // 0x0
	private int _count; // 0x10
	private DefaultJsonNameTable.Entry[] _entries; // 0x18
	private int _mask; // 0x20

	// Methods

	// RVA: 0x1D08A80 Offset: 0x1D07480 VA: 0x181D08A80
	private static void .cctor() { }

	// RVA: 0x1D08AC0 Offset: 0x1D074C0 VA: 0x181D08AC0
	public void .ctor() { }

	// RVA: 0x1D08650 Offset: 0x1D07050 VA: 0x181D08650 Slot: 4
	public override string Get(char[] key, int start, int length) { }

	// RVA: 0x1D08490 Offset: 0x1D06E90 VA: 0x181D08490
	public string Add(string key) { }

	// RVA: 0x1D08210 Offset: 0x1D06C10 VA: 0x181D08210
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x1D08870 Offset: 0x1D07270 VA: 0x181D08870
	private void Grow() { }

	// RVA: 0x1D089E0 Offset: 0x1D073E0 VA: 0x181D089E0
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }
}
