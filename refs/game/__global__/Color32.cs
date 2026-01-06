public struct Color32 : IFormattable // TypeDefIndex: 11747
{
	// Fields
	[Ignore(DoesNotContributeToSize = True)]
	private int rgba; // 0x0
	public byte r; // 0x0
	public byte g; // 0x1
	public byte b; // 0x2
	public byte a; // 0x3

	// Methods

	// RVA: 0x26E0D50 Offset: 0x26DF750 VA: 0x1826E0D50
	public void .ctor(byte r, byte g, byte b, byte a) { }

	// RVA: 0x489110 Offset: 0x487B10 VA: 0x180489110
	public static Color32 op_Implicit(Color c) { }

	// RVA: 0x2CA2320 Offset: 0x2CA0D20 VA: 0x182CA2320
	public static Color op_Implicit(Color32 c) { }

	// RVA: 0x88C250 Offset: 0x88AC50 VA: 0x18088C250
	public static Color32 Lerp(Color32 a, Color32 b, float t) { }

	// RVA: 0x2CA2310 Offset: 0x2CA0D10 VA: 0x182CA2310 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CA20B0 Offset: 0x2CA0AB0 VA: 0x182CA20B0 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}
