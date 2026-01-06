public class ProductIconManager : Singleton<ProductIconManager> // TypeDefIndex: 2471
{
	// Fields
	public const string ProductIconPath = "Textures/ProductIcons";
	[SerializeField]
	private List<ProductIconManager.ProductIcon> icons; // 0x28
	[Header("Product and packaging")]
	public IconGenerator IconGenerator; // 0x30
	public ProductDefinition[] Products; // 0x38
	public PackagingDefinition[] Packaging; // 0x40

	// Methods

	// RVA: 0x893810 Offset: 0x892210 VA: 0x180893810 Slot: 5
	protected override void Awake() { }

	// RVA: 0x893F50 Offset: 0x892950 VA: 0x180893F50
	public Sprite GetIcon(string productID, string packagingID, bool ignoreError = False) { }

	// RVA: 0x893960 Offset: 0x892360 VA: 0x180893960
	public Sprite GenerateIcons(string productID) { }

	// RVA: 0x893F20 Offset: 0x892920 VA: 0x180893F20
	private Texture2D GenerateProductTexture(string productID, string packagingID) { }

	// RVA: 0x894190 Offset: 0x892B90 VA: 0x180894190
	public void .ctor() { }
}
