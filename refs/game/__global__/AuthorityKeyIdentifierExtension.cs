public class AuthorityKeyIdentifierExtension : X509Extension // TypeDefIndex: 17519
{
	// Fields
	private byte[] aki; // 0x28

	// Properties
	public byte[] Identifier { get; }

	// Methods

	// RVA: 0x1A56810 Offset: 0x1A55210 VA: 0x181A56810
	public void .ctor(X509Extension extension) { }

	// RVA: 0x1A563C0 Offset: 0x1A54DC0 VA: 0x181A563C0 Slot: 4
	protected override void Decode() { }

	// RVA: 0x1A56510 Offset: 0x1A54F10 VA: 0x181A56510 Slot: 5
	protected override void Encode() { }

	// RVA: 0x1A56820 Offset: 0x1A55220 VA: 0x181A56820
	public byte[] get_Identifier() { }

	// RVA: 0x1A56680 Offset: 0x1A55080 VA: 0x181A56680 Slot: 3
	public override string ToString() { }
}
