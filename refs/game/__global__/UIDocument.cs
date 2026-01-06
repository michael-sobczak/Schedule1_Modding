public sealed class UIDocument : MonoBehaviour // TypeDefIndex: 6683
{
	// Fields
	internal const string k_RootStyleClassName = "unity-ui-document__root";
	internal const string k_VisualElementNameSuffix = "-container";
	private const int k_DefaultSortingOrder = 0;
	private static int s_CurrentUIDocumentCounter; // 0x0
	internal readonly int m_UIDocumentCreationIndex; // 0x20
	[SerializeField]
	private PanelSettings m_PanelSettings; // 0x28
	private PanelSettings m_PreviousPanelSettings; // 0x30
	[SerializeField]
	private UIDocument m_ParentUI; // 0x38
	private UIDocumentList m_ChildrenContent; // 0x40
	private List<UIDocument> m_ChildrenContentCopy; // 0x48
	[SerializeField]
	private VisualTreeAsset sourceAsset; // 0x50
	private VisualElement m_RootVisualElement; // 0x58
	private int m_FirstChildInsertIndex; // 0x60
	[SerializeField]
	private float m_SortingOrder; // 0x64

	// Properties
	public PanelSettings panelSettings { get; set; }
	public UIDocument parentUI { get; set; }
	public VisualTreeAsset visualTreeAsset { get; set; }
	public VisualElement rootVisualElement { get; }
	internal int firstChildInserIndex { get; }
	public float sortingOrder { get; set; }

	// Methods

	// RVA: 0x1E0E080 Offset: 0x1E0CA80 VA: 0x181E0E080
	public PanelSettings get_panelSettings() { }

	// RVA: 0x2EB9200 Offset: 0x2EB7C00 VA: 0x182EB9200
	public void set_panelSettings(PanelSettings value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public UIDocument get_parentUI() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_parentUI(UIDocument value) { }

	// RVA: 0x2D0E270 Offset: 0x2D0CC70 VA: 0x182D0E270
	public VisualTreeAsset get_visualTreeAsset() { }

	// RVA: 0x2EB94F0 Offset: 0x2EB7EF0 VA: 0x182EB94F0
	public void set_visualTreeAsset(VisualTreeAsset value) { }

	// RVA: 0x2D0E1A0 Offset: 0x2D0CBA0 VA: 0x182D0E1A0
	public VisualElement get_rootVisualElement() { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	internal int get_firstChildInserIndex() { }

	// RVA: 0x4CD1A0 Offset: 0x4CBBA0 VA: 0x1804CD1A0
	public float get_sortingOrder() { }

	// RVA: 0x2EB94D0 Offset: 0x2EB7ED0 VA: 0x182EB94D0
	public void set_sortingOrder(float value) { }

	// RVA: 0x2EB83E0 Offset: 0x2EB6DE0 VA: 0x182EB83E0
	internal void ApplySortingOrder() { }

	// RVA: 0x2EB9170 Offset: 0x2EB7B70 VA: 0x182EB9170
	private void .ctor() { }

	// RVA: 0x2EB83F0 Offset: 0x2EB6DF0 VA: 0x182EB83F0
	private void Awake() { }

	// RVA: 0x2EB84F0 Offset: 0x2EB6EF0 VA: 0x182EB84F0
	private void OnEnable() { }

	// RVA: 0x2EB8F70 Offset: 0x2EB7970 VA: 0x182EB8F70
	private void SetupFromHierarchy() { }

	// RVA: 0x2EB8400 Offset: 0x2EB6E00 VA: 0x182EB8400
	private UIDocument FindUIDocumentParent() { }

	// RVA: 0x2EB8E60 Offset: 0x2EB7860 VA: 0x182EB8E60
	internal void Reset() { }

	// RVA: 0x2EB8220 Offset: 0x2EB6C20 VA: 0x182EB8220
	private void AddChildAndInsertContentToVisualTree(UIDocument child) { }

	// RVA: 0x2EB8CE0 Offset: 0x2EB76E0 VA: 0x182EB8CE0
	private void RemoveChild(UIDocument child) { }

	// RVA: 0x2EB8870 Offset: 0x2EB7270 VA: 0x182EB8870
	private void RecreateUI() { }

	// RVA: 0x2EB90E0 Offset: 0x2EB7AE0 VA: 0x182EB90E0
	private void SetupRootClassList() { }

	// RVA: 0x2EB8310 Offset: 0x2EB6D10 VA: 0x182EB8310
	private void AddRootVisualElementToTree() { }

	// RVA: 0x2EB8D50 Offset: 0x2EB7750 VA: 0x182EB8D50
	private void RemoveFromHierarchy() { }

	// RVA: 0x2EB84B0 Offset: 0x2EB6EB0 VA: 0x182EB84B0
	private void OnDisable() { }

	// RVA: 0x2EB85C0 Offset: 0x2EB6FC0 VA: 0x182EB85C0
	private void OnTransformChildrenChanged() { }

	// RVA: 0x2EB87B0 Offset: 0x2EB71B0 VA: 0x182EB87B0
	private void OnTransformParentChanged() { }

	// RVA: 0x2EB87C0 Offset: 0x2EB71C0 VA: 0x182EB87C0
	internal void ReactToHierarchyChanged() { }
}
