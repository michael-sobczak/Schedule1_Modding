internal class CodePageDataItem // TypeDefIndex: 4846
{
	// Fields
	internal int m_dataIndex; // 0x10
	internal int m_uiFamilyCodePage; // 0x14
	internal string m_webName; // 0x18
	internal string m_headerName; // 0x20
	internal string m_bodyName; // 0x28
	internal uint m_flags; // 0x30
	private static readonly char[] sep; // 0x0

	// Properties
	public string WebName { get; }
	public string HeaderName { get; }

	// Methods

	// RVA: 0x1BD8460 Offset: 0x1BD6E60 VA: 0x181BD8460
	internal void .ctor(int dataIndex) { }

	// RVA: 0x1BD8310 Offset: 0x1BD6D10 VA: 0x181BD8310
	internal static string CreateString(string pStrings, uint index) { }

	// RVA: 0x1BD85F0 Offset: 0x1BD6FF0 VA: 0x181BD85F0
	public string get_WebName() { }

	// RVA: 0x1BD8520 Offset: 0x1BD6F20 VA: 0x181BD8520
	public string get_HeaderName() { }

	// RVA: 0x1BD83D0 Offset: 0x1BD6DD0 VA: 0x181BD83D0
	private static void .cctor() { }
}
