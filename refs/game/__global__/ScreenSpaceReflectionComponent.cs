public sealed class ScreenSpaceReflectionComponent : PostProcessingComponentCommandBuffer<ScreenSpaceReflectionModel> // TypeDefIndex: 145
{
	// Fields
	private bool k_HighlightSuppression; // 0x20
	private bool k_TraceBehindObjects; // 0x21
	private bool k_TreatBackfaceHitAsMiss; // 0x22
	private bool k_BilateralUpsample; // 0x23
	private readonly int[] m_ReflectionTextures; // 0x28

	// Properties
	public override bool active { get; }

	// Methods

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x57BA20 Offset: 0x57A420 VA: 0x18057BA20 Slot: 5
	public override bool get_active() { }

	// RVA: 0x57A4D0 Offset: 0x578ED0 VA: 0x18057A4D0 Slot: 6
	public override void OnEnable() { }

	// RVA: 0x57A4A0 Offset: 0x578EA0 VA: 0x18057A4A0 Slot: 11
	public override string GetName() { }

	// RVA: 0x57A490 Offset: 0x578E90 VA: 0x18057A490 Slot: 10
	public override CameraEvent GetCameraEvent() { }

	// RVA: 0x57A5F0 Offset: 0x578FF0 VA: 0x18057A5F0 Slot: 12
	public override void PopulateCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x57B9B0 Offset: 0x57A3B0 VA: 0x18057B9B0
	public void .ctor() { }
}
