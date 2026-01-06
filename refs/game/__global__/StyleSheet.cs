public class StyleSheet : ScriptableObject // TypeDefIndex: 6895
{
	// Fields
	[SerializeField]
	private bool m_ImportedWithErrors; // 0x18
	[SerializeField]
	private bool m_ImportedWithWarnings; // 0x19
	[SerializeField]
	private StyleRule[] m_Rules; // 0x20
	[SerializeField]
	private StyleComplexSelector[] m_ComplexSelectors; // 0x28
	[SerializeField]
	internal float[] floats; // 0x30
	[SerializeField]
	internal Dimension[] dimensions; // 0x38
	[SerializeField]
	internal Color[] colors; // 0x40
	[SerializeField]
	internal string[] strings; // 0x48
	[SerializeField]
	internal Object[] assets; // 0x50
	[SerializeField]
	internal StyleSheet.ImportStruct[] imports; // 0x58
	[SerializeField]
	private List<StyleSheet> m_FlattenedImportedStyleSheets; // 0x60
	[SerializeField]
	private int m_ContentHash; // 0x68
	[SerializeField]
	internal ScalableImage[] scalableImages; // 0x70
	internal Dictionary<string, StyleComplexSelector> orderedNameSelectors; // 0x78
	internal Dictionary<string, StyleComplexSelector> orderedTypeSelectors; // 0x80
	internal Dictionary<string, StyleComplexSelector> orderedClassSelectors; // 0x88
	private bool m_IsDefaultStyleSheet; // 0x90
	private static string kCustomPropertyMarker; // 0x0

	// Properties
	public bool importedWithErrors { get; set; }
	public bool importedWithWarnings { get; set; }
	internal StyleRule[] rules { get; set; }
	internal StyleComplexSelector[] complexSelectors { get; set; }
	internal List<StyleSheet> flattenedRecursiveImports { get; }
	public int contentHash { get; set; }
	internal bool isDefaultStyleSheet { get; set; }

	// Methods

	// RVA: 0x2D8D6C0 Offset: 0x2D8C0C0 VA: 0x182D8D6C0
	public bool get_importedWithErrors() { }

	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000
	internal void set_importedWithErrors(bool value) { }

	// RVA: 0x2DF7FC0 Offset: 0x2DF69C0 VA: 0x182DF7FC0
	public bool get_importedWithWarnings() { }

	// RVA: 0xCD85F0 Offset: 0xCD6FF0 VA: 0x180CD85F0
	internal void set_importedWithWarnings(bool value) { }

	// RVA: 0x1E09860 Offset: 0x1E08260 VA: 0x181E09860
	internal StyleRule[] get_rules() { }

	// RVA: 0x2F05640 Offset: 0x2F04040 VA: 0x182F05640
	internal void set_rules(StyleRule[] value) { }

	// RVA: 0x1E0E080 Offset: 0x1E0CA80 VA: 0x181E0E080
	internal StyleComplexSelector[] get_complexSelectors() { }

	// RVA: 0x2F05500 Offset: 0x2F03F00 VA: 0x182F05500
	internal void set_complexSelectors(StyleComplexSelector[] value) { }

	// RVA: 0x2D0E190 Offset: 0x2D0CB90 VA: 0x182D0E190
	internal List<StyleSheet> get_flattenedRecursiveImports() { }

	// RVA: 0x2CF7FB0 Offset: 0x2CF69B0 VA: 0x182CF7FB0
	public int get_contentHash() { }

	// RVA: 0x54CF80 Offset: 0x54B980 VA: 0x18054CF80
	public void set_contentHash(int value) { }

	// RVA: 0x2F054F0 Offset: 0x2F03EF0 VA: 0x182F054F0
	internal bool get_isDefaultStyleSheet() { }

	// RVA: 0x2F05530 Offset: 0x2F03F30 VA: 0x182F05530
	internal void set_isDefaultStyleSheet(bool value) { }

	// RVA: -1 Offset: -1
	private bool TryCheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF59030 Offset: 0xF57A30 VA: 0x180F59030
	|-StyleSheet.TryCheckAccess<Color>
	|
	|-RVA: 0xF59220 Offset: 0xF57C20 VA: 0x180F59220
	|-StyleSheet.TryCheckAccess<Dimension>
	|
	|-RVA: 0xF59680 Offset: 0xF58080 VA: 0x180F59680
	|-StyleSheet.TryCheckAccess<object>
	|
	|-RVA: 0xF59870 Offset: 0xF58270 VA: 0x180F59870
	|-StyleSheet.TryCheckAccess<float>
	|
	|-RVA: 0xF59410 Offset: 0xF57E10 VA: 0x180F59410
	|-StyleSheet.TryCheckAccess<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private T CheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF582E0 Offset: 0xF56CE0 VA: 0x180F582E0
	|-StyleSheet.CheckAccess<Color>
	|
	|-RVA: 0xF584E0 Offset: 0xF56EE0 VA: 0x180F584E0
	|-StyleSheet.CheckAccess<Dimension>
	|
	|-RVA: 0xF58A10 Offset: 0xF57410 VA: 0x180F58A10
	|-StyleSheet.CheckAccess<object>
	|
	|-RVA: 0xF58C20 Offset: 0xF57620 VA: 0x180F58C20
	|-StyleSheet.CheckAccess<ScalableImage>
	|
	|-RVA: 0xF58E20 Offset: 0xF57820 VA: 0x180F58E20
	|-StyleSheet.CheckAccess<float>
	|
	|-RVA: 0xF586F0 Offset: 0xF570F0 VA: 0x180F586F0
	|-StyleSheet.CheckAccess<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2F042D0 Offset: 0x2F02CD0 VA: 0x182F042D0 Slot: 4
	internal virtual void OnEnable() { }

	// RVA: 0x2F04250 Offset: 0x2F02C50 VA: 0x182F04250
	internal void FlattenImportedStyleSheetsRecursive() { }

	// RVA: 0x2F04120 Offset: 0x2F02B20 VA: 0x182F04120
	private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet) { }

	// RVA: 0x2F049F0 Offset: 0x2F033F0 VA: 0x182F049F0
	private void SetupReferences() { }

	// RVA: 0x2DD5590 Offset: 0x2DD3F90 VA: 0x182DD5590
	internal StyleValueKeyword ReadKeyword(StyleValueHandle handle) { }

	// RVA: 0x2F044D0 Offset: 0x2F02ED0 VA: 0x182F044D0
	internal float ReadFloat(StyleValueHandle handle) { }

	// RVA: 0x2F05260 Offset: 0x2F03C60 VA: 0x182F05260
	internal bool TryReadFloat(StyleValueHandle handle, out float value) { }

	// RVA: 0x2F043C0 Offset: 0x2F02DC0 VA: 0x182F043C0
	internal Dimension ReadDimension(StyleValueHandle handle) { }

	// RVA: 0x2F05100 Offset: 0x2F03B00 VA: 0x182F05100
	internal bool TryReadDimension(StyleValueHandle handle, out Dimension value) { }

	// RVA: 0x2F04340 Offset: 0x2F02D40 VA: 0x182F04340
	internal Color ReadColor(StyleValueHandle handle) { }

	// RVA: 0x2F05090 Offset: 0x2F03A90 VA: 0x182F05090
	internal bool TryReadColor(StyleValueHandle handle, out Color value) { }

	// RVA: 0x2F04930 Offset: 0x2F03330 VA: 0x182F04930
	internal string ReadString(StyleValueHandle handle) { }

	// RVA: 0x2F053A0 Offset: 0x2F03DA0 VA: 0x182F053A0
	internal bool TryReadString(StyleValueHandle handle, out string value) { }

	// RVA: 0x2F04470 Offset: 0x2F02E70 VA: 0x182F04470
	internal string ReadEnum(StyleValueHandle handle) { }

	// RVA: 0x2F051F0 Offset: 0x2F03BF0 VA: 0x182F051F0
	internal bool TryReadEnum(StyleValueHandle handle, out string value) { }

	// RVA: 0x2F04990 Offset: 0x2F03390 VA: 0x182F04990
	internal string ReadVariable(StyleValueHandle handle) { }

	// RVA: 0x2F05410 Offset: 0x2F03E10 VA: 0x182F05410
	internal bool TryReadVariable(StyleValueHandle handle, out string value) { }

	// RVA: 0x2F04850 Offset: 0x2F03250 VA: 0x182F04850
	internal string ReadResourcePath(StyleValueHandle handle) { }

	// RVA: 0x2F05330 Offset: 0x2F03D30 VA: 0x182F05330
	internal bool TryReadResourcePath(StyleValueHandle handle, out string value) { }

	// RVA: 0x2F042E0 Offset: 0x2F02CE0 VA: 0x182F042E0
	internal Object ReadAssetReference(StyleValueHandle handle) { }

	// RVA: 0x2F047F0 Offset: 0x2F031F0 VA: 0x182F047F0
	internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle) { }

	// RVA: 0x2F05020 Offset: 0x2F03A20 VA: 0x182F05020
	internal bool TryReadAssetReference(StyleValueHandle handle, out Object value) { }

	// RVA: 0x2DD5590 Offset: 0x2DD3F90 VA: 0x182DD5590
	internal StyleValueFunction ReadFunction(StyleValueHandle handle) { }

	// RVA: 0x2F04570 Offset: 0x2F02F70 VA: 0x182F04570
	internal string ReadFunctionName(StyleValueHandle handle) { }

	// RVA: 0x2F048B0 Offset: 0x2F032B0 VA: 0x182F048B0
	internal ScalableImage ReadScalableImage(StyleValueHandle handle) { }

	// RVA: 0x2F04050 Offset: 0x2F02A50 VA: 0x182F04050
	private static bool CustomStartsWith(string originalString, string pattern) { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	public void .ctor() { }

	// RVA: 0x2F05480 Offset: 0x2F03E80 VA: 0x182F05480
	private static void .cctor() { }
}
