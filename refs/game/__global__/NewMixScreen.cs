public class NewMixScreen : Singleton<NewMixScreen> // TypeDefIndex: 2643
{
	// Fields
	public const int MAX_PROPERTIES_DISPLAYED = 5;
	[SerializeField]
	[Header("References")]
	protected Canvas canvas; // 0x28
	public RectTransform Container; // 0x30
	[SerializeField]
	protected TMP_InputField nameInputField; // 0x38
	[SerializeField]
	protected GameObject mixAlreadyExistsText; // 0x40
	[SerializeField]
	protected RectTransform editIcon; // 0x48
	[SerializeField]
	protected Button randomizeNameButton; // 0x50
	[SerializeField]
	protected Button confirmButton; // 0x58
	[SerializeField]
	protected TextMeshProUGUI PropertiesLabel; // 0x60
	[SerializeField]
	protected TextMeshProUGUI MarketValueLabel; // 0x68
	public AudioSourceController Sound; // 0x70
	[Header("Prefabs")]
	[SerializeField]
	protected GameObject attributeEntryPrefab; // 0x78
	[Header("Name Library")]
	[SerializeField]
	protected List<string> name1Library; // 0x80
	[SerializeField]
	protected List<string> name2Library; // 0x88
	public Action<string> onMixNamed; // 0x90

	// Properties
	public bool IsOpen { get; }

	// Methods

	// RVA: 0x8F9340 Offset: 0x8F7D40 VA: 0x1808F9340
	public bool get_IsOpen() { }

	// RVA: 0x8F8120 Offset: 0x8F6B20 VA: 0x1808F8120 Slot: 5
	protected override void Awake() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Exit(ExitAction action) { }

	// RVA: 0x8F91E0 Offset: 0x8F7BE0 VA: 0x1808F91E0 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x8F8B30 Offset: 0x8F7530 VA: 0x1808F8B30
	public void Open(List<Effect> properties, EDrugType drugType, float productMarketValue) { }

	// RVA: 0x8F8290 Offset: 0x8F6C90 VA: 0x1808F8290
	public void Close() { }

	// RVA: 0x8F9070 Offset: 0x8F7A70 VA: 0x1808F9070
	public void RandomizeButtonClicked() { }

	// RVA: 0x8F8370 Offset: 0x8F6D70 VA: 0x1808F8370
	public void ConfirmButtonClicked() { }

	// RVA: 0x8F84D0 Offset: 0x8F6ED0 VA: 0x1808F84D0
	public string GenerateUniqueName(Effect[] properties, EDrugType drugType = 0) { }

	// RVA: 0x8F90B0 Offset: 0x8F7AB0 VA: 0x1808F90B0
	protected void RefreshNameButtons() { }

	// RVA: 0x8F8870 Offset: 0x8F7270 VA: 0x1808F8870
	public void OnNameValueChanged(string newVal) { }

	// RVA: 0x8F9270 Offset: 0x8F7C70 VA: 0x1808F9270
	public void .ctor() { }
}
