public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider // TypeDefIndex: 11353
{
	// Fields
	[Nullable(2)]
	private static JTokenEqualityComparer _equalityComparer; // 0x0
	[Nullable(2)]
	private JContainer _parent; // 0x10
	[Nullable(2)]
	private JToken _previous; // 0x18
	[Nullable(2)]
	private JToken _next; // 0x20
	[Nullable(2)]
	private object _annotations; // 0x28
	private static readonly JTokenType[] BooleanTypes; // 0x8
	private static readonly JTokenType[] NumberTypes; // 0x10
	private static readonly JTokenType[] BigIntegerTypes; // 0x18
	private static readonly JTokenType[] StringTypes; // 0x20
	private static readonly JTokenType[] GuidTypes; // 0x28
	private static readonly JTokenType[] TimeSpanTypes; // 0x30
	private static readonly JTokenType[] UriTypes; // 0x38
	private static readonly JTokenType[] CharTypes; // 0x40
	private static readonly JTokenType[] DateTimeTypes; // 0x48
	private static readonly JTokenType[] BytesTypes; // 0x50

	// Properties
	public static JTokenEqualityComparer EqualityComparer { get; }
	[Nullable(2)]
	public JContainer Parent { get; set; }
	public JToken Root { get; }
	public abstract JTokenType Type { get; }
	public abstract bool HasValues { get; }
	[Nullable(2)]
	public JToken Next { get; set; }
	[Nullable(2)]
	public JToken Previous { get; set; }
	public string Path { get; }
	[Nullable(2)]
	public virtual JToken Item { get; set; }
	[Nullable(2)]
	public virtual JToken First { get; }
	[Nullable(2)]
	public virtual JToken Last { get; }
	private IJEnumerable<JToken> Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.Item { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x1DC3180 Offset: 0x1DC1B80 VA: 0x181DC3180 Slot: 12
	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x1DC31C0 Offset: 0x1DC1BC0 VA: 0x181DC31C0
	public Task WriteToAsync(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x1DC0820 Offset: 0x1DBF220 VA: 0x181DC0820
	public static Task<JToken> ReadFromAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JToken.<ReadFromAsync>d__3))]
	// RVA: 0x1DC06E0 Offset: 0x1DBF0E0 VA: 0x181DC06E0
	public static Task<JToken> ReadFromAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x1DC0280 Offset: 0x1DBEC80 VA: 0x181DC0280
	public static Task<JToken> LoadAsync(JsonReader reader, CancellationToken cancellationToken) { }

	// RVA: 0x1DC0210 Offset: 0x1DBEC10 VA: 0x181DC0210
	public static Task<JToken> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x1DC35D0 Offset: 0x1DC1FD0 VA: 0x181DC35D0
	public static JTokenEqualityComparer get_EqualityComparer() { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public JContainer get_Parent() { }

	[NullableContext(2)]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	internal void set_Parent(JContainer value) { }

	// RVA: 0x1DC3B70 Offset: 0x1DC2570 VA: 0x181DC3B70
	public JToken get_Root() { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract JToken CloneToken(JsonCloneSettings settings);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract bool DeepEquals(JToken node);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract JTokenType get_Type();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool get_HasValues();

	[NullableContext(2)]
	// RVA: 0x1DBFC80 Offset: 0x1DBE680 VA: 0x181DBFC80
	public static bool DeepEquals(JToken t1, JToken t2) { }

	[NullableContext(2)]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public JToken get_Next() { }

	[NullableContext(2)]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void set_Next(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public JToken get_Previous() { }

	[NullableContext(2)]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_Previous(JToken value) { }

	// RVA: 0x1DC38A0 Offset: 0x1DC22A0 VA: 0x181DC38A0
	public string get_Path() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	[NullableContext(2)]
	// RVA: 0x1DBF380 Offset: 0x1DBDD80 VA: 0x181DBF380
	public void AddAfterSelf(object content) { }

	[NullableContext(2)]
	// RVA: 0x1DBF6F0 Offset: 0x1DBE0F0 VA: 0x181DBF6F0
	public void AddBeforeSelf(object content) { }

	// RVA: 0x1DBF830 Offset: 0x1DBE230 VA: 0x181DBF830
	public IEnumerable<JToken> Ancestors() { }

	// RVA: 0x1DBF820 Offset: 0x1DBE220 VA: 0x181DBF820
	public IEnumerable<JToken> AncestorsAndSelf() { }

	[IteratorStateMachine(typeof(JToken.<GetAncestors>d__48))]
	// RVA: 0x1DBFFE0 Offset: 0x1DBE9E0 VA: 0x181DBFFE0
	internal IEnumerable<JToken> GetAncestors(bool self) { }

	[IteratorStateMachine(typeof(JToken.<AfterSelf>d__49))]
	// RVA: 0x1DBF7A0 Offset: 0x1DBE1A0 VA: 0x181DBF7A0
	public IEnumerable<JToken> AfterSelf() { }

	[IteratorStateMachine(typeof(JToken.<BeforeSelf>d__50))]
	// RVA: 0x1DBFA60 Offset: 0x1DBE460 VA: 0x181DBFA60
	public IEnumerable<JToken> BeforeSelf() { }

	// RVA: 0x1DC3760 Offset: 0x1DC2160 VA: 0x181DC3760 Slot: 17
	public virtual JToken get_Item(object key) { }

	// RVA: 0x1DCAAC0 Offset: 0x1DC94C0 VA: 0x181DCAAC0 Slot: 18
	public virtual void set_Item(object key, JToken value) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 19
	public virtual T Value<T>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4CD0 Offset: 0xEE36D0 VA: 0x180EE4CD0
	|-JToken.Value<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	// RVA: 0x1DC36C0 Offset: 0x1DC20C0 VA: 0x181DC36C0 Slot: 20
	public virtual JToken get_First() { }

	[NullableContext(2)]
	// RVA: 0x1DC3800 Offset: 0x1DC2200 VA: 0x181DC3800 Slot: 21
	public virtual JToken get_Last() { }

	// RVA: 0x1DBFAE0 Offset: 0x1DBE4E0 VA: 0x181DBFAE0 Slot: 22
	public virtual JEnumerable<JToken> Children() { }

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	public JEnumerable<T> Children<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE47C0 Offset: 0xEE31C0 VA: 0x180EE47C0
	|-JToken.Children<object>
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 23
	public virtual IEnumerable<T> Values<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4E00 Offset: 0xEE3800 VA: 0x180EE4E00
	|-JToken.Values<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1DC0F00 Offset: 0x1DBF900 VA: 0x181DC0F00
	public void Remove() { }

	// RVA: 0x1DC0F80 Offset: 0x1DBF980 VA: 0x181DC0F80
	public void Replace(JToken value) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters);

	// RVA: 0x1DC2E40 Offset: 0x1DC1840 VA: 0x181DC2E40 Slot: 3
	public override string ToString() { }

	// RVA: 0x1DC2EF0 Offset: 0x1DC18F0 VA: 0x181DC2EF0
	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	// RVA: 0x1DBFCB0 Offset: 0x1DBE6B0 VA: 0x181DBFCB0
	private static JValue EnsureValue(JToken value) { }

	// RVA: 0x1DC0130 Offset: 0x1DBEB30 VA: 0x181DC0130
	private static string GetType(JToken token) { }

	// RVA: 0x1DC30A0 Offset: 0x1DC1AA0 VA: 0x181DC30A0
	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	// RVA: 0x1DC6660 Offset: 0x1DC5060 VA: 0x181DC6660
	public static bool op_Explicit(JToken value) { }

	// RVA: 0x1DC5060 Offset: 0x1DC3A60 VA: 0x181DC5060
	public static DateTimeOffset op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC8000 Offset: 0x1DC6A00 VA: 0x181DC8000
	public static Nullable<bool> op_Explicit(JToken value) { }

	// RVA: 0x1DC8CC0 Offset: 0x1DC76C0 VA: 0x181DC8CC0
	public static long op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC7AC0 Offset: 0x1DC64C0 VA: 0x181DC7AC0
	public static Nullable<DateTime> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC4D30 Offset: 0x1DC3730 VA: 0x181DC4D30
	public static Nullable<DateTimeOffset> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC7520 Offset: 0x1DC5F20 VA: 0x181DC7520
	public static Nullable<Decimal> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC9670 Offset: 0x1DC8070 VA: 0x181DC9670
	public static Nullable<double> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC55A0 Offset: 0x1DC3FA0 VA: 0x181DC55A0
	public static Nullable<char> op_Explicit(JToken value) { }

	// RVA: 0x1DC60F0 Offset: 0x1DC4AF0 VA: 0x181DC60F0
	public static int op_Explicit(JToken value) { }

	// RVA: 0x1DC6B20 Offset: 0x1DC5520 VA: 0x181DC6B20
	public static short op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DC82B0 Offset: 0x1DC6CB0 VA: 0x181DC82B0
	public static ushort op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DC8520 Offset: 0x1DC6F20 VA: 0x181DC8520
	public static char op_Explicit(JToken value) { }

	// RVA: 0x1DC9900 Offset: 0x1DC8300 VA: 0x181DC9900
	public static byte op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DC7020 Offset: 0x1DC5A20 VA: 0x181DC7020
	public static sbyte op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC7820 Offset: 0x1DC6220 VA: 0x181DC7820
	public static Nullable<int> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC5BB0 Offset: 0x1DC45B0 VA: 0x181DC5BB0
	public static Nullable<short> op_Explicit(JToken value) { }

	[NullableContext(2)]
	[CLSCompliant(False)]
	// RVA: 0x1DC8790 Offset: 0x1DC7190 VA: 0x181DC8790
	public static Nullable<ushort> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC45B0 Offset: 0x1DC2FB0 VA: 0x181DC45B0
	public static Nullable<byte> op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	// RVA: 0x1DC8A30 Offset: 0x1DC7430 VA: 0x181DC8A30
	public static Nullable<sbyte> op_Explicit(JToken value) { }

	// RVA: 0x1DC4AD0 Offset: 0x1DC34D0 VA: 0x181DC4AD0
	public static DateTime op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC7290 Offset: 0x1DC5C90 VA: 0x181DC7290
	public static Nullable<long> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC40A0 Offset: 0x1DC2AA0 VA: 0x181DC40A0
	public static Nullable<float> op_Explicit(JToken value) { }

	// RVA: 0x1DC3E10 Offset: 0x1DC2810 VA: 0x181DC3E10
	public static Decimal op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	// RVA: 0x1DC5E50 Offset: 0x1DC4850 VA: 0x181DC5E50
	public static Nullable<uint> op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	// RVA: 0x1DC6D90 Offset: 0x1DC5790 VA: 0x181DC6D90
	public static Nullable<ulong> op_Explicit(JToken value) { }

	// RVA: 0x1DC91A0 Offset: 0x1DC7BA0 VA: 0x181DC91A0
	public static double op_Explicit(JToken value) { }

	// RVA: 0x1DC5330 Offset: 0x1DC3D30 VA: 0x181DC5330
	public static float op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC7D30 Offset: 0x1DC6730 VA: 0x181DC7D30
	public static string op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DC4340 Offset: 0x1DC2D40 VA: 0x181DC4340
	public static uint op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DC3BA0 Offset: 0x1DC25A0 VA: 0x181DC3BA0
	public static ulong op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC5840 Offset: 0x1DC4240 VA: 0x181DC5840
	public static byte[] op_Explicit(JToken value) { }

	// RVA: 0x1DC4840 Offset: 0x1DC3240 VA: 0x181DC4840
	public static Guid op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC6360 Offset: 0x1DC4D60 VA: 0x181DC6360
	public static Nullable<Guid> op_Explicit(JToken value) { }

	// RVA: 0x1DC9410 Offset: 0x1DC7E10 VA: 0x181DC9410
	public static TimeSpan op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC8F30 Offset: 0x1DC7930 VA: 0x181DC8F30
	public static Nullable<TimeSpan> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1DC68F0 Offset: 0x1DC52F0 VA: 0x181DC68F0
	public static Uri op_Explicit(JToken value) { }

	// RVA: 0x1DC1890 Offset: 0x1DC0290 VA: 0x181DC1890
	private static BigInteger ToBigInteger(JToken value) { }

	// RVA: 0x1DC1610 Offset: 0x1DC0010 VA: 0x181DC1610
	private static Nullable<BigInteger> ToBigIntegerNullable(JToken value) { }

	// RVA: 0x1DCA3B0 Offset: 0x1DC8DB0 VA: 0x181DCA3B0
	public static JToken op_Implicit(bool value) { }

	// RVA: 0x1DC9CD0 Offset: 0x1DC86D0 VA: 0x181DC9CD0
	public static JToken op_Implicit(DateTimeOffset value) { }

	// RVA: 0x1DCA7C0 Offset: 0x1DC91C0 VA: 0x181DCA7C0
	public static JToken op_Implicit(byte value) { }

	// RVA: 0x1DCA820 Offset: 0x1DC9220 VA: 0x181DCA820
	public static JToken op_Implicit(Nullable<byte> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DC9E30 Offset: 0x1DC8830 VA: 0x181DC9E30
	public static JToken op_Implicit(sbyte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DC9BD0 Offset: 0x1DC85D0 VA: 0x181DC9BD0
	public static JToken op_Implicit(Nullable<sbyte> value) { }

	// RVA: 0x1DC9D30 Offset: 0x1DC8730 VA: 0x181DC9D30
	public static JToken op_Implicit(Nullable<bool> value) { }

	// RVA: 0x1DCA350 Offset: 0x1DC8D50 VA: 0x181DCA350
	public static JToken op_Implicit(long value) { }

	// RVA: 0x1DCA1C0 Offset: 0x1DC8BC0 VA: 0x181DCA1C0
	public static JToken op_Implicit(Nullable<DateTime> value) { }

	// RVA: 0x1DCA6D0 Offset: 0x1DC90D0 VA: 0x181DCA6D0
	public static JToken op_Implicit(Nullable<DateTimeOffset> value) { }

	// RVA: 0x1DC9E90 Offset: 0x1DC8890 VA: 0x181DC9E90
	public static JToken op_Implicit(Nullable<Decimal> value) { }

	// RVA: 0x1DCA590 Offset: 0x1DC8F90 VA: 0x181DCA590
	public static JToken op_Implicit(Nullable<double> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DCA530 Offset: 0x1DC8F30 VA: 0x181DCA530
	public static JToken op_Implicit(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DC9B70 Offset: 0x1DC8570 VA: 0x181DC9B70
	public static JToken op_Implicit(ushort value) { }

	// RVA: 0x1DCA760 Offset: 0x1DC9160 VA: 0x181DCA760
	public static JToken op_Implicit(int value) { }

	// RVA: 0x1DCA000 Offset: 0x1DC8A00 VA: 0x181DCA000
	public static JToken op_Implicit(Nullable<int> value) { }

	// RVA: 0x1DCA080 Offset: 0x1DC8A80 VA: 0x181DCA080
	public static JToken op_Implicit(DateTime value) { }

	// RVA: 0x1DCAA40 Offset: 0x1DC9440 VA: 0x181DCAA40
	public static JToken op_Implicit(Nullable<long> value) { }

	// RVA: 0x1DCA140 Offset: 0x1DC8B40 VA: 0x181DCA140
	public static JToken op_Implicit(Nullable<float> value) { }

	// RVA: 0x1DCA8A0 Offset: 0x1DC92A0 VA: 0x181DCA8A0
	public static JToken op_Implicit(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DC9F80 Offset: 0x1DC8980 VA: 0x181DC9F80
	public static JToken op_Implicit(Nullable<short> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DC9DB0 Offset: 0x1DC87B0 VA: 0x181DC9DB0
	public static JToken op_Implicit(Nullable<ushort> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DC9C50 Offset: 0x1DC8650 VA: 0x181DC9C50
	public static JToken op_Implicit(Nullable<uint> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DCA2D0 Offset: 0x1DC8CD0 VA: 0x181DCA2D0
	public static JToken op_Implicit(Nullable<ulong> value) { }

	// RVA: 0x1DCA0E0 Offset: 0x1DC8AE0 VA: 0x181DCA0E0
	public static JToken op_Implicit(double value) { }

	// RVA: 0x1DCA610 Offset: 0x1DC9010 VA: 0x181DCA610
	public static JToken op_Implicit(float value) { }

	// RVA: 0x1DCA4D0 Offset: 0x1DC8ED0 VA: 0x181DCA4D0
	public static JToken op_Implicit(string value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DCA470 Offset: 0x1DC8E70 VA: 0x181DCA470
	public static JToken op_Implicit(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DCA670 Offset: 0x1DC9070 VA: 0x181DCA670
	public static JToken op_Implicit(ulong value) { }

	// RVA: 0x1DC9F20 Offset: 0x1DC8920 VA: 0x181DC9F20
	public static JToken op_Implicit(byte[] value) { }

	// RVA: 0x1DCA410 Offset: 0x1DC8E10 VA: 0x181DCA410
	public static JToken op_Implicit(Uri value) { }

	// RVA: 0x1DCA9E0 Offset: 0x1DC93E0 VA: 0x181DCA9E0
	public static JToken op_Implicit(TimeSpan value) { }

	// RVA: 0x1DCA960 Offset: 0x1DC9360 VA: 0x181DCA960
	public static JToken op_Implicit(Nullable<TimeSpan> value) { }

	// RVA: 0x1DCA900 Offset: 0x1DC9300 VA: 0x181DCA900
	public static JToken op_Implicit(Guid value) { }

	// RVA: 0x1DCA240 Offset: 0x1DC8C40 VA: 0x181DCA240
	public static JToken op_Implicit(Nullable<Guid> value) { }

	// RVA: 0x1DC15B0 Offset: 0x1DBFFB0 VA: 0x181DC15B0 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1DC1530 Offset: 0x1DBFF30 VA: 0x181DC1530 Slot: 5
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	// RVA: -1 Offset: -1 Slot: 25
	internal abstract int GetDeepHashCode();

	// RVA: 0x1DC04D0 Offset: 0x1DBEED0 VA: 0x181DC04D0 Slot: 4
	private IJEnumerable<JToken> Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.get_Item(object key) { }

	// RVA: 0x1DBFBE0 Offset: 0x1DBE5E0 VA: 0x181DBFBE0
	public JsonReader CreateReader() { }

	// RVA: 0x1DBFDD0 Offset: 0x1DBE7D0 VA: 0x181DBFDD0
	internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer) { }

	// RVA: 0x1DBFF20 Offset: 0x1DBE920 VA: 0x181DBFF20
	public static JToken FromObject(object o) { }

	// RVA: 0x1DBFF80 Offset: 0x1DBE980 VA: 0x181DBFF80
	public static JToken FromObject(object o, JsonSerializer jsonSerializer) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public T ToObject<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4AB0 Offset: 0xEE34B0 VA: 0x180EE4AB0
	|-JToken.ToObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1DC1C50 Offset: 0x1DC0650 VA: 0x181DC1C50
	public object ToObject(Type objectType) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public T ToObject<T>(JsonSerializer jsonSerializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4BC0 Offset: 0xEE35C0 VA: 0x180EE4BC0
	|-JToken.ToObject<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	// RVA: 0x1DC1A50 Offset: 0x1DC0450 VA: 0x181DC1A50
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	// RVA: 0x1DC0BF0 Offset: 0x1DBF5F0 VA: 0x181DC0BF0
	public static JToken ReadFrom(JsonReader reader) { }

	// RVA: 0x1DC0880 Offset: 0x1DBF280 VA: 0x181DC0880
	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x1DC0690 Offset: 0x1DBF090 VA: 0x181DC0690
	public static JToken Parse(string json) { }

	// RVA: 0x1DC04F0 Offset: 0x1DBEEF0 VA: 0x181DC04F0
	public static JToken Parse(string json, JsonLoadSettings settings) { }

	// RVA: 0x1DC0390 Offset: 0x1DBED90 VA: 0x181DC0390
	public static JToken Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x1DC0310 Offset: 0x1DBED10 VA: 0x181DC0310
	public static JToken Load(JsonReader reader) { }

	[NullableContext(2)]
	// RVA: 0x1DC1440 Offset: 0x1DBFE40 VA: 0x181DC1440
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	// RVA: 0x1DC13C0 Offset: 0x1DBFDC0 VA: 0x181DC13C0
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x1DC03F0 Offset: 0x1DBEDF0 VA: 0x181DC03F0 Slot: 7
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x1DC0430 Offset: 0x1DBEE30 VA: 0x181DC0430 Slot: 8
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x1DC0480 Offset: 0x1DBEE80 VA: 0x181DC0480 Slot: 9
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0x1DC11F0 Offset: 0x1DBFBF0 VA: 0x181DC11F0
	public JToken SelectToken(string path) { }

	// RVA: 0x1DC1200 Offset: 0x1DBFC00 VA: 0x181DC1200
	public JToken SelectToken(string path, bool errorWhenNoMatch) { }

	[NullableContext(2)]
	// RVA: 0x1DC1000 Offset: 0x1DBFA00 VA: 0x181DC1000
	public JToken SelectToken(string path, JsonSelectSettings settings) { }

	// RVA: 0x1DC1290 Offset: 0x1DBFC90 VA: 0x181DC1290
	public IEnumerable<JToken> SelectTokens(string path) { }

	// RVA: 0x1DC12A0 Offset: 0x1DBFCA0 VA: 0x181DC12A0
	public IEnumerable<JToken> SelectTokens(string path, bool errorWhenNoMatch) { }

	// RVA: 0x1DC1330 Offset: 0x1DBFD30 VA: 0x181DC1330
	public IEnumerable<JToken> SelectTokens(string path, JsonSelectSettings settings) { }

	// RVA: 0x1DC0070 Offset: 0x1DBEA70 VA: 0x181DC0070 Slot: 26
	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0x1DC15F0 Offset: 0x1DBFFF0 VA: 0x181DC15F0 Slot: 11
	private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0x1DBFC60 Offset: 0x1DBE660 VA: 0x181DBFC60 Slot: 10
	private object System.ICloneable.Clone() { }

	// RVA: 0x1DBFC60 Offset: 0x1DBE660 VA: 0x181DBFC60
	public JToken DeepClone() { }

	// RVA: 0x1DBFC40 Offset: 0x1DBE640 VA: 0x181DBFC40
	public JToken DeepClone(JsonCloneSettings settings) { }

	// RVA: 0x1DBF430 Offset: 0x1DBDE30 VA: 0x181DBF430
	public void AddAnnotation(object annotation) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4590 Offset: 0xEE2F90 VA: 0x180EE4590
	|-JToken.Annotation<object>
	*/

	// RVA: 0x1DBF840 Offset: 0x1DBE240 VA: 0x181DBF840
	public object Annotation(Type type) { }

	[IteratorStateMachine(typeof(JToken.<Annotations>d__185<T>))]
	// RVA: -1 Offset: -1
	public IEnumerable<T> Annotations<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4730 Offset: 0xEE3130 VA: 0x180EE4730
	|-JToken.Annotations<object>
	*/

	[IteratorStateMachine(typeof(JToken.<Annotations>d__186))]
	// RVA: 0x1DBF9D0 Offset: 0x1DBE3D0 VA: 0x181DBF9D0
	public IEnumerable<object> Annotations(Type type) { }

	// RVA: -1 Offset: -1
	public void RemoveAnnotations<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4860 Offset: 0xEE3260 VA: 0x180EE4860
	|-JToken.RemoveAnnotations<object>
	*/

	// RVA: 0x1DC0C40 Offset: 0x1DBF640 VA: 0x181DC0C40
	public void RemoveAnnotations(Type type) { }

	// RVA: 0x1DBFB30 Offset: 0x1DBE530 VA: 0x181DBFB30
	internal void CopyAnnotations(JToken target, JToken source) { }

	// RVA: 0x1DC31F0 Offset: 0x1DC1BF0 VA: 0x181DC31F0
	private static void .cctor() { }
}
