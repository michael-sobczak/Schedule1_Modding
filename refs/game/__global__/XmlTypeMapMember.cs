internal class XmlTypeMapMember // TypeDefIndex: 8213
{
	// Fields
	private string _name; // 0x10
	private int _index; // 0x18
	private int _globalIndex; // 0x1C
	private int _specifiedGlobalIndex; // 0x20
	private TypeData _typeData; // 0x28
	private MemberInfo _member; // 0x30
	private MemberInfo _specifiedMember; // 0x38
	private MethodInfo _shouldSerialize; // 0x40
	private object _defaultValue; // 0x48
	private int _flags; // 0x50

	// Properties
	public string Name { get; set; }
	public object DefaultValue { get; set; }
	public TypeData TypeData { get; set; }
	public int Index { get; set; }
	public int GlobalIndex { get; set; }
	public bool IsOptionalValueType { get; set; }
	public bool IsReturnValue { get; set; }

	// Methods

	// RVA: 0x2575330 Offset: 0x2573D30 VA: 0x182575330
	public void .ctor() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Name() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Name(string value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public object get_DefaultValue() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_DefaultValue(object value) { }

	// RVA: 0x2574BA0 Offset: 0x25735A0 VA: 0x182574BA0
	public bool IsReadOnly(Type type) { }

	// RVA: 0x2574730 Offset: 0x2573130 VA: 0x182574730
	public static object GetValue(object ob, string name) { }

	// RVA: 0x25745C0 Offset: 0x2572FC0 VA: 0x1825745C0
	public object GetValue(object ob) { }

	// RVA: 0x2574FD0 Offset: 0x25739D0 VA: 0x182574FD0
	public void SetValue(object ob, object value) { }

	// RVA: 0x2575170 Offset: 0x2573B70 VA: 0x182575170
	public static void SetValue(object ob, string name, object value) { }

	// RVA: 0x25748D0 Offset: 0x25732D0 VA: 0x1825748D0
	private void InitMember(Type type) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public TypeData get_TypeData() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_TypeData(TypeData value) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Index() { }

	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_Index(int value) { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_GlobalIndex() { }

	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	public void set_GlobalIndex(int value) { }

	// RVA: 0x1B39DD0 Offset: 0x1B387D0 VA: 0x181B39DD0
	public bool get_IsOptionalValueType() { }

	// RVA: 0x25753B0 Offset: 0x2573DB0 VA: 0x1825753B0
	public void set_IsOptionalValueType(bool value) { }

	// RVA: 0x1B39DB0 Offset: 0x1B387B0 VA: 0x181B39DB0
	public bool get_IsReturnValue() { }

	// RVA: 0x25753E0 Offset: 0x2573DE0 VA: 0x1825753E0
	public void set_IsReturnValue(bool value) { }

	// RVA: 0x2574250 Offset: 0x2572C50 VA: 0x182574250
	public void CheckOptionalValueType(Type type) { }

	// RVA: 0x25742D0 Offset: 0x2572CD0 VA: 0x1825742D0
	public bool GetValueSpecified(object ob) { }

	// RVA: 0x2574C80 Offset: 0x2573680 VA: 0x182574C80
	public void SetValueSpecified(object ob, bool value) { }
}
