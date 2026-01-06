public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier> // TypeDefIndex: 12184
{
	// Fields
	public const int AllDepthSlices = -1;
	private BuiltinRenderTextureType m_Type; // 0x0
	private int m_NameID; // 0x4
	private int m_InstanceID; // 0x8
	private IntPtr m_BufferPointer; // 0x10
	private int m_MipLevel; // 0x18
	private CubemapFace m_CubeFace; // 0x1C
	private int m_DepthSlice; // 0x20

	// Methods

	// RVA: 0x2CE71C0 Offset: 0x2CE5BC0 VA: 0x182CE71C0
	public void .ctor(BuiltinRenderTextureType type) { }

	// RVA: 0x2CE6FC0 Offset: 0x2CE59C0 VA: 0x182CE6FC0
	public void .ctor(string name) { }

	// RVA: 0x2CE72F0 Offset: 0x2CE5CF0 VA: 0x182CE72F0
	public void .ctor(string name, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x2CE6FA0 Offset: 0x2CE59A0 VA: 0x182CE6FA0
	public void .ctor(int nameID) { }

	// RVA: 0x2CE7190 Offset: 0x2CE5B90 VA: 0x182CE7190
	public void .ctor(int nameID, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x2CE7160 Offset: 0x2CE5B60 VA: 0x182CE7160
	public void .ctor(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x2CE71E0 Offset: 0x2CE5BE0 VA: 0x182CE71E0
	public void .ctor(Texture tex) { }

	// RVA: 0x2CE7000 Offset: 0x2CE5A00 VA: 0x182CE7000
	public void .ctor(Texture tex, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x2CE7130 Offset: 0x2CE5B30 VA: 0x182CE7130
	public void .ctor(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x2CE7350 Offset: 0x2CE5D50 VA: 0x182CE7350
	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	// RVA: 0x2CE7540 Offset: 0x2CE5F40 VA: 0x182CE7540
	public static RenderTargetIdentifier op_Implicit(string name) { }

	// RVA: 0x2CE73A0 Offset: 0x2CE5DA0 VA: 0x182CE73A0
	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	// RVA: 0x2CE73F0 Offset: 0x2CE5DF0 VA: 0x182CE73F0
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	// RVA: 0x2CE75C0 Offset: 0x2CE5FC0 VA: 0x182CE75C0
	public static RenderTargetIdentifier op_Implicit(RenderBuffer buf) { }

	// RVA: 0x2CE6C40 Offset: 0x2CE5640 VA: 0x182CE6C40 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CE6BF0 Offset: 0x2CE55F0 VA: 0x182CE6BF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CE6B40 Offset: 0x2CE5540 VA: 0x182CE6B40 Slot: 4
	public bool Equals(RenderTargetIdentifier rhs) { }

	// RVA: 0x2CE6A90 Offset: 0x2CE5490 VA: 0x182CE6A90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CE6B40 Offset: 0x2CE5540 VA: 0x182CE6B40
	public static bool op_Equality(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs) { }

	// RVA: 0x2CE7620 Offset: 0x2CE6020 VA: 0x182CE7620
	public static bool op_Inequality(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs) { }
}
