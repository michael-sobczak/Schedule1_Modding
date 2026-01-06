public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging // TypeDefIndex: 11332
{
	// Fields
	private readonly JPropertyKeyedCollection _properties; // 0x58
	[Nullable(2)]
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; // 0x60
	[CompilerGenerated]
	[Nullable(2)]
	private PropertyChangingEventHandler PropertyChanging; // 0x68

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	[Nullable(2)]
	public override JToken Item { get; set; }
	[Nullable(2)]
	public JToken Item { get; set; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get; }
	[Nullable(new[] { 1, 2 })]
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x1DBB490 Offset: 0x1DB9E90 VA: 0x181DBB490 Slot: 12
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x1DB9690 Offset: 0x1DB8090 VA: 0x181DB9690
	public static Task<JObject> LoadAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JObject.<LoadAsync>d__2))]
	// RVA: 0x1DB9540 Offset: 0x1DB7F40 VA: 0x181DB9540
	public static Task<JObject> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0 Slot: 75
	protected override IList<JToken> get_ChildrenTokens() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x1DBBA00 Offset: 0x1DBA400 VA: 0x181DBBA00 Slot: 121
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1DBBCD0 Offset: 0x1DBA6D0 VA: 0x181DBBCD0 Slot: 122
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1DBBAA0 Offset: 0x1DBA4A0 VA: 0x181DBBAA0 Slot: 123
	public void add_PropertyChanging(PropertyChangingEventHandler value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1DBBD70 Offset: 0x1DBA770 VA: 0x181DBBD70 Slot: 124
	public void remove_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: 0x1DBB960 Offset: 0x1DBA360 VA: 0x181DBB960
	public void .ctor() { }

	// RVA: 0x1DBB850 Offset: 0x1DBA250 VA: 0x181DBB850
	public void .ctor(JObject other) { }

	// RVA: 0x1DBB8D0 Offset: 0x1DBA2D0 VA: 0x181DBB8D0
	internal void .ctor(JObject other, JsonCloneSettings settings) { }

	// RVA: 0x1DBB790 Offset: 0x1DBA190 VA: 0x181DBB790
	public void .ctor(object[] content) { }

	// RVA: 0x1DBB790 Offset: 0x1DBA190 VA: 0x181DBB790
	public void .ctor(object content) { }

	// RVA: 0x1DB8CA0 Offset: 0x1DB76A0 VA: 0x181DB8CA0 Slot: 14
	internal override bool DeepEquals(JToken node) { }

	[NullableContext(2)]
	// RVA: 0x1DB91F0 Offset: 0x1DB7BF0 VA: 0x181DB91F0 Slot: 80
	internal override int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x1DB92B0 Offset: 0x1DB7CB0 VA: 0x181DB92B0 Slot: 81
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0x1DBB1A0 Offset: 0x1DB9BA0 VA: 0x181DBB1A0 Slot: 90
	internal override void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0x1DB98B0 Offset: 0x1DB82B0 VA: 0x181DB98B0 Slot: 92
	internal override void MergeItem(object content, JsonMergeSettings settings) { }

	// RVA: 0x1DB94B0 Offset: 0x1DB7EB0 VA: 0x181DB94B0
	private static bool IsNull(JToken token) { }

	// RVA: 0x1DB9330 Offset: 0x1DB7D30 VA: 0x181DB9330
	internal void InternalPropertyChanged(JProperty childProperty) { }

	// RVA: 0x1DB9480 Offset: 0x1DB7E80 VA: 0x181DB9480
	internal void InternalPropertyChanging(JProperty childProperty) { }

	// RVA: 0x1DB8AF0 Offset: 0x1DB74F0 VA: 0x181DB8AF0 Slot: 13
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 15
	public override JTokenType get_Type() { }

	// RVA: 0x1DB9ED0 Offset: 0x1DB88D0 VA: 0x181DB9ED0
	public IEnumerable<JProperty> Properties() { }

	// RVA: 0x1DBA270 Offset: 0x1DB8C70 VA: 0x181DBA270
	public JProperty Property(string name) { }

	// RVA: 0x1DBA090 Offset: 0x1DB8A90 VA: 0x181DBA090
	public JProperty Property(string name, StringComparison comparison) { }

	// RVA: 0x1DB9F10 Offset: 0x1DB8910 VA: 0x181DB9F10
	public JEnumerable<JToken> PropertyValues() { }

	// RVA: 0x1DBBB40 Offset: 0x1DBA540 VA: 0x181DBBB40 Slot: 17
	public override JToken get_Item(object key) { }

	// RVA: 0x1DBBF10 Offset: 0x1DBA910 VA: 0x181DBBF10 Slot: 18
	public override void set_Item(object key, JToken value) { }

	// RVA: 0x1DBBC50 Offset: 0x1DBA650 VA: 0x181DBBC50 Slot: 93
	public JToken get_Item(string propertyName) { }

	// RVA: 0x1DBBE10 Offset: 0x1DBA810 VA: 0x181DBBE10 Slot: 94
	public void set_Item(string propertyName, JToken value) { }

	// RVA: 0x1DB96A0 Offset: 0x1DB80A0 VA: 0x181DB96A0
	public static JObject Load(JsonReader reader) { }

	// RVA: 0x1DB96B0 Offset: 0x1DB80B0 VA: 0x181DB96B0
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x1DB9D70 Offset: 0x1DB8770 VA: 0x181DB9D70
	public static JObject Parse(string json) { }

	// RVA: 0x1DB9D80 Offset: 0x1DB8780 VA: 0x181DB9D80
	public static JObject Parse(string json, JsonLoadSettings settings) { }

	// RVA: 0x1DB8D30 Offset: 0x1DB7730 VA: 0x181DB8D30
	public static JObject FromObject(object o) { }

	// RVA: 0x1DB8EB0 Offset: 0x1DB78B0 VA: 0x181DB8EB0
	public static JObject FromObject(object o, JsonSerializer jsonSerializer) { }

	// RVA: 0x1DBB670 Offset: 0x1DBA070 VA: 0x181DBB670 Slot: 24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[NullableContext(2)]
	// RVA: 0x1DB91B0 Offset: 0x1DB7BB0 VA: 0x181DB91B0
	public JToken GetValue(string propertyName) { }

	[NullableContext(2)]
	// RVA: 0x1DB9170 Offset: 0x1DB7B70 VA: 0x181DB9170
	public JToken GetValue(string propertyName, StringComparison comparison) { }

	// RVA: 0x1DBAFA0 Offset: 0x1DB99A0 VA: 0x181DBAFA0
	public bool TryGetValue(string propertyName, StringComparison comparison, out JToken value) { }

	// RVA: 0x1DB8A60 Offset: 0x1DB7460 VA: 0x181DB8A60 Slot: 98
	public void Add(string propertyName, JToken value) { }

	// RVA: 0x1DB8BB0 Offset: 0x1DB75B0 VA: 0x181DB8BB0 Slot: 97
	public bool ContainsKey(string propertyName) { }

	// RVA: 0x1DBA960 Offset: 0x1DB9360 VA: 0x181DBA960 Slot: 95
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	// RVA: 0x1DBA280 Offset: 0x1DB8C80 VA: 0x181DBA280 Slot: 99
	public bool Remove(string propertyName) { }

	// RVA: 0x1DBAFF0 Offset: 0x1DB99F0 VA: 0x181DBAFF0 Slot: 100
	public bool TryGetValue(string propertyName, out JToken value) { }

	// RVA: 0x1DBA9C0 Offset: 0x1DB93C0 VA: 0x181DBA9C0 Slot: 96
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	// RVA: 0x1DBA320 Offset: 0x1DB8D20 VA: 0x181DBA320 Slot: 103
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<string, JToken> item) { }

	// RVA: 0x70D2D0 Offset: 0x70BCD0 VA: 0x18070D2D0 Slot: 104
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	// RVA: 0x1DBA3C0 Offset: 0x1DB8DC0 VA: 0x181DBA3C0 Slot: 105
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<string, JToken> item) { }

	// RVA: 0x1DBA450 Offset: 0x1DB8E50 VA: 0x181DBA450 Slot: 106
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 102
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	// RVA: 0x1DBA7E0 Offset: 0x1DB91E0 VA: 0x181DBA7E0 Slot: 107
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<string, JToken> item) { }

	// RVA: 0x1D97D20 Offset: 0x1D96720 VA: 0x181D97D20 Slot: 25
	internal override int GetDeepHashCode() { }

	[IteratorStateMachine(typeof(JObject.<GetEnumerator>d__64))]
	// RVA: 0x1DB9030 Offset: 0x1DB7A30 VA: 0x181DB9030 Slot: 108
	public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator() { }

	// RVA: 0x1DB9C50 Offset: 0x1DB8650 VA: 0x181DB9C50 Slot: 125
	protected virtual void OnPropertyChanged(string propertyName) { }

	// RVA: 0x1DB9CE0 Offset: 0x1DB86E0 VA: 0x181DB9CE0 Slot: 126
	protected virtual void OnPropertyChanging(string propertyName) { }

	// RVA: 0x1DBAE70 Offset: 0x1DB9870 VA: 0x181DBAE70 Slot: 118
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1DBAB40 Offset: 0x1DB9540 VA: 0x181DBAB40 Slot: 119
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x1DBAA00 Offset: 0x1DB9400 VA: 0x181DBAA00 Slot: 109
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	[NullableContext(2)]
	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 110
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	[NullableContext(2)]
	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 111
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x1DBAA50 Offset: 0x1DB9450 VA: 0x181DBAA50 Slot: 112
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	[NullableContext(2)]
	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 113
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	[NullableContext(2)]
	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 114
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 115
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1DBAAA0 Offset: 0x1DB94A0 VA: 0x181DBAAA0 Slot: 117
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x1DBAAF0 Offset: 0x1DB94F0 VA: 0x181DBAAF0 Slot: 116
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	[NullableContext(2)]
	// RVA: 0x1DBAF20 Offset: 0x1DB9920 VA: 0x181DBAF20 Slot: 120
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0x1DB90A0 Offset: 0x1DB7AA0 VA: 0x181DB90A0 Slot: 26
	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

	[AsyncStateMachine(typeof(JObject.<<WriteToAsync>g__AwaitProperties|0_0>d))]
	[CompilerGenerated]
	// RVA: 0x1DBB050 Offset: 0x1DB9A50 VA: 0x181DBB050
	private Task <WriteToAsync>g__AwaitProperties|0_0(Task task, int i, JsonWriter Writer, CancellationToken CancellationToken, JsonConverter[] Converters) { }
}
