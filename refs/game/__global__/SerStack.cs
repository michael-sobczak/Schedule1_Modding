internal sealed class SerStack // TypeDefIndex: 4506
{
	// Fields
	internal object[] objects; // 0x10
	internal string stackId; // 0x18
	internal int top; // 0x20

	// Methods

	// RVA: 0x1B75580 Offset: 0x1B73F80 VA: 0x181B75580
	internal void .ctor(string stackId) { }

	// RVA: 0x1B75450 Offset: 0x1B73E50 VA: 0x181B75450
	internal void Push(object obj) { }

	// RVA: 0x1B753D0 Offset: 0x1B73DD0 VA: 0x181B753D0
	internal object Pop() { }

	// RVA: 0x1B752A0 Offset: 0x1B73CA0 VA: 0x181B752A0
	internal void IncreaseCapacity() { }

	// RVA: 0x1B75390 Offset: 0x1B73D90 VA: 0x181B75390
	internal object Peek() { }

	// RVA: 0x1B75350 Offset: 0x1B73D50 VA: 0x181B75350
	internal object PeekPeek() { }

	// RVA: 0x1B75340 Offset: 0x1B73D40 VA: 0x181B75340
	internal bool IsEmpty() { }
}
