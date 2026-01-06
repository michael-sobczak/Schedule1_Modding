public struct SharedStatic<T> // TypeDefIndex: 16317
{
	// Fields
	private readonly void* _buffer; // 0x0
	private const uint DefaultAlignment = 16;

	// Properties
	public T Data { get; }
	public void* UnsafeDataPointer { get; }

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor(void* buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	|-SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>>..ctor
	|-SharedStatic<int>..ctor
	|-SharedStatic<IntPtr>..ctor
	|-SharedStatic<Long1024>..ctor
	|-SharedStatic<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Data() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1088270 Offset: 0x1086C70 VA: 0x181088270
	|-SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>>.get_Data
	|-SharedStatic<int>.get_Data
	|-SharedStatic<IntPtr>.get_Data
	|-SharedStatic<Long1024>.get_Data
	|
	|-RVA: 0x11C1DF0 Offset: 0x11C07F0 VA: 0x1811C1DF0
	|-SharedStatic<__Il2CppFullySharedGenericStructType>.get_Data
	*/

	// RVA: -1 Offset: -1
	public void* get_UnsafeDataPointer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>>.get_UnsafeDataPointer
	|-SharedStatic<int>.get_UnsafeDataPointer
	|-SharedStatic<IntPtr>.get_UnsafeDataPointer
	|-SharedStatic<Long1024>.get_UnsafeDataPointer
	|-SharedStatic<__Il2CppFullySharedGenericStructType>.get_UnsafeDataPointer
	*/

	// RVA: -1 Offset: -1
	public static SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCA3E0 Offset: 0xDC8DE0 VA: 0x180DCA3E0
	|-SharedStatic<__Il2CppFullySharedGenericStructType>.GetOrCreate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static SharedStatic<T> GetOrCreate<TContext, TSubContext>(uint alignment = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCA320 Offset: 0xDC8D20 VA: 0x180DCA320
	|-SharedStatic<__Il2CppFullySharedGenericStructType>.GetOrCreate<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C1780 Offset: 0x11C0180 VA: 0x1811C1780
	|-SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>>.GetOrCreateUnsafe
	|
	|-RVA: 0x11C18A0 Offset: 0x11C02A0 VA: 0x1811C18A0
	|-SharedStatic<int>.GetOrCreateUnsafe
	|
	|-RVA: 0x11C1630 Offset: 0x11C0030 VA: 0x1811C1630
	|-SharedStatic<IntPtr>.GetOrCreateUnsafe
	|
	|-RVA: 0x11C1810 Offset: 0x11C0210 VA: 0x1811C1810
	|-SharedStatic<Long1024>.GetOrCreateUnsafe
	|
	|-RVA: 0x11C16C0 Offset: 0x11C00C0 VA: 0x1811C16C0
	|-SharedStatic<__Il2CppFullySharedGenericStructType>.GetOrCreateUnsafe
	*/

	// RVA: -1 Offset: -1
	public static SharedStatic<T> GetOrCreatePartiallyUnsafeWithHashCode<TSubContext>(uint alignment, long hashCode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCA0D0 Offset: 0xDC8AD0 VA: 0x180DCA0D0
	|-SharedStatic<__Il2CppFullySharedGenericStructType>.GetOrCreatePartiallyUnsafeWithHashCode<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static SharedStatic<T> GetOrCreatePartiallyUnsafeWithSubHashCode<TContext>(uint alignment, long subHashCode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCA1B0 Offset: 0xDC8BB0 VA: 0x180DCA1B0
	|-SharedStatic<__Il2CppFullySharedGenericStructType>.GetOrCreatePartiallyUnsafeWithSubHashCode<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static SharedStatic<T> GetOrCreate(Type contextType, uint alignment = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C1C00 Offset: 0x11C0600 VA: 0x1811C1C00
	|-SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>>.GetOrCreate
	|
	|-RVA: 0x11C1A10 Offset: 0x11C0410 VA: 0x1811C1A10
	|-SharedStatic<int>.GetOrCreate
	|
	|-RVA: 0x11C1930 Offset: 0x11C0330 VA: 0x1811C1930
	|-SharedStatic<IntPtr>.GetOrCreate
	|
	|-RVA: 0x11C1AF0 Offset: 0x11C04F0 VA: 0x1811C1AF0
	|-SharedStatic<Long1024>.GetOrCreate
	|
	|-RVA: 0x11C1CE0 Offset: 0x11C06E0 VA: 0x1811C1CE0
	|-SharedStatic<__Il2CppFullySharedGenericStructType>.GetOrCreate
	*/

	// RVA: -1 Offset: -1
	public static SharedStatic<T> GetOrCreate(Type contextType, Type subContextType, uint alignment = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C1D70 Offset: 0x11C0770 VA: 0x1811C1D70
	|-SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>>.GetOrCreate
	|
	|-RVA: 0x11C1A70 Offset: 0x11C0470 VA: 0x1811C1A70
	|-SharedStatic<int>.GetOrCreate
	|
	|-RVA: 0x11C1C60 Offset: 0x11C0660 VA: 0x1811C1C60
	|-SharedStatic<IntPtr>.GetOrCreate
	|
	|-RVA: 0x11C1990 Offset: 0x11C0390 VA: 0x1811C1990
	|-SharedStatic<Long1024>.GetOrCreate
	|
	|-RVA: 0x11C1B50 Offset: 0x11C0550 VA: 0x1811C1B50
	|-SharedStatic<__Il2CppFullySharedGenericStructType>.GetOrCreate
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void CheckIf_T_IsUnmanagedOrThrow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9F93E0 Offset: 0x9F7DE0 VA: 0x1809F93E0
	|-SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>>.CheckIf_T_IsUnmanagedOrThrow
	|-SharedStatic<int>.CheckIf_T_IsUnmanagedOrThrow
	|-SharedStatic<IntPtr>.CheckIf_T_IsUnmanagedOrThrow
	|-SharedStatic<Long1024>.CheckIf_T_IsUnmanagedOrThrow
	|
	|-RVA: 0x11C1520 Offset: 0x11BFF20 VA: 0x1811C1520
	|-SharedStatic<__Il2CppFullySharedGenericStructType>.CheckIf_T_IsUnmanagedOrThrow
	*/
}
