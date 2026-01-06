public abstract class PrimeGeneratorBase // TypeDefIndex: 17566
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x1A7CD70 Offset: 0x1A7B770 VA: 0x181A7CD70 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x1A7CEB0 Offset: 0x1A7B8B0 VA: 0x181A7CEB0 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
