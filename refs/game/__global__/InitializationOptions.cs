public class InitializationOptions // TypeDefIndex: 19095
{
	// Fields
	[CompilerGenerated]
	private readonly IDictionary<string, object> <Values>k__BackingField; // 0x10

	// Properties
	internal IDictionary<string, object> Values { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal IDictionary<string, object> get_Values() { }

	// RVA: 0x2B982A0 Offset: 0x2B96CA0 VA: 0x182B982A0
	public void .ctor() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(IDictionary<string, object> values) { }

	// RVA: 0x2B98320 Offset: 0x2B96D20 VA: 0x182B98320
	internal void .ctor(InitializationOptions source) { }

	// RVA: 0x2B98180 Offset: 0x2B96B80 VA: 0x182B98180
	public bool TryGetOption(string key, out bool option) { }

	// RVA: 0x2B981E0 Offset: 0x2B96BE0 VA: 0x182B981E0
	public bool TryGetOption(string key, out int option) { }

	// RVA: 0x2B98240 Offset: 0x2B96C40 VA: 0x182B98240
	public bool TryGetOption(string key, out float option) { }

	// RVA: 0x2B98120 Offset: 0x2B96B20 VA: 0x182B98120
	public bool TryGetOption(string key, out string option) { }

	// RVA: -1 Offset: -1
	private bool TryGetOption<T>(string key, out T option) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xECA610 Offset: 0xEC9010 VA: 0x180ECA610
	|-InitializationOptions.TryGetOption<bool>
	|
	|-RVA: 0xECA9E0 Offset: 0xEC93E0 VA: 0x180ECA9E0
	|-InitializationOptions.TryGetOption<int>
	|-InitializationOptions.TryGetOption<float>
	|
	|-RVA: 0xECAB60 Offset: 0xEC9560 VA: 0x180ECAB60
	|-InitializationOptions.TryGetOption<object>
	|
	|-RVA: 0xECA790 Offset: 0xEC9190 VA: 0x180ECA790
	|-InitializationOptions.TryGetOption<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2B97FE0 Offset: 0x2B969E0 VA: 0x182B97FE0
	public InitializationOptions SetOption(string key, bool value) { }

	// RVA: 0x2B97ED0 Offset: 0x2B968D0 VA: 0x182B97ED0
	public InitializationOptions SetOption(string key, int value) { }

	// RVA: 0x2B98080 Offset: 0x2B96A80 VA: 0x182B98080
	public InitializationOptions SetOption(string key, float value) { }

	// RVA: 0x2B97F70 Offset: 0x2B96970 VA: 0x182B97F70
	public InitializationOptions SetOption(string key, string value) { }
}
