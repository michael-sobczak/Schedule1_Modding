public sealed class Texture2DArray : Texture // TypeDefIndex: 11728
{
	// Properties
	public static int allSlices { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeName("GetAllTextureLayersIdentifier")]
	// RVA: 0x2CB24E0 Offset: 0x2CB0EE0 VA: 0x182CB24E0
	public static int get_allSlices() { }

	// RVA: 0x2CB2510 Offset: 0x2CB0F10 VA: 0x182CB2510 Slot: 11
	public override bool get_isReadable() { }

	[FreeFunction("Texture2DArrayScripting::Create")]
	// RVA: 0x2CB15C0 Offset: 0x2CAFFC0 VA: 0x182CB15C0
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x2CB1620 Offset: 0x2CB0020 VA: 0x182CB1620
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x2CB1850 Offset: 0x2CB0250 VA: 0x182CB1850
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x2CB1700 Offset: 0x2CB0100 VA: 0x182CB1700
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB2480 Offset: 0x2CB0E80 VA: 0x182CB2480
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB1A80 Offset: 0x2CB0480 VA: 0x182CB1A80
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	// RVA: 0x2CB1EF0 Offset: 0x2CB08F0 VA: 0x182CB1EF0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB20F0 Offset: 0x2CB0AF0 VA: 0x182CB20F0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2CB1C20 Offset: 0x2CB0620 VA: 0x182CB1C20
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x2CB22A0 Offset: 0x2CB0CA0 VA: 0x182CB22A0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x2CB23B0 Offset: 0x2CB0DB0 VA: 0x182CB23B0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	// RVA: 0x2CB22E0 Offset: 0x2CB0CE0 VA: 0x182CB22E0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[ExcludeFromDocs]
	// RVA: 0x2CB19C0 Offset: 0x2CB03C0 VA: 0x182CB19C0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2CB1960 Offset: 0x2CB0360 VA: 0x182CB1960
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }
}
