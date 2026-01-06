public sealed class BuiltinDebugViewsComponent : PostProcessingComponentCommandBuffer<BuiltinDebugViewsModel> // TypeDefIndex: 120
{
	// Fields
	private const string k_ShaderString = "Hidden/Post FX/Builtin Debug Views";
	private BuiltinDebugViewsComponent.ArrowArray m_Arrows; // 0x20

	// Properties
	public override bool active { get; }

	// Methods

	// RVA: 0x56DDE0 Offset: 0x56C7E0 VA: 0x18056DDE0 Slot: 5
	public override bool get_active() { }

	// RVA: 0x56D0B0 Offset: 0x56BAB0 VA: 0x18056D0B0 Slot: 4
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x56D050 Offset: 0x56BA50 VA: 0x18056D050 Slot: 10
	public override CameraEvent GetCameraEvent() { }

	// RVA: 0x56D120 Offset: 0x56BB20 VA: 0x18056D120 Slot: 11
	public override string GetName() { }

	// RVA: 0x56D9A0 Offset: 0x56C3A0 VA: 0x18056D9A0 Slot: 12
	public override void PopulateCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x56CEF0 Offset: 0x56B8F0 VA: 0x18056CEF0
	private void DepthPass(CommandBuffer cb) { }

	// RVA: 0x56CE20 Offset: 0x56B820 VA: 0x18056CE20
	private void DepthNormalsPass(CommandBuffer cb) { }

	// RVA: 0x56D150 Offset: 0x56BB50 VA: 0x18056D150
	private void MotionVectorsPass(CommandBuffer cb) { }

	// RVA: 0x56DC80 Offset: 0x56C680 VA: 0x18056DC80
	private void PrepareArrows() { }

	// RVA: 0x56D940 Offset: 0x56C340 VA: 0x18056D940 Slot: 7
	public override void OnDisable() { }

	// RVA: 0x56DDA0 Offset: 0x56C7A0 VA: 0x18056DDA0
	public void .ctor() { }
}
