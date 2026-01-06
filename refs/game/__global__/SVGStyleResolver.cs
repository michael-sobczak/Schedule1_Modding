internal class SVGStyleResolver // TypeDefIndex: 10312
{
	// Fields
	private List<SVGStyleResolver.StyleLayer> layers; // 0x10
	private SVGStyleSheet globalStyleSheet; // 0x18
	private Dictionary<SceneNode, SVGStyleResolver.StyleLayer> nodeLayers; // 0x20

	// Methods

	// RVA: 0x46E430 Offset: 0x46CE30 VA: 0x18046E430
	public void PushNode(XmlReaderIterator.Node node) { }

	// RVA: 0x46E370 Offset: 0x46CD70 VA: 0x18046E370
	public void PopNode() { }

	// RVA: 0x46E380 Offset: 0x46CD80 VA: 0x18046E380
	public void PushLayer(SVGStyleResolver.StyleLayer layer) { }

	// RVA: 0x46E2E0 Offset: 0x46CCE0 VA: 0x18046E2E0
	public void PopLayer() { }

	// RVA: 0x46E270 Offset: 0x46CC70 VA: 0x18046E270
	public SVGStyleResolver.StyleLayer PeekLayer() { }

	// RVA: 0x46E980 Offset: 0x46D380 VA: 0x18046E980
	public void SaveLayerForSceneNode(SceneNode node) { }

	// RVA: 0x46DCF0 Offset: 0x46C6F0 VA: 0x18046DCF0
	public SVGStyleResolver.StyleLayer GetLayerForScenNode(SceneNode node) { }

	// RVA: 0x46EA40 Offset: 0x46D440 VA: 0x18046EA40
	public void SetGlobalStyleSheet(SVGStyleSheet sheet) { }

	// RVA: 0x46DB30 Offset: 0x46C530 VA: 0x18046DB30
	public string Evaluate(string attribName, Inheritance inheritance = 0) { }

	// RVA: 0x46E140 Offset: 0x46CB40 VA: 0x18046E140
	private bool LookupStyleOrAttribute(SVGStyleResolver.StyleLayer layer, string attribName, Inheritance inheritance, out string attrib) { }

	// RVA: 0x46DE90 Offset: 0x46C890 VA: 0x18046DE90
	private bool LookupProperty(SVGStyleResolver.NodeData nodeData, string attribName, SVGStyleSheet sheet, out string val) { }

	// RVA: 0x46DD80 Offset: 0x46C780 VA: 0x18046DD80
	private bool LookupPropertyInSheet(SVGStyleSheet sheet, string attribName, string selector, out string val) { }

	[IteratorStateMachine(typeof(SVGStyleResolver.<SortedClasses>d__12))]
	// RVA: 0x46EC50 Offset: 0x46D650 VA: 0x18046EC50
	private IEnumerable<string> SortedClasses(List<string> classes) { }

	// RVA: 0x46ECE0 Offset: 0x46D6E0 VA: 0x18046ECE0
	public void .ctor() { }
}
