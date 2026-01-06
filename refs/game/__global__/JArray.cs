public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 11317
{
	// Fields
	private readonly List<JToken> _values; // 0x58

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	[Nullable(2)]
	public override JToken Item { get; set; }
	public JToken Item { get; set; }
	public bool IsReadOnly { get; }

	// Methods

	[AsyncStateMachine(typeof(JArray.<WriteToAsync>d__0))]
	// RVA: 0x1D98570 Offset: 0x1D96F70 VA: 0x181D98570 Slot: 12
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x1D97E60 Offset: 0x1D96860 VA: 0x181D97E60
	public static Task<JArray> LoadAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JArray.<LoadAsync>d__2))]
	// RVA: 0x1D97FA0 Offset: 0x1D969A0 VA: 0x181D97FA0
	public static Task<JArray> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0 Slot: 75
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 15
	public override JTokenType get_Type() { }

	// RVA: 0x1D987A0 Offset: 0x1D971A0 VA: 0x181D987A0
	public void .ctor() { }

	// RVA: 0x1D988C0 Offset: 0x1D972C0 VA: 0x181D988C0
	public void .ctor(JArray other) { }

	// RVA: 0x1D98950 Offset: 0x1D97350 VA: 0x181D98950
	internal void .ctor(JArray other, JsonCloneSettings settings) { }

	// RVA: 0x1D98820 Offset: 0x1D97220 VA: 0x181D98820
	public void .ctor(object[] content) { }

	// RVA: 0x1D98820 Offset: 0x1D97220 VA: 0x181D98820
	public void .ctor(object content) { }

	// RVA: 0x1D97990 Offset: 0x1D96390 VA: 0x181D97990 Slot: 14
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x1D97880 Offset: 0x1D96280 VA: 0x181D97880 Slot: 13
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0x1D982D0 Offset: 0x1D96CD0 VA: 0x181D982D0
	public static JArray Load(JsonReader reader) { }

	// RVA: 0x1D980F0 Offset: 0x1D96AF0 VA: 0x181D980F0
	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x1D98520 Offset: 0x1D96F20 VA: 0x181D98520
	public static JArray Parse(string json) { }

	// RVA: 0x1D983D0 Offset: 0x1D96DD0 VA: 0x181D983D0
	public static JArray Parse(string json, JsonLoadSettings settings) { }

	// RVA: 0x1D97A20 Offset: 0x1D96420 VA: 0x181D97A20
	public static JArray FromObject(object o) { }

	// RVA: 0x1D97BA0 Offset: 0x1D965A0 VA: 0x181D97BA0
	public static JArray FromObject(object o, JsonSerializer jsonSerializer) { }

	// RVA: 0x1D986B0 Offset: 0x1D970B0 VA: 0x181D986B0 Slot: 24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x1D989F0 Offset: 0x1D973F0 VA: 0x181D989F0 Slot: 17
	public override JToken get_Item(object key) { }

	// RVA: 0x1D98B60 Offset: 0x1D97560 VA: 0x181D98B60 Slot: 18
	public override void set_Item(object key, JToken value) { }

	// RVA: 0x1D98B20 Offset: 0x1D97520 VA: 0x181D98B20 Slot: 27
	public JToken get_Item(int index) { }

	// RVA: 0x1D98B40 Offset: 0x1D97540 VA: 0x181D98B40 Slot: 28
	public void set_Item(int index, JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1D97DB0 Offset: 0x1D967B0 VA: 0x181D97DB0 Slot: 80
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0x1D982E0 Offset: 0x1D96CE0 VA: 0x181D982E0 Slot: 92
	internal override void MergeItem(object content, JsonMergeSettings settings) { }

	// RVA: 0x1D97E10 Offset: 0x1D96810 VA: 0x181D97E10 Slot: 29
	public int IndexOf(JToken item) { }

	// RVA: 0x1D97E30 Offset: 0x1D96830 VA: 0x181D97E30 Slot: 30
	public void Insert(int index, JToken item) { }

	// RVA: 0x1D98530 Offset: 0x1D96F30 VA: 0x181D98530 Slot: 31
	public void RemoveAt(int index) { }

	// RVA: 0x1D97D30 Offset: 0x1D96730 VA: 0x181D97D30 Slot: 5
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0x1D97860 Offset: 0x1D96260 VA: 0x181D97860 Slot: 34
	public void Add(JToken item) { }

	// RVA: 0x70D2D0 Offset: 0x70BCD0 VA: 0x18070D2D0 Slot: 35
	public void Clear() { }

	// RVA: 0x1D97950 Offset: 0x1D96350 VA: 0x181D97950 Slot: 36
	public bool Contains(JToken item) { }

	// RVA: 0x1D97970 Offset: 0x1D96370 VA: 0x181D97970 Slot: 37
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 33
	public bool get_IsReadOnly() { }

	// RVA: 0x1D98550 Offset: 0x1D96F50 VA: 0x181D98550 Slot: 38
	public bool Remove(JToken item) { }

	// RVA: 0x1D97D20 Offset: 0x1D96720 VA: 0x181D97D20 Slot: 25
	internal override int GetDeepHashCode() { }
}
