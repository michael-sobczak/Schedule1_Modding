public sealed class Cubemap : Texture // TypeDefIndex: 11726
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	[FreeFunction("CubemapScripting::Create")]
	// RVA: 0x2CA4730 Offset: 0x2CA3130 VA: 0x182CA4730
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x2CA4790 Offset: 0x2CA3190 VA: 0x182CA4790
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction(Name = "CubemapScripting::Apply", HasExplicitThis = True)]
	// RVA: 0x2CA45B0 Offset: 0x2CA2FB0 VA: 0x182CA45B0
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x2CA55C0 Offset: 0x2CA3FC0 VA: 0x182CA55C0 Slot: 11
	public override bool get_isReadable() { }

	[NativeName("SetPixel")]
	// RVA: 0x2CA48C0 Offset: 0x2CA32C0 VA: 0x182CA48C0
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	// RVA: 0x2CA4AC0 Offset: 0x2CA34C0 VA: 0x182CA4AC0
	internal bool ValidateFormat(TextureFormat format, int width) { }

	// RVA: 0x2CA4BC0 Offset: 0x2CA35C0 VA: 0x182CA4BC0
	internal bool ValidateFormat(GraphicsFormat format, int width) { }

	[ExcludeFromDocs]
	// RVA: 0x2CA4E10 Offset: 0x2CA3810 VA: 0x182CA4E10
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2CA4EB0 Offset: 0x2CA38B0 VA: 0x182CA4EB0
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x2CA4F00 Offset: 0x2CA3900 VA: 0x182CA4F00
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2CA4FA0 Offset: 0x2CA39A0 VA: 0x182CA4FA0
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2CA5320 Offset: 0x2CA3D20 VA: 0x182CA5320
	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	// RVA: 0x2CA5240 Offset: 0x2CA3C40 VA: 0x182CA5240
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2CA4D60 Offset: 0x2CA3760 VA: 0x182CA4D60
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x2CA5220 Offset: 0x2CA3C20 VA: 0x182CA5220
	public void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x2CA52F0 Offset: 0x2CA3CF0 VA: 0x182CA52F0
	public void .ctor(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	[ExcludeFromDocs]
	// RVA: 0x2CA4940 Offset: 0x2CA3340 VA: 0x182CA4940
	public void SetPixel(CubemapFace face, int x, int y, Color color) { }

	// RVA: 0x2CA4A00 Offset: 0x2CA3400 VA: 0x182CA4A00
	public void SetPixel(CubemapFace face, int x, int y, Color color, int mip) { }

	// RVA: 0x2CA4690 Offset: 0x2CA3090 VA: 0x182CA4690
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	// RVA: 0x2CA4610 Offset: 0x2CA3010 VA: 0x182CA4610
	public void Apply() { }

	// RVA: 0x2CA4D00 Offset: 0x2CA3700 VA: 0x182CA4D00
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x2CA4860 Offset: 0x2CA3260 VA: 0x182CA4860
	private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color) { }
}
