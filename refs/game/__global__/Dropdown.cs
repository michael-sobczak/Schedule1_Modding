public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 16392
{
	// Fields
	[SerializeField]
	private RectTransform m_Template; // 0x100
	[SerializeField]
	private Text m_CaptionText; // 0x108
	[SerializeField]
	private Image m_CaptionImage; // 0x110
	[Space]
	[SerializeField]
	private Text m_ItemText; // 0x118
	[SerializeField]
	private Image m_ItemImage; // 0x120
	[Space]
	[SerializeField]
	private int m_Value; // 0x128
	[Space]
	[SerializeField]
	private Dropdown.OptionDataList m_Options; // 0x130
	[SerializeField]
	[Space]
	private Dropdown.DropdownEvent m_OnValueChanged; // 0x138
	[SerializeField]
	private float m_AlphaFadeSpeed; // 0x140
	private GameObject m_Dropdown; // 0x148
	private GameObject m_Blocker; // 0x150
	private List<Dropdown.DropdownItem> m_Items; // 0x158
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x160
	private bool validTemplate; // 0x168
	private const int kHighSortingLayer = 30000;
	private static Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<Dropdown.OptionData> options { get; set; }
	public Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }

	// Methods

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public RectTransform get_template() { }

	// RVA: 0x2D993E0 Offset: 0x2D97DE0 VA: 0x182D993E0
	public void set_template(RectTransform value) { }

	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	public Text get_captionText() { }

	// RVA: 0x2D99310 Offset: 0x2D97D10 VA: 0x182D99310
	public void set_captionText(Text value) { }

	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	public Image get_captionImage() { }

	// RVA: 0x2D992E0 Offset: 0x2D97CE0 VA: 0x182D992E0
	public void set_captionImage(Image value) { }

	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public Text get_itemText() { }

	// RVA: 0x2D99370 Offset: 0x2D97D70 VA: 0x182D99370
	public void set_itemText(Text value) { }

	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public Image get_itemImage() { }

	// RVA: 0x2D99340 Offset: 0x2D97D40 VA: 0x182D99340
	public void set_itemImage(Image value) { }

	// RVA: 0x2D992C0 Offset: 0x2D97CC0 VA: 0x182D992C0
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x2D993A0 Offset: 0x2D97DA0 VA: 0x182D993A0
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850
	public Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x65D8F0 Offset: 0x65C2F0 VA: 0x18065D8F0
	public void set_onValueChanged(Dropdown.DropdownEvent value) { }

	// RVA: 0x8D20F0 Offset: 0x8D0AF0 VA: 0x1808D20F0
	public float get_alphaFadeSpeed() { }

	// RVA: 0x992DE0 Offset: 0x9917E0 VA: 0x180992DE0
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x51D950 Offset: 0x51C350 VA: 0x18051D950
	public int get_value() { }

	// RVA: 0x2D99410 Offset: 0x2D97E10 VA: 0x182D99410
	public void set_value(int value) { }

	// RVA: 0x2D97760 Offset: 0x2D96160 VA: 0x182D97760
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x2D97770 Offset: 0x2D96170 VA: 0x182D97770
	private void Set(int value, bool sendCallback = True) { }

	// RVA: 0x2D99120 Offset: 0x2D97B20 VA: 0x182D99120
	protected void .ctor() { }

	// RVA: 0x2D96650 Offset: 0x2D95050 VA: 0x182D96650 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2D98FE0 Offset: 0x2D979E0 VA: 0x182D98FE0 Slot: 6
	protected override void Start() { }

	// RVA: 0x2D972C0 Offset: 0x2D95CC0 VA: 0x182D972C0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2D974A0 Offset: 0x2D95EA0 VA: 0x182D974A0
	public void RefreshShownValue() { }

	// RVA: 0x2D963E0 Offset: 0x2D94DE0 VA: 0x182D963E0
	public void AddOptions(List<Dropdown.OptionData> options) { }

	// RVA: 0x2D960E0 Offset: 0x2D94AE0 VA: 0x182D960E0
	public void AddOptions(List<string> options) { }

	// RVA: 0x2D96260 Offset: 0x2D94C60 VA: 0x182D96260
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x2D96760 Offset: 0x2D95160 VA: 0x182D96760
	public void ClearOptions() { }

	// RVA: 0x2D978A0 Offset: 0x2D962A0 VA: 0x182D978A0
	private void SetupTemplate(Canvas rootCanvas) { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE81880 Offset: 0xE80280 VA: 0x180E81880
	|-Dropdown.GetOrAddComponent<object>
	*/

	// RVA: 0x2D97370 Offset: 0x2D95D70 VA: 0x182D97370 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2D97370 Offset: 0x2D95D70 VA: 0x182D97370 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x2D972B0 Offset: 0x2D95CB0 VA: 0x182D972B0 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x2D97FC0 Offset: 0x2D969C0 VA: 0x182D97FC0
	public void Show() { }

	// RVA: 0x2D967E0 Offset: 0x2D951E0 VA: 0x182D967E0 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x2D96E70 Offset: 0x2D95870 VA: 0x182D96E70 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x2D96D30 Offset: 0x2D95730 VA: 0x182D96D30 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x2D96EC0 Offset: 0x2D958C0 VA: 0x182D96EC0 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x2D96D90 Offset: 0x2D95790 VA: 0x182D96D90 Slot: 49
	protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 50
	protected virtual void DestroyItem(Dropdown.DropdownItem item) { }

	// RVA: 0x2D95DC0 Offset: 0x2D947C0 VA: 0x182D95DC0
	private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items) { }

	// RVA: 0x2D965C0 Offset: 0x2D94FC0 VA: 0x182D965C0
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x2D96450 Offset: 0x2D94E50 VA: 0x182D96450
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x2D976B0 Offset: 0x2D960B0 VA: 0x182D976B0
	private void SetAlpha(float alpha) { }

	// RVA: 0x2D96F10 Offset: 0x2D95910 VA: 0x182D96F10
	public void Hide() { }

	[IteratorStateMachine(typeof(Dropdown.<DelayedDestroyDropdownList>d__75))]
	// RVA: 0x2D96DF0 Offset: 0x2D957F0 VA: 0x182D96DF0
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x2D970F0 Offset: 0x2D95AF0 VA: 0x182D970F0
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x2D97380 Offset: 0x2D95D80 VA: 0x182D97380
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x2D990A0 Offset: 0x2D97AA0 VA: 0x182D990A0
	private static void .cctor() { }
}
