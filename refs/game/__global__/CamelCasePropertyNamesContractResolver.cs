public class CamelCasePropertyNamesContractResolver : DefaultContractResolver // TypeDefIndex: 11211
{
	// Fields
	private static readonly object TypeContractCacheLock; // 0x0
	private static readonly DefaultJsonNameTable NameTable; // 0x8
	[Nullable(new[] { 2, 0, 1, 1, 1 })]
	private static Dictionary<StructMultiKey<Type, Type>, JsonContract> _contractCache; // 0x10

	// Methods

	// RVA: 0x1D75FC0 Offset: 0x1D749C0 VA: 0x181D75FC0
	public void .ctor() { }

	// RVA: 0x1D75BB0 Offset: 0x1D745B0 VA: 0x181D75BB0 Slot: 5
	public override JsonContract ResolveContract(Type type) { }

	// RVA: 0x1D75B60 Offset: 0x1D74560 VA: 0x181D75B60 Slot: 20
	internal override DefaultJsonNameTable GetNameTable() { }

	// RVA: 0x1D75EF0 Offset: 0x1D748F0 VA: 0x181D75EF0
	private static void .cctor() { }
}
