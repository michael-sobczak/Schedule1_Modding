public class StoredItem_GenericBox : StoredItem // TypeDefIndex: 2408
{
	// Fields
	private const float ReferenceIconWidth = 1024;
	[SerializeField]
	[Header("References")]
	protected SpriteRenderer icon1; // 0x68
	[SerializeField]
	protected SpriteRenderer icon2; // 0x70
	[Header("Settings")]
	public float IconScale; // 0x78

	// Methods

	// RVA: 0x889990 Offset: 0x888390 VA: 0x180889990 Slot: 5
	public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation) { }

	// RVA: 0x889BB0 Offset: 0x8885B0 VA: 0x180889BB0
	public void .ctor() { }
}
