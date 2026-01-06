public class Texture2DAtlas // TypeDefIndex: 13827
{
	// Fields
	internal const int kGPUTexInvalid = 0;
	internal const int kGPUTexValidMip0 = 1;
	internal const int kGPUTexValidMipAll = 2;
	internal RTHandle m_AtlasTexture; // 0x10
	internal int m_Width; // 0x18
	internal int m_Height; // 0x1C
	internal GraphicsFormat m_Format; // 0x20
	internal bool m_UseMipMaps; // 0x24
	private bool m_IsAtlasTextureOwner; // 0x25
	private AtlasAllocator m_AtlasAllocator; // 0x28
	[TupleElementNames(new[] { "scaleOffset", "size" })]
	private Dictionary<int, ValueTuple<Vector4, Vector2Int>> m_AllocationCache; // 0x30
	private Dictionary<int, int> m_IsGPUTextureUpToDate; // 0x38
	private Dictionary<int, int> m_TextureHashes; // 0x40
	private static readonly Vector4 fullScaleOffset; // 0x0
	private static readonly int s_MaxMipLevelPadding; // 0x10

	// Properties
	public static int maxMipLevelPadding { get; }
	public RTHandle AtlasTexture { get; }

	// Methods

	// RVA: 0x2A44FB0 Offset: 0x2A439B0 VA: 0x182A44FB0
	public static int get_maxMipLevelPadding() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public RTHandle get_AtlasTexture() { }

	// RVA: 0x2A44CD0 Offset: 0x2A436D0 VA: 0x182A44CD0
	public void .ctor(int width, int height, GraphicsFormat format, FilterMode filterMode = 0, bool powerOfTwoPadding = False, string name = "", bool useMipMap = True) { }

	// RVA: 0x2A447E0 Offset: 0x2A431E0 VA: 0x182A447E0
	public void Release() { }

	// RVA: 0x2A448F0 Offset: 0x2A432F0 VA: 0x182A448F0
	public void ResetAllocator() { }

	// RVA: 0x2A435D0 Offset: 0x2A41FD0 VA: 0x182A435D0
	public void ClearTarget(CommandBuffer cmd) { }

	// RVA: 0x2A43AF0 Offset: 0x2A424F0 VA: 0x182A43AF0
	internal int GetTextureMipmapCount(int width, int height) { }

	// RVA: 0x2A43BC0 Offset: 0x2A425C0 VA: 0x182A43BC0
	internal bool Is2D(Texture texture) { }

	// RVA: 0x2A43DB0 Offset: 0x2A427B0 VA: 0x182A43DB0
	internal bool IsSingleChannelBlit(Texture source, Texture destination) { }

	// RVA: 0x2A42F90 Offset: 0x2A41990 VA: 0x182A42F90
	private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, Texture2DAtlas.BlitType blitType) { }

	// RVA: 0x2A440A0 Offset: 0x2A42AA0 VA: 0x182A440A0
	internal void MarkGPUTextureValid(int instanceId, bool mipAreValid = False) { }

	// RVA: 0x2A44040 Offset: 0x2A42A40 VA: 0x182A44040
	internal void MarkGPUTextureInvalid(int instanceId) { }

	// RVA: 0x2A43440 Offset: 0x2A41E40 VA: 0x182A43440 Slot: 4
	public virtual void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1) { }

	// RVA: 0x2A433D0 Offset: 0x2A41DD0 VA: 0x182A433D0 Slot: 5
	public virtual void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1) { }

	// RVA: 0x2A43230 Offset: 0x2A41C30 VA: 0x182A43230 Slot: 6
	public virtual void BlitCubeTexture2D(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, bool blitMips = True, int overrideInstanceID = -1) { }

	// RVA: 0x2A42D60 Offset: 0x2A41760 VA: 0x182A42D60 Slot: 7
	public virtual bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1) { }

	// RVA: 0x2A42CF0 Offset: 0x2A416F0 VA: 0x182A42CF0
	public bool AllocateTextureWithoutBlit(Texture texture, int width, int height, ref Vector4 scaleOffset) { }

	// RVA: 0x2A42AD0 Offset: 0x2A414D0 VA: 0x182A42AD0 Slot: 8
	public virtual bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref Vector4 scaleOffset) { }

	// RVA: 0x2A43A10 Offset: 0x2A42410 VA: 0x182A43A10
	internal int GetTextureHash(Texture textureA, Texture textureB) { }

	// RVA: 0x2A43AD0 Offset: 0x2A424D0 VA: 0x182A43AD0
	public int GetTextureID(Texture texture) { }

	// RVA: 0x2A43A80 Offset: 0x2A42480 VA: 0x182A43A80
	public int GetTextureID(Texture textureA, Texture textureB) { }

	// RVA: 0x2A43C80 Offset: 0x2A42680 VA: 0x182A43C80
	public bool IsCached(out Vector4 scaleOffset, Texture textureA, Texture textureB) { }

	// RVA: 0x2A43D70 Offset: 0x2A42770 VA: 0x182A43D70
	public bool IsCached(out Vector4 scaleOffset, Texture texture) { }

	// RVA: 0x2A43CF0 Offset: 0x2A426F0 VA: 0x182A43CF0
	public bool IsCached(out Vector4 scaleOffset, int id) { }

	// RVA: 0x2A439A0 Offset: 0x2A423A0 VA: 0x182A439A0
	internal Vector2Int GetCachedTextureSize(int id) { }

	// RVA: 0x2A44590 Offset: 0x2A42F90 VA: 0x182A44590 Slot: 9
	public virtual bool NeedsUpdate(Texture texture, bool needMips = False) { }

	// RVA: 0x2A44110 Offset: 0x2A42B10 VA: 0x182A44110 Slot: 10
	public virtual bool NeedsUpdate(Texture textureA, Texture textureB, bool needMips = False) { }

	// RVA: 0x2A429F0 Offset: 0x2A413F0 VA: 0x182A429F0 Slot: 11
	public virtual bool AddTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture) { }

	// RVA: 0x2A449B0 Offset: 0x2A433B0 VA: 0x182A449B0 Slot: 12
	public virtual bool UpdateTexture(CommandBuffer cmd, Texture oldTexture, Texture newTexture, ref Vector4 scaleOffset, Vector4 sourceScaleOffset, bool updateIfNeeded = True, bool blitMips = True) { }

	// RVA: 0x2A44BA0 Offset: 0x2A435A0 VA: 0x182A44BA0 Slot: 13
	public virtual bool UpdateTexture(CommandBuffer cmd, Texture texture, ref Vector4 scaleOffset, bool updateIfNeeded = True, bool blitMips = True) { }

	// RVA: 0x2A437A0 Offset: 0x2A421A0 VA: 0x182A437A0
	internal bool EnsureTextureSlot(out bool isUploadNeeded, ref Vector4 scaleBias, int key, int width, int height) { }

	// RVA: 0x2A44C70 Offset: 0x2A43670 VA: 0x182A44C70
	private static void .cctor() { }
}
