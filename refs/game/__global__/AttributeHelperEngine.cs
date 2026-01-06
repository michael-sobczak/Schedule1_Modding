internal class AttributeHelperEngine // TypeDefIndex: 11794
{
	// Fields
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2CB9490 Offset: 0x2CB7E90 VA: 0x182CB9490
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[RequiredByNativeCode]
	// RVA: 0x2CB95D0 Offset: 0x2CB7FD0 VA: 0x182CB95D0
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x2CB9380 Offset: 0x2CB7D80 VA: 0x182CB9380
	private static int GetExecuteMode(Type klass) { }

	[RequiredByNativeCode]
	// RVA: 0x2CB9110 Offset: 0x2CB7B10 VA: 0x182CB9110
	private static int CheckIsEditorScript(Type klass) { }

	[RequiredByNativeCode]
	// RVA: 0x2CB9310 Offset: 0x2CB7D10 VA: 0x182CB9310
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: -1 Offset: -1
	private static T GetCustomAttributeOfType<T>(Type klass) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE581A0 Offset: 0xE56BA0 VA: 0x180E581A0
	|-AttributeHelperEngine.GetCustomAttributeOfType<object>
	*/

	// RVA: 0x2CB9A50 Offset: 0x2CB8450 VA: 0x182CB9A50
	private static void .cctor() { }
}
