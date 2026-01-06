public class ArrayPoolsProvider // TypeDefIndex: 10358
{
	// Fields
	private static readonly Dictionary<Type, object> arrayPools; // 0x0
	private static readonly object lockObject; // 0x8

	// Methods

	// RVA: -1 Offset: -1
	public static ArrayPool<T> GetPool<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4BA20 Offset: 0xE4A420 VA: 0x180E4BA20
	|-ArrayPoolsProvider.GetPool<CGSpot>
	|
	|-RVA: 0xE4BFF0 Offset: 0xE4A9F0 VA: 0x180E4BFF0
	|-ArrayPoolsProvider.GetPool<int>
	|
	|-RVA: 0xE4C2D0 Offset: 0xE4ACD0 VA: 0x180E4C2D0
	|-ArrayPoolsProvider.GetPool<float>
	|
	|-RVA: 0xE4C5B0 Offset: 0xE4AFB0 VA: 0x180E4C5B0
	|-ArrayPoolsProvider.GetPool<Vector2>
	|
	|-RVA: 0xE4C890 Offset: 0xE4B290 VA: 0x180E4C890
	|-ArrayPoolsProvider.GetPool<Vector3>
	|
	|-RVA: 0xE4CB70 Offset: 0xE4B570 VA: 0x180E4CB70
	|-ArrayPoolsProvider.GetPool<Vector4>
	|
	|-RVA: 0xE4BD00 Offset: 0xE4A700 VA: 0x180E4BD00
	|-ArrayPoolsProvider.GetPool<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x489E90 Offset: 0x488890 VA: 0x180489E90
	private static void .cctor() { }
}
