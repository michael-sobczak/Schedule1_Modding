public sealed class Texture2D : Texture // TypeDefIndex: 11725
{
	// Fields
	internal const int streamingMipmapsPriorityMin = -128;
	internal const int streamingMipmapsPriorityMax = 127;

	// Properties
	public TextureFormat format { get; }
	[StaticAccessor("builtintex", 2)]
	public static Texture2D whiteTexture { get; }
	[StaticAccessor("builtintex", 2)]
	public static Texture2D blackTexture { get; }
	[StaticAccessor("builtintex", 2)]
	public static Texture2D normalTexture { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeName("GetTextureFormat")]
	// RVA: 0x2CB4470 Offset: 0x2CB2E70 VA: 0x182CB4470
	public TextureFormat get_format() { }

	// RVA: 0x2CB4520 Offset: 0x2CB2F20 VA: 0x182CB4520
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x2CB4440 Offset: 0x2CB2E40 VA: 0x182CB4440
	public static Texture2D get_blackTexture() { }

	// RVA: 0x2CB44F0 Offset: 0x2CB2EF0 VA: 0x182CB44F0
	public static Texture2D get_normalTexture() { }

	[FreeFunction("Texture2DScripting::Create")]
	// RVA: 0x2CB2D40 Offset: 0x2CB1740 VA: 0x182CB2D40
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x2CB2DA0 Offset: 0x2CB17A0 VA: 0x182CB2DA0
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x2CB44B0 Offset: 0x2CB2EB0 VA: 0x182CB44B0 Slot: 11
	public override bool get_isReadable() { }

	[NativeName("Apply")]
	// RVA: 0x2CB2550 Offset: 0x2CB0F50 VA: 0x182CB2550
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeName("Reinitialize")]
	// RVA: 0x2CB32D0 Offset: 0x2CB1CD0 VA: 0x182CB32D0
	private bool ReinitializeImpl(int width, int height) { }

	[NativeName("SetPixel")]
	// RVA: 0x2CB35C0 Offset: 0x2CB1FC0 VA: 0x182CB35C0
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	[NativeName("GetPixel")]
	// RVA: 0x2CB2880 Offset: 0x2CB1280 VA: 0x182CB2880
	private Color GetPixelImpl(int image, int mip, int x, int y) { }

	[NativeName("GetPixelBilinear")]
	// RVA: 0x2CB26D0 Offset: 0x2CB10D0 VA: 0x182CB26D0
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v) { }

	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithTextureFormat", HasExplicitThis = True)]
	// RVA: 0x2CB3320 Offset: 0x2CB1D20 VA: 0x182CB3320
	private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	[FreeFunction(Name = "Texture2DScripting::ReadPixels", HasExplicitThis = True)]
	// RVA: 0x2CB30E0 Offset: 0x2CB1AE0 VA: 0x182CB30E0
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CB3750 Offset: 0x2CB2150 VA: 0x182CB3750
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = True)]
	// RVA: 0x2CB2EE0 Offset: 0x2CB18E0 VA: 0x182CB2EE0
	private bool LoadRawTextureDataImpl(IntPtr data, ulong size) { }

	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = True)]
	// RVA: 0x2CB2E90 Offset: 0x2CB1890 VA: 0x182CB2E90
	private bool LoadRawTextureDataImplArray(byte[] data) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixelData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CB34F0 Offset: 0x2CB1EF0 VA: 0x182CB34F0
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	// RVA: 0x2CB2D00 Offset: 0x2CB1700 VA: 0x182CB2D00
	private IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x2CB2C80 Offset: 0x2CB1680 VA: 0x182CB2C80
	private ulong GetRawImageDataSize() { }

	[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CB3490 Offset: 0x2CB1E90 VA: 0x182CB3490
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunction("Texture2DScripting::GetRawTextureData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CB2CC0 Offset: 0x2CB16C0 VA: 0x182CB2CC0
	public byte[] GetRawTextureData() { }

	[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CB2C20 Offset: 0x2CB1620 VA: 0x182CB2C20
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB2A50 Offset: 0x2CB1450 VA: 0x182CB2A50
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) { }

	[FreeFunction("Texture2DScripting::GetPixels32", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CB29D0 Offset: 0x2CB13D0 VA: 0x182CB29D0
	public Color32[] GetPixels32(int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB2A10 Offset: 0x2CB1410 VA: 0x182CB2A10
	public Color32[] GetPixels32() { }

	// RVA: 0x2CB3A60 Offset: 0x2CB2460 VA: 0x182CB3A60
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x2CB3910 Offset: 0x2CB2310 VA: 0x182CB3910
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	// RVA: 0x2CB3CC0 Offset: 0x2CB26C0 VA: 0x182CB3CC0
	internal void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex, string mipmapLimitGroupName) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB3F60 Offset: 0x2CB2960 VA: 0x182CB3F60
	public void .ctor(int width, int height, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB3B70 Offset: 0x2CB2570 VA: 0x182CB3B70
	public void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2CB40F0 Offset: 0x2CB2AF0 VA: 0x182CB40F0
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x2CB3F20 Offset: 0x2CB2920 VA: 0x182CB3F20
	public void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x2CB4020 Offset: 0x2CB2A20 VA: 0x182CB4020
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB4380 Offset: 0x2CB2D80 VA: 0x182CB4380
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB3C20 Offset: 0x2CB2620 VA: 0x182CB3C20
	public void .ctor(int width, int height) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB3640 Offset: 0x2CB2040 VA: 0x182CB3640
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x2CB37B0 Offset: 0x2CB21B0 VA: 0x182CB37B0
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB38E0 Offset: 0x2CB22E0 VA: 0x182CB38E0
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB3860 Offset: 0x2CB2260 VA: 0x182CB3860
	public void SetPixels(Color[] colors) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB2900 Offset: 0x2CB1300 VA: 0x182CB2900
	public Color GetPixel(int x, int y) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB2750 Offset: 0x2CB1150 VA: 0x182CB2750
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x2CB2F40 Offset: 0x2CB1940 VA: 0x182CB2F40
	public void LoadRawTextureData(byte[] data) { }

	// RVA: -1 Offset: -1
	public void LoadRawTextureData<T>(NativeArray<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5FE00 Offset: 0xF5E800 VA: 0x180F5FE00
	|-Texture2D.LoadRawTextureData<byte>
	|
	|-RVA: 0xF5FF50 Offset: 0xF5E950 VA: 0x180F5FF50
	|-Texture2D.LoadRawTextureData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void SetPixelData<T>(NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF602E0 Offset: 0xF5ECE0 VA: 0x180F602E0
	|-Texture2D.SetPixelData<float>
	|
	|-RVA: 0xF60100 Offset: 0xF5EB00 VA: 0x180F60100
	|-Texture2D.SetPixelData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> GetPixelData<T>(int mipLevel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5F520 Offset: 0xF5DF20 VA: 0x180F5F520
	|-Texture2D.GetPixelData<float>
	|
	|-RVA: 0xF5F7E0 Offset: 0xF5E1E0 VA: 0x180F5F7E0
	|-Texture2D.GetPixelData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> GetRawTextureData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5FBC0 Offset: 0xF5E5C0 VA: 0x180F5FBC0
	|-Texture2D.GetRawTextureData<Color>
	|
	|-RVA: 0xF5FAB0 Offset: 0xF5E4B0 VA: 0x180F5FAB0
	|-Texture2D.GetRawTextureData<Color32>
	|
	|-RVA: 0xF5FCD0 Offset: 0xF5E6D0 VA: 0x180F5FCD0
	|-Texture2D.GetRawTextureData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2CB25B0 Offset: 0x2CB0FB0 VA: 0x182CB25B0
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB2660 Offset: 0x2CB1060 VA: 0x182CB2660
	public void Apply(bool updateMipmaps) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB2650 Offset: 0x2CB1050 VA: 0x182CB2650
	public void Apply() { }

	// RVA: 0x2CB3390 Offset: 0x2CB1D90 VA: 0x182CB3390
	public bool Reinitialize(int width, int height) { }

	// RVA: 0x2CB3420 Offset: 0x2CB1E20 VA: 0x182CB3420
	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x2CB3210 Offset: 0x2CB1C10 VA: 0x182CB3210
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB3150 Offset: 0x2CB1B50 VA: 0x182CB3150
	public void ReadPixels(Rect source, int destX, int destY) { }

	// RVA: 0x2CB3490 Offset: 0x2CB1E90 VA: 0x182CB3490
	public void SetPixels32(Color32[] colors, int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB3700 Offset: 0x2CB2100 VA: 0x182CB3700
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x2CB2AC0 Offset: 0x2CB14C0 VA: 0x182CB2AC0
	public Color[] GetPixels(int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB2B80 Offset: 0x2CB1580 VA: 0x182CB2B80
	public Color[] GetPixels() { }

	// RVA: 0x2CB3560 Offset: 0x2CB1F60 VA: 0x182CB3560
	private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color) { }

	// RVA: 0x2CB2820 Offset: 0x2CB1220 VA: 0x182CB2820
	private void GetPixelImpl_Injected(int image, int mip, int x, int y, out Color ret) { }

	// RVA: 0x2CB2670 Offset: 0x2CB1070 VA: 0x182CB2670
	private void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, out Color ret) { }

	// RVA: 0x2CB3070 Offset: 0x2CB1A70 VA: 0x182CB3070
	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }
}
