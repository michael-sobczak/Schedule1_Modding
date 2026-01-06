public sealed class BinaryFormatter // TypeDefIndex: 4492
{
	// Fields
	internal ISurrogateSelector m_surrogates; // 0x10
	internal StreamingContext m_context; // 0x18
	internal SerializationBinder m_binder; // 0x28
	internal FormatterTypeStyle m_typeFormat; // 0x30
	internal FormatterAssemblyStyle m_assemblyFormat; // 0x34
	internal TypeFilterLevel m_securityLevel; // 0x38
	internal object[] m_crossAppDomainArray; // 0x40
	private static Dictionary<Type, TypeInformation> typeNameCache; // 0x0

	// Properties
	public FormatterAssemblyStyle AssemblyFormat { set; }
	public ISurrogateSelector SurrogateSelector { set; }

	// Methods

	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0 Slot: 4
	public void set_SurrogateSelector(ISurrogateSelector value) { }

	// RVA: 0x1B44F40 Offset: 0x1B43940 VA: 0x181B44F40
	public void .ctor() { }

	// RVA: 0x1B44FB0 Offset: 0x1B439B0 VA: 0x181B44FB0
	public void .ctor(ISurrogateSelector selector, StreamingContext context) { }

	// RVA: 0x1B44860 Offset: 0x1B43260 VA: 0x181B44860 Slot: 5
	public object Deserialize(Stream serializationStream) { }

	// RVA: 0x1B44510 Offset: 0x1B42F10 VA: 0x181B44510
	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	// RVA: 0x1B44840 Offset: 0x1B43240 VA: 0x181B44840 Slot: 6
	public object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	// RVA: 0x1B44E90 Offset: 0x1B43890 VA: 0x181B44E90 Slot: 7
	public void Serialize(Stream serializationStream, object graph) { }

	// RVA: 0x1B44AF0 Offset: 0x1B434F0 VA: 0x181B44AF0 Slot: 8
	public void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	// RVA: 0x1B44B10 Offset: 0x1B43510 VA: 0x181B44B10
	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	// RVA: 0x1B44880 Offset: 0x1B43280 VA: 0x181B44880
	internal static TypeInformation GetTypeInformation(Type type) { }

	// RVA: 0x1B44EB0 Offset: 0x1B438B0 VA: 0x181B44EB0
	private static void .cctor() { }
}
