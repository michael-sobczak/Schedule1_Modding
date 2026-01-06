public class XmlSerializerFactory // TypeDefIndex: 8207
{
	// Fields
	private static Hashtable serializersBySource; // 0x0

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x2571DF0 Offset: 0x25707F0 VA: 0x182571DF0
	public XmlSerializer CreateSerializer(Type type) { }

	// RVA: 0x2571E20 Offset: 0x2570820 VA: 0x182571E20
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	// RVA: 0x2571A30 Offset: 0x2570430 VA: 0x182571A30
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x2571E50 Offset: 0x2570850 VA: 0x182571E50
	private static void .cctor() { }
}
