public class Texture : Object // TypeDefIndex: 11724
{
	// Fields
	public static readonly int GenerateAllMips; // 0x0

	// Properties
	public int mipmapCount { get; }
	public virtual GraphicsFormat graphicsFormat { get; }
	public virtual int width { get; set; }
	public virtual int height { get; set; }
	public virtual TextureDimension dimension { get; set; }
	public virtual bool isReadable { get; }
	public TextureWrapMode wrapMode { get; set; }
	public TextureWrapMode wrapModeU { set; }
	public TextureWrapMode wrapModeV { set; }
	public TextureWrapMode wrapModeW { set; }
	public FilterMode filterMode { get; set; }
	public int anisoLevel { get; set; }
	public float mipMapBias { get; set; }
	public Vector2 texelSize { get; }
	public uint updateCount { get; }
	internal ColorSpace activeTextureColorSpace { get; }

	// Methods

	// RVA: 0x2CB5B60 Offset: 0x2CB4560 VA: 0x182CB5B60
	protected void .ctor() { }

	[NativeName("GetMipmapCount")]
	// RVA: 0x2CB5D40 Offset: 0x2CB4740 VA: 0x182CB5D40
	public int get_mipmapCount() { }

	// RVA: 0x2CB5C70 Offset: 0x2CB4670 VA: 0x182CB5C70 Slot: 4
	public virtual GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x2CB5610 Offset: 0x2CB4010 VA: 0x182CB5610
	private int GetDataWidth() { }

	// RVA: 0x2CB55D0 Offset: 0x2CB3FD0 VA: 0x182CB55D0
	private int GetDataHeight() { }

	// RVA: 0x2CB5650 Offset: 0x2CB4050 VA: 0x182CB5650
	private TextureDimension GetDimension() { }

	// RVA: 0x2CB5610 Offset: 0x2CB4010 VA: 0x182CB5610 Slot: 5
	public virtual int get_width() { }

	// RVA: 0x2CB5FF0 Offset: 0x2CB49F0 VA: 0x182CB5FF0 Slot: 6
	public virtual void set_width(int value) { }

	// RVA: 0x2CB55D0 Offset: 0x2CB3FD0 VA: 0x182CB55D0 Slot: 7
	public virtual int get_height() { }

	// RVA: 0x2CB5F60 Offset: 0x2CB4960 VA: 0x182CB5F60 Slot: 8
	public virtual void set_height(int value) { }

	// RVA: 0x2CB5650 Offset: 0x2CB4050 VA: 0x182CB5650 Slot: 9
	public virtual TextureDimension get_dimension() { }

	// RVA: 0x2CB5EE0 Offset: 0x2CB48E0 VA: 0x182CB5EE0 Slot: 10
	public virtual void set_dimension(TextureDimension value) { }

	// RVA: 0x2CB5CC0 Offset: 0x2CB46C0 VA: 0x182CB5CC0 Slot: 11
	public virtual bool get_isReadable() { }

	[NativeName("GetWrapModeU")]
	// RVA: 0x2CB5E60 Offset: 0x2CB4860 VA: 0x182CB5E60
	public TextureWrapMode get_wrapMode() { }

	// RVA: 0x2CB60F0 Offset: 0x2CB4AF0 VA: 0x182CB60F0
	public void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0x2CB6030 Offset: 0x2CB4A30 VA: 0x182CB6030
	public void set_wrapModeU(TextureWrapMode value) { }

	// RVA: 0x2CB6070 Offset: 0x2CB4A70 VA: 0x182CB6070
	public void set_wrapModeV(TextureWrapMode value) { }

	// RVA: 0x2CB60B0 Offset: 0x2CB4AB0 VA: 0x182CB60B0
	public void set_wrapModeW(TextureWrapMode value) { }

	// RVA: 0x2CB5C30 Offset: 0x2CB4630 VA: 0x182CB5C30
	public FilterMode get_filterMode() { }

	// RVA: 0x2CB5F20 Offset: 0x2CB4920 VA: 0x182CB5F20
	public void set_filterMode(FilterMode value) { }

	// RVA: 0x2CB5BF0 Offset: 0x2CB45F0 VA: 0x182CB5BF0
	public int get_anisoLevel() { }

	// RVA: 0x2CB5EA0 Offset: 0x2CB48A0 VA: 0x182CB5EA0
	public void set_anisoLevel(int value) { }

	// RVA: 0x2CB5D00 Offset: 0x2CB4700 VA: 0x182CB5D00
	public float get_mipMapBias() { }

	// RVA: 0x2CB5FA0 Offset: 0x2CB49A0 VA: 0x182CB5FA0
	public void set_mipMapBias(float value) { }

	[NativeName("GetTexelSize")]
	// RVA: 0x2CB5DD0 Offset: 0x2CB47D0 VA: 0x182CB5DD0
	public Vector2 get_texelSize() { }

	// RVA: 0x2CB5E20 Offset: 0x2CB4820 VA: 0x182CB5E20
	public uint get_updateCount() { }

	[NativeMethod("GetActiveTextureColorSpace")]
	// RVA: 0x2CB5790 Offset: 0x2CB4190 VA: 0x182CB5790
	private int Internal_GetActiveTextureColorSpace() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule", "Unity.UIElements" })]
	// RVA: 0x2CB5BB0 Offset: 0x2CB45B0 VA: 0x182CB5BB0
	internal ColorSpace get_activeTextureColorSpace() { }

	// RVA: 0x2CB56E0 Offset: 0x2CB40E0 VA: 0x182CB56E0
	internal ulong GetPixelDataSize(int mipLevel, int element = 0) { }

	// RVA: 0x2CB5690 Offset: 0x2CB4090 VA: 0x182CB5690
	internal ulong GetPixelDataOffset(int mipLevel, int element = 0) { }

	// RVA: 0x2CB5780 Offset: 0x2CB4180 VA: 0x182CB5780
	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	// RVA: 0x2CB5730 Offset: 0x2CB4130 VA: 0x182CB5730
	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	// RVA: 0x2CB5980 Offset: 0x2CB4380 VA: 0x182CB5980
	internal bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x2CB57D0 Offset: 0x2CB41D0 VA: 0x182CB57D0
	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x2CB5540 Offset: 0x2CB3F40 VA: 0x182CB5540
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x2CB54E0 Offset: 0x2CB3EE0 VA: 0x182CB54E0
	internal UnityException CreateNativeArrayLengthOverflowException() { }

	// RVA: 0x2CB5B20 Offset: 0x2CB4520 VA: 0x182CB5B20
	private static void .cctor() { }

	// RVA: 0x2CB5D80 Offset: 0x2CB4780 VA: 0x182CB5D80
	private void get_texelSize_Injected(out Vector2 ret) { }
}
