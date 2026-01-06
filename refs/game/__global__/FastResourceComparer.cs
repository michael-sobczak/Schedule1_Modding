internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 4660
{
	// Fields
	internal static readonly FastResourceComparer Default; // 0x0

	// Methods

	// RVA: 0x1B61400 Offset: 0x1B5FE00 VA: 0x181B61400 Slot: 6
	public int GetHashCode(object key) { }

	// RVA: 0x1B614C0 Offset: 0x1B5FEC0 VA: 0x181B614C0 Slot: 9
	public int GetHashCode(string key) { }

	// RVA: 0x1B61550 Offset: 0x1B5FF50 VA: 0x181B61550
	internal static int HashFunction(string key) { }

	// RVA: 0x1B612A0 Offset: 0x1B5FCA0 VA: 0x181B612A0 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0x1B61280 Offset: 0x1B5FC80 VA: 0x181B61280 Slot: 7
	public int Compare(string a, string b) { }

	// RVA: 0x1B613E0 Offset: 0x1B5FDE0 VA: 0x181B613E0 Slot: 8
	public bool Equals(string a, string b) { }

	// RVA: 0x1B61340 Offset: 0x1B5FD40 VA: 0x181B61340 Slot: 5
	public bool Equals(object a, object b) { }

	// RVA: 0x1B611B0 Offset: 0x1B5FBB0 VA: 0x181B611B0
	public static int CompareOrdinal(string a, byte[] bytes, int bCharLength) { }

	// RVA: 0x1B61010 Offset: 0x1B5FA10 VA: 0x181B61010
	public static int CompareOrdinal(byte[] bytes, int aCharLength, string b) { }

	// RVA: 0x1B61100 Offset: 0x1B5FB00 VA: 0x181B61100
	internal static int CompareOrdinal(byte* a, int byteLen, string b) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1B615B0 Offset: 0x1B5FFB0 VA: 0x181B615B0
	private static void .cctor() { }
}
