internal class GraphUpdateProcessor // TypeDefIndex: 13170
{
	// Fields
	[CompilerGenerated]
	private Action OnGraphsUpdated; // 0x10
	private readonly AstarPath astar; // 0x18
	private Thread graphUpdateThread; // 0x20
	private bool anyGraphUpdateInProgress; // 0x28
	private CustomSampler asyncUpdateProfilingSampler; // 0x30
	private readonly Queue<GraphUpdateObject> graphUpdateQueue; // 0x38
	private readonly Queue<GraphUpdateProcessor.GUOSingle> graphUpdateQueueAsync; // 0x40
	private readonly Queue<GraphUpdateProcessor.GUOSingle> graphUpdateQueuePost; // 0x48
	private readonly Queue<GraphUpdateProcessor.GUOSingle> graphUpdateQueueRegular; // 0x50
	private readonly ManualResetEvent asyncGraphUpdatesComplete; // 0x58
	private readonly AutoResetEvent graphUpdateAsyncEvent; // 0x60
	private readonly AutoResetEvent exitAsyncThread; // 0x68

	// Properties
	public bool IsAnyGraphUpdateQueued { get; }
	public bool IsAnyGraphUpdateInProgress { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xB18DF0 Offset: 0xB177F0 VA: 0x180B18DF0
	public void add_OnGraphsUpdated(Action value) { }

	[CompilerGenerated]
	// RVA: 0xB18EE0 Offset: 0xB178E0 VA: 0x180B18EE0
	public void remove_OnGraphsUpdated(Action value) { }

	// RVA: 0xB18E90 Offset: 0xB17890 VA: 0x180B18E90
	public bool get_IsAnyGraphUpdateQueued() { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsAnyGraphUpdateInProgress() { }

	// RVA: 0xB18C10 Offset: 0xB17610 VA: 0x180B18C10
	public void .ctor(AstarPath astar) { }

	// RVA: 0xB17D40 Offset: 0xB16740 VA: 0x180B17D40
	public AstarWorkItem GetWorkItem() { }

	// RVA: 0xB17BE0 Offset: 0xB165E0 VA: 0x180B17BE0
	public void EnableMultithreading() { }

	// RVA: 0xB17B20 Offset: 0xB16520 VA: 0x180B17B20
	public void DisableMultithreading() { }

	// RVA: 0xB17AC0 Offset: 0xB164C0 VA: 0x180B17AC0
	public void AddToQueue(GraphUpdateObject ob) { }

	// RVA: 0xB187A0 Offset: 0xB171A0 VA: 0x180B187A0
	private void QueueGraphUpdatesInternal() { }

	// RVA: 0xB181E0 Offset: 0xB16BE0 VA: 0x180B181E0
	private bool ProcessGraphUpdates(bool force) { }

	// RVA: 0xB18470 Offset: 0xB16E70 VA: 0x180B18470
	private bool ProcessRegularUpdates(bool force) { }

	// RVA: 0xB18BA0 Offset: 0xB175A0 VA: 0x180B18BA0
	private bool StartAsyncUpdatesIfQueued() { }

	// RVA: 0xB182D0 Offset: 0xB16CD0 VA: 0x180B182D0
	private void ProcessPostUpdates() { }

	// RVA: 0xB17E50 Offset: 0xB16850 VA: 0x180B17E50
	private void ProcessGraphUpdatesAsync() { }
}
