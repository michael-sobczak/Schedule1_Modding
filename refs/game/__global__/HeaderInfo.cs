internal abstract class HeaderInfo // TypeDefIndex: 17729
{
	// Fields
	public bool AllowsMany; // 0x10
	public readonly HttpHeaderKind HeaderKind; // 0x14
	public readonly string Name; // 0x18
	[CompilerGenerated]
	private Func<object, string> <CustomToString>k__BackingField; // 0x20

	// Properties
	public Func<object, string> CustomToString { get; set; }
	public virtual string Separator { get; }

	// Methods

	// RVA: 0x2182B40 Offset: 0x2181540 VA: 0x182182B40
	protected void .ctor(string name, HttpHeaderKind headerKind) { }

	// RVA: -1 Offset: -1
	public static HeaderInfo CreateSingle<T>(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, Func<object, string> toString) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC44E0 Offset: 0xEC2EE0 VA: 0x180EC44E0
	|-HeaderInfo.CreateSingle<DateTimeOffset>
	|-HeaderInfo.CreateSingle<int>
	|-HeaderInfo.CreateSingle<long>
	|-HeaderInfo.CreateSingle<object>
	|-HeaderInfo.CreateSingle<TimeSpan>
	|
	|-RVA: 0xEC45A0 Offset: 0xEC2FA0 VA: 0x180EC45A0
	|-HeaderInfo.CreateSingle<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static HeaderInfo CreateMulti<T>(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1, string separator = ", ") { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC4430 Offset: 0xEC2E30 VA: 0x180EC4430
	|-HeaderInfo.CreateMulti<object>
	*/

	// RVA: 0x2182B20 Offset: 0x2181520 VA: 0x182182B20
	public object CreateCollection(HttpHeaders headers) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Func<object, string> get_CustomToString() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_CustomToString(Func<object, string> value) { }

	// RVA: 0x2182B90 Offset: 0x2181590 VA: 0x182182B90 Slot: 4
	public virtual string get_Separator() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AddToCollection(object collection, object value);

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract List<string> ToStringCollection(object collection);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool TryParse(string value, out object result);
}
