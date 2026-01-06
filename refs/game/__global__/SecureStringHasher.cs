internal class SecureStringHasher : IEqualityComparer<string> // TypeDefIndex: 7944
{
	// Fields
	private static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0x24C3A30 Offset: 0x24C2430 VA: 0x1824C3A30
	public void .ctor() { }

	// RVA: 0x24C36E0 Offset: 0x24C20E0 VA: 0x1824C36E0 Slot: 4
	public bool Equals(string x, string y) { }

	// RVA: 0x24C3970 Offset: 0x24C2370 VA: 0x1824C3970 Slot: 5
	public int GetHashCode(string key) { }

	// RVA: 0x24C38F0 Offset: 0x24C22F0 VA: 0x1824C38F0
	private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy) { }

	// RVA: 0x24C3700 Offset: 0x24C2100 VA: 0x1824C3700
	private static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate() { }
}
