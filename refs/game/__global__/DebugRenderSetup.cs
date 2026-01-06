internal class DebugRenderSetup : IDisposable // TypeDefIndex: 8824
{
	// Fields
	private readonly DebugHandler m_DebugHandler; // 0x10
	private readonly ScriptableRenderContext m_Context; // 0x18
	private readonly CommandBuffer m_CommandBuffer; // 0x20
	private readonly int m_Index; // 0x28
	private readonly FilteringSettings m_FilteringSettings; // 0x2C

	// Properties
	private DebugDisplaySettingsMaterial MaterialSettings { get; }
	private DebugDisplaySettingsRendering RenderingSettings { get; }
	private DebugDisplaySettingsLighting LightingSettings { get; }

	// Methods

	// RVA: 0x2ACA390 Offset: 0x2AC8D90 VA: 0x182ACA390
	private DebugDisplaySettingsMaterial get_MaterialSettings() { }

	// RVA: 0x2ACA3C0 Offset: 0x2AC8DC0 VA: 0x182ACA3C0
	private DebugDisplaySettingsRendering get_RenderingSettings() { }

	// RVA: 0x2ACA360 Offset: 0x2AC8D60 VA: 0x182ACA360
	private DebugDisplaySettingsLighting get_LightingSettings() { }

	// RVA: 0x2AC9A30 Offset: 0x2AC8430 VA: 0x182AC9A30
	private void Begin() { }

	// RVA: 0x2AC9D80 Offset: 0x2AC8780 VA: 0x182AC9D80
	private void End() { }

	// RVA: 0x2ACA200 Offset: 0x2AC8C00 VA: 0x182ACA200
	internal void .ctor(DebugHandler debugHandler, ScriptableRenderContext context, CommandBuffer commandBuffer, int index, FilteringSettings filteringSettings) { }

	// RVA: 0x2AC9B20 Offset: 0x2AC8520 VA: 0x182AC9B20
	internal DrawingSettings CreateDrawingSettings(DrawingSettings drawingSettings) { }

	// RVA: 0x2AC9E20 Offset: 0x2AC8820 VA: 0x182AC9E20
	internal RenderStateBlock GetRenderStateBlock(RenderStateBlock renderStateBlock) { }

	// RVA: 0x2AC9D80 Offset: 0x2AC8780 VA: 0x182AC9D80 Slot: 4
	public void Dispose() { }
}
