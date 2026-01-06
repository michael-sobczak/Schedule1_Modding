public class Process : Component // TypeDefIndex: 9592
{
	// Fields
	private bool haveProcessId; // 0x28
	private int processId; // 0x2C
	private bool haveProcessHandle; // 0x30
	private SafeProcessHandle m_processHandle; // 0x38
	private bool isRemoteMachine; // 0x40
	private string machineName; // 0x48
	private int m_processAccess; // 0x50
	private ProcessThreadCollection threads; // 0x58
	private ProcessModuleCollection modules; // 0x60
	private bool haveWorkingSetLimits; // 0x68
	private bool havePriorityClass; // 0x69
	private bool watchForExit; // 0x6A
	private bool watchingForExit; // 0x6B
	private EventHandler onExited; // 0x70
	private bool exited; // 0x78
	private int exitCode; // 0x7C
	private bool signaled; // 0x80
	private bool haveExitTime; // 0x81
	private bool raisedOnExited; // 0x82
	private RegisteredWaitHandle registeredWaitHandle; // 0x88
	private WaitHandle waitHandle; // 0x90
	private ISynchronizeInvoke synchronizingObject; // 0x98
	private StreamReader standardOutput; // 0xA0
	private StreamWriter standardInput; // 0xA8
	private StreamReader standardError; // 0xB0
	private bool disposed; // 0xB8
	private Process.StreamReadMode outputStreamReadMode; // 0xBC
	private Process.StreamReadMode errorStreamReadMode; // 0xC0
	private Process.StreamReadMode inputStreamReadMode; // 0xC4
	internal AsyncStreamReader output; // 0xC8
	internal AsyncStreamReader error; // 0xD0
	private string process_name; // 0xD8

	// Properties
	[MonitoringDescription("Indicates if the process component is associated with a real process.")]
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	private bool Associated { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	[MonitoringDescription("Indicates if the associated process has been terminated.")]
	public bool HasExited { get; }
	[MonitoringDescription("The unique identifier for the process.")]
	[DesignerSerializationVisibility(0)]
	public int Id { get; }
	[Browsable(False)]
	[DefaultValue(null)]
	[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
	public ISynchronizeInvoke SynchronizingObject { get; }
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("The name of this process.")]
	public string ProcessName { get; }

	// Methods

	// RVA: 0x262FAD0 Offset: 0x262E4D0 VA: 0x18262FAD0
	private void .ctor(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	// RVA: 0x262FB70 Offset: 0x262E570 VA: 0x18262FB70
	private bool get_Associated() { }

	// RVA: 0x262FB80 Offset: 0x262E580 VA: 0x18262FB80
	public bool get_HasExited() { }

	// RVA: 0x262FEC0 Offset: 0x262E8C0 VA: 0x18262FEC0
	public int get_Id() { }

	// RVA: 0x2630130 Offset: 0x262EB30 VA: 0x182630130
	public ISynchronizeInvoke get_SynchronizingObject() { }

	// RVA: 0x262F890 Offset: 0x262E290 VA: 0x18262F890
	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	// RVA: 0x262ED60 Offset: 0x262D760 VA: 0x18262ED60 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x262EB30 Offset: 0x262D530 VA: 0x18262EB30
	public void Close() { }

	// RVA: 0x262EDB0 Offset: 0x262D7B0 VA: 0x18262EDB0
	private void EnsureState(Process.State state) { }

	// RVA: 0x262F030 Offset: 0x262DA30 VA: 0x18262F030
	public static Process GetCurrentProcess() { }

	// RVA: 0x262F450 Offset: 0x262DE50 VA: 0x18262F450
	protected void OnExited() { }

	// RVA: 0x262F100 Offset: 0x262DB00 VA: 0x18262F100
	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	// RVA: 0x262F440 Offset: 0x262DE40 VA: 0x18262F440
	private SafeProcessHandle GetProcessHandle(int access) { }

	// RVA: 0x262F840 Offset: 0x262E240 VA: 0x18262F840
	public void Refresh() { }

	// RVA: 0x262F8B0 Offset: 0x262E2B0 VA: 0x18262F8B0
	private void StopWatchingForExit() { }

	// RVA: 0x262F9C0 Offset: 0x262E3C0 VA: 0x18262F9C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x262F6B0 Offset: 0x262E0B0 VA: 0x18262F6B0
	private static string ProcessName_icall(IntPtr handle) { }

	// RVA: 0x262F6C0 Offset: 0x262E0C0 VA: 0x18262F6C0
	private static string ProcessName_internal(SafeProcessHandle handle) { }

	// RVA: 0x262FEE0 Offset: 0x262E8E0 VA: 0x18262FEE0
	public string get_ProcessName() { }

	// RVA: 0x262F790 Offset: 0x262E190 VA: 0x18262F790
	private void RaiseOnExited() { }
}
