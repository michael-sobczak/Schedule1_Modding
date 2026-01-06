public class Material : Object // TypeDefIndex: 11669
{
	// Properties
	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; set; }
	public int renderQueue { get; set; }
	internal int rawRenderQueue { get; }
	public LocalKeyword[] enabledKeywords { set; }
	[NativeProperty("EnableInstancingVariants")]
	public bool enableInstancing { get; set; }
	public int passCount { get; }
	public string[] shaderKeywords { get; set; }

	// Methods

	[FreeFunction("MaterialScripting::CreateWithShader")]
	// RVA: 0x2C923A0 Offset: 0x2C90DA0 VA: 0x182C923A0
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	// RVA: 0x2C92350 Offset: 0x2C90D50 VA: 0x182C92350
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunction("MaterialScripting::CreateWithString")]
	// RVA: 0x2C923F0 Offset: 0x2C90DF0 VA: 0x182C923F0
	private static void CreateWithString(Material self) { }

	// RVA: 0x2C93F60 Offset: 0x2C92960 VA: 0x182C93F60
	public void .ctor(Shader shader) { }

	[RequiredByNativeCode]
	// RVA: 0x2C94050 Offset: 0x2C92A50 VA: 0x182C94050
	public void .ctor(Material source) { }

	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", False)]
	[EditorBrowsable(1)]
	// RVA: 0x2C93FE0 Offset: 0x2C929E0 VA: 0x182C93FE0
	public void .ctor(string contents) { }

	// RVA: 0x2C94380 Offset: 0x2C92D80 VA: 0x182C94380
	public Shader get_shader() { }

	// RVA: 0x2C945F0 Offset: 0x2C92FF0 VA: 0x182C945F0
	public void set_shader(Shader value) { }

	// RVA: 0x2C940D0 Offset: 0x2C92AD0 VA: 0x182C940D0
	public Color get_color() { }

	// RVA: 0x2C943C0 Offset: 0x2C92DC0 VA: 0x182C943C0
	public void set_color(Color value) { }

	// RVA: 0x2C94200 Offset: 0x2C92C00 VA: 0x182C94200
	public Texture get_mainTexture() { }

	// RVA: 0x2C944E0 Offset: 0x2C92EE0 VA: 0x182C944E0
	public void set_mainTexture(Texture value) { }

	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	// RVA: 0x2C926E0 Offset: 0x2C910E0 VA: 0x182C926E0
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeName("HasPropertyFromScript")]
	// RVA: 0x2C92D20 Offset: 0x2C91720 VA: 0x182C92D20
	public bool HasProperty(int nameID) { }

	// RVA: 0x2C92D60 Offset: 0x2C91760 VA: 0x182C92D60
	public bool HasProperty(string name) { }

	[NativeName("GetActualRenderQueue")]
	// RVA: 0x2C94340 Offset: 0x2C92D40 VA: 0x182C94340
	public int get_renderQueue() { }

	[NativeName("SetCustomRenderQueue")]
	// RVA: 0x2C945B0 Offset: 0x2C92FB0 VA: 0x182C945B0
	public void set_renderQueue(int value) { }

	[NativeName("GetCustomRenderQueue")]
	// RVA: 0x2C94300 Offset: 0x2C92D00 VA: 0x182C94300
	internal int get_rawRenderQueue() { }

	// RVA: 0x2C92480 Offset: 0x2C90E80 VA: 0x182C92480
	public void EnableKeyword(string keyword) { }

	// RVA: 0x2C92430 Offset: 0x2C90E30 VA: 0x182C92430
	public void DisableKeyword(string keyword) { }

	// RVA: 0x2C92DD0 Offset: 0x2C917D0 VA: 0x182C92DD0
	public bool IsKeywordEnabled(string keyword) { }

	[FreeFunction("MaterialScripting::SetEnabledKeywords", HasExplicitThis = True)]
	// RVA: 0x2C930D0 Offset: 0x2C91AD0 VA: 0x182C930D0
	private void SetEnabledKeywords(LocalKeyword[] keywords) { }

	// RVA: 0x2C930D0 Offset: 0x2C91AD0 VA: 0x182C930D0
	public void set_enabledKeywords(LocalKeyword[] value) { }

	// RVA: 0x2C941C0 Offset: 0x2C92BC0 VA: 0x182C941C0
	public bool get_enableInstancing() { }

	// RVA: 0x2C94490 Offset: 0x2C92E90 VA: 0x182C94490
	public void set_enableInstancing(bool value) { }

	[NativeName("GetShader()->GetPassCount")]
	// RVA: 0x2C942C0 Offset: 0x2C92CC0 VA: 0x182C942C0
	public int get_passCount() { }

	[FreeFunction("MaterialScripting::SetShaderPassEnabled", HasExplicitThis = True)]
	// RVA: 0x2C93A60 Offset: 0x2C92460 VA: 0x182C93A60
	public void SetShaderPassEnabled(string passName, bool enabled) { }

	// RVA: 0x2C924D0 Offset: 0x2C90ED0 VA: 0x182C924D0
	public int FindPass(string passName) { }

	[NativeName("GetTag")]
	// RVA: 0x2C928D0 Offset: 0x2C912D0 VA: 0x182C928D0
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	// RVA: 0x2C92940 Offset: 0x2C91340 VA: 0x182C92940
	public string GetTag(string tag, bool searchFallbacks) { }

	[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = True)]
	// RVA: 0x2C939D0 Offset: 0x2C923D0 VA: 0x182C939D0
	public bool SetPass(int pass) { }

	[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = True)]
	// RVA: 0x2C92300 Offset: 0x2C90D00 VA: 0x182C92300
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = True)]
	// RVA: 0x2C92890 Offset: 0x2C91290 VA: 0x182C92890
	private string[] GetShaderKeywords() { }

	[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = True)]
	// RVA: 0x2C93A10 Offset: 0x2C92410 VA: 0x182C93A10
	private void SetShaderKeywords(string[] names) { }

	// RVA: 0x2C92890 Offset: 0x2C91290 VA: 0x182C92890
	public string[] get_shaderKeywords() { }

	// RVA: 0x2C93A10 Offset: 0x2C92410 VA: 0x182C93A10
	public void set_shaderKeywords(string[] value) { }

	// RVA: 0x2C922C0 Offset: 0x2C90CC0 VA: 0x182C922C0
	public int ComputeCRC() { }

	[NativeName("SetIntFromScript")]
	// RVA: 0x2C93470 Offset: 0x2C91E70 VA: 0x182C93470
	private void SetIntImpl(int name, int value) { }

	[NativeName("SetFloatFromScript")]
	// RVA: 0x2C933A0 Offset: 0x2C91DA0 VA: 0x182C933A0
	private void SetFloatImpl(int name, float value) { }

	[NativeName("SetColorFromScript")]
	// RVA: 0x2C92F40 Offset: 0x2C91940 VA: 0x182C92F40
	private void SetColorImpl(int name, Color value) { }

	[NativeName("SetMatrixFromScript")]
	// RVA: 0x2C93870 Offset: 0x2C92270 VA: 0x182C93870
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeName("SetTextureFromScript")]
	// RVA: 0x2C93AC0 Offset: 0x2C924C0 VA: 0x182C93AC0
	private void SetTextureImpl(int name, Texture value) { }

	[NativeName("SetBufferFromScript")]
	// RVA: 0x2C92E20 Offset: 0x2C91820 VA: 0x182C92E20
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeName("SetConstantBufferFromScript")]
	// RVA: 0x2C93070 Offset: 0x2C91A70 VA: 0x182C93070
	private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[NativeName("GetFloatFromScript")]
	// RVA: 0x2C92720 Offset: 0x2C91120 VA: 0x182C92720
	private float GetFloatImpl(int name) { }

	[NativeName("GetColorFromScript")]
	// RVA: 0x2C92570 Offset: 0x2C90F70 VA: 0x182C92570
	private Color GetColorImpl(int name) { }

	[NativeName("GetTextureFromScript")]
	// RVA: 0x2C929D0 Offset: 0x2C913D0 VA: 0x182C929D0
	private Texture GetTextureImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::SetFloatArray", HasExplicitThis = True)]
	// RVA: 0x2C93120 Offset: 0x2C91B20 VA: 0x182C93120
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[FreeFunction(Name = "MaterialScripting::SetVectorArray", HasExplicitThis = True)]
	// RVA: 0x2C93B90 Offset: 0x2C92590 VA: 0x182C93B90
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	[FreeFunction(Name = "MaterialScripting::SetMatrixArray", HasExplicitThis = True)]
	// RVA: 0x2C935A0 Offset: 0x2C91FA0 VA: 0x182C935A0
	private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[NativeName("GetTextureScaleAndOffsetFromScript")]
	// RVA: 0x2C92AD0 Offset: 0x2C914D0 VA: 0x182C92AD0
	private Vector4 GetTextureScaleAndOffsetImpl(int name) { }

	// RVA: 0x2C93240 Offset: 0x2C91C40 VA: 0x182C93240
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x2C93BF0 Offset: 0x2C925F0 VA: 0x182C93BF0
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x2C93600 Offset: 0x2C92000 VA: 0x182C93600
	private void SetMatrixArray(int name, Matrix4x4[] values, int count) { }

	// RVA: 0x2C934C0 Offset: 0x2C91EC0 VA: 0x182C934C0
	public void SetInt(string name, int value) { }

	// RVA: 0x2C93540 Offset: 0x2C91F40 VA: 0x182C93540
	public void SetInt(int nameID, int value) { }

	// RVA: 0x2C933F0 Offset: 0x2C91DF0 VA: 0x182C933F0
	public void SetFloat(string name, float value) { }

	// RVA: 0x2C933A0 Offset: 0x2C91DA0 VA: 0x182C933A0
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x2C93470 Offset: 0x2C91E70 VA: 0x182C93470
	public void SetInteger(int nameID, int value) { }

	// RVA: 0x2C92FE0 Offset: 0x2C919E0 VA: 0x182C92FE0
	public void SetColor(string name, Color value) { }

	// RVA: 0x2C92F90 Offset: 0x2C91990 VA: 0x182C92F90
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x2C93EA0 Offset: 0x2C928A0 VA: 0x182C93EA0
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x2C93E10 Offset: 0x2C92810 VA: 0x182C93E10
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x2C938C0 Offset: 0x2C922C0 VA: 0x182C938C0
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x2C93960 Offset: 0x2C92360 VA: 0x182C93960
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x2C93B10 Offset: 0x2C92510 VA: 0x182C93B10
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x2C93AC0 Offset: 0x2C924C0 VA: 0x182C93AC0
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x2C92E70 Offset: 0x2C91870 VA: 0x182C92E70
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x2C93070 Offset: 0x2C91A70 VA: 0x182C93070
	public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	// RVA: 0x2C93180 Offset: 0x2C91B80 VA: 0x182C93180
	public void SetFloatArray(int nameID, float[] values) { }

	// RVA: 0x2C93D50 Offset: 0x2C92750 VA: 0x182C93D50
	public void SetVectorArray(int nameID, Vector4[] values) { }

	// RVA: 0x2C93760 Offset: 0x2C92160 VA: 0x182C93760
	public void SetMatrixArray(int nameID, Matrix4x4[] values) { }

	// RVA: 0x2C927D0 Offset: 0x2C911D0 VA: 0x182C927D0
	public int GetInt(string name) { }

	// RVA: 0x2C92840 Offset: 0x2C91240 VA: 0x182C92840
	public int GetInt(int nameID) { }

	// RVA: 0x2C92760 Offset: 0x2C91160 VA: 0x182C92760
	public float GetFloat(string name) { }

	// RVA: 0x2C92720 Offset: 0x2C91120 VA: 0x182C92720
	public float GetFloat(int nameID) { }

	// RVA: 0x2C925D0 Offset: 0x2C90FD0 VA: 0x182C925D0
	public Color GetColor(string name) { }

	// RVA: 0x2C92670 Offset: 0x2C91070 VA: 0x182C92670
	public Color GetColor(int nameID) { }

	// RVA: 0x2C92C10 Offset: 0x2C91610 VA: 0x182C92C10
	public Vector4 GetVector(string name) { }

	// RVA: 0x2C92CB0 Offset: 0x2C916B0 VA: 0x182C92CB0
	public Vector4 GetVector(int nameID) { }

	// RVA: 0x2C92BA0 Offset: 0x2C915A0 VA: 0x182C92BA0
	public Texture GetTexture(string name) { }

	// RVA: 0x2C929D0 Offset: 0x2C913D0 VA: 0x182C929D0
	public Texture GetTexture(int nameID) { }

	// RVA: 0x2C92A10 Offset: 0x2C91410 VA: 0x182C92A10
	public Vector2 GetTextureOffset(int nameID) { }

	// RVA: 0x2C92B30 Offset: 0x2C91530 VA: 0x182C92B30
	public Vector2 GetTextureScale(int nameID) { }

	// RVA: 0x2C92EF0 Offset: 0x2C918F0 VA: 0x182C92EF0
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x2C93820 Offset: 0x2C92220 VA: 0x182C93820
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x2C92520 Offset: 0x2C90F20 VA: 0x182C92520
	private void GetColorImpl_Injected(int name, out Color ret) { }

	// RVA: 0x2C92A80 Offset: 0x2C91480 VA: 0x182C92A80
	private void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret) { }
}
