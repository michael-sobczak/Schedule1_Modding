public abstract class ItemInstance // TypeDefIndex: 3070
{
	// Fields
	public const int APPROXIMATE_BYTE_SIZE = 80;
	[CodegenExclude]
	protected ItemDefinition definition; // 0x10
	[CompilerGenerated]
	private string <ID>k__BackingField; // 0x18
	public int Quantity; // 0x20
	[CodegenExclude]
	public Action onDataChanged; // 0x28
	[CodegenExclude]
	public Action requestClearSlot; // 0x30

	// Properties
	[CodegenExclude]
	public ItemDefinition Definition { get; }
	public string ID { get; set; }
	[CodegenExclude]
	public virtual string Name { get; }
	[CodegenExclude]
	public virtual string Description { get; }
	[CodegenExclude]
	public virtual Sprite Icon { get; }
	[CodegenExclude]
	public virtual EItemCategory Category { get; }
	[CodegenExclude]
	public virtual int StackLimit { get; }
	[CodegenExclude]
	public virtual Color LabelDisplayColor { get; }
	[CodegenExclude]
	public virtual Equippable Equippable { get; }

	// Methods

	// RVA: 0x997B00 Offset: 0x996500 VA: 0x180997B00
	public ItemDefinition get_Definition() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_ID() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	protected void set_ID(string value) { }

	// RVA: 0x997CA0 Offset: 0x9966A0 VA: 0x180997CA0 Slot: 4
	public virtual string get_Name() { }

	// RVA: 0x997C00 Offset: 0x996600 VA: 0x180997C00 Slot: 5
	public virtual string get_Description() { }

	// RVA: 0x997C40 Offset: 0x996640 VA: 0x180997C40 Slot: 6
	public virtual Sprite get_Icon() { }

	// RVA: 0x997AE0 Offset: 0x9964E0 VA: 0x180997AE0 Slot: 7
	public virtual EItemCategory get_Category() { }

	// RVA: 0x997CC0 Offset: 0x9966C0 VA: 0x180997CC0 Slot: 8
	public virtual int get_StackLimit() { }

	// RVA: 0x997C60 Offset: 0x996660 VA: 0x180997C60 Slot: 9
	public virtual Color get_LabelDisplayColor() { }

	// RVA: 0x997C20 Offset: 0x996620 VA: 0x180997C20 Slot: 10
	public virtual Equippable get_Equippable() { }

	// RVA: 0x9979D0 Offset: 0x9963D0 VA: 0x1809979D0
	public void .ctor() { }

	// RVA: 0x997A30 Offset: 0x996430 VA: 0x180997A30
	public void .ctor(ItemDefinition definition, int quantity) { }

	// RVA: 0x9975A0 Offset: 0x995FA0 VA: 0x1809975A0 Slot: 11
	public virtual bool CanStackWith(ItemInstance other, bool checkQuantities = True) { }

	// RVA: 0x997710 Offset: 0x996110 VA: 0x180997710 Slot: 12
	public virtual ItemInstance GetCopy(int overrideQuantity = -1) { }

	// RVA: 0x997800 Offset: 0x996200 VA: 0x180997800 Slot: 13
	public virtual bool IsValidInstance() { }

	// RVA: 0x9977E0 Offset: 0x9961E0 VA: 0x1809977E0
	protected void InvokeDataChange() { }

	// RVA: 0x9978E0 Offset: 0x9962E0 VA: 0x1809978E0
	public void SetQuantity(int quantity) { }

	// RVA: 0x997620 Offset: 0x996020 VA: 0x180997620
	public void ChangeQuantity(int change) { }

	// RVA: 0x997770 Offset: 0x996170 VA: 0x180997770 Slot: 14
	public virtual ItemData GetItemData() { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 15
	public virtual float GetMonetaryValue() { }

	// RVA: 0x939D40 Offset: 0x938740 VA: 0x180939D40
	public void RequestClearSlot() { }

	// RVA: 0x9978B0 Offset: 0x9962B0 VA: 0x1809978B0
	public void SetID(string id) { }
}
