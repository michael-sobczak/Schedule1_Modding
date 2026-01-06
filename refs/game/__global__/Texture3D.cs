public sealed class Texture3D : Texture // TypeDefIndex: 11727
{
	// Properties
	public int depth { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeName("GetTextureLayerCount")]
	// RVA: 0x2CB5460 Offset: 0x2CB3E60 VA: 0x182CB5460
	public int get_depth() { }

	// RVA: 0x2CB54A0 Offset: 0x2CB3EA0 VA: 0x182CB54A0 Slot: 11
	public override bool get_isReadable() { }

	[NativeName("SetPixel")]
	// RVA: 0x2CB4910 Offset: 0x2CB3310 VA: 0x182CB4910
	private void SetPixelImpl(int mip, int x, int y, int z, Color color) { }

	[FreeFunction("Texture3DScripting::Create")]
	// RVA: 0x2CB46F0 Offset: 0x2CB30F0 VA: 0x182CB46F0
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x2CB4750 Offset: 0x2CB3150 VA: 0x182CB4750
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction(Name = "Texture3DScripting::Apply", HasExplicitThis = True)]
	// RVA: 0x2CB4550 Offset: 0x2CB2F50 VA: 0x182CB4550
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction(Name = "Texture3DScripting::GetPixels32", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CB46B0 Offset: 0x2CB30B0 VA: 0x182CB46B0
	public Color32[] GetPixels32(int miplevel) { }

	// RVA: 0x2CB4670 Offset: 0x2CB3070 VA: 0x182CB4670
	public Color32[] GetPixels32() { }

	[FreeFunction(Name = "Texture3DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CB4B00 Offset: 0x2CB3500 VA: 0x182CB4B00
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x2CB4B60 Offset: 0x2CB3560 VA: 0x182CB4B60
	public void SetPixels(Color[] colors) { }

	[FreeFunction(Name = "Texture3DScripting::SetPixels32", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CB4AA0 Offset: 0x2CB34A0 VA: 0x182CB4AA0
	public void SetPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x2CB4A50 Offset: 0x2CB3450 VA: 0x182CB4A50
	public void SetPixels32(Color32[] colors) { }

	[FreeFunction(Name = "Texture3DScripting::SetPixelData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CB4840 Offset: 0x2CB3240 VA: 0x182CB4840
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB5250 Offset: 0x2CB3C50 VA: 0x182CB5250
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB4CD0 Offset: 0x2CB36D0 VA: 0x182CB4CD0
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x2CB51A0 Offset: 0x2CB3BA0 VA: 0x182CB51A0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB4D30 Offset: 0x2CB3730 VA: 0x182CB4D30
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB5420 Offset: 0x2CB3E20 VA: 0x182CB5420
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x2CB53E0 Offset: 0x2CB3DE0 VA: 0x182CB53E0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x2CB4FA0 Offset: 0x2CB39A0 VA: 0x182CB4FA0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB4C10 Offset: 0x2CB3610 VA: 0x182CB4C10
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2CB4EE0 Offset: 0x2CB38E0 VA: 0x182CB4EE0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x2CB5310 Offset: 0x2CB3D10 VA: 0x182CB5310
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x2CB45D0 Offset: 0x2CB2FD0 VA: 0x182CB45D0
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB45C0 Offset: 0x2CB2FC0 VA: 0x182CB45C0
	public void Apply(bool updateMipmaps) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB45B0 Offset: 0x2CB2FB0 VA: 0x182CB45B0
	public void Apply() { }

	// RVA: 0x2CB4990 Offset: 0x2CB3390 VA: 0x182CB4990
	public void SetPixel(int x, int y, int z, Color color, int mipLevel) { }

	// RVA: -1 Offset: -1
	public void SetPixelData<T>(NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF60470 Offset: 0xF5EE70 VA: 0x180F60470
	|-Texture3D.SetPixelData<byte>
	|
	|-RVA: 0xF607E0 Offset: 0xF5F1E0 VA: 0x180F607E0
	|-Texture3D.SetPixelData<ushort>
	|
	|-RVA: 0xF60600 Offset: 0xF5F000 VA: 0x180F60600
	|-Texture3D.SetPixelData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2CB4BB0 Offset: 0x2CB35B0 VA: 0x182CB4BB0
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x2CB48B0 Offset: 0x2CB32B0 VA: 0x182CB48B0
	private void SetPixelImpl_Injected(int mip, int x, int y, int z, ref Color color) { }
}
