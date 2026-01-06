public sealed class Shader : Object // TypeDefIndex: 11668
{
	// Properties
	public bool isSupported { get; }
	public static string globalRenderPipeline { set; }
	public LocalKeywordSpace keywordSpace { get; }
	public int passCount { get; }

	// Methods

	// RVA: 0x2C9F9F0 Offset: 0x2C9E3F0 VA: 0x182C9F9F0
	public static Shader Find(string name) { }

	[NativeMethod("IsSupported")]
	// RVA: 0x2CA0500 Offset: 0x2C9EF00 VA: 0x182CA0500
	public bool get_isSupported() { }

	// RVA: 0x2CA0620 Offset: 0x2C9F020 VA: 0x182CA0620
	public static void set_globalRenderPipeline(string value) { }

	// RVA: 0x2CA0590 Offset: 0x2C9EF90 VA: 0x182CA0590
	public LocalKeywordSpace get_keywordSpace() { }

	[FreeFunction("ShaderScripting::EnableKeyword")]
	// RVA: 0x2C9F9B0 Offset: 0x2C9E3B0 VA: 0x182C9F9B0
	public static void EnableKeyword(string keyword) { }

	[FreeFunction("ShaderScripting::DisableKeyword")]
	// RVA: 0x2C9F970 Offset: 0x2C9E370 VA: 0x182C9F970
	public static void DisableKeyword(string keyword) { }

	[FreeFunction("ShaderScripting::TagToID")]
	// RVA: 0x2CA0470 Offset: 0x2C9EE70 VA: 0x182CA0470
	internal static int TagToID(string name) { }

	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = True)]
	// RVA: 0x2C9FA60 Offset: 0x2C9E460 VA: 0x182C9FA60
	public static int PropertyToID(string name) { }

	[FreeFunction(Name = "ShaderScripting::GetPassCount", HasExplicitThis = True)]
	// RVA: 0x2CA05E0 Offset: 0x2C9EFE0 VA: 0x182CA05E0
	public int get_passCount() { }

	[FreeFunction("ShaderScripting::SetGlobalFloat")]
	// RVA: 0x2C9FB80 Offset: 0x2C9E580 VA: 0x182C9FB80
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunction("ShaderScripting::SetGlobalVector")]
	// RVA: 0x2CA0370 Offset: 0x2C9ED70 VA: 0x182CA0370
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[FreeFunction("ShaderScripting::SetGlobalMatrix")]
	// RVA: 0x2C9FF90 Offset: 0x2C9E990 VA: 0x182C9FF90
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[FreeFunction("ShaderScripting::SetGlobalTexture")]
	// RVA: 0x2CA0030 Offset: 0x2C9EA30 VA: 0x182CA0030
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunction("ShaderScripting::SetGlobalConstantBuffer")]
	// RVA: 0x2C9FB20 Offset: 0x2C9E520 VA: 0x182C9FB20
	private static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[FreeFunction("ShaderScripting::SetGlobalVectorArray")]
	// RVA: 0x2CA00E0 Offset: 0x2C9EAE0 VA: 0x182CA00E0
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	[FreeFunction("ShaderScripting::SetGlobalMatrixArray")]
	// RVA: 0x2C9FD00 Offset: 0x2C9E700 VA: 0x182C9FD00
	private static void SetGlobalMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	// RVA: 0x2CA0130 Offset: 0x2C9EB30 VA: 0x182CA0130
	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x2C9FE00 Offset: 0x2C9E800 VA: 0x182C9FE00
	private static void SetGlobalMatrixArray(int name, Matrix4x4[] values, int count) { }

	// RVA: 0x2C9FC40 Offset: 0x2C9E640 VA: 0x182C9FC40
	public static void SetGlobalInt(string name, int value) { }

	// RVA: 0x2C9FCB0 Offset: 0x2C9E6B0 VA: 0x182C9FCB0
	public static void SetGlobalInt(int nameID, int value) { }

	// RVA: 0x2C9FBD0 Offset: 0x2C9E5D0 VA: 0x182C9FBD0
	public static void SetGlobalFloat(string name, float value) { }

	// RVA: 0x2C9FB80 Offset: 0x2C9E580 VA: 0x182C9FB80
	public static void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x2CA03B0 Offset: 0x2C9EDB0 VA: 0x182CA03B0
	public static void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x2CA0430 Offset: 0x2C9EE30 VA: 0x182CA0430
	public static void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x2C9FAA0 Offset: 0x2C9E4A0 VA: 0x182C9FAA0
	public static void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x2C9FFD0 Offset: 0x2C9E9D0 VA: 0x182C9FFD0
	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x2CA0070 Offset: 0x2C9EA70 VA: 0x182CA0070
	public static void SetGlobalTexture(string name, Texture value) { }

	// RVA: 0x2CA0030 Offset: 0x2C9EA30 VA: 0x182CA0030
	public static void SetGlobalTexture(int nameID, Texture value) { }

	// RVA: 0x2C9FB20 Offset: 0x2C9E520 VA: 0x182C9FB20
	public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	// RVA: 0x2CA0280 Offset: 0x2C9EC80 VA: 0x182CA0280
	public static void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	// RVA: 0x2C9FD50 Offset: 0x2C9E750 VA: 0x182C9FD50
	public static void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	// RVA: 0x2CA04B0 Offset: 0x2C9EEB0 VA: 0x182CA04B0
	private void .ctor() { }

	// RVA: 0x2CA0540 Offset: 0x2C9EF40 VA: 0x182CA0540
	private void get_keywordSpace_Injected(out LocalKeywordSpace ret) { }

	// RVA: 0x2CA0330 Offset: 0x2C9ED30 VA: 0x182CA0330
	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x2C9FF50 Offset: 0x2C9E950 VA: 0x182C9FF50
	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }
}
