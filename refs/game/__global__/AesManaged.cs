public sealed class AesManaged : Aes // TypeDefIndex: 15039
{
	// Fields
	private RijndaelManaged m_rijndael; // 0x48

	// Properties
	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x1F7A020 Offset: 0x1F78A20 VA: 0x181F7A020
	public void .ctor() { }

	// RVA: 0x1F7A1B0 Offset: 0x1F78BB0 VA: 0x181F7A1B0 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x1F7A1E0 Offset: 0x1F78BE0 VA: 0x181F7A1E0 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x1F7A2A0 Offset: 0x1F78CA0 VA: 0x181F7A2A0 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x1F7A210 Offset: 0x1F78C10 VA: 0x181F7A210 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1F7A300 Offset: 0x1F78D00 VA: 0x181F7A300 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1A45550 Offset: 0x1A43F50 VA: 0x181A45550 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1F7A2D0 Offset: 0x1F78CD0 VA: 0x181F7A2D0 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1F7A240 Offset: 0x1F78C40 VA: 0x181F7A240 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x1F7A330 Offset: 0x1F78D30 VA: 0x181F7A330 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x1F7A270 Offset: 0x1F78C70 VA: 0x181F7A270 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x1F7A3E0 Offset: 0x1F78DE0 VA: 0x181F7A3E0 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x1F79D10 Offset: 0x1F78710 VA: 0x181F79D10 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x1F79B70 Offset: 0x1F78570 VA: 0x181F79B70 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1F79EE0 Offset: 0x1F788E0 VA: 0x181F79EE0 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x1F79D40 Offset: 0x1F78740 VA: 0x181F79D40 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1F79F10 Offset: 0x1F78910 VA: 0x181F79F10 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1F79FC0 Offset: 0x1F789C0 VA: 0x181F79FC0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1F79FF0 Offset: 0x1F789F0 VA: 0x181F79FF0 Slot: 24
	public override void GenerateKey() { }
}
