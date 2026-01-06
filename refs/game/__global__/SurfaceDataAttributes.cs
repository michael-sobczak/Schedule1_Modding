public class SurfaceDataAttributes : Attribute // TypeDefIndex: 13797
{
	// Fields
	public string[] displayNames; // 0x10
	public bool isDirection; // 0x18
	public bool sRGBDisplay; // 0x19
	public FieldPrecision precision; // 0x1C
	public bool checkIsNormalized; // 0x20
	public string preprocessor; // 0x28

	// Methods

	// RVA: 0x2A2C070 Offset: 0x2A2AA70 VA: 0x182A2C070
	public void .ctor(string displayName = "", bool isDirection = False, bool sRGBDisplay = False, FieldPrecision precision = 2, bool checkIsNormalized = False, string preprocessor = "") { }

	// RVA: 0x2A2C150 Offset: 0x2A2AB50 VA: 0x182A2C150
	public void .ctor(string[] displayNames, bool isDirection = False, bool sRGBDisplay = False, FieldPrecision precision = 2, bool checkIsNormalized = False, string preprocessor = "") { }
}
