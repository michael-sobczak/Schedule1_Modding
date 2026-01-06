internal class ClickDetector // TypeDefIndex: 6181
{
	// Fields
	private List<ClickDetector.ButtonClickStatus> m_ClickStatus; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static int <s_DoubleClickTime>k__BackingField; // 0x0

	// Properties
	internal static int s_DoubleClickTime { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2DB3590 Offset: 0x2DB1F90 VA: 0x182DB3590
	internal static int get_s_DoubleClickTime() { }

	[CompilerGenerated]
	// RVA: 0x2DB35E0 Offset: 0x2DB1FE0 VA: 0x182DB35E0
	internal static void set_s_DoubleClickTime(int value) { }

	// RVA: 0x2DB3310 Offset: 0x2DB1D10 VA: 0x182DB3310
	public void .ctor() { }

	// RVA: 0x2DB30E0 Offset: 0x2DB1AE0 VA: 0x182DB30E0
	private void StartClickTracking(EventBase evt) { }

	// RVA: 0x2DB2C80 Offset: 0x2DB1680 VA: 0x182DB2C80
	private void SendClickEvent(EventBase evt) { }

	// RVA: 0x2DB2580 Offset: 0x2DB0F80 VA: 0x182DB2580
	private void CancelClickTracking(EventBase evt) { }

	// RVA: 0x2DB2910 Offset: 0x2DB1310 VA: 0x182DB2910
	public void ProcessEvent(EventBase evt) { }

	// RVA: 0x2DB2780 Offset: 0x2DB1180 VA: 0x182DB2780
	private static bool ContainsPointer(VisualElement element, Vector2 position) { }

	// RVA: 0x2DB2620 Offset: 0x2DB1020 VA: 0x182DB2620
	internal void Cleanup(List<VisualElement> elements) { }

	// RVA: 0x2DB32D0 Offset: 0x2DB1CD0 VA: 0x182DB32D0
	private static void .cctor() { }
}
