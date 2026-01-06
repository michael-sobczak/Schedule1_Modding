internal class SVGAttribParser // TypeDefIndex: 10316
{
	// Fields
	private LinkedList<BezierSegment> currentContour; // 0x10
	private List<BezierContour> contours; // 0x18
	private Vector2 penPos; // 0x20
	private string attribString; // 0x28
	private char pathCommand; // 0x30
	private Matrix2D transform; // 0x34
	private IFill fill; // 0x50
	private string attribName; // 0x58
	private int stringPos; // 0x60
	private static NamedWebColorDictionary namedColors; // 0x0

	// Methods

	// RVA: 0x459430 Offset: 0x457E30 VA: 0x180459430
	public static List<BezierContour> ParsePath(XmlReaderIterator.Node node) { }

	// RVA: 0x4598B0 Offset: 0x4582B0 VA: 0x1804598B0
	public static Matrix2D ParseTransform(XmlReaderIterator.Node node) { }

	// RVA: 0x459920 Offset: 0x458320 VA: 0x180459920
	public static Matrix2D ParseTransform(XmlReaderIterator.Node node, string attribName) { }

	// RVA: 0x4593A0 Offset: 0x457DA0 VA: 0x1804593A0
	public static IFill ParseFill(XmlReaderIterator.Node node, SVGDictionary dict, SVGPostponedFills postponedFills, SVGStyleResolver styles, Inheritance inheritance = 1) { }

	// RVA: 0x4590C0 Offset: 0x457AC0 VA: 0x1804590C0
	public static IFill ParseFill(XmlReaderIterator.Node node, SVGDictionary dict, SVGPostponedFills postponedFills, SVGStyleResolver styles, Inheritance inheritance, out bool isDefaultFill) { }

	// RVA: 0x459680 Offset: 0x458080 VA: 0x180459680
	public static Stroke ParseStrokeAndOpacity(XmlReaderIterator.Node node, SVGDictionary dict, SVGStyleResolver styles, Inheritance inheritance = 1) { }

	// RVA: 0x458AD0 Offset: 0x4574D0 VA: 0x180458AD0
	public static Color ParseColor(string colorString) { }

	// RVA: 0x459AE0 Offset: 0x4584E0 VA: 0x180459AE0
	public static string ParseURLRef(string url) { }

	// RVA: 0x459560 Offset: 0x457F60 VA: 0x180459560
	public static object ParseRelativeRef(string iri, SVGDictionary dict) { }

	// RVA: 0x457E20 Offset: 0x456820 VA: 0x180457E20
	public static string CleanIri(string iri) { }

	// RVA: 0x45AF40 Offset: 0x459940 VA: 0x18045AF40
	private void .ctor(string attrib, SVGAttribParser.AttribPath attribPath) { }

	// RVA: 0x459E20 Offset: 0x458820 VA: 0x180459E20
	private void .ctor(string attrib, string attribNameVal, SVGAttribParser.AttribTransform attribTransform) { }

	// RVA: 0x45A8E0 Offset: 0x4592E0 VA: 0x18045A8E0
	private void .ctor(string attrib, string attribName, float opacity, FillMode mode, SVGDictionary dict, SVGPostponedFills postponedFills, bool allowReference = True) { }

	// RVA: 0x457F00 Offset: 0x456900 VA: 0x180457F00
	private void ConcludePath(bool joinEnds) { }

	// RVA: 0x458A60 Offset: 0x457460 VA: 0x180458A60
	private Vector2 NextVector2(bool relative = False) { }

	// RVA: 0x4583E0 Offset: 0x456DE0 VA: 0x1804583E0
	private float NextFloat() { }

	// RVA: 0x4593D0 Offset: 0x457DD0 VA: 0x1804593D0
	internal static float ParseFloat(string s) { }

	// RVA: 0x458360 Offset: 0x456D60 VA: 0x180458360
	private bool NextBool() { }

	// RVA: 0x458720 Offset: 0x457120 VA: 0x180458720
	private char NextPathCommand(bool noCommandInheritance = False) { }

	// RVA: 0x458890 Offset: 0x457290 VA: 0x180458890
	private string NextStringCommand() { }

	// RVA: 0x459BD0 Offset: 0x4585D0 VA: 0x180459BD0
	private void SkipSymbol(char s) { }

	// RVA: 0x459B70 Offset: 0x458570 VA: 0x180459B70
	private bool PeekSymbol(char s) { }

	// RVA: 0x459DA0 Offset: 0x4587A0 VA: 0x180459DA0
	private void SkipWhitespaces() { }
}
