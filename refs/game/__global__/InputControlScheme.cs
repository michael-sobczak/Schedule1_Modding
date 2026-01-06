public struct InputControlScheme : IEquatable<InputControlScheme> // TypeDefIndex: 7333
{
	// Fields
	[SerializeField]
	internal string m_Name; // 0x0
	[SerializeField]
	internal string m_BindingGroup; // 0x8
	[SerializeField]
	internal InputControlScheme.DeviceRequirement[] m_DeviceRequirements; // 0x10

	// Properties
	public string name { get; }
	public string bindingGroup { get; set; }
	public ReadOnlyArray<InputControlScheme.DeviceRequirement> deviceRequirements { get; }

	// Methods

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public string get_name() { }

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public string get_bindingGroup() { }

	// RVA: 0xCC9B80 Offset: 0xCC8580 VA: 0x180CC9B80
	public void set_bindingGroup(string value) { }

	// RVA: 0x27A1900 Offset: 0x27A0300 VA: 0x1827A1900
	public ReadOnlyArray<InputControlScheme.DeviceRequirement> get_deviceRequirements() { }

	// RVA: 0x27A17E0 Offset: 0x27A01E0 VA: 0x1827A17E0
	public void .ctor(string name, IEnumerable<InputControlScheme.DeviceRequirement> devices, string bindingGroup) { }

	// RVA: 0x27A1460 Offset: 0x279FE60 VA: 0x1827A1460
	internal void SetNameAndBindingGroup(string name, string bindingGroup) { }

	// RVA: -1 Offset: -1
	public static Nullable<InputControlScheme> FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, InputDevice mustIncludeDevice, bool allowUnsuccesfulMatch = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED6460 Offset: 0xED4E60 VA: 0x180ED6460
	|-InputControlScheme.FindControlSchemeForDevices<InputControlList<object>, ReadOnlyArray<InputControlScheme>>
	|
	|-RVA: 0xED7390 Offset: 0xED5D90 VA: 0x180ED7390
	|-InputControlScheme.FindControlSchemeForDevices<ReadOnlyArray<object>, ReadOnlyArray<InputControlScheme>>
	|
	|-RVA: 0xED7BF0 Offset: 0xED65F0 VA: 0x180ED7BF0
	|-InputControlScheme.FindControlSchemeForDevices<object, ReadOnlyArray<InputControlScheme>>
	|
	|-RVA: 0xED6120 Offset: 0xED4B20 VA: 0x180ED6120
	|-InputControlScheme.FindControlSchemeForDevices<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, out InputControlScheme controlScheme, out InputControlScheme.MatchResult matchResult, InputDevice mustIncludeDevice, bool allowUnsuccessfulMatch = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED65A0 Offset: 0xED4FA0 VA: 0x180ED65A0
	|-InputControlScheme.FindControlSchemeForDevices<InputControlList<object>, ReadOnlyArray<InputControlScheme>>
	|
	|-RVA: 0xED6CA0 Offset: 0xED56A0 VA: 0x180ED6CA0
	|-InputControlScheme.FindControlSchemeForDevices<ReadOnlyArray<object>, ReadOnlyArray<InputControlScheme>>
	|
	|-RVA: 0xED74C0 Offset: 0xED5EC0 VA: 0x180ED74C0
	|-InputControlScheme.FindControlSchemeForDevices<object, ReadOnlyArray<InputControlScheme>>
	|
	|-RVA: 0xED5890 Offset: 0xED4290 VA: 0x180ED5890
	|-InputControlScheme.FindControlSchemeForDevices<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Nullable<InputControlScheme> FindControlSchemeForDevice<TSchemes>(InputDevice device, TSchemes schemes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED5670 Offset: 0xED4070 VA: 0x180ED5670
	|-InputControlScheme.FindControlSchemeForDevice<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x27A1520 Offset: 0x279FF20 VA: 0x1827A1520
	public bool SupportsDevice(InputDevice device) { }

	// RVA: -1 Offset: -1
	public InputControlScheme.MatchResult PickDevicesFrom<TDevices>(TDevices devices, InputDevice favorDevice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED8570 Offset: 0xED6F70 VA: 0x180ED8570
	|-InputControlScheme.PickDevicesFrom<InputControlList<object>>
	|
	|-RVA: 0xED8D10 Offset: 0xED7710 VA: 0x180ED8D10
	|-InputControlScheme.PickDevicesFrom<ReadOnlyArray<object>>
	|
	|-RVA: 0xED9460 Offset: 0xED7E60 VA: 0x180ED9460
	|-InputControlScheme.PickDevicesFrom<object>
	|
	|-RVA: 0xED7DA0 Offset: 0xED67A0 VA: 0x180ED7DA0
	|-InputControlScheme.PickDevicesFrom<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x27A1090 Offset: 0x279FA90 VA: 0x1827A1090 Slot: 4
	public bool Equals(InputControlScheme other) { }

	// RVA: 0x27A1310 Offset: 0x279FD10 VA: 0x1827A1310 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x27A13B0 Offset: 0x279FDB0 VA: 0x1827A13B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x27A1650 Offset: 0x27A0050 VA: 0x1827A1650 Slot: 3
	public override string ToString() { }

	// RVA: 0x27A1960 Offset: 0x27A0360 VA: 0x1827A1960
	public static bool op_Equality(InputControlScheme left, InputControlScheme right) { }

	// RVA: 0x27A1990 Offset: 0x27A0390 VA: 0x1827A1990
	public static bool op_Inequality(InputControlScheme left, InputControlScheme right) { }
}
