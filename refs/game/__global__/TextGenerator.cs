public sealed class TextGenerator : IDisposable // TypeDefIndex: 19026
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private string m_LastString; // 0x18
	private TextGenerationSettings m_LastSettings; // 0x20
	private bool m_HasGenerated; // 0x80
	private TextGenerationError m_LastValid; // 0x84
	private readonly List<UIVertex> m_Verts; // 0x88
	private readonly List<UICharInfo> m_Characters; // 0x90
	private readonly List<UILineInfo> m_Lines; // 0x98
	private bool m_CachedVerts; // 0xA0
	private bool m_CachedCharacters; // 0xA1
	private bool m_CachedLines; // 0xA2

	// Properties
	public int characterCountVisible { get; }
	public IList<UIVertex> verts { get; }
	public IList<UICharInfo> characters { get; }
	public IList<UILineInfo> lines { get; }
	public Rect rectExtents { get; }
	public int characterCount { get; }
	public int lineCount { get; }

	// Methods

	// RVA: 0x2D8B940 Offset: 0x2D8A340 VA: 0x182D8B940
	public void .ctor() { }

	// RVA: 0x2D8B7E0 Offset: 0x2D8A1E0 VA: 0x182D8B7E0
	public void .ctor(int initialCapacity) { }

	// RVA: 0x2D8A260 Offset: 0x2D88C60 VA: 0x182D8A260 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2D8B460 Offset: 0x2D89E60 VA: 0x182D8B460 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2D8BA90 Offset: 0x2D8A490 VA: 0x182D8BA90
	public int get_characterCountVisible() { }

	// RVA: 0x2D8B4C0 Offset: 0x2D89EC0 VA: 0x182D8B4C0
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x2D8A5F0 Offset: 0x2D88FF0 VA: 0x182D8A5F0
	public void Invalidate() { }

	// RVA: 0x2D8A340 Offset: 0x2D88D40 VA: 0x182D8A340
	public void GetCharacters(List<UICharInfo> characters) { }

	// RVA: 0x2D8A390 Offset: 0x2D88D90 VA: 0x182D8A390
	public void GetLines(List<UILineInfo> lines) { }

	// RVA: 0x2D8A530 Offset: 0x2D88F30 VA: 0x182D8A530
	public void GetVertices(List<UIVertex> vertices) { }

	// RVA: 0x2D8A480 Offset: 0x2D88E80 VA: 0x182D8A480
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x2D8A3E0 Offset: 0x2D88DE0 VA: 0x182D8A3E0
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x2D8ADA0 Offset: 0x2D897A0 VA: 0x182D8ADA0
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x2D8B400 Offset: 0x2D89E00 VA: 0x182D8B400
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x2D8A980 Offset: 0x2D89380 VA: 0x182D8A980
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x2D8A600 Offset: 0x2D89000 VA: 0x182D8A600
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x2D8BCD0 Offset: 0x2D8A6D0 VA: 0x182D8BCD0
	public IList<UIVertex> get_verts() { }

	// RVA: 0x2D8BB10 Offset: 0x2D8A510 VA: 0x182D8BB10
	public IList<UICharInfo> get_characters() { }

	// RVA: 0x2D8BBC0 Offset: 0x2D8A5C0 VA: 0x182D8BBC0
	public IList<UILineInfo> get_lines() { }

	// RVA: 0x2D8BC80 Offset: 0x2D8A680 VA: 0x182D8BC80
	public Rect get_rectExtents() { }

	// RVA: 0x2D8BAD0 Offset: 0x2D8A4D0 VA: 0x182D8BAD0
	public int get_characterCount() { }

	// RVA: 0x2D8BB80 Offset: 0x2D8A580 VA: 0x182D8BB80
	public int get_lineCount() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2D8A580 Offset: 0x2D88F80 VA: 0x182D8A580
	private static IntPtr Internal_Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2D8A5B0 Offset: 0x2D88FB0 VA: 0x182D8A5B0
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x2D8B280 Offset: 0x2D89C80 VA: 0x182D8B280
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x2D8B080 Offset: 0x2D89A80 VA: 0x182D8B080
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[NativeThrows]
	// RVA: 0x2D8A530 Offset: 0x2D88F30 VA: 0x182D8A530
	private void GetVerticesInternal(object vertices) { }

	[NativeThrows]
	// RVA: 0x2D8A340 Offset: 0x2D88D40 VA: 0x182D8A340
	private void GetCharactersInternal(object characters) { }

	[NativeThrows]
	// RVA: 0x2D8A390 Offset: 0x2D88D90 VA: 0x182D8A390
	private void GetLinesInternal(object lines) { }

	// RVA: 0x2D8BC30 Offset: 0x2D8A630 VA: 0x182D8BC30
	private void get_rectExtents_Injected(out Rect ret) { }

	// RVA: 0x2D8AFC0 Offset: 0x2D899C0 VA: 0x182D8AFC0
	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }
}
