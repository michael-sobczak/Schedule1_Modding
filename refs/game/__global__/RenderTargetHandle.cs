public struct RenderTargetHandle // TypeDefIndex: 9005
{
	// Fields
	[CompilerGenerated]
	private int <id>k__BackingField; // 0x0
	[CompilerGenerated]
	private RenderTargetIdentifier <rtid>k__BackingField; // 0x8
	public static readonly RenderTargetHandle CameraTarget; // 0x0

	// Properties
	public int id { get; set; }
	private RenderTargetIdentifier rtid { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_id(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_id() { }

	[CompilerGenerated]
	// RVA: 0x2B1CCB0 Offset: 0x2B1B6B0 VA: 0x182B1CCB0
	private void set_rtid(RenderTargetIdentifier value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x109FEB0 Offset: 0x109E8B0 VA: 0x18109FEB0
	private RenderTargetIdentifier get_rtid() { }

	// RVA: 0x2B1C8C0 Offset: 0x2B1B2C0 VA: 0x182B1C8C0
	public void .ctor(RenderTargetIdentifier renderTargetIdentifier) { }

	// RVA: 0x2B1C930 Offset: 0x2B1B330 VA: 0x182B1C930
	public void .ctor(RTHandle rtHandle) { }

	// RVA: 0x2B1C480 Offset: 0x2B1AE80 VA: 0x182B1C480
	internal static RenderTargetHandle GetCameraTarget(ref CameraData cameraData) { }

	// RVA: 0x2B1C800 Offset: 0x2B1B200 VA: 0x182B1C800
	public void Init(string shaderProperty) { }

	// RVA: 0x2B1C790 Offset: 0x2B1B190 VA: 0x182B1C790
	public void Init(RenderTargetIdentifier renderTargetIdentifier) { }

	// RVA: 0x2B1C660 Offset: 0x2B1B060 VA: 0x182B1C660
	public RenderTargetIdentifier Identifier() { }

	// RVA: 0x2B1C610 Offset: 0x2B1B010 VA: 0x182B1C610
	public bool HasInternalRenderTargetId() { }

	// RVA: 0x2B1C270 Offset: 0x2B1AC70 VA: 0x182B1C270
	public bool Equals(RenderTargetHandle other) { }

	// RVA: 0x2B1C3C0 Offset: 0x2B1ADC0 VA: 0x182B1C3C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2B1C5C0 Offset: 0x2B1AFC0 VA: 0x182B1C5C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2B1CBB0 Offset: 0x2B1B5B0 VA: 0x182B1CBB0
	public static bool op_Equality(RenderTargetHandle c1, RenderTargetHandle c2) { }

	// RVA: 0x2B1CC30 Offset: 0x2B1B630 VA: 0x182B1CC30
	public static bool op_Inequality(RenderTargetHandle c1, RenderTargetHandle c2) { }

	// RVA: 0x2B1C860 Offset: 0x2B1B260 VA: 0x182B1C860
	private static void .cctor() { }
}
