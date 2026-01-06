internal class ArgumentCache : ISerializationCallbackReceiver // TypeDefIndex: 11951
{
	// Fields
	[FormerlySerializedAs("objectArgument")]
	[SerializeField]
	private Object m_ObjectArgument; // 0x10
	[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
	[SerializeField]
	private string m_ObjectArgumentAssemblyTypeName; // 0x18
	[SerializeField]
	[FormerlySerializedAs("intArgument")]
	private int m_IntArgument; // 0x20
	[FormerlySerializedAs("floatArgument")]
	[SerializeField]
	private float m_FloatArgument; // 0x24
	[SerializeField]
	[FormerlySerializedAs("stringArgument")]
	private string m_StringArgument; // 0x28
	[SerializeField]
	private bool m_BoolArgument; // 0x30

	// Properties
	public Object unityObjectArgument { get; set; }
	public string unityObjectArgumentAssemblyTypeName { get; }
	public int intArgument { get; set; }
	public float floatArgument { get; set; }
	public string stringArgument { get; set; }
	public bool boolArgument { get; set; }

	// Methods

	// RVA: 0x180D270 Offset: 0x180BC70 VA: 0x18180D270
	public Object get_unityObjectArgument() { }

	// RVA: 0x2CD4110 Offset: 0x2CD2B10 VA: 0x182CD4110
	public void set_unityObjectArgument(Object value) { }

	// RVA: 0x1670E50 Offset: 0x166F850 VA: 0x181670E50
	public string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0x1263FA0 Offset: 0x12629A0 VA: 0x181263FA0
	public int get_intArgument() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_intArgument(int value) { }

	// RVA: 0x2CD4100 Offset: 0x2CD2B00 VA: 0x182CD4100
	public float get_floatArgument() { }

	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	public void set_floatArgument(float value) { }

	// RVA: 0x1E0E080 Offset: 0x1E0CA80 VA: 0x181E0E080
	public string get_stringArgument() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_stringArgument(string value) { }

	// RVA: 0x2CD40F0 Offset: 0x2CD2AF0 VA: 0x182CD40F0
	public bool get_boolArgument() { }

	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	public void set_boolArgument(bool value) { }

	// RVA: 0x2CD40C0 Offset: 0x2CD2AC0 VA: 0x182CD40C0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x2CD40C0 Offset: 0x2CD2AC0 VA: 0x182CD40C0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
