public abstract class Event // TypeDefIndex: 17907
{
	// Fields
	internal readonly Dictionary<string, string> m_Strings; // 0x10
	internal readonly Dictionary<string, long> m_Integers; // 0x18
	internal readonly Dictionary<string, bool> m_Booleans; // 0x20
	internal readonly Dictionary<string, double> m_Floats; // 0x28
	internal readonly string Name; // 0x30
	internal readonly bool StandardEvent; // 0x38
	internal readonly int EventVersion; // 0x3C

	// Methods

	// RVA: 0x2B91240 Offset: 0x2B8FC40 VA: 0x182B91240
	protected void .ctor(string name) { }

	// RVA: 0x2B914F0 Offset: 0x2B8FEF0 VA: 0x182B914F0
	internal void .ctor(string name, bool standardEvent, int eventVersion) { }

	// RVA: 0x2B91160 Offset: 0x2B8FB60 VA: 0x182B91160
	protected void SetParameter(string name, string value) { }

	// RVA: 0x2B90FA0 Offset: 0x2B8F9A0 VA: 0x182B90FA0
	protected void SetParameter(string name, bool value) { }

	// RVA: 0x2B91080 Offset: 0x2B8FA80 VA: 0x182B91080
	protected void SetParameter(string name, int value) { }

	// RVA: 0x2B911D0 Offset: 0x2B8FBD0 VA: 0x182B911D0
	protected void SetParameter(string name, long value) { }

	// RVA: 0x2B91010 Offset: 0x2B8FA10 VA: 0x182B91010
	protected void SetParameter(string name, float value) { }

	// RVA: 0x2B910F0 Offset: 0x2B8FAF0 VA: 0x182B910F0
	protected void SetParameter(string name, double value) { }

	// RVA: 0x2B90810 Offset: 0x2B8F210 VA: 0x182B90810 Slot: 4
	internal virtual void Serialize(IBuffer buffer) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void Validate() { }

	// RVA: 0x2B90680 Offset: 0x2B8F080 VA: 0x182B90680
	protected bool ParameterHasBeenSet(string name) { }

	// RVA: 0x2B90760 Offset: 0x2B8F160 VA: 0x182B90760 Slot: 6
	public virtual void Reset() { }

	// RVA: -1 Offset: -1
	internal static string[] BakeEnum2String<T>(bool toUpper = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE99D80 Offset: 0xE98780 VA: 0x180E99D80
	|-Event.BakeEnum2String<Int32Enum>
	|-Event.BakeEnum2String<__Il2CppFullySharedGenericStructType>
	*/
}
