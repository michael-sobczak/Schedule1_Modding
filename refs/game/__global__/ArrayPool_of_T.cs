public static class ArrayPool<T> // TypeDefIndex: 13382
{
	// Fields
	private const int MaximumExactArrayLength = 256;
	private static readonly Stack<T[]>[] pool; // 0x0
	private static readonly Stack<T[]>[] exactPool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static T[] Claim(int minimumLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164D480 Offset: 0x164BE80 VA: 0x18164D480
	|-ArrayPool<bool>.Claim
	|-ArrayPool<Color>.Claim
	|-ArrayPool<Connection>.Claim
	|-ArrayPool<Int3>.Claim
	|-ArrayPool<int>.Claim
	|-ArrayPool<IntRect>.Claim
	|-ArrayPool<object>.Claim
	|-ArrayPool<ushort>.Claim
	|-ArrayPool<Vector2>.Claim
	|-ArrayPool<Vector3>.Claim
	|-ArrayPool<BBTree.BBTreeBox>.Claim
	|
	|-RVA: 0x164DAA0 Offset: 0x164C4A0 VA: 0x18164DAA0
	|-ArrayPool<__Il2CppFullySharedGenericType>.Claim
	*/

	// RVA: -1 Offset: -1
	public static T[] ClaimWithExactLength(int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164CDE0 Offset: 0x164B7E0 VA: 0x18164CDE0
	|-ArrayPool<bool>.ClaimWithExactLength
	|-ArrayPool<Color>.ClaimWithExactLength
	|-ArrayPool<Connection>.ClaimWithExactLength
	|-ArrayPool<Int3>.ClaimWithExactLength
	|-ArrayPool<int>.ClaimWithExactLength
	|-ArrayPool<IntRect>.ClaimWithExactLength
	|-ArrayPool<object>.ClaimWithExactLength
	|-ArrayPool<ushort>.ClaimWithExactLength
	|-ArrayPool<Vector2>.ClaimWithExactLength
	|-ArrayPool<Vector3>.ClaimWithExactLength
	|-ArrayPool<BBTree.BBTreeBox>.ClaimWithExactLength
	|
	|-RVA: 0x164D0D0 Offset: 0x164BAD0 VA: 0x18164D0D0
	|-ArrayPool<__Il2CppFullySharedGenericType>.ClaimWithExactLength
	*/

	// RVA: -1 Offset: -1
	public static void Release(ref T[] array, bool allowNonPowerOfTwo = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1656570 Offset: 0x1654F70 VA: 0x181656570
	|-ArrayPool<bool>.Release
	|
	|-RVA: 0x1651110 Offset: 0x164FB10 VA: 0x181651110
	|-ArrayPool<Color>.Release
	|
	|-RVA: 0x1653690 Offset: 0x1652090 VA: 0x181653690
	|-ArrayPool<Connection>.Release
	|
	|-RVA: 0x16523D0 Offset: 0x1650DD0 VA: 0x1816523D0
	|-ArrayPool<Int3>.Release
	|
	|-RVA: 0x16507B0 Offset: 0x164F1B0 VA: 0x1816507B0
	|-ArrayPool<int>.Release
	|
	|-RVA: 0x16552B0 Offset: 0x1653CB0 VA: 0x1816552B0
	|-ArrayPool<IntRect>.Release
	|
	|-RVA: 0x1651A70 Offset: 0x1650470 VA: 0x181651A70
	|-ArrayPool<object>.Release
	|
	|-RVA: 0x1652D30 Offset: 0x1651730 VA: 0x181652D30
	|-ArrayPool<ushort>.Release
	|
	|-RVA: 0x1653FF0 Offset: 0x16529F0 VA: 0x181653FF0
	|-ArrayPool<Vector2>.Release
	|
	|-RVA: 0x1655C10 Offset: 0x1654610 VA: 0x181655C10
	|-ArrayPool<Vector3>.Release
	|
	|-RVA: 0x164FDA0 Offset: 0x164E7A0 VA: 0x18164FDA0
	|-ArrayPool<__Il2CppFullySharedGenericType>.Release
	|
	|-RVA: 0x1654950 Offset: 0x1653350 VA: 0x181654950
	|-ArrayPool<BBTree.BBTreeBox>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16594C0 Offset: 0x1657EC0 VA: 0x1816594C0
	|-ArrayPool<bool>..cctor
	|-ArrayPool<Color>..cctor
	|-ArrayPool<Connection>..cctor
	|-ArrayPool<Int3>..cctor
	|-ArrayPool<int>..cctor
	|-ArrayPool<IntRect>..cctor
	|-ArrayPool<object>..cctor
	|-ArrayPool<ushort>..cctor
	|-ArrayPool<Vector2>..cctor
	|-ArrayPool<Vector3>..cctor
	|-ArrayPool<__Il2CppFullySharedGenericType>..cctor
	|-ArrayPool<BBTree.BBTreeBox>..cctor
	*/
}
