public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 17567
{
	// Methods

	// RVA: 0x1A809D0 Offset: 0x1A7F3D0 VA: 0x181A809D0 Slot: 8
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0x1A809B0 Offset: 0x1A7F3B0 VA: 0x181A809B0 Slot: 7
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x1A805D0 Offset: 0x1A7EFD0 VA: 0x181A805D0 Slot: 9
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 10
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
