public class JConstructor : JContainer // TypeDefIndex: 11320
{
	// Fields
	[Nullable(2)]
	private string _name; // 0x58
	private readonly List<JToken> _values; // 0x60

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	[Nullable(2)]
	public string Name { get; set; }
	public override JTokenType Type { get; }
	[Nullable(2)]
	public override JToken Item { get; set; }

	// Methods

	[AsyncStateMachine(typeof(JConstructor.<WriteToAsync>d__0))]
	// RVA: 0x1DB3410 Offset: 0x1DB1E10 VA: 0x181DB3410 Slot: 12
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x1DB3110 Offset: 0x1DB1B10 VA: 0x181DB3110
	public static Task<JConstructor> LoadAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JConstructor.<LoadAsync>d__2))]
	// RVA: 0x1DB2FC0 Offset: 0x1DB19C0 VA: 0x181DB2FC0
	public static Task<JConstructor> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0 Slot: 75
	protected override IList<JToken> get_ChildrenTokens() { }

	[NullableContext(2)]
	// RVA: 0x1DB2F60 Offset: 0x1DB1960 VA: 0x181DB2F60 Slot: 80
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0x1DB3370 Offset: 0x1DB1D70 VA: 0x181DB3370 Slot: 92
	internal override void MergeItem(object content, JsonMergeSettings settings) { }

	[NullableContext(2)]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_Name() { }

	[NullableContext(2)]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_Name(string value) { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 15
	public override JTokenType get_Type() { }

	// RVA: 0x1DB3980 Offset: 0x1DB2380 VA: 0x181DB3980
	public void .ctor() { }

	// RVA: 0x1DB3690 Offset: 0x1DB2090 VA: 0x181DB3690
	public void .ctor(JConstructor other) { }

	// RVA: 0x1DB38C0 Offset: 0x1DB22C0 VA: 0x181DB38C0
	internal void .ctor(JConstructor other, JsonCloneSettings settings) { }

	// RVA: 0x1DB3650 Offset: 0x1DB2050 VA: 0x181DB3650
	public void .ctor(string name, object[] content) { }

	// RVA: 0x1DB3650 Offset: 0x1DB2050 VA: 0x181DB3650
	public void .ctor(string name, object content) { }

	// RVA: 0x1DB3740 Offset: 0x1DB2140 VA: 0x181DB3740
	public void .ctor(string name) { }

	// RVA: 0x1DB2E70 Offset: 0x1DB1870 VA: 0x181DB2E70 Slot: 14
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x1DB2D90 Offset: 0x1DB1790 VA: 0x181DB2D90 Slot: 13
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0x1DB3550 Offset: 0x1DB1F50 VA: 0x181DB3550 Slot: 24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x1DB3A30 Offset: 0x1DB2430 VA: 0x181DB3A30 Slot: 17
	public override JToken get_Item(object key) { }

	// RVA: 0x1DB3B60 Offset: 0x1DB2560 VA: 0x181DB3B60 Slot: 18
	public override void set_Item(object key, JToken value) { }

	// RVA: 0x1DB2F10 Offset: 0x1DB1910 VA: 0x181DB2F10 Slot: 25
	internal override int GetDeepHashCode() { }

	// RVA: 0x1DB3120 Offset: 0x1DB1B20 VA: 0x181DB3120
	public static JConstructor Load(JsonReader reader) { }

	// RVA: 0x1DB3130 Offset: 0x1DB1B30 VA: 0x181DB3130
	public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }
}
