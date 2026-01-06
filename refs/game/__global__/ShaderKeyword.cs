public struct ShaderKeyword // TypeDefIndex: 12284
{
	// Fields
	internal string m_Name; // 0x0
	internal uint m_Index; // 0x8
	internal bool m_IsLocal; // 0xC
	internal bool m_IsCompute; // 0xD
	internal bool m_IsValid; // 0xE

	// Properties
	public string name { get; }

	// Methods

	[FreeFunction("ShaderScripting::GetGlobalKeywordCount")]
	// RVA: 0x2CFC870 Offset: 0x2CFB270 VA: 0x182CFC870
	internal static uint GetGlobalKeywordCount() { }

	[FreeFunction("ShaderScripting::GetGlobalKeywordIndex")]
	// RVA: 0x2CFC8A0 Offset: 0x2CFB2A0 VA: 0x182CFC8A0
	internal static uint GetGlobalKeywordIndex(string keyword) { }

	[FreeFunction("ShaderScripting::CreateGlobalKeyword")]
	// RVA: 0x2CFC830 Offset: 0x2CFB230 VA: 0x182CFC830
	internal static void CreateGlobalKeyword(string keyword) { }

	// RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0
	public string get_name() { }

	// RVA: 0x2CFC8E0 Offset: 0x2CFB2E0 VA: 0x182CFC8E0
	public void .ctor(string keywordName) { }

	// RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0 Slot: 3
	public override string ToString() { }
}
