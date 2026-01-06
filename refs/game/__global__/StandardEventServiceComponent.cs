internal class StandardEventServiceComponent : IAnalyticsStandardEventComponent, IServiceComponent // TypeDefIndex: 17962
{
	// Fields
	private readonly IProjectConfiguration m_Configuration; // 0x10
	private readonly IUnstructuredEventRecorder m_AnalyticsService; // 0x18

	// Methods

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	public void .ctor(IProjectConfiguration configuration, IUnstructuredEventRecorder analyticsService) { }

	// RVA: 0x2B92000 Offset: 0x2B90A00 VA: 0x182B92000 Slot: 4
	public void Record(string eventName, IDictionary<string, object> eventParameters, int eventVersion, string packageName) { }
}
