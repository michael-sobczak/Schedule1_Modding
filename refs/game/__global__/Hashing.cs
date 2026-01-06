public static class Hashing // TypeDefIndex: 18161
{
	// Fields
	private const uint FNV_offset_basis32 = 2166136261;
	private const uint FNV_prime32 = 16777619;
	private const ulong FNV_offset_basis64 = 14695981039346656037;
	private const ulong FNV_prime64 = 1099511628211;

	// Methods

	[Extension]
	// RVA: 0xDA6250 Offset: 0xDA4C50 VA: 0x180DA6250
	public static ushort GetStableHashU16(string txt) { }

	[Extension]
	// RVA: 0xDA62C0 Offset: 0xDA4CC0 VA: 0x180DA62C0
	public static uint GetStableHashU32(string txt) { }

	[Extension]
	// RVA: 0xDA6320 Offset: 0xDA4D20 VA: 0x180DA6320
	public static ulong GetStableHashU64(string txt) { }
}
