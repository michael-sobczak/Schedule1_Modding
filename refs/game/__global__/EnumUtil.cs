internal sealed class EnumUtil // TypeDefIndex: 16606
{
	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: 0x1E30910 Offset: 0x1E2F310 VA: 0x181E30910
	internal static string GetDescription(Enum value) { }

	// RVA: 0x1E30DC0 Offset: 0x1E2F7C0 VA: 0x181E30DC0
	internal static object Parse(Type enumType, string stringRepresentation) { }

	// RVA: 0x1E30A80 Offset: 0x1E2F480 VA: 0x181E30A80
	public static Enum[] GetEnumValues(Type type) { }

	// RVA: -1 Offset: -1
	public static string[] GetEnumStrings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE83340 Offset: 0xE81D40 VA: 0x180E83340
	|-EnumUtil.GetEnumStrings<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E30C90 Offset: 0x1E2F690 VA: 0x181E30C90
	internal static object Parse(Type enumType, string stringRepresentation, bool ignoreCase) { }
}
