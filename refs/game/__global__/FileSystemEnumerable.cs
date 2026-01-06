private sealed class FileSystemEnumerable.DelegateEnumerator<TResult> : FileSystemEnumerator<TResult> // TypeDefIndex: 5123
{
	// Fields
	private readonly FileSystemEnumerable<TResult> _enumerable; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FileSystemEnumerable<TResult> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E75C0 Offset: 0x14E5FC0 VA: 0x1814E75C0
	|-FileSystemEnumerable.DelegateEnumerator<object>..ctor
	|
	|-RVA: 0x14E7530 Offset: 0x14E5F30 VA: 0x1814E7530
	|-FileSystemEnumerable.DelegateEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override TResult TransformEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7500 Offset: 0x14E5F00 VA: 0x1814E7500
	|-FileSystemEnumerable.DelegateEnumerator<object>.TransformEntry
	|
	|-RVA: 0x14E7410 Offset: 0x14E5E10 VA: 0x1814E7410
	|-FileSystemEnumerable.DelegateEnumerator<__Il2CppFullySharedGenericType>.TransformEntry
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E73D0 Offset: 0x14E5DD0 VA: 0x1814E73D0
	|-FileSystemEnumerable.DelegateEnumerator<object>.ShouldRecurseIntoEntry
	|
	|-RVA: 0x14E7340 Offset: 0x14E5D40 VA: 0x1814E7340
	|-FileSystemEnumerable.DelegateEnumerator<__Il2CppFullySharedGenericType>.ShouldRecurseIntoEntry
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override bool ShouldIncludeEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7300 Offset: 0x14E5D00 VA: 0x1814E7300
	|-FileSystemEnumerable.DelegateEnumerator<object>.ShouldIncludeEntry
	|
	|-RVA: 0x14E7270 Offset: 0x14E5C70 VA: 0x1814E7270
	|-FileSystemEnumerable.DelegateEnumerator<__Il2CppFullySharedGenericType>.ShouldIncludeEntry
	*/
}
