public class SoapServices // TypeDefIndex: 4295
{
	// Fields
	private static Hashtable _xmlTypes; // 0x0
	private static Hashtable _xmlElements; // 0x8
	private static Hashtable _soapActions; // 0x10
	private static Hashtable _soapActionsMethods; // 0x18
	private static Hashtable _typeInfos; // 0x20

	// Properties
	public static string XmlNsForClrTypeWithAssembly { get; }
	public static string XmlNsForClrTypeWithNs { get; }
	public static string XmlNsForClrTypeWithNsAndAssembly { get; }

	// Methods

	// RVA: 0x1B1D140 Offset: 0x1B1BB40 VA: 0x181B1D140
	public static string get_XmlNsForClrTypeWithAssembly() { }

	// RVA: 0x1B1D1A0 Offset: 0x1B1BBA0 VA: 0x181B1D1A0
	public static string get_XmlNsForClrTypeWithNs() { }

	// RVA: 0x1B1D170 Offset: 0x1B1BB70 VA: 0x181B1D170
	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	// RVA: 0x1B1BDD0 Offset: 0x1B1A7D0 VA: 0x181B1BDD0
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	// RVA: 0x1B1C1A0 Offset: 0x1B1ABA0 VA: 0x181B1C1A0
	private static string GetNameKey(string name, string namspace) { }

	// RVA: 0x1B1C030 Offset: 0x1B1AA30 VA: 0x181B1C030
	private static string GetAssemblyName(MethodBase mb) { }

	// RVA: 0x1B1C200 Offset: 0x1B1AC00 VA: 0x181B1C200
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	// RVA: 0x1B1C310 Offset: 0x1B1AD10 VA: 0x181B1C310
	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	// RVA: 0x1B1C3C0 Offset: 0x1B1ADC0 VA: 0x181B1C3C0
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	// RVA: 0x1B1C470 Offset: 0x1B1AE70 VA: 0x181B1C470
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	// RVA: 0x1B1CBE0 Offset: 0x1B1B5E0 VA: 0x181B1CBE0
	public static void PreLoad(Assembly assembly) { }

	// RVA: 0x1B1C560 Offset: 0x1B1AF60 VA: 0x181B1C560
	public static void PreLoad(Type type) { }

	// RVA: 0x1B1CCA0 Offset: 0x1B1B6A0 VA: 0x181B1CCA0
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	// RVA: 0x1B1CE30 Offset: 0x1B1B830 VA: 0x181B1CE30
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

	// RVA: 0x1B1BF60 Offset: 0x1B1A960 VA: 0x181B1BF60
	private static string EncodeNs(string ns) { }

	// RVA: 0x1B1CFB0 Offset: 0x1B1B9B0 VA: 0x181B1CFB0
	private static void .cctor() { }
}
