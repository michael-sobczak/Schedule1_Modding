public sealed class PropertySheetFactory // TypeDefIndex: 17069
{
	// Fields
	private readonly Dictionary<Shader, PropertySheet> m_Sheets; // 0x10

	// Methods

	// RVA: 0x29BB330 Offset: 0x29B9D30 VA: 0x1829BB330
	public void .ctor() { }

	[Obsolete("Use PropertySheet.Get(Shader) with a direct reference to the Shader instead.")]
	// RVA: 0x29BB090 Offset: 0x29B9A90 VA: 0x1829BB090
	public PropertySheet Get(string shaderName) { }

	// RVA: 0x29BAE70 Offset: 0x29B9870 VA: 0x1829BAE70
	public PropertySheet Get(Shader shader) { }

	// RVA: 0x29BB170 Offset: 0x29B9B70 VA: 0x1829BB170
	public void Release() { }
}
