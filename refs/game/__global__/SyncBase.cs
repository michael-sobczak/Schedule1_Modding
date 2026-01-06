public class SyncBase : ISyncType // TypeDefIndex: 12650
{
	// Fields
	[CompilerGenerated]
	private bool <IsRegistered>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsSyncObject>k__BackingField; // 0x11
	public Settings Settings; // 0x18
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; // 0x20
	public NetworkManager NetworkManager; // 0x28
	public NetworkBehaviour NetworkBehaviour; // 0x30
	[CompilerGenerated]
	private bool <OnStartServerCalled>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <OnStartClientCalled>k__BackingField; // 0x39
	public uint NextSyncTick; // 0x3C
	[CompilerGenerated]
	private uint <SyncIndex>k__BackingField; // 0x40
	private uint _timeToTicks; // 0x44
	private Channel _currentChannel; // 0x48

	// Properties
	public bool IsRegistered { get; set; }
	public bool IsNetworkInitialized { get; }
	public bool IsSyncObject { get; set; }
	public float SendRate { get; }
	public bool IsDirty { get; set; }
	public bool OnStartServerCalled { get; set; }
	public bool OnStartClientCalled { get; set; }
	public uint SyncIndex { get; set; }
	internal Channel Channel { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_IsRegistered() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	private void set_IsRegistered(bool value) { }

	// RVA: 0xD3C1B0 Offset: 0xD3ABB0 VA: 0x180D3C1B0
	public bool get_IsNetworkInitialized() { }

	[CompilerGenerated]
	// RVA: 0x498A50 Offset: 0x497450 VA: 0x180498A50
	public bool get_IsSyncObject() { }

	[CompilerGenerated]
	// RVA: 0x498A90 Offset: 0x497490 VA: 0x180498A90
	private void set_IsSyncObject(bool value) { }

	// RVA: 0xD3C210 Offset: 0xD3AC10 VA: 0x180D3C210
	public float get_SendRate() { }

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0 Slot: 4
	public bool get_IsDirty() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsDirty(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_OnStartServerCalled() { }

	[CompilerGenerated]
	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	private void set_OnStartServerCalled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8D2180 Offset: 0x8D0B80 VA: 0x1808D2180
	public bool get_OnStartClientCalled() { }

	[CompilerGenerated]
	// RVA: 0xCD74A0 Offset: 0xCD5EA0 VA: 0x180CD74A0
	private void set_OnStartClientCalled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public uint get_SyncIndex() { }

	[CompilerGenerated]
	// RVA: 0x4E28B0 Offset: 0x4E12B0 VA: 0x1804E28B0
	protected void set_SyncIndex(uint value) { }

	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	internal Channel get_Channel() { }

	// RVA: 0xD3BCE0 Offset: 0xD3A6E0 VA: 0x180D3BCE0
	public void InitializeInstance(NetworkBehaviour nb, uint syncIndex, WritePermission writePermissions, ReadPermission readPermissions, float tickRate, Channel channel, bool isSyncObject) { }

	// RVA: 0xD3C090 Offset: 0xD3AA90 VA: 0x180D3C090 Slot: 5
	public void SetRegistered() { }

	// RVA: 0x50C890 Offset: 0x50B290 VA: 0x18050C890 Slot: 12
	protected virtual void Registered() { }

	// RVA: 0xD3BF00 Offset: 0xD3A900 VA: 0x180D3BF00 Slot: 6
	public void PreInitialize(NetworkManager networkManager) { }

	// RVA: 0xD3BEE0 Offset: 0xD3A8E0 VA: 0x180D3BEE0 Slot: 13
	public virtual void OnStartCallback(bool asServer) { }

	// RVA: 0xD3BEF0 Offset: 0xD3A8F0 VA: 0x180D3BEF0 Slot: 14
	public virtual void OnStopCallback(bool asServer) { }

	// RVA: 0xD3B8E0 Offset: 0xD3A2E0 VA: 0x180D3B8E0
	protected bool CanNetworkSetValues(bool warn = True) { }

	// RVA: 0xD3BE00 Offset: 0xD3A800 VA: 0x180D3BE00
	protected void LogServerNotActiveWarning() { }

	// RVA: 0xD3BBA0 Offset: 0xD3A5A0 VA: 0x180D3BBA0
	public bool Dirty() { }

	// RVA: 0xD3C010 Offset: 0xD3AA10 VA: 0x180D3C010
	internal void ResetDirty() { }

	// RVA: 0xD3C0B0 Offset: 0xD3AAB0 VA: 0x180D3C0B0
	internal bool SyncTimeMet(uint tick) { }

	// RVA: 0xD3C0C0 Offset: 0xD3AAC0 VA: 0x180D3C0C0 Slot: 15
	public virtual void WriteDelta(PooledWriter writer, bool resetSyncTick = True) { }

	// RVA: 0xD3C0E0 Offset: 0xD3AAE0 VA: 0x180D3C0E0 Slot: 16
	protected virtual void WriteHeader(PooledWriter writer, bool resetSyncTick = True) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 17
	public virtual void WriteFull(PooledWriter writer) { }

	[Obsolete("Use Read(PooledReader, bool).")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 18
	public virtual void Read(PooledReader reader) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 19
	public virtual void Read(PooledReader reader, bool asServer) { }

	[Obsolete("Use ResetState().")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 20
	public virtual void Reset() { }

	// RVA: 0xD3C050 Offset: 0xD3AA50 VA: 0x180D3C050 Slot: 21
	public virtual void ResetState() { }

	// RVA: 0xD3C140 Offset: 0xD3AB40 VA: 0x180D3C140
	public void .ctor() { }
}
