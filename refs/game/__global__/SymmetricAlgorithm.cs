public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 4237
{
	// Fields
	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	// Properties
	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x1B00EB0 Offset: 0x1AFF8B0 VA: 0x181B00EB0
	protected void .ctor() { }

	// RVA: 0x1B00DA0 Offset: 0x1AFF7A0 VA: 0x181B00DA0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1B00AC0 Offset: 0x1AFF4C0 VA: 0x181B00AC0
	public void Clear() { }

	// RVA: 0x1B00D20 Offset: 0x1AFF720 VA: 0x181B00D20 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x1B010A0 Offset: 0x1AFFAA0 VA: 0x181B010A0 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70 Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x1B00EE0 Offset: 0x1AFF8E0 VA: 0x181B00EE0 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x1B011F0 Offset: 0x1AFFBF0 VA: 0x181B011F0 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x1B00F80 Offset: 0x1AFF980 VA: 0x181B00F80 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x1B01400 Offset: 0x1AFFE00 VA: 0x181B01400 Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x1B01020 Offset: 0x1AFFA20 VA: 0x181B01020 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x1B01360 Offset: 0x1AFFD60 VA: 0x181B01360 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x1B01590 Offset: 0x1AFFF90 VA: 0x181B01590 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x1B01610 Offset: 0x1B00010 VA: 0x181B01610 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x1B00E10 Offset: 0x1AFF810 VA: 0x181B00E10
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x1B00C50 Offset: 0x1AFF650 VA: 0x181B00C50
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x1B00BE0 Offset: 0x1AFF5E0 VA: 0x181B00BE0 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: 0x1B00B70 Offset: 0x1AFF570 VA: 0x181B00B70 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV();
}
