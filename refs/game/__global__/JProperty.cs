public class JProperty : JContainer // TypeDefIndex: 11337
{
	// Fields
	private readonly JProperty.JPropertyList _content; // 0x58
	private readonly string _name; // 0x60

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public string Name { get; }
	public JToken Value { get; set; }
	public override JTokenType Type { get; }

	// Methods

	// RVA: 0x1DBE7E0 Offset: 0x1DBD1E0 VA: 0x181DBE7E0 Slot: 12
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	[AsyncStateMachine(typeof(JProperty.<WriteToAsync>d__1))]
	// RVA: 0x1DBE6A0 Offset: 0x1DBD0A0 VA: 0x181DBE6A0
	private Task WriteToAsync(Task task, JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x1DBEA90 Offset: 0x1DBD490 VA: 0x181DBEA90
	private Task WriteValueAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x1DBDEC0 Offset: 0x1DBC8C0 VA: 0x181DBDEC0
	public static Task<JProperty> LoadAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JProperty.<LoadAsync>d__4))]
	// RVA: 0x1DBDD70 Offset: 0x1DBC770 VA: 0x181DBDD70
	public static Task<JProperty> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0 Slot: 75
	protected override IList<JToken> get_ChildrenTokens() { }

	[DebuggerStepThrough]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public string get_Name() { }

	[DebuggerStepThrough]
	// RVA: 0x1DBEEE0 Offset: 0x1DBD8E0 VA: 0x181DBEEE0
	public JToken get_Value() { }

	// RVA: 0x1DBEF00 Offset: 0x1DBD900 VA: 0x181DBEF00
	public void set_Value(JToken value) { }

	// RVA: 0x1DBEB10 Offset: 0x1DBD510 VA: 0x181DBEB10
	public void .ctor(JProperty other) { }

	// RVA: 0x1DBEBB0 Offset: 0x1DBD5B0 VA: 0x181DBEBB0
	internal void .ctor(JProperty other, JsonCloneSettings settings) { }

	// RVA: 0x1DBDB90 Offset: 0x1DBC590 VA: 0x181DBDB90 Slot: 84
	internal override JToken GetItem(int index) { }

	[NullableContext(2)]
	// RVA: 0x1DBE3B0 Offset: 0x1DBCDB0 VA: 0x181DBE3B0 Slot: 85
	internal override void SetItem(int index, JToken item) { }

	[NullableContext(2)]
	// RVA: 0x1DBE2F0 Offset: 0x1DBCCF0 VA: 0x181DBE2F0 Slot: 83
	internal override bool RemoveItem(JToken item) { }

	// RVA: 0x1DBE230 Offset: 0x1DBCC30 VA: 0x181DBE230 Slot: 82
	internal override void RemoveItemAt(int index) { }

	[NullableContext(2)]
	// RVA: 0x1DBDC00 Offset: 0x1DBC600 VA: 0x181DBDC00 Slot: 80
	internal override int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x1DBDC40 Offset: 0x1DBC640 VA: 0x181DBDC40 Slot: 81
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[NullableContext(2)]
	// RVA: 0x1DBDA50 Offset: 0x1DBC450 VA: 0x181DBDA50 Slot: 88
	internal override bool ContainsItem(JToken item) { }

	// RVA: 0x1DBE120 Offset: 0x1DBCB20 VA: 0x181DBE120 Slot: 92
	internal override void MergeItem(object content, JsonMergeSettings settings) { }

	// RVA: 0x1DBD8C0 Offset: 0x1DBC2C0 VA: 0x181DBD8C0 Slot: 86
	internal override void ClearItems() { }

	// RVA: 0x1DBDA70 Offset: 0x1DBC470 VA: 0x181DBDA70 Slot: 14
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x1DBD980 Offset: 0x1DBC380 VA: 0x181DBD980 Slot: 13
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160 Slot: 15
	public override JTokenType get_Type() { }

	// RVA: 0x1DBEC60 Offset: 0x1DBD660 VA: 0x181DBEC60
	internal void .ctor(string name) { }

	// RVA: 0x1DBEB00 Offset: 0x1DBD500 VA: 0x181DBEB00
	public void .ctor(string name, object[] content) { }

	// RVA: 0x1DBED40 Offset: 0x1DBD740 VA: 0x181DBED40
	public void .ctor(string name, object content) { }

	// RVA: 0x1DBE9F0 Offset: 0x1DBD3F0 VA: 0x181DBE9F0 Slot: 24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x1DBDB10 Offset: 0x1DBC510 VA: 0x181DBDB10 Slot: 25
	internal override int GetDeepHashCode() { }

	// RVA: 0x1DBDED0 Offset: 0x1DBC8D0 VA: 0x181DBDED0
	public static JProperty Load(JsonReader reader) { }

	// RVA: 0x1DBDEE0 Offset: 0x1DBC8E0 VA: 0x181DBDEE0
	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }
}
