internal struct ColorPage // TypeDefIndex: 6748
{
	// Fields
	public bool isValid; // 0x0
	public Color32 pageAndID; // 0x4

	// Methods

	// RVA: 0x2ED4730 Offset: 0x2ED3130 VA: 0x182ED4730
	public static ColorPage Init(RenderChain renderChain, BMPAlloc alloc) { }

	// RVA: 0x2ED47F0 Offset: 0x2ED31F0 VA: 0x182ED47F0
	public MeshBuilderNative.NativeColorPage ToNativeColorPage() { }
}
