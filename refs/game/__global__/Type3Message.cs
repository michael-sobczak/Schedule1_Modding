public class Type3Message : MessageBase // TypeDefIndex: 17529
{
	// Fields
	private NtlmAuthLevel _level; // 0x18
	private byte[] _challenge; // 0x20
	private string _host; // 0x28
	private string _domain; // 0x30
	private string _username; // 0x38
	private string _password; // 0x40
	private Type2Message _type2; // 0x48
	private byte[] _lm; // 0x50
	private byte[] _nt; // 0x58

	// Properties
	public string Domain { set; }
	public string Password { set; }
	public string Username { set; }

	// Methods

	// RVA: 0x1A822E0 Offset: 0x1A80CE0 VA: 0x181A822E0
	public void .ctor(Type2Message type2) { }

	// RVA: 0x1A81A60 Offset: 0x1A80460 VA: 0x181A81A60 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A82570 Offset: 0x1A80F70 VA: 0x181A82570
	public void set_Domain(string value) { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_Password(string value) { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_Username(string value) { }

	// RVA: 0x1A81700 Offset: 0x1A80100 VA: 0x181A81700 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1A81690 Offset: 0x1A80090 VA: 0x181A81690
	private string DecodeString(byte[] buffer, int offset, int len) { }

	// RVA: 0x1A819D0 Offset: 0x1A803D0 VA: 0x181A819D0
	private byte[] EncodeString(string text) { }

	// RVA: 0x1A81B20 Offset: 0x1A80520 VA: 0x181A81B20 Slot: 5
	public override byte[] GetBytes() { }
}
