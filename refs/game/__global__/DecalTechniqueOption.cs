internal enum DecalTechniqueOption // TypeDefIndex: 8979
{
	// Fields
	public int value__; // 0x0
	[Tooltip("Automatically selects technique based on build platform.")]
	public const DecalTechniqueOption Automatic = 0;
	[Tooltip("Renders decals into DBuffer and then applied during opaque rendering. Requires DepthNormal prepass which makes not viable solution for the tile based renderers common on mobile.")]
	[InspectorName("DBuffer")]
	public const DecalTechniqueOption DBuffer = 1;
	[Tooltip("Renders decals after opaque objects with normal reconstructed from depth. The decals are simply rendered as mesh on top of opaque ones, as result does not support blending per single surface data (etc. normal blending only).")]
	public const DecalTechniqueOption ScreenSpace = 2;
}
