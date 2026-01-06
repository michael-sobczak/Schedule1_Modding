public struct InputDeviceMatcher : IEquatable<InputDeviceMatcher> // TypeDefIndex: 7767
{
	// Fields
	private KeyValuePair<InternedString, object>[] m_Patterns; // 0x0
	private static readonly InternedString kInterfaceKey; // 0x0
	private static readonly InternedString kDeviceClassKey; // 0x10
	private static readonly InternedString kManufacturerKey; // 0x20
	private static readonly InternedString kManufacturerContainsKey; // 0x30
	private static readonly InternedString kProductKey; // 0x40
	private static readonly InternedString kVersionKey; // 0x50

	// Properties
	public bool empty { get; }
	public IEnumerable<KeyValuePair<string, object>> patterns { get; }

	// Methods

	// RVA: 0xC246A0 Offset: 0xC230A0 VA: 0x180C246A0
	public bool get_empty() { }

	[IteratorStateMachine(typeof(InputDeviceMatcher.<get_patterns>d__4))]
	// RVA: 0x2784B80 Offset: 0x2783580 VA: 0x182784B80
	public IEnumerable<KeyValuePair<string, object>> get_patterns() { }

	// RVA: 0x2783FB0 Offset: 0x27829B0 VA: 0x182783FB0
	public InputDeviceMatcher WithInterface(string pattern, bool supportRegex = True) { }

	// RVA: 0x2783F10 Offset: 0x2782910 VA: 0x182783F10
	public InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex = True) { }

	// RVA: 0x2784190 Offset: 0x2782B90 VA: 0x182784190
	public InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex = True) { }

	// RVA: 0x2784040 Offset: 0x2782A40 VA: 0x182784040
	public InputDeviceMatcher WithManufacturerContains(string noRegExPattern) { }

	// RVA: 0x2784230 Offset: 0x2782C30 VA: 0x182784230
	public InputDeviceMatcher WithProduct(string pattern, bool supportRegex = True) { }

	// RVA: 0x27842D0 Offset: 0x2782CD0 VA: 0x1827842D0
	public InputDeviceMatcher WithVersion(string pattern, bool supportRegex = True) { }

	// RVA: -1 Offset: -1
	public InputDeviceMatcher WithCapability<TValue>(string path, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA870 Offset: 0xED9270 VA: 0x180EDA870
	|-InputDeviceMatcher.WithCapability<int>
	|-InputDeviceMatcher.WithCapability<Int32Enum>
	|
	|-RVA: 0xEDA940 Offset: 0xED9340 VA: 0x180EDA940
	|-InputDeviceMatcher.WithCapability<object>
	|
	|-RVA: 0xEDA750 Offset: 0xED9150 VA: 0x180EDA750
	|-InputDeviceMatcher.WithCapability<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2784370 Offset: 0x2782D70 VA: 0x182784370
	private InputDeviceMatcher With(InternedString key, object value, bool supportRegex = True) { }

	// RVA: 0x2783590 Offset: 0x2781F90 VA: 0x182783590
	public float MatchPercentage(InputDeviceDescription deviceDescription) { }

	// RVA: 0x2783C90 Offset: 0x2782690 VA: 0x182783C90
	private static bool MatchSingleProperty(object pattern, string value) { }

	// RVA: 0x2783C10 Offset: 0x2782610 VA: 0x182783C10
	private static bool MatchSinglePropertyContains(object pattern, string value) { }

	// RVA: 0x27834F0 Offset: 0x2781EF0 VA: 0x1827834F0
	private static int GetNumPropertiesIn(InputDeviceDescription description) { }

	// RVA: 0x2782EA0 Offset: 0x27818A0 VA: 0x182782EA0
	public static InputDeviceMatcher FromDeviceDescription(InputDeviceDescription deviceDescription) { }

	// RVA: 0x2783D60 Offset: 0x2782760 VA: 0x182783D60 Slot: 3
	public override string ToString() { }

	// RVA: 0x2782D50 Offset: 0x2781750 VA: 0x182782D50 Slot: 4
	public bool Equals(InputDeviceMatcher other) { }

	// RVA: 0x2782CB0 Offset: 0x27816B0 VA: 0x182782CB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2784C00 Offset: 0x2783600 VA: 0x182784C00
	public static bool op_Equality(InputDeviceMatcher left, InputDeviceMatcher right) { }

	// RVA: 0x2784C60 Offset: 0x2783660 VA: 0x182784C60
	public static bool op_Inequality(InputDeviceMatcher left, InputDeviceMatcher right) { }

	// RVA: 0x18A4420 Offset: 0x18A2E20 VA: 0x1818A4420 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27845B0 Offset: 0x2782FB0 VA: 0x1827845B0
	private static void .cctor() { }
}
