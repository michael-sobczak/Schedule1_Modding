public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 14893
{
	// Fields
	private static readonly TMP_Dropdown.OptionData k_NothingOption; // 0x0
	private static readonly TMP_Dropdown.OptionData k_EverythingOption; // 0x8
	private static readonly TMP_Dropdown.OptionData k_MixedOption; // 0x10
	[SerializeField]
	private RectTransform m_Template; // 0x100
	[SerializeField]
	private TMP_Text m_CaptionText; // 0x108
	[SerializeField]
	private Image m_CaptionImage; // 0x110
	[SerializeField]
	private Graphic m_Placeholder; // 0x118
	[Space]
	[SerializeField]
	private TMP_Text m_ItemText; // 0x120
	[SerializeField]
	private Image m_ItemImage; // 0x128
	[Space]
	[SerializeField]
	private int m_Value; // 0x130
	[SerializeField]
	private bool m_MultiSelect; // 0x134
	[Space]
	[SerializeField]
	private TMP_Dropdown.OptionDataList m_Options; // 0x138
	[Space]
	[SerializeField]
	private TMP_Dropdown.DropdownEvent m_OnValueChanged; // 0x140
	[SerializeField]
	private float m_AlphaFadeSpeed; // 0x148
	private GameObject m_Dropdown; // 0x150
	private GameObject m_Blocker; // 0x158
	private List<TMP_Dropdown.DropdownItem> m_Items; // 0x160
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x168
	private bool validTemplate; // 0x170
	private Coroutine m_Coroutine; // 0x178
	private static TMP_Dropdown.OptionData s_NoOptionData; // 0x18

	// Properties
	public RectTransform template { get; set; }
	public TMP_Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Graphic placeholder { get; set; }
	public TMP_Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<TMP_Dropdown.OptionData> options { get; set; }
	public TMP_Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }
	public bool IsExpanded { get; }
	public bool MultiSelect { get; set; }

	// Methods

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public RectTransform get_template() { }

	// RVA: 0x2BDDDA0 Offset: 0x2BDC7A0 VA: 0x182BDDDA0
	public void set_template(RectTransform value) { }

	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	public TMP_Text get_captionText() { }

	// RVA: 0x2BDDCA0 Offset: 0x2BDC6A0 VA: 0x182BDDCA0
	public void set_captionText(TMP_Text value) { }

	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	public Image get_captionImage() { }

	// RVA: 0x2BDDC70 Offset: 0x2BDC670 VA: 0x182BDDC70
	public void set_captionImage(Image value) { }

	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public Graphic get_placeholder() { }

	// RVA: 0x2BDDD70 Offset: 0x2BDC770 VA: 0x182BDDD70
	public void set_placeholder(Graphic value) { }

	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public TMP_Text get_itemText() { }

	// RVA: 0x2BDDD00 Offset: 0x2BDC700 VA: 0x182BDDD00
	public void set_itemText(TMP_Text value) { }

	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public Image get_itemImage() { }

	// RVA: 0x2BDDCD0 Offset: 0x2BDC6D0 VA: 0x182BDDCD0
	public void set_itemImage(Image value) { }

	// RVA: 0x2BDDC50 Offset: 0x2BDC650 VA: 0x182BDDC50
	public List<TMP_Dropdown.OptionData> get_options() { }

	// RVA: 0x2BDDD30 Offset: 0x2BDC730 VA: 0x182BDDD30
	public void set_options(List<TMP_Dropdown.OptionData> value) { }

	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910
	public TMP_Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x6FB0A0 Offset: 0x6F9AA0 VA: 0x1806FB0A0
	public void set_onValueChanged(TMP_Dropdown.DropdownEvent value) { }

	// RVA: 0x513070 Offset: 0x511A70 VA: 0x180513070
	public float get_alphaFadeSpeed() { }

	// RVA: 0x653870 Offset: 0x652270 VA: 0x180653870
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x523410 Offset: 0x521E10 VA: 0x180523410
	public int get_value() { }

	// RVA: 0x2BDDDD0 Offset: 0x2BDC7D0 VA: 0x182BDDDD0
	public void set_value(int value) { }

	// RVA: 0x2BDBA00 Offset: 0x2BDA400 VA: 0x182BDBA00
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x2BDBA10 Offset: 0x2BDA410 VA: 0x182BDBA10
	private void SetValue(int value, bool sendCallback = True) { }

	// RVA: 0x2BDDBF0 Offset: 0x2BDC5F0 VA: 0x182BDDBF0
	public bool get_IsExpanded() { }

	// RVA: 0x66FB80 Offset: 0x66E580 VA: 0x18066FB80
	public bool get_MultiSelect() { }

	// RVA: 0x66FC30 Offset: 0x66E630 VA: 0x18066FC30
	public void set_MultiSelect(bool value) { }

	// RVA: 0x2BDDA50 Offset: 0x2BDC450 VA: 0x182BDDA50
	protected void .ctor() { }

	// RVA: 0x2BDA320 Offset: 0x2BD8D20 VA: 0x182BDA320 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2BDD7B0 Offset: 0x2BDC1B0 VA: 0x182BDD7B0 Slot: 6
	protected override void Start() { }

	// RVA: 0x2BDB0E0 Offset: 0x2BD9AE0 VA: 0x182BDB0E0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2BDB4E0 Offset: 0x2BD9EE0 VA: 0x182BDB4E0
	public void RefreshShownValue() { }

	// RVA: 0x2BD9D90 Offset: 0x2BD8790 VA: 0x182BD9D90
	public void AddOptions(List<TMP_Dropdown.OptionData> options) { }

	// RVA: 0x2BD9E00 Offset: 0x2BD8800 VA: 0x182BD9E00
	public void AddOptions(List<string> options) { }

	// RVA: 0x2BD9F90 Offset: 0x2BD8990 VA: 0x182BD9F90
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x2BDA470 Offset: 0x2BD8E70 VA: 0x182BDA470
	public void ClearOptions() { }

	// RVA: 0x2BDBB90 Offset: 0x2BDA590 VA: 0x182BDBB90
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE81880 Offset: 0xE80280 VA: 0x180E81880
	|-TMP_Dropdown.GetOrAddComponent<object>
	*/

	// RVA: 0x2BDB190 Offset: 0x2BD9B90 VA: 0x182BDB190 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2BDB190 Offset: 0x2BD9B90 VA: 0x182BDB190 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x2BDB0D0 Offset: 0x2BD9AD0 VA: 0x182BDB0D0 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x2BDC280 Offset: 0x2BDAC80 VA: 0x182BDC280
	public void Show() { }

	// RVA: 0x2BDB0A0 Offset: 0x2BD9AA0 VA: 0x182BDB0A0
	private static bool IsEverythingValue(int count, int value) { }

	// RVA: 0x2BDAC40 Offset: 0x2BD9640 VA: 0x182BDAC40
	private static int EverythingValue(int count) { }

	// RVA: 0x2BDA530 Offset: 0x2BD8F30 VA: 0x182BDA530 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x2BDABA0 Offset: 0x2BD95A0 VA: 0x182BDABA0 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x2BDAA60 Offset: 0x2BD9460 VA: 0x182BDAA60 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x2BDABF0 Offset: 0x2BD95F0 VA: 0x182BDABF0 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x2BDAAC0 Offset: 0x2BD94C0 VA: 0x182BDAAC0 Slot: 49
	protected virtual TMP_Dropdown.DropdownItem CreateItem(TMP_Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 50
	protected virtual void DestroyItem(TMP_Dropdown.DropdownItem item) { }

	// RVA: 0x2BD9A30 Offset: 0x2BD8430 VA: 0x182BD9A30
	private TMP_Dropdown.DropdownItem AddItem(TMP_Dropdown.OptionData data, bool selected, TMP_Dropdown.DropdownItem itemTemplate, List<TMP_Dropdown.DropdownItem> items) { }

	// RVA: 0x2BDA290 Offset: 0x2BD8C90 VA: 0x182BDA290
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x2BDA120 Offset: 0x2BD8B20 VA: 0x182BDA120
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x2BDB950 Offset: 0x2BDA350 VA: 0x182BDB950
	private void SetAlpha(float alpha) { }

	// RVA: 0x2BDAC90 Offset: 0x2BD9690 VA: 0x182BDAC90
	public void Hide() { }

	[IteratorStateMachine(typeof(TMP_Dropdown.<DelayedDestroyDropdownList>d__90))]
	// RVA: 0x2BDAB20 Offset: 0x2BD9520 VA: 0x182BDAB20
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x2BDAEA0 Offset: 0x2BD98A0 VA: 0x182BDAEA0
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x2BDB1A0 Offset: 0x2BD9BA0 VA: 0x182BDB1A0
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x2BDAC70 Offset: 0x2BD9670 VA: 0x182BDAC70
	private static int FirstActiveFlagIndex(int value) { }

	// RVA: 0x2BDD870 Offset: 0x2BDC270 VA: 0x182BDD870
	private static void .cctor() { }
}
