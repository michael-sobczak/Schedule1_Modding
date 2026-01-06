public class SyncStopwatch : SyncBase, ICustomSync // TypeDefIndex: 12615
{
	// Fields
	[CompilerGenerated]
	private SyncStopwatch.SyncTypeChanged OnChange; // 0x50
	[CompilerGenerated]
	private float <Elapsed>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <Paused>k__BackingField; // 0x5C
	private List<SyncStopwatch.ChangeData> _changed; // 0x60
	private readonly List<SyncStopwatch.ChangeData> _serverOnChanges; // 0x68
	private readonly List<SyncStopwatch.ChangeData> _clientOnChanges; // 0x70

	// Properties
	public float Elapsed { get; set; }
	public bool Paused { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xD3CED0 Offset: 0xD3B8D0 VA: 0x180D3CED0
	public void add_OnChange(SyncStopwatch.SyncTypeChanged value) { }

	[CompilerGenerated]
	// RVA: 0xD3CF70 Offset: 0xD3B970 VA: 0x180D3CF70
	public void remove_OnChange(SyncStopwatch.SyncTypeChanged value) { }

	[CompilerGenerated]
	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_Elapsed() { }

	[CompilerGenerated]
	// RVA: 0x66B040 Offset: 0x669A40 VA: 0x18066B040
	private void set_Elapsed(float value) { }

	[CompilerGenerated]
	// RVA: 0x4CD980 Offset: 0x4CC380 VA: 0x1804CD980
	public bool get_Paused() { }

	[CompilerGenerated]
	// RVA: 0xCE3D60 Offset: 0xCE2760 VA: 0x180CE3D60
	private void set_Paused(bool value) { }

	// RVA: 0xD3C8E0 Offset: 0xD3B2E0 VA: 0x180D3C8E0
	public void StartStopwatch(bool sendElapsedOnStop = True) { }

	// RVA: 0xD3C650 Offset: 0xD3B050 VA: 0x180D3C650
	public void PauseStopwatch(bool sendElapsed = False) { }

	// RVA: 0xD3CA20 Offset: 0xD3B420 VA: 0x180D3CA20
	public void UnpauseStopwatch() { }

	// RVA: 0xD3C9C0 Offset: 0xD3B3C0 VA: 0x180D3C9C0
	public void StopStopwatch(bool sendElapsed = False) { }

	// RVA: 0xD3C250 Offset: 0xD3AC50 VA: 0x180D3C250
	private void AddOperation(SyncStopwatchOperation operation, float prev) { }

	// RVA: 0xD3CA90 Offset: 0xD3B490 VA: 0x180D3CA90 Slot: 15
	public override void WriteDelta(PooledWriter writer, bool resetSyncTick = True) { }

	// RVA: 0xD3CCB0 Offset: 0xD3B6B0 VA: 0x180D3CCB0 Slot: 17
	public override void WriteFull(PooledWriter writer) { }

	// RVA: 0xD3CD60 Offset: 0xD3B760 VA: 0x180D3CD60
	private void WriteStartStopwatch(Writer w, float elapsed, bool includeOperationByte) { }

	[APIExclude]
	// RVA: 0xD3C6B0 Offset: 0xD3B0B0 VA: 0x180D3C6B0 Slot: 19
	public override void Read(PooledReader reader, bool asServer) { }

	// RVA: 0xD3C390 Offset: 0xD3AD90 VA: 0x180D3C390
	private bool CanSetValues(bool asServer) { }

	// RVA: 0xD3C980 Offset: 0xD3B380 VA: 0x180D3C980
	private void StopStopwatch_Internal(bool asServer) { }

	// RVA: 0xD3C3C0 Offset: 0xD3ADC0 VA: 0x180D3C3C0
	private void InvokeOnChange(SyncStopwatchOperation operation, float prev, bool asServer) { }

	// RVA: 0xD3C4B0 Offset: 0xD3AEB0 VA: 0x180D3C4B0 Slot: 13
	public override void OnStartCallback(bool asServer) { }

	// RVA: 0xD3CA70 Offset: 0xD3B470 VA: 0x180D3CA70
	public void Update(float delta) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 22
	public object GetSerializedType() { }

	// RVA: 0xD3CDB0 Offset: 0xD3B7B0 VA: 0x180D3CDB0
	public void .ctor() { }
}
