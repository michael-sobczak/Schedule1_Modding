public static class StackPool<T> // TypeDefIndex: 13391
{
	// Fields
	private static readonly List<Stack<T>> pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E2DC0 Offset: 0x11E17C0 VA: 0x1811E2DC0
	|-StackPool<object>..cctor
	|
	|-RVA: 0x11E2EC0 Offset: 0x11E18C0 VA: 0x1811E2EC0
	|-StackPool<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public static Stack<T> Claim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E1100 Offset: 0x11DFB00 VA: 0x1811E1100
	|-StackPool<object>.Claim
	|
	|-RVA: 0x11E15B0 Offset: 0x11DFFB0 VA: 0x1811E15B0
	|-StackPool<__Il2CppFullySharedGenericType>.Claim
	*/

	// RVA: -1 Offset: -1
	public static void Warmup(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E2980 Offset: 0x11E1380 VA: 0x1811E2980
	|-StackPool<object>.Warmup
	|
	|-RVA: 0x11E2B80 Offset: 0x11E1580 VA: 0x1811E2B80
	|-StackPool<__Il2CppFullySharedGenericType>.Warmup
	*/

	// RVA: -1 Offset: -1
	public static void Release(Stack<T> stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E20B0 Offset: 0x11E0AB0 VA: 0x1811E20B0
	|-StackPool<object>.Release
	|
	|-RVA: 0x11E24D0 Offset: 0x11E0ED0 VA: 0x1811E24D0
	|-StackPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	public static void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E1B30 Offset: 0x11E0530 VA: 0x1811E1B30
	|-StackPool<object>.Clear
	|
	|-RVA: 0x11E1D00 Offset: 0x11E0700 VA: 0x1811E1D00
	|-StackPool<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public static int GetSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E1FF0 Offset: 0x11E09F0 VA: 0x1811E1FF0
	|-StackPool<object>.GetSize
	|
	|-RVA: 0x11E1EF0 Offset: 0x11E08F0 VA: 0x1811E1EF0
	|-StackPool<__Il2CppFullySharedGenericType>.GetSize
	*/
}
