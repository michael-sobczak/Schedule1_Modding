public struct RendererList // TypeDefIndex: 12254
{
	// Fields
	internal UIntPtr context; // 0x0
	internal uint index; // 0x8
	internal uint frame; // 0xC
	internal uint type; // 0x10
	public static readonly RendererList nullRendererList; // 0x0

	// Properties
	public bool isValid { get; }

	// Methods

	// RVA: 0x2CE8A70 Offset: 0x2CE7470 VA: 0x182CE8A70
	public bool get_isValid() { }

	// RVA: 0x2CE8A20 Offset: 0x2CE7420 VA: 0x182CE8A20
	internal void .ctor(UIntPtr ctx, uint indx) { }

	// RVA: 0x2CE89C0 Offset: 0x2CE73C0 VA: 0x182CE89C0
	private static void .cctor() { }

	// RVA: 0x2CE8A30 Offset: 0x2CE7430 VA: 0x182CE8A30
	private static bool get_isValid_Injected(ref RendererList _unity_self) { }
}
