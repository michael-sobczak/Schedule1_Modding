public class Note : CGModule, INoProcessing // TypeDefIndex: 10745
{
	// Fields
	[SerializeField]
	[TextArea(3, 10)]
	private string m_Note; // 0xC0

	// Properties
	public string NoteText { get; set; }

	// Methods

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public string get_NoteText() { }

	// RVA: 0x4B6C60 Offset: 0x4B5660 VA: 0x1804B6C60
	public void set_NoteText(string value) { }

	// RVA: 0x4EFB50 Offset: 0x4EE550 VA: 0x1804EFB50 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x539B70 Offset: 0x538570 VA: 0x180539B70 Slot: 13
	public override void Reset() { }

	// RVA: 0x4EDCF0 Offset: 0x4EC6F0 VA: 0x1804EDCF0
	public void .ctor() { }
}
