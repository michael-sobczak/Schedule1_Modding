internal class TMP_DynamicFontAssetUtilities // TypeDefIndex: 14895
{
	// Fields
	private static TMP_DynamicFontAssetUtilities s_Instance; // 0x0
	private Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference> s_SystemFontLookup; // 0x10
	private string[] s_SystemFontPaths; // 0x18
	private uint s_RegularStyleNameHashCode; // 0x20

	// Methods

	// RVA: 0x2BDDDE0 Offset: 0x2BDC7E0 VA: 0x182BDDDE0
	private void InitializeSystemFontReferenceCache() { }

	// RVA: 0x2BDE7F0 Offset: 0x2BDD1F0 VA: 0x182BDE7F0
	public static bool TryGetSystemFontReference(string familyName, out TMP_DynamicFontAssetUtilities.FontReference fontRef) { }

	// RVA: 0x2BDE760 Offset: 0x2BDD160 VA: 0x182BDE760
	public static bool TryGetSystemFontReference(string familyName, string styleName, out TMP_DynamicFontAssetUtilities.FontReference fontRef) { }

	// RVA: 0x2BDE450 Offset: 0x2BDCE50 VA: 0x182BDE450
	private bool TryGetSystemFontReferenceInternal(string familyName, string styleName, out TMP_DynamicFontAssetUtilities.FontReference fontRef) { }

	// RVA: 0x2BDE8F0 Offset: 0x2BDD2F0 VA: 0x182BDE8F0
	public void .ctor() { }

	// RVA: 0x2BDE880 Offset: 0x2BDD280 VA: 0x182BDE880
	private static void .cctor() { }
}
