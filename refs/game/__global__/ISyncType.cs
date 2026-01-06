public interface ISyncType // TypeDefIndex: 12648
{
	// Properties
	public abstract bool IsDirty { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsDirty();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetRegistered();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void PreInitialize(NetworkManager networkManager);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void WriteDelta(PooledWriter writer, bool resetSyncTick = True);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void WriteFull(PooledWriter writer);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Read(PooledReader reader);

	[Obsolete("Use ResetState().")]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Reset();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ResetState();
}
