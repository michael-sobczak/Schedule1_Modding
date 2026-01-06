public struct HashCode // TypeDefIndex: 3656
{
	// Fields
	private static readonly uint s_seed; // 0x0
	private uint _v1; // 0x0
	private uint _v2; // 0x4
	private uint _v3; // 0x8
	private uint _v4; // 0xC
	private uint _queue1; // 0x10
	private uint _queue2; // 0x14
	private uint _queue3; // 0x18
	private uint _length; // 0x1C

	// Methods

	// RVA: 0x1C63C60 Offset: 0x1C62660 VA: 0x181C63C60
	private static uint GenerateGlobalSeed() { }

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC01B0 Offset: 0xEBEBB0 VA: 0x180EC01B0
	|-HashCode.Combine<object, AssemblyVersion, object, object>
	|
	|-RVA: 0xEC0490 Offset: 0xEBEE90 VA: 0x180EC0490
	|-HashCode.Combine<ushort, ushort, ushort, ushort>
	|
	|-RVA: 0xEC0740 Offset: 0xEBF140 VA: 0x180EC0740
	|-HashCode.Combine<Vector4, Vector4, Vector4, SHCoefficients>
	|
	|-RVA: 0xEBFB30 Offset: 0xEBE530 VA: 0x180EBFB30
	|-HashCode.Combine<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC09E0 Offset: 0xEBF3E0 VA: 0x180EC09E0
	|-HashCode.Combine<Vector4, Vector4, Vector4, Vector4, Vector4, Vector4, Vector4, Vector4>
	|
	|-RVA: 0xEBEF00 Offset: 0xEBD900 VA: 0x180EBEF00
	|-HashCode.Combine<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C63F50 Offset: 0x1C62950 VA: 0x181C63F50
	private static uint Rol(uint value, int count) { }

	// RVA: 0x1C63CE0 Offset: 0x1C626E0 VA: 0x181C63CE0
	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) { }

	// RVA: 0x1C63F70 Offset: 0x1C62970 VA: 0x181C63F70
	private static uint Round(uint hash, uint input) { }

	// RVA: 0x1C63EE0 Offset: 0x1C628E0 VA: 0x181C63EE0
	private static uint QueueRound(uint hash, uint queuedValue) { }

	// RVA: 0x1C63E40 Offset: 0x1C62840 VA: 0x181C63E40
	private static uint MixState(uint v1, uint v2, uint v3, uint v4) { }

	// RVA: 0x1C63DB0 Offset: 0x1C627B0 VA: 0x181C63DB0
	private static uint MixEmptyState() { }

	// RVA: 0x1C63E10 Offset: 0x1C62810 VA: 0x181C63E10
	private static uint MixFinal(uint hash) { }

	// RVA: -1 Offset: -1
	public void Add<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBE960 Offset: 0xEBD360 VA: 0x180EBE960
	|-HashCode.Add<bool>
	|
	|-RVA: 0xEBEA00 Offset: 0xEBD400 VA: 0x180EBEA00
	|-HashCode.Add<Color>
	|
	|-RVA: 0xEBEC80 Offset: 0xEBD680 VA: 0x180EBEC80
	|-HashCode.Add<int>
	|
	|-RVA: 0xEBED80 Offset: 0xEBD780 VA: 0x180EBED80
	|-HashCode.Add<object>
	|
	|-RVA: 0xEBED00 Offset: 0xEBD700 VA: 0x180EBED00
	|-HashCode.Add<Rect>
	|
	|-RVA: 0xEBEE00 Offset: 0xEBD800 VA: 0x180EBEE00
	|-HashCode.Add<float>
	|
	|-RVA: 0xEBEE80 Offset: 0xEBD880 VA: 0x180EBEE80
	|-HashCode.Add<Vector4>
	|
	|-RVA: 0xEBEB10 Offset: 0xEBD510 VA: 0x180EBEB10
	|-HashCode.Add<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C63A70 Offset: 0x1C62470 VA: 0x181C63A70
	private void Add(int value) { }

	// RVA: 0x1C63FE0 Offset: 0x1C629E0 VA: 0x181C63FE0
	public int ToHashCode() { }

	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes. Use ToHashCode to retrieve the computed hash code.", True)]
	// RVA: 0x1C63C90 Offset: 0x1C62690 VA: 0x181C63C90 Slot: 2
	public override int GetHashCode() { }

	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes.", True)]
	// RVA: 0x1C63C10 Offset: 0x1C62610 VA: 0x181C63C10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C64230 Offset: 0x1C62C30 VA: 0x181C64230
	private static void .cctor() { }
}
