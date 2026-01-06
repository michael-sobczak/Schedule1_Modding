public sealed class PostProcessDebugLayer // TypeDefIndex: 17033
{
	// Fields
	public LightMeterMonitor lightMeter; // 0x10
	public HistogramMonitor histogram; // 0x18
	public WaveformMonitor waveform; // 0x20
	public VectorscopeMonitor vectorscope; // 0x28
	private Dictionary<MonitorType, Monitor> m_Monitors; // 0x30
	private int frameWidth; // 0x38
	private int frameHeight; // 0x3C
	[CompilerGenerated]
	private RenderTexture <debugOverlayTarget>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <debugOverlayActive>k__BackingField; // 0x48
	[CompilerGenerated]
	private DebugOverlay <debugOverlay>k__BackingField; // 0x4C
	public PostProcessDebugLayer.OverlaySettings overlaySettings; // 0x50

	// Properties
	public RenderTexture debugOverlayTarget { get; set; }
	public bool debugOverlayActive { get; set; }
	public DebugOverlay debugOverlay { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public RenderTexture get_debugOverlayTarget() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_debugOverlayTarget(RenderTexture value) { }

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	public bool get_debugOverlayActive() { }

	[CompilerGenerated]
	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	private void set_debugOverlayActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0
	public DebugOverlay get_debugOverlay() { }

	[CompilerGenerated]
	// RVA: 0x4E27E0 Offset: 0x4E11E0 VA: 0x1804E27E0
	private void set_debugOverlay(DebugOverlay value) { }

	// RVA: 0x29AD180 Offset: 0x29ABB80 VA: 0x1829AD180
	internal void OnEnable() { }

	// RVA: 0x29ACFD0 Offset: 0x29AB9D0 VA: 0x1829ACFD0
	internal void OnDisable() { }

	// RVA: 0x29ACD80 Offset: 0x29AB780 VA: 0x1829ACD80
	private void DestroyDebugOverlayTarget() { }

	// RVA: 0x29AE090 Offset: 0x29ACA90 VA: 0x1829AE090
	public void RequestMonitorPass(MonitorType monitor) { }

	// RVA: 0x4E27E0 Offset: 0x4E11E0 VA: 0x1804E27E0
	public void RequestDebugOverlay(DebugOverlay mode) { }

	// RVA: 0x29AE0F0 Offset: 0x29ACAF0 VA: 0x1829AE0F0
	internal void SetFrameSize(int width, int height) { }

	// RVA: 0x29AD430 Offset: 0x29ABE30 VA: 0x1829AD430
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	// RVA: 0x29ACFA0 Offset: 0x29AB9A0 VA: 0x1829ACFA0
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x29AD750 Offset: 0x29AC150 VA: 0x1829AD750
	internal void RenderMonitors(PostProcessRenderContext context) { }

	// RVA: 0x29ADC20 Offset: 0x29AC620 VA: 0x1829ADC20
	internal void RenderSpecialOverlays(PostProcessRenderContext context) { }

	// RVA: 0x29ACDF0 Offset: 0x29AB7F0 VA: 0x1829ACDF0
	internal void EndFrame() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
