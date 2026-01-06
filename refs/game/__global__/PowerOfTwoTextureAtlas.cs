public class PowerOfTwoTextureAtlas : Texture2DAtlas // TypeDefIndex: 13815
{
	// Fields
	private readonly int m_MipPadding; // 0x48
	private const float k_MipmapFactorApprox = 1.33;
	private Dictionary<int, Vector2Int> m_RequestedTextures; // 0x50

	// Properties
	public int mipPadding { get; }

	// Methods

	// RVA: 0x2A20E50 Offset: 0x2A1F850 VA: 0x182A20E50
	public void .ctor(int size, int mipPadding, GraphicsFormat format, FilterMode filterMode = 0, string name = "", bool useMipMap = True) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public int get_mipPadding() { }

	// RVA: 0x2A20650 Offset: 0x2A1F050 VA: 0x182A20650
	private int GetTexturePadding() { }

	// RVA: 0x2A20410 Offset: 0x2A1EE10 VA: 0x182A20410
	public Vector4 GetPayloadScaleOffset(Texture texture, in Vector4 scaleOffset) { }

	// RVA: 0x2A20330 Offset: 0x2A1ED30 VA: 0x182A20330
	public static Vector4 GetPayloadScaleOffset(in Vector2 textureSize, in Vector2 paddingSize, in Vector4 scaleOffset) { }

	// RVA: 0x2A1F990 Offset: 0x2A1E390 VA: 0x182A1F990
	private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, PowerOfTwoTextureAtlas.BlitType blitType) { }

	// RVA: 0x2A200A0 Offset: 0x2A1EAA0 VA: 0x182A200A0 Slot: 4
	public override void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1) { }

	// RVA: 0x2A1FFC0 Offset: 0x2A1E9C0 VA: 0x182A1FFC0
	public void BlitTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1) { }

	// RVA: 0x2A1FEE0 Offset: 0x2A1E8E0 VA: 0x182A1FEE0 Slot: 5
	public override void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1) { }

	// RVA: 0x2A1FE00 Offset: 0x2A1E800 VA: 0x182A1FE00
	public void BlitOctahedralTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1) { }

	// RVA: 0x2A20E10 Offset: 0x2A1F810 VA: 0x182A20E10
	private void TextureSizeToPowerOfTwo(Texture texture, ref int width, ref int height) { }

	// RVA: 0x2A205D0 Offset: 0x2A1EFD0 VA: 0x182A205D0
	private Vector2 GetPowerOfTwoTextureSize(Texture texture) { }

	// RVA: 0x2A1F7B0 Offset: 0x2A1E1B0 VA: 0x182A1F7B0 Slot: 7
	public override bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1) { }

	// RVA: 0x2A20DC0 Offset: 0x2A1F7C0 VA: 0x182A20DC0
	public void ResetRequestedTexture() { }

	// RVA: 0x2A20B60 Offset: 0x2A1F560 VA: 0x182A20B60
	public bool ReserveSpace(Texture texture) { }

	// RVA: 0x2A20D70 Offset: 0x2A1F770 VA: 0x182A20D70
	public bool ReserveSpace(Texture texture, int width, int height) { }

	// RVA: 0x2A20D30 Offset: 0x2A1F730 VA: 0x182A20D30
	public bool ReserveSpace(Texture textureA, Texture textureB, int width, int height) { }

	// RVA: 0x2A20C00 Offset: 0x2A1F600 VA: 0x182A20C00
	private bool ReserveSpace(int id, int width, int height) { }

	// RVA: 0x2A20680 Offset: 0x2A1F080 VA: 0x182A20680
	public bool RelayoutEntries() { }

	// RVA: 0x2A20170 Offset: 0x2A1EB70 VA: 0x182A20170
	public static long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, GraphicsFormat format) { }

	// RVA: 0x2A20240 Offset: 0x2A1EC40 VA: 0x182A20240
	public static int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, GraphicsFormat format) { }
}
