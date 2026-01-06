internal interface IDiskCache // TypeDefIndex: 17943
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Write(List<EventSummary> eventSummaries, Stream payload);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Read(List<EventSummary> eventSummaries, Stream buffer);
}
