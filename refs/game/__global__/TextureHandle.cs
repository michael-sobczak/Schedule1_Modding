public struct TextureHandle // TypeDefIndex: 13546
{
	// Fields
	private static TextureHandle s_NullHandle; // 0x0
	internal ResourceHandle handle; // 0x0

	// Properties
	public static TextureHandle nullHandle { get; }

	// Methods

	// RVA: 0x29DB810 Offset: 0x29DA210 VA: 0x1829DB810
	public static TextureHandle get_nullHandle() { }

	// RVA: 0x29DB7D0 Offset: 0x29DA1D0 VA: 0x1829DB7D0
	internal void .ctor(int handle, bool shared = False) { }

	// RVA: 0x29DBAF0 Offset: 0x29DA4F0 VA: 0x1829DBAF0
	public static RenderTargetIdentifier op_Implicit(TextureHandle texture) { }

	// RVA: 0x29DB860 Offset: 0x29DA260 VA: 0x1829DB860
	public static Texture op_Implicit(TextureHandle texture) { }

	// RVA: 0x29DBA10 Offset: 0x29DA410 VA: 0x1829DBA10
	public static RenderTexture op_Implicit(TextureHandle texture) { }

	// RVA: 0x29DB940 Offset: 0x29DA340 VA: 0x1829DB940
	public static RTHandle op_Implicit(TextureHandle texture) { }

	// RVA: 0x29DB780 Offset: 0x29DA180 VA: 0x1829DB780
	public bool IsValid() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void .cctor() { }
}
