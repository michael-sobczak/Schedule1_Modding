public struct LocalKeyword : IEquatable<LocalKeyword> // TypeDefIndex: 12282
{
	// Fields
	internal readonly LocalKeywordSpace m_SpaceInfo; // 0x0
	internal readonly string m_Name; // 0x8
	internal readonly uint m_Index; // 0x10

	// Methods

	[FreeFunction("ShaderScripting::GetKeywordCount")]
	// RVA: 0x2CF2840 Offset: 0x2CF1240 VA: 0x182CF2840
	private static uint GetShaderKeywordCount(Shader shader) { }

	[FreeFunction("ShaderScripting::GetKeywordIndex")]
	// RVA: 0x2CF2880 Offset: 0x2CF1280 VA: 0x182CF2880
	private static uint GetShaderKeywordIndex(Shader shader, string keyword) { }

	// RVA: 0x2CF28D0 Offset: 0x2CF12D0 VA: 0x182CF28D0
	public void .ctor(Shader shader, string name) { }

	// RVA: 0x1CD2DF0 Offset: 0x1CD17F0 VA: 0x181CD2DF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CF26E0 Offset: 0x2CF10E0 VA: 0x182CF26E0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2CF2790 Offset: 0x2CF1190 VA: 0x182CF2790 Slot: 4
	public bool Equals(LocalKeyword rhs) { }

	// RVA: 0x2CF2800 Offset: 0x2CF1200 VA: 0x182CF2800 Slot: 2
	public override int GetHashCode() { }
}
