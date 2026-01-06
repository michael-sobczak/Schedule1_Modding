public struct TimerState : IEquatable<TimerState> // TypeDefIndex: 6760
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private long <start>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private long <now>k__BackingField; // 0x8

	// Properties
	public long start { get; set; }
	public long now { get; set; }
	public long deltaTime { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public long get_start() { }

	[CompilerGenerated]
	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void set_start(long value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public long get_now() { }

	[CompilerGenerated]
	// RVA: 0x1CD2E00 Offset: 0x1CD1800 VA: 0x181CD2E00
	public void set_now(long value) { }

	// RVA: 0x2EE34D0 Offset: 0x2EE1ED0 VA: 0x182EE34D0
	public long get_deltaTime() { }

	// RVA: 0x2EE33B0 Offset: 0x2EE1DB0 VA: 0x182EE33B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2EE3380 Offset: 0x2EE1D80 VA: 0x182EE3380 Slot: 4
	public bool Equals(TimerState other) { }

	// RVA: 0x2EE3450 Offset: 0x2EE1E50 VA: 0x182EE3450 Slot: 2
	public override int GetHashCode() { }
}
