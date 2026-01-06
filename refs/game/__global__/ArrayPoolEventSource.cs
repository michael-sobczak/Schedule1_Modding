internal sealed class ArrayPoolEventSource : EventSource // TypeDefIndex: 5026
{
	// Fields
	internal static readonly ArrayPoolEventSource Log; // 0x0

	// Methods

	// RVA: 0x1C0AD70 Offset: 0x1C09770 VA: 0x181C0AD70
	private void .ctor() { }

	[Event(1, Level = 5)]
	// RVA: 0x1C0AAF0 Offset: 0x1C094F0 VA: 0x181C0AAF0
	internal void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId) { }

	[Event(2, Level = 4)]
	// RVA: 0x1C0A9E0 Offset: 0x1C093E0 VA: 0x181C0A9E0
	internal void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, ArrayPoolEventSource.BufferAllocatedReason reason) { }

	[Event(3, Level = 5)]
	// RVA: 0x1C0ABE0 Offset: 0x1C095E0 VA: 0x181C0ABE0
	internal void BufferReturned(int bufferId, int bufferSize, int poolId) { }

	[Event(4, Level = 4)]
	// RVA: 0x1C0AC40 Offset: 0x1C09640 VA: 0x181C0AC40
	internal void BufferTrimmed(int bufferId, int bufferSize, int poolId) { }

	[Event(5, Level = 4)]
	// RVA: 0x1C0AC10 Offset: 0x1C09610 VA: 0x181C0AC10
	internal void BufferTrimPoll(int milliseconds, int pressure) { }

	// RVA: 0x1C0AC70 Offset: 0x1C09670 VA: 0x181C0AC70
	private static void .cctor() { }
}
