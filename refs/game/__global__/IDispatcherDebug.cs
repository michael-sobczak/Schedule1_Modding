internal interface IDispatcherDebug // TypeDefIndex: 17951
{
	// Properties
	public abstract bool FlushInProgress { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_FlushInProgress();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void add_FlushStarted(Action<byte[]> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void remove_FlushStarted(Action<byte[]> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void add_FlushFinished(Action<int, bool, bool, bool, bool, byte[]> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void remove_FlushFinished(Action<int, bool, bool, bool, bool, byte[]> value);
}
