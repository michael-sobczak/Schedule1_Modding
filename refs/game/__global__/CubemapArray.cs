public sealed class CubemapArray : Texture // TypeDefIndex: 11729
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x2CA4570 Offset: 0x2CA2F70 VA: 0x182CA4570 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunction("CubemapArrayScripting::Create")]
	// RVA: 0x2CA3B80 Offset: 0x2CA2580 VA: 0x182CA3B80
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x2CA3BE0 Offset: 0x2CA25E0 VA: 0x182CA3BE0
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	[FreeFunction(Name = "CubemapArrayScripting::Apply", HasExplicitThis = True)]
	// RVA: 0x2CA3A00 Offset: 0x2CA2400 VA: 0x182CA3A00
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction(Name = "CubemapArrayScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CA3CB0 Offset: 0x2CA26B0 VA: 0x182CA3CB0
	public void SetPixels(Color[] colors, CubemapFace face, int arrayElement, int miplevel) { }

	// RVA: 0x2CA3D20 Offset: 0x2CA2720 VA: 0x182CA3D20
	public void SetPixels(Color[] colors, CubemapFace face, int arrayElement) { }

	[ExcludeFromDocs]
	// RVA: 0x2CA3FC0 Offset: 0x2CA29C0 VA: 0x182CA3FC0
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2CA43D0 Offset: 0x2CA2DD0 VA: 0x182CA43D0
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	// RVA: 0x2CA4420 Offset: 0x2CA2E20 VA: 0x182CA4420
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2CA3DF0 Offset: 0x2CA27F0 VA: 0x182CA3DF0
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2CA4070 Offset: 0x2CA2A70 VA: 0x182CA4070
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x2CA3F90 Offset: 0x2CA2990 VA: 0x182CA3F90
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x2CA4250 Offset: 0x2CA2C50 VA: 0x182CA4250
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	[ExcludeFromDocs]
	// RVA: 0x2CA4310 Offset: 0x2CA2D10 VA: 0x182CA4310
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x2CA44C0 Offset: 0x2CA2EC0 VA: 0x182CA44C0
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2CA3A60 Offset: 0x2CA2460 VA: 0x182CA3A60
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	// RVA: 0x2CA3B00 Offset: 0x2CA2500 VA: 0x182CA3B00
	public void Apply() { }

	// RVA: 0x2CA3D90 Offset: 0x2CA2790 VA: 0x182CA3D90
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }
}
