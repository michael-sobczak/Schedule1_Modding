public class PropertyUtility : Singleton<PropertyUtility> // TypeDefIndex: 2499
{
	// Fields
	public List<PropertyUtility.PropertyData> PropertyDatas; // 0x28
	public List<PropertyUtility.DrugTypeData> DrugTypeDatas; // 0x30
	public List<Effect> AllProperties; // 0x38
	[Header("Test Mixing")]
	public List<ProductDefinition> Products; // 0x40
	public List<PropertyItemDefinition> Properties; // 0x48
	private Dictionary<string, Effect> PropertiesDict; // 0x50

	// Methods

	// RVA: 0x8B9AD0 Offset: 0x8B84D0 VA: 0x1808B9AD0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8BA760 Offset: 0x8B9160 VA: 0x1808BA760 Slot: 4
	protected override void Start() { }

	// RVA: 0x8BA500 Offset: 0x8B8F00 VA: 0x1808BA500
	public List<Effect> GetProperties(int tier) { }

	// RVA: 0x8BA140 Offset: 0x8B8B40 VA: 0x1808BA140
	public List<Effect> GetProperties(List<string> ids) { }

	// RVA: 0x8BA640 Offset: 0x8B9040 VA: 0x1808BA640
	public static PropertyUtility.PropertyData GetPropertyData(EProperty property) { }

	// RVA: 0x8B9C20 Offset: 0x8B8620 VA: 0x1808B9C20
	public static PropertyUtility.DrugTypeData GetDrugTypeData(EDrugType drugType) { }

	// RVA: 0x8B9D40 Offset: 0x8B8740 VA: 0x1808B9D40
	public static List<Color32> GetOrderedPropertyColors(List<Effect> properties) { }

	// RVA: 0x8BA7A0 Offset: 0x8B91A0 VA: 0x1808BA7A0
	public void .ctor() { }
}
