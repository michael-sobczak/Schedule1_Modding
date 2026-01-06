public sealed class ExpandoObject : IDynamicMetaObjectProvider, IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged // TypeDefIndex: 15640
{
	// Fields
	private static readonly MethodInfo s_expandoTryGetValue; // 0x0
	private static readonly MethodInfo s_expandoTrySetValue; // 0x8
	private static readonly MethodInfo s_expandoTryDeleteValue; // 0x10
	private static readonly MethodInfo s_expandoPromoteClass; // 0x18
	private static readonly MethodInfo s_expandoCheckVersion; // 0x20
	internal readonly object LockObject; // 0x10
	private ExpandoObject.ExpandoData _data; // 0x18
	private int _count; // 0x20
	internal static readonly object Uninitialized; // 0x28
	private PropertyChangedEventHandler _propertyChanged; // 0x28

	// Properties
	internal ExpandoClass Class { get; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys { get; }
	private ICollection<object> System.Collections.Generic.IDictionary<System.String,System.Object>.Values { get; }
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.Item { get; set; }
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x1FEC0E0 Offset: 0x1FEAAE0 VA: 0x181FEC0E0
	public void .ctor() { }

	// RVA: 0x1FEB9A0 Offset: 0x1FEA3A0 VA: 0x181FEB9A0
	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	// RVA: 0x1FEBAF0 Offset: 0x1FEA4F0 VA: 0x181FEBAF0
	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

	// RVA: 0x1FEB690 Offset: 0x1FEA090 VA: 0x181FEB690
	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	// RVA: 0x1FEA8B0 Offset: 0x1FE92B0 VA: 0x181FEA8B0
	internal bool IsDeletedMember(int index) { }

	// RVA: 0x1DF3BE0 Offset: 0x1DF25E0 VA: 0x181DF3BE0
	internal ExpandoClass get_Class() { }

	// RVA: 0x1FEA950 Offset: 0x1FE9350 VA: 0x181FEA950
	private ExpandoObject.ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	// RVA: 0x1FEA9A0 Offset: 0x1FE93A0 VA: 0x181FEA9A0
	internal void PromoteClass(object oldClass, object newClass) { }

	// RVA: 0x1FEB590 Offset: 0x1FE9F90 VA: 0x181FEB590 Slot: 4
	private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0x1FEB600 Offset: 0x1FEA000 VA: 0x181FEB600
	private void TryAddMember(string key, object value) { }

	// RVA: 0x1FEB370 Offset: 0x1FE9D70 VA: 0x181FEB370
	private bool TryGetValueForKey(string key, out object value) { }

	// RVA: 0x1FEA7E0 Offset: 0x1FE91E0 VA: 0x181FEA7E0
	private bool ExpandoContainsKey(string key) { }

	// RVA: 0x1FEB410 Offset: 0x1FE9E10 VA: 0x181FEB410 Slot: 7
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }

	// RVA: 0x1FEB470 Offset: 0x1FE9E70 VA: 0x181FEB470 Slot: 8
	private ICollection<object> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values() { }

	// RVA: 0x1FEB3A0 Offset: 0x1FE9DA0 VA: 0x181FEB3A0 Slot: 5
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	// RVA: 0x1FEB4D0 Offset: 0x1FE9ED0 VA: 0x181FEB4D0 Slot: 6
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(string key, object value) { }

	// RVA: 0x1FEB1E0 Offset: 0x1FE9BE0 VA: 0x181FEB1E0 Slot: 10
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	// RVA: 0x1FEB1F0 Offset: 0x1FE9BF0 VA: 0x181FEB1F0 Slot: 9
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	// RVA: 0x1FEB2C0 Offset: 0x1FE9CC0 VA: 0x181FEB2C0 Slot: 11
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(string key) { }

	// RVA: 0x1FEB370 Offset: 0x1FE9D70 VA: 0x181FEB370 Slot: 12
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 13
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	// RVA: 0x1FEAB20 Offset: 0x1FE9520 VA: 0x181FEAB20 Slot: 15
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item) { }

	// RVA: 0x1FEAB80 Offset: 0x1FE9580 VA: 0x181FEAB80 Slot: 16
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	// RVA: 0x1FEADD0 Offset: 0x1FE97D0 VA: 0x181FEADD0 Slot: 17
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item) { }

	// RVA: 0x1FEAE70 Offset: 0x1FE9870 VA: 0x181FEAE70 Slot: 18
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) { }

	// RVA: 0x1FEB170 Offset: 0x1FE9B70 VA: 0x181FEB170 Slot: 19
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item) { }

	// RVA: 0x1FEB560 Offset: 0x1FE9F60 VA: 0x181FEB560 Slot: 20
	private IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x1FEB560 Offset: 0x1FE9F60 VA: 0x181FEB560 Slot: 21
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachine(typeof(ExpandoObject.<GetExpandoEnumerator>d__51))]
	// RVA: 0x1FEA810 Offset: 0x1FE9210 VA: 0x181FEA810
	private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoObject.ExpandoData data, int version) { }

	// RVA: 0x1FEBE50 Offset: 0x1FEA850 VA: 0x181FEBE50
	private static void .cctor() { }
}
