internal static class GroupBoxUtility // TypeDefIndex: 6684
{
	// Fields
	private static Dictionary<IGroupBox, IGroupManager> s_GroupManagers; // 0x0
	private static Dictionary<IGroupBoxOption, IGroupManager> s_GroupOptionManagerCache; // 0x8
	private static readonly Type k_GenericGroupBoxType; // 0x10

	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static void RegisterGroupBoxOption<T>(T option) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBE1F0 Offset: 0xEBCBF0 VA: 0x180EBE1F0
	|-GroupBoxUtility.RegisterGroupBoxOption<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void UnregisterGroupBoxOption<T>(T option) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBE340 Offset: 0xEBCD40 VA: 0x180EBE340
	|-GroupBoxUtility.UnregisterGroupBoxOption<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void OnOptionSelected<T>(T selectedOption) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBE0F0 Offset: 0xEBCAF0 VA: 0x180EBE0F0
	|-GroupBoxUtility.OnOptionSelected<object>
	*/

	// RVA: 0x2EA4690 Offset: 0x2EA3090 VA: 0x182EA4690
	private static IGroupManager FindOrCreateGroupManager(IGroupBox groupBox) { }

	// RVA: 0x2EA4BE0 Offset: 0x2EA35E0 VA: 0x182EA4BE0
	private static void OnGroupBoxDetachedFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x2EA4CA0 Offset: 0x2EA36A0 VA: 0x182EA4CA0
	private static void OnPanelDestroyed(BaseVisualElementPanel panel) { }

	// RVA: 0x2EA4E10 Offset: 0x2EA3810 VA: 0x182EA4E10
	private static void .cctor() { }
}
