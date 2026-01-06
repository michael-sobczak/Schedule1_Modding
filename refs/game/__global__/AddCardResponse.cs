public class AddCardResponse // TypeDefIndex: 18061
{
	// Fields
	public string id; // 0x10
	public Badges badges; // 0x18
	public bool[] checkItemStates; // 0x20
	public bool closed; // 0x28
	public DateTime dateLastActivity; // 0x30
	public string desc; // 0x38
	public Descdata descData; // 0x40
	public string due; // 0x48
	public bool dueComplete; // 0x50
	public string email; // 0x58
	public string idBoard; // 0x60
	public string[] idChecklists; // 0x68
	public string[] idLabels; // 0x70
	public string idList; // 0x78
	public string[] idMembers; // 0x80
	public int idShort; // 0x88
	public string idAttachmentCover; // 0x90
	public bool manualCoverAttachment; // 0x98
	public CardLabel[] labels; // 0xA0
	public string name; // 0xA8
	public int pos; // 0xB0
	public string shortUrl; // 0xB8
	public string url; // 0xC0
	public string[] stickers; // 0xC8

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
