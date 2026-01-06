internal struct ConvertMeshJobData // TypeDefIndex: 7101
{
	// Fields
	public IntPtr vertSrc; // 0x0
	public IntPtr vertDst; // 0x8
	public int vertCount; // 0x10
	public Matrix4x4 transform; // 0x14
	public int transformUVs; // 0x54
	public Color32 xformClipPages; // 0x58
	public Color32 ids; // 0x5C
	public Color32 addFlags; // 0x60
	public Color32 opacityPage; // 0x64
	public Color32 textCoreSettingsPage; // 0x68
	public int isText; // 0x6C
	public float textureId; // 0x70
	public IntPtr indexSrc; // 0x78
	public IntPtr indexDst; // 0x80
	public int indexCount; // 0x88
	public int indexOffset; // 0x8C
	public int flipIndices; // 0x90
}
