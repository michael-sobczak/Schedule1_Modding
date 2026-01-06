public class Type1Message : MessageBase // TypeDefIndex: 17527
{
	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Properties
	public string Domain { set; }
	public string Host { set; }

	// Methods

	// RVA: 0x1A81080 Offset: 0x1A7FA80 VA: 0x181A81080
	public void .ctor() { }

	// RVA: 0x1A81110 Offset: 0x1A7FB10 VA: 0x181A81110
	public void set_Domain(string value) { }

	// RVA: 0x1A81190 Offset: 0x1A7FB90 VA: 0x181A81190
	public void set_Host(string value) { }

	// RVA: 0x1A80C90 Offset: 0x1A7F690 VA: 0x181A80C90 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1A80DB0 Offset: 0x1A7F7B0 VA: 0x181A80DB0 Slot: 5
	public override byte[] GetBytes() { }
}
