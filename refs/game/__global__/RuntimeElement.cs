internal abstract class RuntimeElement : IInterval // TypeDefIndex: 17411
{
	// Fields
	[CompilerGenerated]
	private int <intervalBit>k__BackingField; // 0x10

	// Properties
	public abstract long intervalStart { get; }
	public abstract long intervalEnd { get; }
	public int intervalBit { get; set; }
	public abstract bool enable { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract long get_intervalStart();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long get_intervalEnd();

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_intervalBit() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_intervalBit(int value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_enable(bool value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void EvaluateAt(double localTime, FrameData frameData);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void DisableAt(double localTime, double rootDuration, FrameData frameData);

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
