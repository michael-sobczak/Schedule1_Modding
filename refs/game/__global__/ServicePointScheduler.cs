internal class ServicePointScheduler // TypeDefIndex: 10085
{
	// Fields
	[CompilerGenerated]
	private ServicePoint <ServicePoint>k__BackingField; // 0x10
	private int running; // 0x18
	private int maxIdleTime; // 0x1C
	private ServicePointScheduler.AsyncManualResetEvent schedulerEvent; // 0x20
	private ServicePointScheduler.ConnectionGroup defaultGroup; // 0x28
	private Dictionary<string, ServicePointScheduler.ConnectionGroup> groups; // 0x30
	private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> operations; // 0x38
	private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> idleConnections; // 0x40
	private int currentConnections; // 0x48
	private int connectionLimit; // 0x4C
	private DateTime idleSince; // 0x50
	private static int nextId; // 0x0
	public readonly int ID; // 0x58

	// Properties
	private ServicePoint ServicePoint { get; set; }
	public int MaxIdleTime { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	private ServicePoint get_ServicePoint() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_MaxIdleTime() { }

	// RVA: 0x25C3E00 Offset: 0x25C2800 VA: 0x1825C3E00
	public void .ctor(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x25C3900 Offset: 0x25C2300 VA: 0x1825C3900
	public void Run() { }

	[AsyncStateMachine(typeof(ServicePointScheduler.<RunScheduler>d__32))]
	// RVA: 0x25C3820 Offset: 0x25C2220 VA: 0x1825C3820
	private Task RunScheduler() { }

	// RVA: 0x25C2AE0 Offset: 0x25C14E0 VA: 0x1825C2AE0
	private void Cleanup() { }

	// RVA: 0x25C35D0 Offset: 0x25C1FD0 VA: 0x1825C35D0
	private void RunSchedulerIteration() { }

	// RVA: 0x25C31A0 Offset: 0x25C1BA0 VA: 0x1825C31A0
	private bool OperationCompleted(ServicePointScheduler.ConnectionGroup group, WebOperation operation) { }

	// RVA: 0x25C2DD0 Offset: 0x25C17D0 VA: 0x1825C2DD0
	private void CloseIdleConnection(ServicePointScheduler.ConnectionGroup group, WebConnection connection) { }

	// RVA: 0x25C39D0 Offset: 0x25C23D0 VA: 0x1825C39D0
	private bool SchedulerIteration(ServicePointScheduler.ConnectionGroup group) { }

	// RVA: 0x25C3500 Offset: 0x25C1F00 VA: 0x1825C3500
	private void RemoveOperation(WebOperation operation) { }

	// RVA: 0x25C3430 Offset: 0x25C1E30 VA: 0x1825C3430
	private void RemoveIdleConnection(WebConnection connection) { }

	// RVA: 0x25C2E20 Offset: 0x25C1820 VA: 0x1825C2E20
	private void FinalCleanup() { }

	// RVA: 0x25C3BE0 Offset: 0x25C25E0 VA: 0x1825C3BE0
	public void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x25C2CB0 Offset: 0x25C16B0 VA: 0x1825C2CB0
	public bool CloseConnectionGroup(string groupName) { }

	// RVA: 0x25C2F60 Offset: 0x25C1960 VA: 0x1825C2F60
	private ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0x25C3190 Offset: 0x25C1B90 VA: 0x1825C3190
	private void OnConnectionCreated(WebConnection connection) { }

	// RVA: 0x25C3160 Offset: 0x25C1B60 VA: 0x1825C3160
	private void OnConnectionClosed(WebConnection connection) { }

	[AsyncStateMachine(typeof(ServicePointScheduler.<WaitAsync>d__46))]
	// RVA: 0x25C3CE0 Offset: 0x25C26E0 VA: 0x1825C3CE0
	public static Task<bool> WaitAsync(Task workerTask, int millisecondTimeout) { }

	[CompilerGenerated]
	// RVA: 0x25C3820 Offset: 0x25C2220 VA: 0x1825C3820
	private Task <Run>b__31_0() { }
}
