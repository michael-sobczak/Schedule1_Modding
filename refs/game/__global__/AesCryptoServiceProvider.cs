public sealed class AesCryptoServiceProvider : Aes // TypeDefIndex: 15040
{
	// Properties
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override int FeedbackSize { get; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x1F79A40 Offset: 0x1F78440 VA: 0x181F79A40
	public void .ctor() { }

	// RVA: 0x1F799E0 Offset: 0x1F783E0 VA: 0x181F799E0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1F79A10 Offset: 0x1F78410 VA: 0x181F79A10 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x1F797D0 Offset: 0x1F781D0 VA: 0x181F797D0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1F798D0 Offset: 0x1F782D0 VA: 0x181F798D0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1F79AA0 Offset: 0x1F784A0 VA: 0x181F79AA0 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x1F79AC0 Offset: 0x1F784C0 VA: 0x181F79AC0 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x1F79AB0 Offset: 0x1F784B0 VA: 0x181F79AB0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1F79AE0 Offset: 0x1F784E0 VA: 0x181F79AE0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1F79AD0 Offset: 0x1F784D0 VA: 0x181F79AD0 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x1F79AF0 Offset: 0x1F784F0 VA: 0x181F79AF0 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x1F79B60 Offset: 0x1F78560 VA: 0x181F79B60 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x1B00B70 Offset: 0x1AFF570 VA: 0x181B00B70 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x1B00BE0 Offset: 0x1AFF5E0 VA: 0x181B00BE0 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x1F799D0 Offset: 0x1F783D0 VA: 0x181F799D0 Slot: 5
	protected override void Dispose(bool disposing) { }
}
