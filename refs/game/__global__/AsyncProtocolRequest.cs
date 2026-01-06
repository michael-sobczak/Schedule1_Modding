internal abstract class AsyncProtocolRequest // TypeDefIndex: 9389
{
	// Fields
	[CompilerGenerated]
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly bool <RunSynchronously>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <UserResult>k__BackingField; // 0x1C
	private int Started; // 0x20
	private int RequestedSize; // 0x24
	private int WriteRequested; // 0x28
	private readonly object locker; // 0x30

	// Properties
	public MobileAuthenticatedStream Parent { get; }
	public bool RunSynchronously { get; }
	public string Name { get; }
	public int UserResult { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public MobileAuthenticatedStream get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_RunSynchronously() { }

	// RVA: 0x200E610 Offset: 0x200D010 VA: 0x18200E610
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_UserResult() { }

	[CompilerGenerated]
	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	protected void set_UserResult(int value) { }

	// RVA: 0x200E570 Offset: 0x200CF70 VA: 0x18200E570
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x200E330 Offset: 0x200CD30 VA: 0x18200E330
	internal void RequestRead(int size) { }

	// RVA: 0x200E3C0 Offset: 0x200CDC0 VA: 0x18200E3C0
	internal void RequestWrite() { }

	[AsyncStateMachine(typeof(AsyncProtocolRequest.<StartOperation>d__23))]
	// RVA: 0x200E3D0 Offset: 0x200CDD0 VA: 0x18200E3D0
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(AsyncProtocolRequest.<ProcessOperation>d__24))]
	// RVA: 0x200E220 Offset: 0x200CC20 VA: 0x18200E220
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(AsyncProtocolRequest.<InnerRead>d__25))]
	// RVA: 0x200E0F0 Offset: 0x200CAF0 VA: 0x18200E0F0
	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status);

	// RVA: 0x200E500 Offset: 0x200CF00 VA: 0x18200E500 Slot: 3
	public override string ToString() { }
}
