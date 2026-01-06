public abstract class RC2 : SymmetricAlgorithm // TypeDefIndex: 4211
{
	// Fields
	protected int EffectiveKeySizeValue; // 0x48
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public virtual int EffectiveKeySize { get; }
	public override int KeySize { get; set; }

	// Methods

	// RVA: 0x1AE8030 Offset: 0x1AE6A30 VA: 0x181AE8030
	protected void .ctor() { }

	// RVA: 0x1AE80D0 Offset: 0x1AE6AD0 VA: 0x181AE80D0 Slot: 26
	public virtual int get_EffectiveKeySize() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1AE80E0 Offset: 0x1AE6AE0 VA: 0x181AE80E0 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1AE7EC0 Offset: 0x1AE68C0 VA: 0x181AE7EC0
	private static void .cctor() { }
}
