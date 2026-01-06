public class BuiltinDebugViewsModel : PostProcessingModel // TypeDefIndex: 171
{
	// Fields
	[SerializeField]
	private BuiltinDebugViewsModel.Settings m_Settings; // 0x18

	// Properties
	public BuiltinDebugViewsModel.Settings settings { get; set; }
	public bool willInterrupt { get; }

	// Methods

	// RVA: 0x695430 Offset: 0x693E30 VA: 0x180695430
	public BuiltinDebugViewsModel.Settings get_settings() { }

	// RVA: 0x695480 Offset: 0x693E80 VA: 0x180695480
	public void set_settings(BuiltinDebugViewsModel.Settings value) { }

	// RVA: 0x695450 Offset: 0x693E50 VA: 0x180695450
	public bool get_willInterrupt() { }

	// RVA: 0x695390 Offset: 0x693D90 VA: 0x180695390 Slot: 4
	public override void Reset() { }

	// RVA: 0x695380 Offset: 0x693D80 VA: 0x180695380
	public bool IsModeActive(BuiltinDebugViewsModel.Mode mode) { }

	// RVA: 0x6953E0 Offset: 0x693DE0 VA: 0x1806953E0
	public void .ctor() { }
}
