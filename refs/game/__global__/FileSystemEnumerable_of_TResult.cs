public class FileSystemEnumerable<TResult> : IEnumerable<TResult>, IEnumerable // TypeDefIndex: 5124
{
	// Fields
	private FileSystemEnumerable.DelegateEnumerator<TResult> _enumerator; // 0x0
	private readonly FileSystemEnumerable.FindTransform<TResult> _transform; // 0x0
	private readonly EnumerationOptions _options; // 0x0
	private readonly string _directory; // 0x0
	[CompilerGenerated]
	private FileSystemEnumerable.FindPredicate<TResult> <ShouldIncludePredicate>k__BackingField; // 0x0
	[CompilerGenerated]
	private FileSystemEnumerable.FindPredicate<TResult> <ShouldRecursePredicate>k__BackingField; // 0x0

	// Properties
	public FileSystemEnumerable.FindPredicate<TResult> ShouldIncludePredicate { get; set; }
	public FileSystemEnumerable.FindPredicate<TResult> ShouldRecursePredicate { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string directory, FileSystemEnumerable.FindTransform<TResult> transform, EnumerationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C2BF0 Offset: 0x17C15F0 VA: 0x1817C2BF0
	|-FileSystemEnumerable<object>..ctor
	|
	|-RVA: 0x17C2A40 Offset: 0x17C1440 VA: 0x1817C2A40
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public FileSystemEnumerable.FindPredicate<TResult> get_ShouldIncludePredicate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	|-FileSystemEnumerable<object>.get_ShouldIncludePredicate
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.get_ShouldIncludePredicate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_ShouldIncludePredicate(FileSystemEnumerable.FindPredicate<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	|-FileSystemEnumerable<object>.set_ShouldIncludePredicate
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.set_ShouldIncludePredicate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public FileSystemEnumerable.FindPredicate<TResult> get_ShouldRecursePredicate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	|-FileSystemEnumerable<object>.get_ShouldRecursePredicate
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.get_ShouldRecursePredicate
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TResult> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C2930 Offset: 0x17C1330 VA: 0x1817C2930
	|-FileSystemEnumerable<object>.GetEnumerator
	|
	|-RVA: 0x17C28B0 Offset: 0x17C12B0 VA: 0x1817C28B0
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C29B0 Offset: 0x17C13B0 VA: 0x1817C29B0
	|-FileSystemEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xFEA2B0 Offset: 0xFE8CB0 VA: 0x180FEA2B0
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
