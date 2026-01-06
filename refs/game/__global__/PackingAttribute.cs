public class PackingAttribute : Attribute // TypeDefIndex: 13799
{
	// Fields
	public string[] displayNames; // 0x10
	public float[] range; // 0x18
	public FieldPacking packingScheme; // 0x20
	public int offsetInSource; // 0x24
	public int sizeInBits; // 0x28
	public bool isDirection; // 0x2C
	public bool sRGBDisplay; // 0x2D
	public bool checkIsNormalized; // 0x2E
	public string preprocessor; // 0x30

	// Methods

	// RVA: 0x2A1F570 Offset: 0x2A1DF70 VA: 0x182A1F570
	public void .ctor(string[] displayNames, FieldPacking packingScheme = 0, int bitSize = 32, int offsetInSource = 0, float minValue = 0, float maxValue = 1, bool isDirection = False, bool sRGBDisplay = False, bool checkIsNormalized = False, string preprocessor = "") { }

	// RVA: 0x2A1F670 Offset: 0x2A1E070 VA: 0x182A1F670
	public void .ctor(string displayName = "", FieldPacking packingScheme = 0, int bitSize = 0, int offsetInSource = 0, float minValue = 0, float maxValue = 1, bool isDirection = False, bool sRGBDisplay = False, bool checkIsNormalized = False, string preprocessor = "") { }
}
