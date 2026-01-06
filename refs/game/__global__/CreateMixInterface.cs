public class CreateMixInterface : Singleton<CreateMixInterface> // TypeDefIndex: 2580
{
	// Fields
	public const int BEAN_REQUIREMENT = 5;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	[Header("References")]
	public Canvas Canvas; // 0x30
	public ItemSlotUI BeansSlot; // 0x38
	public ItemSlotUI ProductSlot; // 0x40
	public ItemSlotUI MixerSlot; // 0x48
	public ItemSlotUI OutputSlot; // 0x50
	public Image OutputIcon; // 0x58
	public Button BeginButton; // 0x60
	public WorldStorageEntity Storage; // 0x68
	public TextMeshProUGUI ProductPropertiesLabel; // 0x70
	public TextMeshProUGUI OutputPropertiesLabel; // 0x78
	public TextMeshProUGUI BeanProblemLabel; // 0x80
	public TextMeshProUGUI ProductProblemLabel; // 0x88
	public TextMeshProUGUI MixerProblemLabel; // 0x90
	public TextMeshProUGUI OutputProblemLabel; // 0x98
	public Transform CameraPosition; // 0xA0
	public RectTransform UnknownOutputIcon; // 0xA8
	public UnityEvent onOpen; // 0xB0
	public UnityEvent onClose; // 0xB8

	// Properties
	public bool IsOpen { get; set; }
	private ItemSlot beanSlot { get; }
	private ItemSlot mixerSlot { get; }
	private ItemSlot outputSlot { get; }
	private ItemSlot productSlot { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	private void set_IsOpen(bool value) { }

	// RVA: 0x8DE480 Offset: 0x8DCE80 VA: 0x1808DE480
	private ItemSlot get_beanSlot() { }

	// RVA: 0x8DE4E0 Offset: 0x8DCEE0 VA: 0x1808DE4E0
	private ItemSlot get_mixerSlot() { }

	// RVA: 0x8DE540 Offset: 0x8DCF40 VA: 0x1808DE540
	private ItemSlot get_outputSlot() { }

	// RVA: 0x8DE5A0 Offset: 0x8DCFA0 VA: 0x1808DE5A0
	private ItemSlot get_productSlot() { }

	// RVA: 0x8DB1B0 Offset: 0x8D9BB0 VA: 0x1808DB1B0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8DC5C0 Offset: 0x8DAFC0 VA: 0x1808DC5C0
	private void Exit(ExitAction action) { }

	// RVA: 0x8DCFA0 Offset: 0x8DB9A0 VA: 0x1808DCFA0
	public void Open() { }

	// RVA: 0x8DC5A0 Offset: 0x8DAFA0 VA: 0x1808DC5A0
	private void ContentsChanged() { }

	// RVA: 0x8DD7B0 Offset: 0x8DC1B0 VA: 0x1808DD7B0
	private void UpdateCanBegin() { }

	// RVA: 0x8DDB90 Offset: 0x8DC590 VA: 0x1808DDB90
	private void UpdateOutput() { }

	// RVA: 0x8DB860 Offset: 0x8DA260 VA: 0x1808DB860
	private void BeginPressed() { }

	// RVA: 0x8DC7F0 Offset: 0x8DB1F0 VA: 0x1808DC7F0
	private List<Effect> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer) { }

	// RVA: 0x8DCDC0 Offset: 0x8DB7C0 VA: 0x1808DCDC0
	private bool IsOutputKnown(out ProductDefinition knownProduct) { }

	// RVA: 0x8DC9B0 Offset: 0x8DB3B0 VA: 0x1808DC9B0
	private string GetPropertyListString(List<Effect> properties) { }

	// RVA: 0x8DCB60 Offset: 0x8DB560 VA: 0x1808DCB60
	private string GetPropertyString(Effect property) { }

	// RVA: 0x8DBAB0 Offset: 0x8DA4B0 VA: 0x1808DBAB0
	private bool CanBegin() { }

	// RVA: 0x8DBC00 Offset: 0x8DA600 VA: 0x1808DBC00
	public void Close() { }

	// RVA: 0x8DCD60 Offset: 0x8DB760 VA: 0x1808DCD60
	private bool HasProduct() { }

	// RVA: 0x8DCC90 Offset: 0x8DB690 VA: 0x1808DCC90
	private bool HasBeans() { }

	// RVA: 0x8DCD00 Offset: 0x8DB700 VA: 0x1808DCD00
	private bool HasMixer() { }

	// RVA: 0x8DC880 Offset: 0x8DB280 VA: 0x1808DC880
	private ProductDefinition GetProduct() { }

	// RVA: 0x8DC610 Offset: 0x8DB010 VA: 0x1808DC610
	private PropertyItemDefinition GetMixer() { }

	// RVA: 0x8DE440 Offset: 0x8DCE40 VA: 0x1808DE440
	public void .ctor() { }
}
