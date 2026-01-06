public abstract class DES : SymmetricAlgorithm // TypeDefIndex: 4192
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x1AE3900 Offset: 0x1AE2300 VA: 0x181AE3900
	protected void .ctor() { }

	// RVA: 0x1AE39A0 Offset: 0x1AE23A0 VA: 0x181AE39A0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1AE3AA0 Offset: 0x1AE24A0 VA: 0x181AE3AA0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1AE3290 Offset: 0x1AE1C90 VA: 0x181AE3290
	public static DES Create() { }

	// RVA: 0x1AE35D0 Offset: 0x1AE1FD0 VA: 0x181AE35D0
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x1AE3420 Offset: 0x1AE1E20 VA: 0x181AE3420
	public static bool IsSemiWeakKey(byte[] rgbKey) { }

	// RVA: 0x1AE3410 Offset: 0x1AE1E10 VA: 0x181AE3410
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x1AE36F0 Offset: 0x1AE20F0 VA: 0x181AE36F0
	private static ulong QuadWordFromBigEndian(byte[] block) { }

	// RVA: 0x1AE37A0 Offset: 0x1AE21A0 VA: 0x181AE37A0
	private static void .cctor() { }
}
