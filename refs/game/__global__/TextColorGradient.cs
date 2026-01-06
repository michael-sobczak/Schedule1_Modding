public class TextColorGradient : ScriptableObject // TypeDefIndex: 16723
{
	// Fields
	public ColorGradientMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorGradientMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0x2D5B470 Offset: 0x2D59E70 VA: 0x182D5B470
	public void .ctor() { }

	// RVA: 0x2BD7070 Offset: 0x2BD5A70 VA: 0x182BD7070
	public void .ctor(Color color) { }

	// RVA: 0x2BD70C0 Offset: 0x2BD5AC0 VA: 0x182BD70C0
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0x2D5B430 Offset: 0x2D59E30 VA: 0x182D5B430
	private static void .cctor() { }
}
