public static class BatchingHelper // TypeDefIndex: 225
{
	// Properties
	public static bool forceEnableDepthBlend { get; }

	// Methods

	// RVA: 0x692740 Offset: 0x691140 VA: 0x180692740
	public static bool IsGpuInstancingEnabled(Material material) { }

	// RVA: 0x692760 Offset: 0x691160 VA: 0x180692760
	public static void SetMaterialProperties(Material material, bool enableGpuInstancing) { }

	// RVA: 0x692780 Offset: 0x691180 VA: 0x180692780
	public static bool get_forceEnableDepthBlend() { }

	// RVA: 0x6925C0 Offset: 0x690FC0 VA: 0x1806925C0
	private static bool DoesRenderingModePreventBatching(ShaderMode shaderMode, ref string reasons) { }

	// RVA: 0x691B10 Offset: 0x690510 VA: 0x180691B10
	public static bool CanBeBatched(VolumetricLightBeamSD beamA, VolumetricLightBeamSD beamB, ref string reasons) { }

	// RVA: 0x691990 Offset: 0x690390 VA: 0x180691990
	public static bool CanBeBatched(VolumetricLightBeamSD beam, ref string reasons) { }

	// RVA: 0x692010 Offset: 0x690A10 VA: 0x180692010
	public static bool CanBeBatched(VolumetricLightBeamHD beamA, VolumetricLightBeamHD beamB, ref string reasons) { }

	// RVA: 0x6917D0 Offset: 0x6901D0 VA: 0x1806917D0
	public static bool CanBeBatched(VolumetricLightBeamHD beam, ref string reasons) { }

	// RVA: 0x692470 Offset: 0x690E70 VA: 0x180692470
	public static bool CanBeBatched(VolumetricLightBeamAbstractBase beamA, VolumetricLightBeamAbstractBase beamB, ref string reasons) { }

	// RVA: 0x691720 Offset: 0x690120 VA: 0x180691720
	private static void AppendErrorMessage(ref string message, string toAppend) { }
}
