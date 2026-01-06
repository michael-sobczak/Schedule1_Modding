public sealed class AmbiguousImplementationException : Exception // TypeDefIndex: 4267
{
	// Methods

	// RVA: 0x1B034F0 Offset: 0x1B01EF0 VA: 0x181B034F0
	public void .ctor() { }

	// RVA: 0x1B035E0 Offset: 0x1B01FE0 VA: 0x181B035E0
	public void .ctor(string message) { }

	// RVA: 0x1B03560 Offset: 0x1B01F60 VA: 0x181B03560
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}
