internal interface IXmlDocumentType : IXmlNode // TypeDefIndex: 11416
{
	// Properties
	[Nullable(1)]
	public abstract string Name { get; }
	public abstract string System { get; }
	public abstract string Public { get; }
	public abstract string InternalSubset { get; }

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_System();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Public();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_InternalSubset();
}
