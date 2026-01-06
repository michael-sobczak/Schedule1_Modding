public class VisualTreeAsset : ScriptableObject // TypeDefIndex: 7012
{
	// Fields
	internal static string LinkedVEAInTemplatePropertyName; // 0x0
	[SerializeField]
	private bool m_ImportedWithErrors; // 0x18
	[SerializeField]
	private bool m_ImportedWithWarnings; // 0x19
	private static readonly Dictionary<string, VisualElement> s_TemporarySlotInsertionPoints; // 0x8
	[SerializeField]
	private List<VisualTreeAsset.UsingEntry> m_Usings; // 0x20
	[SerializeField]
	internal StyleSheet inlineSheet; // 0x28
	[SerializeField]
	private List<VisualElementAsset> m_VisualElementAssets; // 0x30
	[SerializeField]
	private List<TemplateAsset> m_TemplateAssets; // 0x38
	[SerializeField]
	private List<VisualTreeAsset.UxmlObjectEntry> m_UxmlObjectEntries; // 0x40
	[SerializeField]
	private List<int> m_UxmlObjectIds; // 0x48
	[SerializeField]
	private List<VisualTreeAsset.AssetEntry> m_AssetEntries; // 0x50
	[SerializeField]
	private List<VisualTreeAsset.SlotDefinition> m_Slots; // 0x58
	[SerializeField]
	private int m_ContentContainerId; // 0x60
	[SerializeField]
	private int m_ContentHash; // 0x64

	// Properties
	public bool importedWithErrors { get; set; }
	public bool importedWithWarnings { get; set; }
	public IEnumerable<VisualTreeAsset> templateDependencies { get; }
	public IEnumerable<StyleSheet> stylesheets { get; }
	internal List<VisualElementAsset> visualElementAssets { get; set; }
	internal List<TemplateAsset> templateAssets { get; set; }
	internal List<VisualTreeAsset.UxmlObjectEntry> uxmlObjectEntries { get; }
	internal List<int> uxmlObjectIds { get; }
	internal List<VisualTreeAsset.SlotDefinition> slots { get; set; }
	internal int contentContainerId { get; set; }
	public int contentHash { get; set; }

	// Methods

	// RVA: 0x2D8D6C0 Offset: 0x2D8C0C0 VA: 0x182D8D6C0
	public bool get_importedWithErrors() { }

	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000
	internal void set_importedWithErrors(bool value) { }

	// RVA: 0x2DF7FC0 Offset: 0x2DF69C0 VA: 0x182DF7FC0
	public bool get_importedWithWarnings() { }

	// RVA: 0xCD85F0 Offset: 0xCD6FF0 VA: 0x180CD85F0
	internal void set_importedWithWarnings(bool value) { }

	// RVA: 0x2DF6D40 Offset: 0x2DF5740 VA: 0x182DF6D40
	internal int GetNextChildSerialNumber() { }

	[IteratorStateMachine(typeof(VisualTreeAsset.<get_templateDependencies>d__19))]
	// RVA: 0x2DF8050 Offset: 0x2DF6A50 VA: 0x182DF8050
	public IEnumerable<VisualTreeAsset> get_templateDependencies() { }

	[IteratorStateMachine(typeof(VisualTreeAsset.<get_stylesheets>d__23))]
	// RVA: 0x2DF7FD0 Offset: 0x2DF69D0 VA: 0x182DF7FD0
	public IEnumerable<StyleSheet> get_stylesheets() { }

	// RVA: 0x1E019C0 Offset: 0x1E003C0 VA: 0x181E019C0
	internal List<VisualElementAsset> get_visualElementAssets() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	internal void set_visualElementAssets(List<VisualElementAsset> value) { }

	// RVA: 0x2D0E1B0 Offset: 0x2D0CBB0 VA: 0x182D0E1B0
	internal List<TemplateAsset> get_templateAssets() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	internal void set_templateAssets(List<TemplateAsset> value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal List<VisualTreeAsset.UxmlObjectEntry> get_uxmlObjectEntries() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal List<int> get_uxmlObjectIds() { }

	// RVA: 0x2DF76D0 Offset: 0x2DF60D0 VA: 0x182DF76D0
	internal void RegisterUxmlObject(UxmlObjectAsset uxmlObjectAsset) { }

	// RVA: -1 Offset: -1
	internal List<T> GetUxmlObjects<T>(IUxmlAttributes asset, CreationContext cc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF760A0 Offset: 0xF74AA0 VA: 0x180F760A0
	|-VisualTreeAsset.GetUxmlObjects<object>
	|
	|-RVA: 0xF75D10 Offset: 0xF74710 VA: 0x180F75D10
	|-VisualTreeAsset.GetUxmlObjects<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2DF4B60 Offset: 0x2DF3560 VA: 0x182DF4B60
	internal bool AssetEntryExists(string path, Type type) { }

	// RVA: 0x2DF74F0 Offset: 0x2DF5EF0 VA: 0x182DF74F0
	internal void RegisterAssetEntry(string path, Type type, Object asset) { }

	// RVA: -1 Offset: -1
	internal T GetAsset<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF75AB0 Offset: 0xF744B0 VA: 0x180F75AB0
	|-VisualTreeAsset.GetAsset<object>
	*/

	// RVA: 0x2DF6DC0 Offset: 0x2DF57C0 VA: 0x182DF6DC0
	internal VisualTreeAsset.UxmlObjectEntry GetUxmlObjectEntry(int id) { }

	// RVA: 0x2DF6F00 Offset: 0x2DF5900 VA: 0x182DF6F00
	private IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset) { }

	// RVA: 0x2D0E1A0 Offset: 0x2D0CBA0 VA: 0x182D0E1A0
	internal List<VisualTreeAsset.SlotDefinition> get_slots() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	internal void set_slots(List<VisualTreeAsset.SlotDefinition> value) { }

	// RVA: 0x2DF7FB0 Offset: 0x2DF69B0 VA: 0x182DF7FB0
	internal int get_contentContainerId() { }

	// RVA: 0x4E2900 Offset: 0x4E1300 VA: 0x1804E2900
	internal void set_contentContainerId(int value) { }

	// RVA: 0x2DF73C0 Offset: 0x2DF5DC0 VA: 0x182DF73C0
	public TemplateContainer Instantiate() { }

	// RVA: 0x2DF6360 Offset: 0x2DF4D60 VA: 0x182DF6360
	public TemplateContainer Instantiate(string bindingPath) { }

	// RVA: 0x2DF6510 Offset: 0x2DF4F10 VA: 0x182DF6510
	public TemplateContainer CloneTree() { }

	// RVA: 0x2DF6360 Offset: 0x2DF4D60 VA: 0x182DF6360
	public TemplateContainer CloneTree(string bindingPath) { }

	// RVA: 0x2DF5C10 Offset: 0x2DF4610 VA: 0x182DF5C10
	public void CloneTree(VisualElement target) { }

	// RVA: 0x2DF63B0 Offset: 0x2DF4DB0 VA: 0x182DF63B0
	public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount) { }

	// RVA: 0x2DF5C40 Offset: 0x2DF4640 VA: 0x182DF5C40
	internal void CloneTree(VisualElement target, Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides) { }

	// RVA: 0x2DF50F0 Offset: 0x2DF3AF0 VA: 0x182DF50F0
	private VisualElement CloneSetupRecursively(VisualElementAsset root, Dictionary<int, List<VisualElementAsset>> idToChildren, CreationContext context) { }

	// RVA: 0x2DF6520 Offset: 0x2DF4F20 VA: 0x182DF6520
	private static int CompareForOrder(VisualElementAsset a, VisualElementAsset b) { }

	// RVA: 0x2DF7CA0 Offset: 0x2DF66A0 VA: 0x182DF7CA0
	internal bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName) { }

	// RVA: 0x2DF79B0 Offset: 0x2DF63B0 VA: 0x182DF79B0
	internal VisualTreeAsset ResolveTemplate(string templateName) { }

	// RVA: 0x2DF6550 Offset: 0x2DF4F50 VA: 0x182DF6550
	internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx) { }

	// RVA: 0x2DF4D20 Offset: 0x2DF3720 VA: 0x182DF4D20
	private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	// RVA: 0x2DF4DB0 Offset: 0x2DF37B0 VA: 0x182DF4DB0
	private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	// RVA: 0x2CF7FC0 Offset: 0x2CF69C0 VA: 0x182CF7FC0
	public int get_contentHash() { }

	// RVA: 0xC27360 Offset: 0xC25D60 VA: 0x180C27360
	public void set_contentHash(int value) { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	public void .ctor() { }

	// RVA: 0x2DF7EE0 Offset: 0x2DF68E0 VA: 0x182DF7EE0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2DF7D80 Offset: 0x2DF6780 VA: 0x182DF7D80
	internal static VisualElement <Create>g__CreateError|65_0(ref VisualTreeAsset.<>c__DisplayClass65_0 ) { }
}
