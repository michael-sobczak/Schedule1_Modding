internal abstract class RuntimeClipBase : RuntimeElement // TypeDefIndex: 17410
{
	// Properties
	public abstract double start { get; }
	public abstract double duration { get; }
	public override long intervalStart { get; }
	public override long intervalEnd { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public abstract double get_start();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract double get_duration();

	// RVA: 0x2C492F0 Offset: 0x2C47CF0 VA: 0x182C492F0 Slot: 6
	public override long get_intervalStart() { }

	// RVA: 0x2C49220 Offset: 0x2C47C20 VA: 0x182C49220 Slot: 7
	public override long get_intervalEnd() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
