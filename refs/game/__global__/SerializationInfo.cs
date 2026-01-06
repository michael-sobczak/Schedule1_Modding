public sealed class SerializationInfo // TypeDefIndex: 4451
{
	// Fields
	private const int defaultSize = 4;
	private const string s_mscorlibAssemblySimpleName = "mscorlib";
	private const string s_mscorlibFileName = "mscorlib.dll";
	internal string[] m_members; // 0x10
	internal object[] m_data; // 0x18
	internal Type[] m_types; // 0x20
	private Dictionary<string, int> m_nameToIndex; // 0x28
	internal int m_currMember; // 0x30
	internal IFormatterConverter m_converter; // 0x38
	private string m_fullTypeName; // 0x40
	private string m_assemName; // 0x48
	private Type objectType; // 0x50
	private bool isFullTypeNameSetExplicit; // 0x58
	private bool isAssemblyNameSetExplicit; // 0x59
	private bool requireSameTokenInPartialTrust; // 0x5A

	// Properties
	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x1B591A0 Offset: 0x1B57BA0 VA: 0x181B591A0
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliant(False)]
	// RVA: 0x1B591C0 Offset: 0x1B57BC0 VA: 0x181B591C0
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_FullTypeName() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_AssemblyName() { }

	// RVA: 0x1B58E20 Offset: 0x1B57820 VA: 0x181B58E20
	public void SetType(Type type) { }

	// RVA: 0x1B57B70 Offset: 0x1B56570 VA: 0x181B57B70
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x1B57BF0 Offset: 0x1B565F0 VA: 0x181B57BF0
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x1B58C80 Offset: 0x1B57680 VA: 0x181B58C80
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public int get_MemberCount() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Type get_ObjectType() { }

	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0x79D110 Offset: 0x79BB10 VA: 0x18079D110
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x1B58260 Offset: 0x1B56C60 VA: 0x181B58260
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x1B57C00 Offset: 0x1B56600 VA: 0x181B57C00
	private void ExpandArrays() { }

	// RVA: 0x1B56DA0 Offset: 0x1B557A0 VA: 0x181B56DA0
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x1B56FC0 Offset: 0x1B559C0 VA: 0x181B56FC0
	public void AddValue(string name, object value) { }

	// RVA: 0x1B57A10 Offset: 0x1B56410 VA: 0x181B57A10
	public void AddValue(string name, bool value) { }

	// RVA: 0x1B57330 Offset: 0x1B55D30 VA: 0x181B57330
	public void AddValue(string name, byte value) { }

	// RVA: 0x1B57490 Offset: 0x1B55E90 VA: 0x181B57490
	public void AddValue(string name, short value) { }

	// RVA: 0x1B57750 Offset: 0x1B56150 VA: 0x181B57750
	public void AddValue(string name, int value) { }

	// RVA: 0x1B56E60 Offset: 0x1B55860 VA: 0x181B56E60
	public void AddValue(string name, long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1B578B0 Offset: 0x1B562B0 VA: 0x181B578B0
	public void AddValue(string name, ulong value) { }

	// RVA: 0x1B571C0 Offset: 0x1B55BC0 VA: 0x181B571C0
	public void AddValue(string name, float value) { }

	// RVA: 0x1B575F0 Offset: 0x1B55FF0 VA: 0x181B575F0
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x1B56AA0 Offset: 0x1B554A0 VA: 0x181B56AA0
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x1B58FE0 Offset: 0x1B579E0 VA: 0x181B58FE0
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x1B57D10 Offset: 0x1B56710 VA: 0x181B57D10
	private int FindElement(string name) { }

	// RVA: 0x1B58090 Offset: 0x1B56A90 VA: 0x181B58090
	private object GetElement(string name, out Type foundType) { }

	[ComVisible(True)]
	// RVA: 0x1B57F40 Offset: 0x1B56940 VA: 0x181B57F40
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x1B58AA0 Offset: 0x1B574A0 VA: 0x181B58AA0
	public object GetValue(string name, Type type) { }

	[ComVisible(True)]
	// RVA: 0x1B588C0 Offset: 0x1B572C0 VA: 0x181B588C0
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x1B57DD0 Offset: 0x1B567D0 VA: 0x181B57DD0
	public bool GetBoolean(string name) { }

	// RVA: 0x1B58300 Offset: 0x1B56D00 VA: 0x181B58300
	public int GetInt32(string name) { }

	// RVA: 0x1B58470 Offset: 0x1B56E70 VA: 0x181B58470
	public long GetInt64(string name) { }

	// RVA: 0x1B585E0 Offset: 0x1B56FE0 VA: 0x181B585E0
	public float GetSingle(string name) { }

	// RVA: 0x1B58750 Offset: 0x1B57150 VA: 0x181B58750
	public string GetString(string name) { }
}
