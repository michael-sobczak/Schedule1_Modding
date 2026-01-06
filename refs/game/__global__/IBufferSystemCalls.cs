internal interface IBufferSystemCalls // TypeDefIndex: 17939
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GenerateGuid();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DateTime Now();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TimeSpan GetTimeZoneUtcOffset(DateTime dateTime);
}
