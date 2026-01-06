public class HttpMethod : IEquatable<HttpMethod> // TypeDefIndex: 17710
{
	// Fields
	private static readonly HttpMethod delete_method; // 0x0
	private static readonly HttpMethod get_method; // 0x8
	private static readonly HttpMethod head_method; // 0x10
	private static readonly HttpMethod options_method; // 0x18
	private static readonly HttpMethod post_method; // 0x20
	private static readonly HttpMethod put_method; // 0x28
	private static readonly HttpMethod trace_method; // 0x30
	private readonly string method; // 0x10

	// Properties
	public static HttpMethod Delete { get; }
	public static HttpMethod Get { get; }
	public string Method { get; }
	public static HttpMethod Post { get; }

	// Methods

	// RVA: 0x2189140 Offset: 0x2187B40 VA: 0x182189140
	public void .ctor(string method) { }

	// RVA: 0x21891E0 Offset: 0x2187BE0 VA: 0x1821891E0
	public static HttpMethod get_Delete() { }

	// RVA: 0x2189230 Offset: 0x2187C30 VA: 0x182189230
	public static HttpMethod get_Get() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Method() { }

	// RVA: 0x2189280 Offset: 0x2187C80 VA: 0x182189280
	public static HttpMethod get_Post() { }

	// RVA: 0x21892D0 Offset: 0x2187CD0 VA: 0x1821892D0
	public static bool op_Equality(HttpMethod left, HttpMethod right) { }

	// RVA: 0x2188DE0 Offset: 0x21877E0 VA: 0x182188DE0 Slot: 4
	public bool Equals(HttpMethod other) { }

	// RVA: 0x2188E10 Offset: 0x2187810 VA: 0x182188E10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A67980 Offset: 0x1A66380 VA: 0x181A67980 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2188EA0 Offset: 0x21878A0 VA: 0x182188EA0
	private static void .cctor() { }
}
