public sealed class DecimalConstantAttribute : Attribute // TypeDefIndex: 4593
{
	// Fields
	private Decimal _dec; // 0x10

	// Properties
	public Decimal Value { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x1B605A0 Offset: 0x1B5EFA0 VA: 0x181B605A0
	public void .ctor(byte scale, byte sign, uint hi, uint mid, uint low) { }

	// RVA: 0x49CD30 Offset: 0x49B730 VA: 0x18049CD30
	public Decimal get_Value() { }
}
