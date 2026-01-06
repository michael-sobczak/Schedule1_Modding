internal class AnalyticsContainer : MonoBehaviour, IAnalyticsContainer, IContainerDebug // TypeDefIndex: 17919
{
	// Fields
	private const float k_AutoFlushPeriod = 60;
	private const float k_GameRunningPeriod = 60;
	private static bool s_Created; // 0x0
	private static GameObject s_Container; // 0x8
	private static AnalyticsContainer m_Instance; // 0x10
	private float m_AutoFlushTime; // 0x20
	private float m_GameRunningTime; // 0x24
	private AnalyticsServiceInstance m_Service; // 0x28

	// Properties
	private float AutoFlushPeriod { get; }
	internal static IContainerDebug ContainerDebug { get; }
	public float TimeUntilNextHeartbeat { get; }

	// Methods

	// RVA: 0x2B847E0 Offset: 0x2B831E0 VA: 0x182B847E0
	private float get_AutoFlushPeriod() { }

	// RVA: 0x2B84860 Offset: 0x2B83260 VA: 0x182B84860
	internal static IContainerDebug get_ContainerDebug() { }

	// RVA: 0x2B848A0 Offset: 0x2B832A0 VA: 0x182B848A0 Slot: 7
	public float get_TimeUntilNextHeartbeat() { }

	// RVA: 0x2B842C0 Offset: 0x2B82CC0 VA: 0x182B842C0
	internal static AnalyticsContainer CreateContainer() { }

	// RVA: 0x2B84540 Offset: 0x2B82F40 VA: 0x182B84540 Slot: 4
	public void Initialize(AnalyticsServiceInstance service) { }

	// RVA: 0x2B84530 Offset: 0x2B82F30 VA: 0x182B84530 Slot: 5
	public void Enable() { }

	// RVA: 0x2B84510 Offset: 0x2B82F10 VA: 0x182B84510 Slot: 6
	public void Disable() { }

	// RVA: 0x2B84670 Offset: 0x2B83070 VA: 0x182B84670
	private void Update() { }

	// RVA: 0x2B84570 Offset: 0x2B82F70 VA: 0x182B84570
	private void OnApplicationPause(bool paused) { }

	// RVA: 0x2B841B0 Offset: 0x2B82BB0 VA: 0x182B841B0
	private void CleanUp() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
