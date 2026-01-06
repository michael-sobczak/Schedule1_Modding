public abstract class XObject : IXmlLineInfo // TypeDefIndex: 18637
{
	// Fields
	internal XContainer parent; // 0x10
	internal object annotations; // 0x18

	// Properties
	public string BaseUri { get; }
	public abstract XmlNodeType NodeType { get; }
	public XElement Parent { get; }
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }
	internal bool HasBaseUri { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x23CB570 Offset: 0x23C9F70 VA: 0x1823CB570
	public string get_BaseUri() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x23CB630 Offset: 0x23CA030 VA: 0x1823CB630
	public XElement get_Parent() { }

	// RVA: 0x23CABD0 Offset: 0x23C95D0 VA: 0x1823CABD0
	public void AddAnnotation(object annotation) { }

	// RVA: 0x23CAE90 Offset: 0x23C9890 VA: 0x1823CAE90
	private object AnnotationForSealedType(Type type) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7E170 Offset: 0xF7CB70 VA: 0x180F7E170
	|-XObject.Annotation<object>
	*/

	// RVA: 0x23CB490 Offset: 0x23C9E90 VA: 0x1823CB490 Slot: 4
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x23CB4D0 Offset: 0x23C9ED0 VA: 0x1823CB4D0 Slot: 5
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x23CB520 Offset: 0x23C9F20 VA: 0x1823CB520 Slot: 6
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x23CB5F0 Offset: 0x23C9FF0 VA: 0x1823CB5F0
	internal bool get_HasBaseUri() { }

	// RVA: 0x23CB1C0 Offset: 0x23C9BC0 VA: 0x1823CB1C0
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x23CB270 Offset: 0x23C9C70 VA: 0x1823CB270
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x23CB320 Offset: 0x23C9D20 VA: 0x1823CB320
	internal void SetBaseUri(string baseUri) { }

	// RVA: 0x23CB3A0 Offset: 0x23C9DA0 VA: 0x1823CB3A0
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x23CB420 Offset: 0x23C9E20 VA: 0x1823CB420
	internal bool SkipNotify() { }

	// RVA: 0x23CAFD0 Offset: 0x23C99D0 VA: 0x1823CAFD0
	internal SaveOptions GetSaveOptionsFromAnnotations() { }
}
