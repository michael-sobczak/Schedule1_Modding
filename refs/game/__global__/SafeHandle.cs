public abstract class SafeHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 4556
{
	// Fields
	protected IntPtr handle; // 0x10
	private int _state; // 0x18
	private bool _ownsHandle; // 0x1C
	private bool _fullyInitialized; // 0x1D
	private const int RefCount_Mask = 2147483644;
	private const int RefCount_One = 4;

	// Properties
	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x1B75080 Offset: 0x1B73A80 VA: 0x181B75080
	protected void .ctor(IntPtr invalidHandleValue, bool ownsHandle) { }

	// RVA: 0x1B75110 Offset: 0x1B73B10 VA: 0x181B75110
	protected void .ctor() { }

	// RVA: 0x1B74ED0 Offset: 0x1B738D0 VA: 0x181B74ED0 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0xCC46F0 Offset: 0xCC30F0 VA: 0x180CC46F0
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public IntPtr DangerousGetHandle() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1B75160 Offset: 0x1B73B60 VA: 0x181B75160
	public bool get_IsClosed() { }

	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsInvalid();

	[ReliabilityContract(3, 2)]
	// RVA: 0x10F5FF0 Offset: 0x10F49F0 VA: 0x1810F5FF0
	public void Close() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x10F5FF0 Offset: 0x10F49F0 VA: 0x1810F5FF0 Slot: 4
	public void Dispose() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1B74E10 Offset: 0x1B73810 VA: 0x181B74E10 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle();

	[ReliabilityContract(3, 2)]
	// RVA: 0x1B75000 Offset: 0x1B73A00 VA: 0x181B75000
	public void SetHandleAsInvalid() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1B74CF0 Offset: 0x1B736F0 VA: 0x181B74CF0
	public void DangerousAddRef(ref bool success) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1B74E00 Offset: 0x1B73800 VA: 0x181B74E00
	public void DangerousRelease() { }

	// RVA: 0x1B74F40 Offset: 0x1B73940 VA: 0x181B74F40
	private void InternalDispose() { }

	// RVA: 0x1B74FE0 Offset: 0x1B739E0 VA: 0x181B74FE0
	private void InternalFinalize() { }

	// RVA: 0x1B74D60 Offset: 0x1B73760 VA: 0x181B74D60
	private void DangerousReleaseInternal(bool dispose) { }
}
