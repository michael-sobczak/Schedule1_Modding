public struct TMP_LinkInfo // TypeDefIndex: 14858
{
	// Fields
	public TMP_Text textComponent; // 0x0
	public int hashCode; // 0x8
	public int linkIdFirstCharacterIndex; // 0xC
	public int linkIdLength; // 0x10
	public int linkTextfirstCharacterIndex; // 0x14
	public int linkTextLength; // 0x18
	internal char[] linkID; // 0x20

	// Methods

	// RVA: 0x2BEA060 Offset: 0x2BE8A60 VA: 0x182BEA060
	internal void SetLinkID(char[] text, int startIndex, int length) { }

	// RVA: 0x2BE9F40 Offset: 0x2BE8940 VA: 0x182BE9F40
	public string GetLinkText() { }

	// RVA: 0x2BEA050 Offset: 0x2BE8A50 VA: 0x182BEA050
	public string GetLink() { }

	// RVA: 0x2BE9EA0 Offset: 0x2BE88A0 VA: 0x182BE9EA0
	public string GetLinkID() { }
}
