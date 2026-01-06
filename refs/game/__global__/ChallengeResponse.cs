public class ChallengeResponse : IDisposable // TypeDefIndex: 17521
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x1A59080 Offset: 0x1A57A80 VA: 0x181A59080
	public void .ctor() { }

	// RVA: 0x1A58EB0 Offset: 0x1A578B0 VA: 0x181A58EB0
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x1A58720 Offset: 0x1A57120 VA: 0x181A58720 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A59330 Offset: 0x1A57D30 VA: 0x181A59330
	public void set_Password(string value) { }

	// RVA: 0x1A591E0 Offset: 0x1A57BE0 VA: 0x181A591E0
	public void set_Challenge(byte[] value) { }

	// RVA: 0x1A59100 Offset: 0x1A57B00 VA: 0x181A59100
	public byte[] get_LM() { }

	// RVA: 0x1A59170 Offset: 0x1A57B70 VA: 0x181A59170
	public byte[] get_NT() { }

	// RVA: 0x1A585F0 Offset: 0x1A56FF0 VA: 0x181A585F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A586A0 Offset: 0x1A570A0 VA: 0x181A586A0
	private void Dispose(bool disposing) { }

	// RVA: 0x1A58830 Offset: 0x1A57230 VA: 0x181A58830
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x1A58BE0 Offset: 0x1A575E0 VA: 0x181A58BE0
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1A58A80 Offset: 0x1A57480 VA: 0x181A58A80
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1A58DC0 Offset: 0x1A577C0 VA: 0x181A58DC0
	private static void .cctor() { }
}
