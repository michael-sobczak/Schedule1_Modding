internal struct LinkInfo // TypeDefIndex: 16711
{
	// Fields
	public int hashCode; // 0x0
	public int linkIdFirstCharacterIndex; // 0x4
	public int linkIdLength; // 0x8
	public int linkTextfirstCharacterIndex; // 0xC
	public int linkTextLength; // 0x10
	internal char[] linkId; // 0x18
	private string m_LinkIdString; // 0x20
	private string m_LinkTextString; // 0x28

	// Methods

	// RVA: 0x2D56910 Offset: 0x2D55310 VA: 0x182D56910
	internal void SetLinkId(char[] text, int startIndex, int length) { }

	// RVA: 0x2D56810 Offset: 0x2D55210 VA: 0x182D56810
	public string GetLinkText(TextInfo textInfo) { }

	// RVA: 0x2D567C0 Offset: 0x2D551C0 VA: 0x182D567C0
	public string GetLinkId() { }
}
