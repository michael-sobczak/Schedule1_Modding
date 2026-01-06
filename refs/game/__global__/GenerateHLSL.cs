public class GenerateHLSL : Attribute // TypeDefIndex: 13796
{
	// Fields
	public PackingRules packingRules; // 0x10
	public bool containsPackedFields; // 0x14
	public bool needAccessors; // 0x15
	public bool needSetters; // 0x16
	public bool needParamDebug; // 0x17
	public int paramDefinesStart; // 0x18
	public bool omitStructDeclaration; // 0x1C
	public bool generateCBuffer; // 0x1D
	public int constantRegister; // 0x20
	public string sourcePath; // 0x28

	// Methods

	// RVA: 0x2A16960 Offset: 0x2A15360 VA: 0x182A16960
	public void .ctor(PackingRules rules = 0, bool needAccessors = True, bool needSetters = False, bool needParamDebug = False, int paramDefinesStart = 1, bool omitStructDeclaration = False, bool containsPackedFields = False, bool generateCBuffer = False, int constantRegister = -1, string sourcePath) { }
}
