public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>>, IEnumerable // TypeDefIndex: 17735
{
	// Fields
	private static readonly Dictionary<string, HeaderInfo> known_headers; // 0x0
	private readonly Dictionary<string, HttpHeaders.HeaderBucket> headers; // 0x10
	private readonly HttpHeaderKind HeaderKind; // 0x18
	internal Nullable<bool> connectionclose; // 0x1C
	internal Nullable<bool> transferEncodingChunked; // 0x1E

	// Methods

	// RVA: 0x2186520 Offset: 0x2184F20 VA: 0x182186520
	private static void .cctor() { }

	// RVA: 0x2188C00 Offset: 0x2187600 VA: 0x182188C00
	protected void .ctor() { }

	// RVA: 0x2188B00 Offset: 0x2187500 VA: 0x182188B00
	internal void .ctor(HttpHeaderKind headerKind) { }

	// RVA: 0x2185130 Offset: 0x2183B30 VA: 0x182185130
	private bool AddInternal(string name, IEnumerable<string> values, HeaderInfo headerInfo, bool ignoreInvalid) { }

	// RVA: 0x2186220 Offset: 0x2184C20 VA: 0x182186220
	public bool TryAddWithoutValidation(string name, IEnumerable<string> values) { }

	// RVA: 0x2185580 Offset: 0x2183F80 VA: 0x182185580
	private HeaderInfo CheckName(string name) { }

	// RVA: 0x21863D0 Offset: 0x2184DD0 VA: 0x1821863D0
	private bool TryCheckName(string name, out HeaderInfo headerInfo) { }

	[IteratorStateMachine(typeof(HttpHeaders.<GetEnumerator>d__19))]
	// RVA: 0x21858C0 Offset: 0x21842C0 VA: 0x1821858C0 Slot: 4
	public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator() { }

	// RVA: 0x21858C0 Offset: 0x21842C0 VA: 0x1821858C0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2185D80 Offset: 0x2184780 VA: 0x182185D80
	public bool Remove(string name) { }

	// RVA: 0x2185A30 Offset: 0x2184430 VA: 0x182185A30
	internal static string GetSingleHeaderString(string key, IEnumerable<string> values) { }

	// RVA: 0x2185F20 Offset: 0x2184920 VA: 0x182185F20 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	internal void AddOrRemove<T>(string name, T value, Func<object, string> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC48F0 Offset: 0xEC32F0 VA: 0x180EC48F0
	|-HttpHeaders.AddOrRemove<object>
	*/

	// RVA: 0x2185700 Offset: 0x2184100 VA: 0x182185700
	private List<string> GetAllHeaderValues(HttpHeaders.HeaderBucket bucket, HeaderInfo headerInfo) { }

	// RVA: 0x2185930 Offset: 0x2184330 VA: 0x182185930
	internal static HttpHeaderKind GetKnownHeaderKind(string name) { }

	// RVA: -1 Offset: -1
	internal T GetValue<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC4CF0 Offset: 0xEC36F0 VA: 0x180EC4CF0
	|-HttpHeaders.GetValue<Nullable<long>>
	|
	|-RVA: 0xEC5010 Offset: 0xEC3A10 VA: 0x180EC5010
	|-HttpHeaders.GetValue<object>
	|
	|-RVA: 0xEC49D0 Offset: 0xEC33D0 VA: 0x180EC49D0
	|-HttpHeaders.GetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal HttpHeaderValueCollection<T> GetValues<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC52F0 Offset: 0xEC3CF0 VA: 0x180EC52F0
	|-HttpHeaders.GetValues<object>
	*/

	// RVA: -1 Offset: -1
	internal void SetValue<T>(string name, T value, Func<object, string> toStringConverter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC57F0 Offset: 0xEC41F0 VA: 0x180EC57F0
	|-HttpHeaders.SetValue<long>
	|
	|-RVA: 0xEC58D0 Offset: 0xEC42D0 VA: 0x180EC58D0
	|-HttpHeaders.SetValue<object>
	|
	|-RVA: 0xEC56D0 Offset: 0xEC40D0 VA: 0x180EC56D0
	|-HttpHeaders.SetValue<__Il2CppFullySharedGenericType>
	*/
}
