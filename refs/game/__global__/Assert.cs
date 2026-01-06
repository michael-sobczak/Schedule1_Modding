public static class Assert // TypeDefIndex: 12347
{
	// Fields
	[Obsolete("Future versions of Unity are expected to always throw exceptions and not have this field.")]
	public static bool raiseExceptions; // 0x0

	// Methods

	// RVA: 0x2CEE770 Offset: 0x2CED170 VA: 0x182CEE770
	private static void Fail(string message, string userMessage) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x2CEEBB0 Offset: 0x2CED5B0 VA: 0x182CEEBB0
	public static void IsTrue(bool condition) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x2CEEAC0 Offset: 0x2CED4C0 VA: 0x182CEEAC0
	public static void IsTrue(bool condition, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x2CEE890 Offset: 0x2CED290 VA: 0x182CEE890
	public static void IsFalse(bool condition, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4E510 Offset: 0xE4CF10 VA: 0x180E4E510
	|-Assert.AreEqual<Int32Enum>
	|
	|-RVA: 0xE4EAE0 Offset: 0xE4D4E0 VA: 0x180E4EAE0
	|-Assert.AreEqual<object>
	|
	|-RVA: 0xE4E140 Offset: 0xE4CB40 VA: 0x180E4E140
	|-Assert.AreEqual<__Il2CppFullySharedGenericType>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4E710 Offset: 0xE4D110 VA: 0x180E4E710
	|-Assert.AreEqual<int>
	|
	|-RVA: 0xE4E580 Offset: 0xE4CF80 VA: 0x180E4E580
	|-Assert.AreEqual<Int32Enum>
	|
	|-RVA: 0xE4EA30 Offset: 0xE4D430 VA: 0x180E4EA30
	|-Assert.AreEqual<object>
	|
	|-RVA: 0xE4DBD0 Offset: 0xE4C5D0 VA: 0x180E4DBD0
	|-Assert.AreEqual<__Il2CppFullySharedGenericType>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4E290 Offset: 0xE4CC90 VA: 0x180E4E290
	|-Assert.AreEqual<int>
	|-Assert.AreEqual<Int32Enum>
	|
	|-RVA: 0xE4E7C0 Offset: 0xE4D1C0 VA: 0x180E4E7C0
	|-Assert.AreEqual<object>
	|
	|-RVA: 0xE4DD30 Offset: 0xE4C730 VA: 0x180E4DD30
	|-Assert.AreEqual<__Il2CppFullySharedGenericType>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x2CEE6C0 Offset: 0x2CED0C0 VA: 0x182CEE6C0
	public static void AreEqual(Object expected, Object actual, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void IsNull<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4EF00 Offset: 0xE4D900 VA: 0x180E4EF00
	|-Assert.IsNull<object>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void IsNull<T>(T value, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4F0C0 Offset: 0xE4DAC0 VA: 0x180E4F0C0
	|-Assert.IsNull<object>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x2CEEA20 Offset: 0x2CED420 VA: 0x182CEEA20
	public static void IsNull(Object value, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void IsNotNull<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4ED40 Offset: 0xE4D740 VA: 0x180E4ED40
	|-Assert.IsNotNull<object>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: -1 Offset: -1
	public static void IsNotNull<T>(T value, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4EBC0 Offset: 0xE4D5C0 VA: 0x180E4EBC0
	|-Assert.IsNotNull<object>
	*/

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x2CEE980 Offset: 0x2CED380 VA: 0x182CEE980
	public static void IsNotNull(Object value, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x2CEE650 Offset: 0x2CED050 VA: 0x182CEE650
	public static void AreEqual(int expected, int actual) { }

	// RVA: 0x2CEEC10 Offset: 0x2CED610 VA: 0x182CEEC10
	private static void .cctor() { }
}
