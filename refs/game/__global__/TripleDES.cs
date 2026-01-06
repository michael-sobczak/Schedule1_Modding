public abstract class TripleDES : SymmetricAlgorithm // TypeDefIndex: 4238
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x1B02140 Offset: 0x1B00B40 VA: 0x181B02140
	protected void .ctor() { }

	// RVA: 0x1B021F0 Offset: 0x1B00BF0 VA: 0x181B021F0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1B022C0 Offset: 0x1B00CC0 VA: 0x181B022C0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1B01B00 Offset: 0x1B00500 VA: 0x181B01B00
	public static TripleDES Create() { }

	// RVA: 0x1B01DD0 Offset: 0x1B007D0 VA: 0x181B01DD0
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x1B01B50 Offset: 0x1B00550 VA: 0x181B01B50
	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count) { }

	// RVA: 0x1B01DB0 Offset: 0x1B007B0 VA: 0x181B01DB0
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x1B01FD0 Offset: 0x1B009D0 VA: 0x181B01FD0
	private static void .cctor() { }
}
