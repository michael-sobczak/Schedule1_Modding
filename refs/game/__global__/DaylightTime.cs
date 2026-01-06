public class DaylightTime // TypeDefIndex: 4805
{
	// Fields
	private readonly DateTime _start; // 0x10
	private readonly DateTime _end; // 0x18
	private readonly TimeSpan _delta; // 0x20

	// Properties
	public DateTime Start { get; }
	public DateTime End { get; }
	public TimeSpan Delta { get; }

	// Methods

	// RVA: 0x1BA9550 Offset: 0x1BA7F50 VA: 0x181BA9550
	public void .ctor(DateTime start, DateTime end, TimeSpan delta) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public DateTime get_Start() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public DateTime get_End() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public TimeSpan get_Delta() { }
}
