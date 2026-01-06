public class CookieContainer // TypeDefIndex: 10025
{
	// Fields
	private static readonly HeaderVariantInfo[] HeaderInfo; // 0x0
	private Hashtable m_domainTable; // 0x10
	private int m_maxCookieSize; // 0x18
	private int m_maxCookies; // 0x1C
	private int m_maxCookiesPerDomain; // 0x20
	private int m_count; // 0x24
	private string m_fqdnMyDomain; // 0x28

	// Methods

	// RVA: 0x25AC790 Offset: 0x25AB190 VA: 0x1825AC790
	public void .ctor() { }

	// RVA: 0x25A93A0 Offset: 0x25A7DA0 VA: 0x1825A93A0
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x25A94D0 Offset: 0x25A7ED0 VA: 0x1825A94D0
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x25A9CC0 Offset: 0x25A86C0 VA: 0x1825A9CC0
	private bool AgeCookies(string domain) { }

	// RVA: 0x25AB8E0 Offset: 0x25AA2E0 VA: 0x1825AB8E0
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x25AC220 Offset: 0x25AAC20 VA: 0x1825AC220
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x25AB230 Offset: 0x25A9C30 VA: 0x1825AB230
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x25ABDD0 Offset: 0x25AA7D0 VA: 0x1825ABDD0
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x25AAB40 Offset: 0x25A9540 VA: 0x1825AAB40
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x25AC4C0 Offset: 0x25AAEC0 VA: 0x1825AC4C0
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x25ABA00 Offset: 0x25AA400 VA: 0x1825ABA00
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x25ABAD0 Offset: 0x25AA4D0 VA: 0x1825ABAD0
	internal string GetCookieHeader(Uri uri, out string optCookie2) { }

	// RVA: 0x25AC660 Offset: 0x25AB060 VA: 0x1825AC660
	private static void .cctor() { }
}
