public class JsonContainerContract : JsonContract // TypeDefIndex: 11237
{
	// Fields
	private JsonContract _itemContract; // 0x90
	private JsonContract _finalItemContract; // 0x98
	[CompilerGenerated]
	private JsonConverter <ItemConverter>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xA8
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xAC
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xB4

	// Properties
	internal JsonContract ItemContract { get; set; }
	internal JsonContract FinalItemContract { get; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }

	// Methods

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	internal JsonContract get_ItemContract() { }

	// RVA: 0x1D81970 Offset: 0x1D80370 VA: 0x181D81970
	internal void set_ItemContract(JsonContract value) { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	internal JsonContract get_FinalItemContract() { }

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public JsonConverter get_ItemConverter() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x1D81950 Offset: 0x1D80350 VA: 0x181D81950
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGenerated]
	// RVA: 0x1D819E0 Offset: 0x1D803E0 VA: 0x181D819E0
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xCE3DA0 Offset: 0xCE27A0 VA: 0x180CE3DA0
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0xCE3E00 Offset: 0xCE2800 VA: 0x180CE3E00
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x1D81960 Offset: 0x1D80360 VA: 0x181D81960
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0x1D819F0 Offset: 0x1D803F0 VA: 0x181D819F0
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[NullableContext(1)]
	// RVA: 0x1D81820 Offset: 0x1D80220 VA: 0x181D81820
	internal void .ctor(Type underlyingType) { }
}
