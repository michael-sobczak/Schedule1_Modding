internal interface IBufferDebug // TypeDefIndex: 17950
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_EventRecorded(Action<string, string, DateTime, byte[]> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_EventRecorded(Action<string, string, DateTime, byte[]> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_EventsClearing(Action<HashSet<string>> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_EventsClearing(Action<HashSet<string>> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_EventsCleared(Action<HashSet<string>> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_EventsCleared(Action<HashSet<string>> value);
}
