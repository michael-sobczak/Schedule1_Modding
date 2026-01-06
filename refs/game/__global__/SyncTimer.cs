public class SyncTimer : SyncBase, ICustomSync // TypeDefIndex: 12620
{
	// Fields
	[CompilerGenerated]
	private SyncTimer.SyncTypeChanged OnChange; // 0x50
	[CompilerGenerated]
	private float <Remaining>k__BackingField; // 0x58
	[CompilerGenerated]
	private float <Duration>k__BackingField; // 0x5C
	[CompilerGenerated]
	private bool <Paused>k__BackingField; // 0x60
	private List<SyncTimer.ChangeData> _changed; // 0x68
	private readonly List<SyncTimer.ChangeData> _serverOnChanges; // 0x70
	private readonly List<SyncTimer.ChangeData> _clientOnChanges; // 0x78

	// Properties
	public float Remaining { get; set; }
	public float Elapsed { get; }
	public float Duration { get; set; }
	public bool Paused { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xD3E090 Offset: 0xD3CA90 VA: 0x180D3E090
	public void add_OnChange(SyncTimer.SyncTypeChanged value) { }

	[CompilerGenerated]
	// RVA: 0xD3E140 Offset: 0xD3CB40 VA: 0x180D3E140
	public void remove_OnChange(SyncTimer.SyncTypeChanged value) { }

	[CompilerGenerated]
	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_Remaining() { }

	[CompilerGenerated]
	// RVA: 0x66B040 Offset: 0x669A40 VA: 0x18066B040
	private void set_Remaining(float value) { }

	// RVA: 0xD3E130 Offset: 0xD3CB30 VA: 0x180D3E130
	public float get_Elapsed() { }

	[CompilerGenerated]
	// RVA: 0x4B5C00 Offset: 0x4B4600 VA: 0x1804B5C00
	public float get_Duration() { }

	[CompilerGenerated]
	// RVA: 0xD3E1E0 Offset: 0xD3CBE0 VA: 0x180D3E1E0
	private void set_Duration(float value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_Paused() { }

	[CompilerGenerated]
	// RVA: 0x68C180 Offset: 0x68AB80 VA: 0x18068C180
	private void set_Paused(bool value) { }

	// RVA: 0xD3D880 Offset: 0xD3C280 VA: 0x180D3D880
	public void StartTimer(float remaining, bool sendRemainingOnStop = True) { }

	// RVA: 0xD3D5C0 Offset: 0xD3BFC0 VA: 0x180D3D5C0
	public void PauseTimer(bool sendRemaining = False) { }

	// RVA: 0xD3DAE0 Offset: 0xD3C4E0 VA: 0x180D3DAE0
	public void UnpauseTimer() { }

	// RVA: 0xD3D980 Offset: 0xD3C380 VA: 0x180D3D980
	public void StopTimer(bool sendRemaining = False) { }

	// RVA: 0xD3D010 Offset: 0xD3BA10 VA: 0x180D3D010
	private void AddOperation(SyncTimerOperation operation, float prev, float next) { }

	// RVA: 0xD3DC20 Offset: 0xD3C620 VA: 0x180D3DC20 Slot: 15
	public override void WriteDelta(PooledWriter writer, bool resetSyncTick = True) { }

	// RVA: 0xD3DE50 Offset: 0xD3C850 VA: 0x180D3DE50 Slot: 17
	public override void WriteFull(PooledWriter writer) { }

	// RVA: 0xD3DF00 Offset: 0xD3C900 VA: 0x180D3DF00
	private void WriteStartTimer(Writer w, bool includeOperationByte) { }

	// RVA: 0xD3C390 Offset: 0xD3AD90 VA: 0x180D3C390
	private bool CanSetValues(bool asServer) { }

	[APIExclude]
	// RVA: 0xD3D620 Offset: 0xD3C020 VA: 0x180D3D620 Slot: 19
	public override void Read(PooledReader reader, bool asServer) { }

	// RVA: 0xD3D940 Offset: 0xD3C340 VA: 0x180D3D940
	private void StopTimer_Internal(bool asServer) { }

	// RVA: 0xD3D210 Offset: 0xD3BC10 VA: 0x180D3D210
	private void InvokeOnChange(SyncTimerOperation operation, float prev, float next, bool asServer) { }

	// RVA: 0xD3D410 Offset: 0xD3BE10 VA: 0x180D3D410 Slot: 13
	public override void OnStartCallback(bool asServer) { }

	// RVA: 0xD3DB30 Offset: 0xD3C530 VA: 0x180D3DB30
	public void Update(float delta) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 22
	public object GetSerializedType() { }

	// RVA: 0xD3DF70 Offset: 0xD3C970 VA: 0x180D3DF70
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xD3D9E0 Offset: 0xD3C3E0 VA: 0x180D3D9E0
	private void <Read>g__UpdatePauseState|31_0(SyncTimerOperation op, ref SyncTimer.<>c__DisplayClass31_0 ) { }
}
