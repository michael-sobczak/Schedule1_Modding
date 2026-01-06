public static class ListCaches // TypeDefIndex: 12489
{
	// Fields
	private static Stack<ListCache<NetworkObject>> _networkObjectCaches; // 0x0
	private static Stack<ListCache<NetworkBehaviour>> _networkBehaviourCaches; // 0x8
	private static Stack<ListCache<Transform>> _transformCaches; // 0x10
	private static Stack<ListCache<NetworkConnection>> _networkConnectionCaches; // 0x18
	private static Stack<ListCache<int>> _intCaches; // 0x20

	// Methods

	[Obsolete("Use RetrieveNetworkObjectCache().")]
	// RVA: 0xD0E950 Offset: 0xD0D350 VA: 0x180D0E950
	public static ListCache<NetworkObject> GetNetworkObjectCache() { }

	// RVA: 0xD0EEB0 Offset: 0xD0D8B0 VA: 0x180D0EEB0
	public static ListCache<NetworkObject> RetrieveNetworkObjectCache() { }

	[Obsolete("Use RetrieveNetworkConnectionCache().")]
	// RVA: 0xD0E820 Offset: 0xD0D220 VA: 0x180D0E820
	public static ListCache<NetworkConnection> GetNetworkConnectionCache() { }

	// RVA: 0xD0EDB0 Offset: 0xD0D7B0 VA: 0x180D0EDB0
	public static ListCache<NetworkConnection> RetrieveNetworkConnectionCache() { }

	[Obsolete("Use RetrieveTransformCache().")]
	// RVA: 0xD0EA80 Offset: 0xD0D480 VA: 0x180D0EA80
	public static ListCache<Transform> GetTransformCache() { }

	// RVA: 0xD0EFA0 Offset: 0xD0D9A0 VA: 0x180D0EFA0
	public static ListCache<Transform> RetrieveTransformCache() { }

	[Obsolete("Use RetrieveNetworkBehaviourCache().")]
	// RVA: 0xD0E6F0 Offset: 0xD0D0F0 VA: 0x180D0E6F0
	public static ListCache<NetworkBehaviour> GetNetworkBehaviourCache() { }

	// RVA: 0xD0ECB0 Offset: 0xD0D6B0 VA: 0x180D0ECB0
	public static ListCache<NetworkBehaviour> RetrieveNetworkBehaviourCache() { }

	[Obsolete("Use RetrieveGetIntCache().")]
	// RVA: 0xD0E5C0 Offset: 0xD0CFC0 VA: 0x180D0E5C0
	public static ListCache<int> GetIntCache() { }

	// RVA: 0xD0EBB0 Offset: 0xD0D5B0 VA: 0x180D0EBB0
	public static ListCache<int> RetrieveIntCache() { }

	// RVA: 0xD0F320 Offset: 0xD0DD20 VA: 0x180D0F320
	public static void StoreCache(ListCache<NetworkObject> cache) { }

	// RVA: 0xD0F0A0 Offset: 0xD0DAA0 VA: 0x180D0F0A0
	public static void StoreCache(ListCache<NetworkConnection> cache) { }

	// RVA: 0xD0F280 Offset: 0xD0DC80 VA: 0x180D0F280
	public static void StoreCache(ListCache<Transform> cache) { }

	// RVA: 0xD0F140 Offset: 0xD0DB40 VA: 0x180D0F140
	public static void StoreCache(ListCache<NetworkBehaviour> cache) { }

	// RVA: 0xD0F1E0 Offset: 0xD0DBE0 VA: 0x180D0F1E0
	public static void StoreCache(ListCache<int> cache) { }

	// RVA: 0xD0F3C0 Offset: 0xD0DDC0 VA: 0x180D0F3C0
	private static void .cctor() { }
}
