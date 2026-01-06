public abstract class FileSystemEnumerator<TResult> : CriticalFinalizerObject, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 5119
{
	// Fields
	private readonly string _originalRootDirectory; // 0x0
	private readonly string _rootDirectory; // 0x0
	private readonly EnumerationOptions _options; // 0x0
	private readonly object _lock; // 0x0
	private Interop.NtDll.FILE_FULL_DIR_INFORMATION* _entry; // 0x0
	private TResult _current; // 0x0
	private IntPtr _buffer; // 0x0
	private int _bufferLength; // 0x0
	private IntPtr _directoryHandle; // 0x0
	private string _currentPath; // 0x0
	private bool _lastEntryFound; // 0x0
	[TupleElementNames(new[] { "Handle", "Path" })]
	private Queue<ValueTuple<IntPtr, string>> _pending; // 0x0

	// Properties
	public TResult Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	private bool GetDataUWP() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C4140 Offset: 0x17C2B40 VA: 0x1817C4140
	|-FileSystemEnumerator<object>.GetDataUWP
	|
	|-RVA: 0x17C3F80 Offset: 0x17C2980 VA: 0x1817C3F80
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.GetDataUWP
	*/

	// RVA: -1 Offset: -1
	private IntPtr CreateRelativeDirectoryHandleUWP(ReadOnlySpan<char> relativePath, string fullPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C3370 Offset: 0x17C1D70 VA: 0x1817C3370
	|-FileSystemEnumerator<object>.CreateRelativeDirectoryHandleUWP
	|
	|-RVA: 0x17C3350 Offset: 0x17C1D50 VA: 0x1817C3350
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.CreateRelativeDirectoryHandleUWP
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string directory, EnumerationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C6470 Offset: 0x17C4E70 VA: 0x1817C6470
	|-FileSystemEnumerator<object>..ctor
	|
	|-RVA: 0x17C5E30 Offset: 0x17C4830 VA: 0x1817C5E30
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void CloseDirectoryHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C2DA0 Offset: 0x17C17A0 VA: 0x1817C2DA0
	|-FileSystemEnumerator<object>.CloseDirectoryHandle
	|
	|-RVA: 0x17C2DE0 Offset: 0x17C17E0 VA: 0x1817C2DE0
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.CloseDirectoryHandle
	*/

	// RVA: -1 Offset: -1
	private IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C2F30 Offset: 0x17C1930 VA: 0x1817C2F30
	|-FileSystemEnumerator<object>.CreateDirectoryHandle
	|
	|-RVA: 0x17C3150 Offset: 0x17C1B50 VA: 0x1817C3150
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.CreateDirectoryHandle
	*/

	// RVA: -1 Offset: -1
	private bool ContinueOnDirectoryError(int error, bool ignoreNotFound) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C2ED0 Offset: 0x17C18D0 VA: 0x1817C2ED0
	|-FileSystemEnumerator<object>.ContinueOnDirectoryError
	|
	|-RVA: 0x17C2E40 Offset: 0x17C1840 VA: 0x1817C2E40
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.ContinueOnDirectoryError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C54F0 Offset: 0x17C3EF0 VA: 0x1817C54F0
	|-FileSystemEnumerator<object>.MoveNext
	|
	|-RVA: 0x17C4B00 Offset: 0x17C3500 VA: 0x1817C4B00
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void FindNextEntry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C3D00 Offset: 0x17C2700 VA: 0x1817C3D00
	|-FileSystemEnumerator<object>.FindNextEntry
	|
	|-RVA: 0x17C3E40 Offset: 0x17C2840 VA: 0x1817C3E40
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.FindNextEntry
	*/

	// RVA: -1 Offset: -1
	private bool DequeueNextDirectory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C3770 Offset: 0x17C2170 VA: 0x1817C3770
	|-FileSystemEnumerator<object>.DequeueNextDirectory
	|
	|-RVA: 0x17C35C0 Offset: 0x17C1FC0 VA: 0x1817C35C0
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.DequeueNextDirectory
	*/

	// RVA: -1 Offset: -1
	private void InternalDispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C4900 Offset: 0x17C3300 VA: 0x1817C4900
	|-FileSystemEnumerator<object>.InternalDispose
	|
	|-RVA: 0x17C4560 Offset: 0x17C2F60 VA: 0x1817C4560
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.InternalDispose
	*/

	// RVA: -1 Offset: -1
	private bool GetData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C4260 Offset: 0x17C2C60 VA: 0x1817C4260
	|-FileSystemEnumerator<object>.GetData
	|
	|-RVA: 0x17C43A0 Offset: 0x17C2DA0 VA: 0x1817C43A0
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.GetData
	*/

	// RVA: -1 Offset: -1
	private IntPtr CreateRelativeDirectoryHandle(ReadOnlySpan<char> relativePath, string fullPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C34A0 Offset: 0x17C1EA0 VA: 0x1817C34A0
	|-FileSystemEnumerator<object>.CreateRelativeDirectoryHandle
	|
	|-RVA: 0x17C3390 Offset: 0x17C1D90 VA: 0x1817C3390
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.CreateRelativeDirectoryHandle
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-FileSystemEnumerator<object>.ShouldIncludeEntry
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.ShouldIncludeEntry
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-FileSystemEnumerator<object>.ShouldRecurseIntoEntry
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.ShouldRecurseIntoEntry
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract TResult TransformEntry(ref FileSystemEntry entry);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.TransformEntry
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void OnDirectoryFinished(ReadOnlySpan<char> directory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-FileSystemEnumerator<object>.OnDirectoryFinished
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.OnDirectoryFinished
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual bool ContinueOnError(int error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-FileSystemEnumerator<object>.ContinueOnError
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.ContinueOnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TResult get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	|-FileSystemEnumerator<object>.get_Current
	|
	|-RVA: 0x17C67A0 Offset: 0x17C51A0 VA: 0x1817C67A0
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	|-FileSystemEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x17C5D80 Offset: 0x17C4780 VA: 0x1817C5D80
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1
	private void DirectoryFinished() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C3990 Offset: 0x17C2390 VA: 0x1817C3990
	|-FileSystemEnumerator<object>.DirectoryFinished
	|
	|-RVA: 0x17C3800 Offset: 0x17C2200 VA: 0x1817C3800
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.DirectoryFinished
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC9ED0 Offset: 0xFC88D0 VA: 0x180FC9ED0
	|-FileSystemEnumerator<object>.Reset
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C3B70 Offset: 0x17C2570 VA: 0x1817C3B70
	|-FileSystemEnumerator<object>.Dispose
	|
	|-RVA: 0x17C3AF0 Offset: 0x17C24F0 VA: 0x1817C3AF0
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-FileSystemEnumerator<object>.Dispose
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C3C80 Offset: 0x17C2680 VA: 0x1817C3C80
	|-FileSystemEnumerator<object>.Finalize
	|
	|-RVA: 0x17C3BF0 Offset: 0x17C25F0 VA: 0x1817C3BF0
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Finalize
	*/
}
