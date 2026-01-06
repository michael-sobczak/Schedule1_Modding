public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 14873
{
	// Fields
	public ColorMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0x2BD6FC0 Offset: 0x2BD59C0 VA: 0x182BD6FC0
	public void .ctor() { }

	// RVA: 0x2BD7070 Offset: 0x2BD5A70 VA: 0x182BD7070
	public void .ctor(Color color) { }

	// RVA: 0x2BD70C0 Offset: 0x2BD5AC0 VA: 0x182BD70C0
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0x2BD6F80 Offset: 0x2BD5980 VA: 0x182BD6F80
	private static void .cctor() { }
}
