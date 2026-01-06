internal class RequestCacheBinding // TypeDefIndex: 10175
{
	// Fields
	private RequestCache m_RequestCache; // 0x10
	private RequestCacheValidator m_CacheValidator; // 0x18
	private RequestCachePolicy m_Policy; // 0x20

	// Properties
	internal RequestCache Cache { get; }
	internal RequestCacheValidator Validator { get; }
	internal RequestCachePolicy Policy { get; }

	// Methods

	// RVA: 0x43EE90 Offset: 0x43D890 VA: 0x18043EE90
	internal void .ctor(RequestCache requestCache, RequestCacheValidator cacheValidator, RequestCachePolicy policy) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal RequestCache get_Cache() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal RequestCacheValidator get_Validator() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal RequestCachePolicy get_Policy() { }
}
