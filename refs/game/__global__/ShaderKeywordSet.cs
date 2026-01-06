public struct ShaderKeywordSet // TypeDefIndex: 12285
{
	// Fields
	private IntPtr m_KeywordState; // 0x0
	private IntPtr m_Shader; // 0x8
	private IntPtr m_ComputeShader; // 0x10
	private ulong m_StateIndex; // 0x18

	// Methods

	[FreeFunction("keywords::IsKeywordEnabled")]
	// RVA: 0x2CFC7E0 Offset: 0x2CFB1E0 VA: 0x182CFC7E0
	private static bool IsKeywordNameEnabled(ShaderKeywordSet state, string name) { }

	// RVA: 0x2CFC600 Offset: 0x2CFB000 VA: 0x182CFC600
	private void CheckKeywordCompatible(ShaderKeyword keyword) { }

	// RVA: 0x2CFC6A0 Offset: 0x2CFB0A0 VA: 0x182CFC6A0
	public bool IsEnabled(ShaderKeyword keyword) { }

	// RVA: 0x2CFC790 Offset: 0x2CFB190 VA: 0x182CFC790
	private static bool IsKeywordNameEnabled_Injected(ref ShaderKeywordSet state, string name) { }
}
