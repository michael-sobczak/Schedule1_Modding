public struct Pollfd : IEquatable<Pollfd> // TypeDefIndex: 19229
{
	// Fields
	public int fd; // 0x0
	[CLSCompliant(False)]
	public PollEvents events; // 0x4
	[CLSCompliant(False)]
	public PollEvents revents; // 0x6

	// Methods

	// RVA: 0x1A51630 Offset: 0x1A50030 VA: 0x181A51630 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A51520 Offset: 0x1A4FF20 VA: 0x181A51520 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A51500 Offset: 0x1A4FF00 VA: 0x181A51500 Slot: 4
	public bool Equals(Pollfd value) { }
}
