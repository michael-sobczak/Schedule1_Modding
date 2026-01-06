public class CryptoConfig // TypeDefIndex: 4241
{
	// Fields
	private static readonly object lockObject; // 0x0
	private static Dictionary<string, Type> algorithms; // 0x8

	// Properties
	[MonoLimitation("nothing is FIPS certified so it never make sense to restrict to this (empty) subset")]
	public static bool AllowOnlyFipsAlgorithms { get; }

	// Methods

	// RVA: 0x1AF3D10 Offset: 0x1AF2710 VA: 0x181AF3D10
	public static object CreateFromName(string name) { }

	// RVA: 0x1AF1F20 Offset: 0x1AF0920 VA: 0x181AF1F20
	public static object CreateFromName(string name, object[] args) { }

	// RVA: 0x1AF4360 Offset: 0x1AF2D60 VA: 0x181AF4360
	public static string MapNameToOID(string name) { }

	// RVA: 0x1AF3F10 Offset: 0x1AF2910 VA: 0x181AF3F10
	public static byte[] EncodeOID(string str) { }

	// RVA: 0x1AF3D60 Offset: 0x1AF2760 VA: 0x181AF3D60
	private static byte[] EncodeLongNumber(long x) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public static bool get_AllowOnlyFipsAlgorithms() { }

	// RVA: 0x1AF4A20 Offset: 0x1AF3420 VA: 0x181AF4A20
	private static void .cctor() { }
}
