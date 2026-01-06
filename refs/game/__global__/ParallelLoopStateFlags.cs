internal class ParallelLoopStateFlags // TypeDefIndex: 4029
{
	// Fields
	private int _loopStateFlags; // 0x10

	// Properties
	internal int LoopStateFlags { get; }

	// Methods

	// RVA: 0x1CF2240 Offset: 0x1CF0C40 VA: 0x181CF2240
	internal int get_LoopStateFlags() { }

	// RVA: 0x1CF2160 Offset: 0x1CF0B60 VA: 0x181CF2160
	internal bool AtomicLoopStateUpdate(int newState, int illegalStates) { }

	// RVA: 0x1CF20A0 Offset: 0x1CF0AA0 VA: 0x181CF20A0
	internal bool AtomicLoopStateUpdate(int newState, int illegalStates, ref int oldState) { }

	// RVA: 0x1CF2230 Offset: 0x1CF0C30 VA: 0x181CF2230
	internal void SetExceptional() { }

	// RVA: 0x1CF2220 Offset: 0x1CF0C20 VA: 0x181CF2220
	internal bool Cancel() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
