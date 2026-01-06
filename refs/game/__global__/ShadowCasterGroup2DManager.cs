internal class ShadowCasterGroup2DManager // TypeDefIndex: 8730
{
	// Fields
	private static List<ShadowCasterGroup2D> s_ShadowCasterGroups; // 0x0

	// Properties
	public static List<ShadowCasterGroup2D> shadowCasterGroups { get; }

	// Methods

	// RVA: 0x2AD0170 Offset: 0x2ACEB70 VA: 0x182AD0170
	public static List<ShadowCasterGroup2D> get_shadowCasterGroups() { }

	// RVA: 0x2ACFD50 Offset: 0x2ACE750 VA: 0x182ACFD50
	public static void CacheValues() { }

	// RVA: 0x2ACF9D0 Offset: 0x2ACE3D0 VA: 0x182ACF9D0
	public static void AddShadowCasterGroupToList(ShadowCasterGroup2D shadowCaster, List<ShadowCasterGroup2D> list) { }

	// RVA: 0x2AD0110 Offset: 0x2ACEB10 VA: 0x182AD0110
	public static void RemoveShadowCasterGroupFromList(ShadowCasterGroup2D shadowCaster, List<ShadowCasterGroup2D> list) { }

	// RVA: 0x2ACFED0 Offset: 0x2ACE8D0 VA: 0x182ACFED0
	private static CompositeShadowCaster2D FindTopMostCompositeShadowCaster(ShadowCaster2D shadowCaster) { }

	// RVA: 0x2ACFA90 Offset: 0x2ACE490 VA: 0x182ACFA90
	public static bool AddToShadowCasterGroup(ShadowCaster2D shadowCaster, ref ShadowCasterGroup2D shadowCasterGroup) { }

	// RVA: 0x2ACFF90 Offset: 0x2ACE990 VA: 0x182ACFF90
	public static void RemoveFromShadowCasterGroup(ShadowCaster2D shadowCaster, ShadowCasterGroup2D shadowCasterGroup) { }

	// RVA: 0x2ACF840 Offset: 0x2ACE240 VA: 0x182ACF840
	public static void AddGroup(ShadowCasterGroup2D group) { }

	// RVA: 0x2AD0060 Offset: 0x2ACEA60 VA: 0x182AD0060
	public static void RemoveGroup(ShadowCasterGroup2D group) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
