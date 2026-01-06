internal class ShaderInfoStorage<T> : BaseShaderInfoStorage // TypeDefIndex: 7126
{
	// Fields
	private readonly int m_InitialSize; // 0x0
	private readonly int m_MaxSize; // 0x0
	private readonly TextureFormat m_Format; // 0x0
	private readonly Func<Color, T> m_Convert; // 0x0
	private UIRAtlasAllocator m_Allocator; // 0x0
	private Texture2D m_Texture; // 0x0
	private NativeArray<T> m_Texels; // 0x0

	// Properties
	public override Texture2D texture { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TextureFormat format, Func<Color, T> convert, int initialSize = 64, int maxSize = 4096) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C04F0 Offset: 0x11BEEF0 VA: 0x1811C04F0
	|-ShaderInfoStorage<Color>..ctor
	|
	|-RVA: 0x11C0600 Offset: 0x11BF000 VA: 0x1811C0600
	|-ShaderInfoStorage<Color32>..ctor
	|
	|-RVA: 0x11C0710 Offset: 0x11BF110 VA: 0x1811C0710
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BFE20 Offset: 0x11BE820 VA: 0x1811BFE20
	|-ShaderInfoStorage<Color>.Dispose
	|
	|-RVA: 0x11BFD50 Offset: 0x11BE750 VA: 0x1811BFD50
	|-ShaderInfoStorage<Color32>.Dispose
	|
	|-RVA: 0x11BFC80 Offset: 0x11BE680 VA: 0x1811BFC80
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override Texture2D get_texture() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	|-ShaderInfoStorage<Color>.get_texture
	|-ShaderInfoStorage<Color32>.get_texture
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.get_texture
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool AllocateRect(int width, int height, out RectInt uvs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BE8A0 Offset: 0x11BD2A0 VA: 0x1811BE8A0
	|-ShaderInfoStorage<Color>.AllocateRect
	|
	|-RVA: 0x11BEA00 Offset: 0x11BD400 VA: 0x1811BEA00
	|-ShaderInfoStorage<Color32>.AllocateRect
	|
	|-RVA: 0x11BEB60 Offset: 0x11BD560 VA: 0x1811BEB60
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.AllocateRect
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void SetTexel(int x, int y, Color color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C00B0 Offset: 0x11BEAB0 VA: 0x1811C00B0
	|-ShaderInfoStorage<Color>.SetTexel
	|
	|-RVA: 0x11C01B0 Offset: 0x11BEBB0 VA: 0x1811C01B0
	|-ShaderInfoStorage<Color32>.SetTexel
	|
	|-RVA: 0x11BFEF0 Offset: 0x11BE8F0 VA: 0x1811BFEF0
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.SetTexel
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void UpdateTexture() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C02B0 Offset: 0x11BECB0 VA: 0x1811C02B0
	|-ShaderInfoStorage<Color>.UpdateTexture
	|
	|-RVA: 0x11C0360 Offset: 0x11BED60 VA: 0x1811C0360
	|-ShaderInfoStorage<Color32>.UpdateTexture
	|
	|-RVA: 0x11C0410 Offset: 0x11BEE10 VA: 0x1811C0410
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.UpdateTexture
	*/

	// RVA: -1 Offset: -1
	private void CreateOrExpandTexture() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BF4D0 Offset: 0x11BDED0 VA: 0x1811BF4D0
	|-ShaderInfoStorage<Color>.CreateOrExpandTexture
	|
	|-RVA: 0x11BF0F0 Offset: 0x11BDAF0 VA: 0x1811BF0F0
	|-ShaderInfoStorage<Color32>.CreateOrExpandTexture
	|
	|-RVA: 0x11BF8D0 Offset: 0x11BE2D0 VA: 0x1811BF8D0
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.CreateOrExpandTexture
	*/

	// RVA: -1 Offset: -1
	private static void CpuBlit(NativeArray<T> src, int srcWidth, int srcHeight, NativeArray<T> dst, int dstWidth, int dstHeight) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BEFE0 Offset: 0x11BD9E0 VA: 0x1811BEFE0
	|-ShaderInfoStorage<Color>.CpuBlit
	|
	|-RVA: 0x11BEEE0 Offset: 0x11BD8E0 VA: 0x1811BEEE0
	|-ShaderInfoStorage<Color32>.CpuBlit
	|
	|-RVA: 0x11BECC0 Offset: 0x11BD6C0 VA: 0x1811BECC0
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.CpuBlit
	*/
}
