public sealed class MotionBlurComponent : PostProcessingComponentCommandBuffer<MotionBlurModel> // TypeDefIndex: 142
{
	// Fields
	private MotionBlurComponent.ReconstructionFilter m_ReconstructionFilter; // 0x20
	private MotionBlurComponent.FrameBlendingFilter m_FrameBlendingFilter; // 0x28
	private bool m_FirstFrame; // 0x30

	// Properties
	public MotionBlurComponent.ReconstructionFilter reconstructionFilter { get; }
	public MotionBlurComponent.FrameBlendingFilter frameBlendingFilter { get; }
	public override bool active { get; }

	// Methods

	// RVA: 0x579770 Offset: 0x578170 VA: 0x180579770
	public MotionBlurComponent.ReconstructionFilter get_reconstructionFilter() { }

	// RVA: 0x5795E0 Offset: 0x577FE0 VA: 0x1805795E0
	public MotionBlurComponent.FrameBlendingFilter get_frameBlendingFilter() { }

	// RVA: 0x579510 Offset: 0x577F10 VA: 0x180579510 Slot: 5
	public override bool get_active() { }

	// RVA: 0x578D70 Offset: 0x577770 VA: 0x180578D70 Slot: 11
	public override string GetName() { }

	// RVA: 0x579490 Offset: 0x577E90 VA: 0x180579490
	public void ResetHistory() { }

	// RVA: 0x578D60 Offset: 0x577760 VA: 0x180578D60 Slot: 4
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x578D50 Offset: 0x577750 VA: 0x180578D50 Slot: 10
	public override CameraEvent GetCameraEvent() { }

	// RVA: 0x578DC0 Offset: 0x5777C0 VA: 0x180578DC0 Slot: 6
	public override void OnEnable() { }

	// RVA: 0x578DD0 Offset: 0x5777D0 VA: 0x180578DD0 Slot: 12
	public override void PopulateCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x578DA0 Offset: 0x5777A0 VA: 0x180578DA0 Slot: 7
	public override void OnDisable() { }

	// RVA: 0x5794D0 Offset: 0x577ED0 VA: 0x1805794D0
	public void .ctor() { }
}
