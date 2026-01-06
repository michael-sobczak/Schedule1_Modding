internal class SVGDocument // TypeDefIndex: 10306
{
	// Fields
	internal const float SVGLengthFactor = 1.4142135;
	private static char[] whiteSpaceNumberChars; // 0x0
	private XmlReaderIterator docReader; // 0x10
	private Scene scene; // 0x18
	private float dpiScale; // 0x20
	private int windowWidth; // 0x24
	private int windowHeight; // 0x28
	private Vector2 scenePos; // 0x2C
	private Vector2 sceneSize; // 0x34
	private SVGDictionary svgObjects; // 0x40
	private Dictionary<string, SVGDocument.Handlers> subTags; // 0x48
	private Dictionary<GradientFill, SVGDocument.GradientExData> gradientExInfo; // 0x50
	private Dictionary<SceneNode, SVGDocument.ViewBoxInfo> symbolViewBoxes; // 0x58
	private Dictionary<SceneNode, SVGDocument.NodeGlobalSceneState> nodeGlobalSceneState; // 0x60
	private Dictionary<SceneNode, float> nodeOpacity; // 0x68
	private Dictionary<string, SceneNode> nodeIDs; // 0x70
	private Dictionary<SceneNode, SVGStyleResolver.StyleLayer> nodeStyleLayers; // 0x78
	private Dictionary<SceneNode, SVGDocument.ClipData> clipData; // 0x80
	private Dictionary<SceneNode, SVGDocument.PatternData> patternData; // 0x88
	private Dictionary<SceneNode, SVGDocument.MaskData> maskData; // 0x90
	private Dictionary<string, List<SVGDocument.NodeReferenceData>> postponedSymbolData; // 0x98
	private Dictionary<string, List<SVGDocument.PostponedStopData>> postponedStopData; // 0xA0
	private Dictionary<string, List<SVGDocument.PostponedClip>> postponedClip; // 0xA8
	private SVGPostponedFills postponedFills; // 0xB0
	private List<SVGDocument.NodeWithParent> invisibleNodes; // 0xB8
	private Stack<Vector2> currentContainerSize; // 0xC0
	private Stack<Vector2> currentViewBoxSize; // 0xC8
	private Stack<SceneNode> currentSceneNode; // 0xD0
	private GradientFill currentGradientFill; // 0xD8
	private string currentGradientId; // 0xE0
	private string currentGradientLink; // 0xE8
	private SVGDocument.ElemHandler[] allElems; // 0xF0
	private HashSet<SVGDocument.ElemHandler> elemsToAddToHierarchy; // 0xF8
	private SVGStyleResolver styles; // 0x100
	private bool applyRootViewBox; // 0x108
	internal Rect sceneViewport; // 0x10C

	// Properties
	public Dictionary<SceneNode, float> NodeOpacities { get; }
	public Dictionary<string, SceneNode> NodeIDs { get; }
	internal static string StockBlackNonZeroFillName { get; }
	internal static string StockBlackOddEvenFillName { get; }

	// Methods

	// RVA: 0x463600 Offset: 0x462000 VA: 0x180463600
	public void .ctor(XmlReader docReader, float dpi, Scene scene, int windowWidth, int windowHeight, bool applyRootViewBox) { }

	// RVA: 0x4608E0 Offset: 0x45F2E0 VA: 0x1804608E0
	public void Import() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public Dictionary<SceneNode, float> get_NodeOpacities() { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public Dictionary<string, SceneNode> get_NodeIDs() { }

	// RVA: 0x4663E0 Offset: 0x464DE0 VA: 0x1804663E0
	internal static string get_StockBlackNonZeroFillName() { }

	// RVA: 0x466410 Offset: 0x464E10 VA: 0x180466410
	internal static string get_StockBlackOddEvenFillName() { }

	// RVA: 0x460AF0 Offset: 0x45F4F0 VA: 0x180460AF0
	private void ParseChildren(XmlReaderIterator.Node node, string nodeName) { }

	// RVA: 0x464FF0 Offset: 0x4639F0 VA: 0x180464FF0
	private void circle() { }

	// RVA: 0x4659B0 Offset: 0x4643B0 VA: 0x1804659B0
	private void defs() { }

	// RVA: 0x465BE0 Offset: 0x4645E0 VA: 0x180465BE0
	private void ellipse() { }

	// RVA: 0x4661F0 Offset: 0x464BF0 VA: 0x1804661F0
	private void g() { }

	// RVA: 0x466440 Offset: 0x464E40 VA: 0x180466440
	private void image() { }

	// RVA: 0x467050 Offset: 0x465A50 VA: 0x180467050
	private void line() { }

	// RVA: 0x467690 Offset: 0x466090 VA: 0x180467690
	private void linearGradient() { }

	// RVA: 0x468480 Offset: 0x466E80 VA: 0x180468480
	private void path() { }

	// RVA: 0x468F30 Offset: 0x467930 VA: 0x180468F30
	private void polygon() { }

	// RVA: 0x4699D0 Offset: 0x4683D0 VA: 0x1804699D0
	private void polyline() { }

	// RVA: 0x46A420 Offset: 0x468E20 VA: 0x18046A420
	private void radialGradient() { }

	// RVA: 0x465570 Offset: 0x463F70 VA: 0x180465570
	private void clipPath() { }

	// RVA: 0x4688A0 Offset: 0x4672A0 VA: 0x1804688A0
	private void pattern() { }

	// RVA: 0x4680D0 Offset: 0x466AD0 VA: 0x1804680D0
	private void mask() { }

	// RVA: 0x46AEC0 Offset: 0x4698C0 VA: 0x18046AEC0
	private void rect() { }

	// RVA: 0x46B650 Offset: 0x46A050 VA: 0x18046B650
	private void stop() { }

	// RVA: 0x46BE70 Offset: 0x46A870 VA: 0x18046BE70
	private void svg() { }

	// RVA: 0x46C2D0 Offset: 0x46ACD0 VA: 0x18046C2D0
	private void symbol() { }

	// RVA: 0x46C8A0 Offset: 0x46B2A0 VA: 0x18046C8A0
	private void use() { }

	// RVA: 0x46BC90 Offset: 0x46A690 VA: 0x18046BC90
	private void style() { }

	// RVA: 0x4628D0 Offset: 0x4612D0 VA: 0x1804628D0
	private void ResolveReferencedNode(SceneNode referencedNode, SVGDocument.NodeReferenceData refData, bool isDeferred) { }

	// RVA: 0x45FE60 Offset: 0x45E860 VA: 0x18045FE60
	private SceneNode CloneSceneNode(SceneNode node) { }

	// RVA: 0x460410 Offset: 0x45EE10 VA: 0x180460410
	private Shape CloneShape(Shape shape) { }

	// RVA: 0x45F6B0 Offset: 0x45E0B0 VA: 0x18045F6B0
	private BezierContour CloneContour(BezierContour c) { }

	// RVA: 0x45F7D0 Offset: 0x45E1D0 VA: 0x18045F7D0
	private IFill CloneFill(IFill fill) { }

	// RVA: 0x45FC80 Offset: 0x45E680 VA: 0x18045FC80
	private PathProperties ClonePathProps(PathProperties props) { }

	// RVA: 0x45FBD0 Offset: 0x45E5D0 VA: 0x18045FBD0
	private GradientFill CloneGradientFill(GradientFill other) { }

	// RVA: 0x45EF20 Offset: 0x45D920 VA: 0x18045EF20
	private int AttribIntVal(string attribName) { }

	// RVA: 0x45EF60 Offset: 0x45D960 VA: 0x18045EF60
	private int AttribIntVal(string attribName, int defaultVal) { }

	// RVA: 0x45EE60 Offset: 0x45D860 VA: 0x18045EE60
	private float AttribFloatVal(string attribName) { }

	// RVA: 0x45EE70 Offset: 0x45D870 VA: 0x18045EE70
	private float AttribFloatVal(string attribName, float defaultVal) { }

	// RVA: 0x45EFB0 Offset: 0x45D9B0 VA: 0x18045EFB0
	private float AttribLengthVal(XmlReaderIterator.Node node, string attribName, SVGDocument.DimType dimType) { }

	// RVA: 0x45F630 Offset: 0x45E030 VA: 0x18045F630
	private float AttribLengthVal(XmlReaderIterator.Node node, string attribName, float defaultUnitVal, SVGDocument.DimType dimType) { }

	// RVA: 0x45F030 Offset: 0x45DA30 VA: 0x18045F030
	private float AttribLengthVal(string val, XmlReaderIterator.Node node, string attribName, float defaultUnitVal, SVGDocument.DimType dimType) { }

	// RVA: 0x45C0A0 Offset: 0x45AAA0 VA: 0x18045C0A0
	private void AddToSVGDictionaryIfPossible(XmlReaderIterator.Node node, object vectorElement) { }

	// RVA: 0x4625A0 Offset: 0x460FA0 VA: 0x1804625A0
	private Rect ParseViewport(XmlReaderIterator.Node node, SceneNode sceneNode, Vector2 defaultViewportSize) { }

	// RVA: 0x4622B0 Offset: 0x460CB0 VA: 0x1804622B0
	private SVGDocument.ViewBoxInfo ParseViewBox(XmlReaderIterator.Node node, SceneNode sceneNode, Rect sceneViewport) { }

	// RVA: 0x461D90 Offset: 0x460790 VA: 0x180461D90
	private void ParseViewBoxAspectRatio(XmlReaderIterator.Node node, ref SVGDocument.ViewBoxInfo viewBoxInfo) { }

	// RVA: 0x45EA10 Offset: 0x45D410 VA: 0x18045EA10
	private void ApplyViewBox(SceneNode sceneNode, SVGDocument.ViewBoxInfo viewBoxInfo, Rect sceneViewport) { }

	// RVA: 0x461850 Offset: 0x460250 VA: 0x180461850
	private Stroke ParseStrokeAttributeSet(XmlReaderIterator.Node node, out PathCorner strokeCorner, out PathEnding strokeEnding, Inheritance inheritance = 1) { }

	// RVA: 0x4612D0 Offset: 0x45FCD0 VA: 0x1804612D0
	private void ParseID(XmlReaderIterator.Node node, SceneNode sceneNode) { }

	// RVA: 0x4617B0 Offset: 0x4601B0 VA: 0x1804617B0
	private float ParseOpacity(SceneNode sceneNode) { }

	// RVA: 0x460F50 Offset: 0x45F950 VA: 0x180460F50
	private void ParseClipAndMask(XmlReaderIterator.Node node, SceneNode sceneNode) { }

	// RVA: 0x460F90 Offset: 0x45F990 VA: 0x180460F90
	private void ParseClip(XmlReaderIterator.Node node, SceneNode sceneNode) { }

	// RVA: 0x45E7E0 Offset: 0x45D1E0 VA: 0x18045E7E0
	private void ApplyClipper(SceneNode clipper, SceneNode target, bool worldRelative) { }

	// RVA: 0x461420 Offset: 0x45FE20 VA: 0x180461420
	private void ParseMask(XmlReaderIterator.Node node, SceneNode sceneNode) { }

	// RVA: 0x460740 Offset: 0x45F140 VA: 0x180460740
	private Texture2D DecodeTextureData(string dataURI) { }

	// RVA: 0x462790 Offset: 0x461190 VA: 0x180462790
	private void PostProcess(SceneNode root) { }

	// RVA: 0x45C150 Offset: 0x45AB50 VA: 0x18045C150
	private void AdjustFills(SceneNode root) { }

	// RVA: 0x45CC20 Offset: 0x45B620 VA: 0x18045CC20
	private void AdjustGradientFill(SceneNode node, Matrix2D worldTransform, IFill fill, BezierContour[] contours, ref Matrix2D computedTransform) { }

	// RVA: 0x45DBD0 Offset: 0x45C5D0 VA: 0x18045DBD0
	private SceneNode AdjustPatternFill(SceneNode node, Matrix2D worldTransform, Shape shape) { }

	// RVA: 0x4627A0 Offset: 0x4611A0 VA: 0x1804627A0
	private void RemoveInvisibleNodes() { }

	// RVA: 0x4633D0 Offset: 0x461DD0 VA: 0x1804633D0
	private bool ShouldDeclareSupportedChildren(XmlReaderIterator.Node node) { }

	// RVA: 0x463430 Offset: 0x461E30 VA: 0x180463430
	private void SupportElems(XmlReaderIterator.Node node, SVGDocument.ElemHandler[] handlers) { }

	// RVA: 0x463590 Offset: 0x461F90 VA: 0x180463590
	private static void .cctor() { }
}
