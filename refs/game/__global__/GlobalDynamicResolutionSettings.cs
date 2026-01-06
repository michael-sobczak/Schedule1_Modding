public struct GlobalDynamicResolutionSettings // TypeDefIndex: 13583
{
	// Fields
	public bool enabled; // 0x0
	public bool useMipBias; // 0x1
	public bool enableDLSS; // 0x2
	public uint DLSSPerfQualitySetting; // 0x4
	public DynamicResolutionHandler.UpsamplerScheduleType DLSSInjectionPoint; // 0x8
	public bool DLSSUseOptimalSettings; // 0xC
	[Range(0, 1)]
	public float DLSSSharpness; // 0x10
	public bool fsrOverrideSharpness; // 0x14
	[Range(0, 1)]
	public float fsrSharpness; // 0x18
	public float maxPercentage; // 0x1C
	public float minPercentage; // 0x20
	public DynamicResolutionType dynResType; // 0x24
	public DynamicResUpscaleFilter upsampleFilter; // 0x25
	public bool forceResolution; // 0x26
	public float forcedPercentage; // 0x28
	public float lowResTransparencyMinimumThreshold; // 0x2C
	public float rayTracingHalfResThreshold; // 0x30
	public float lowResSSGIMinimumThreshold; // 0x34
	public float lowResVolumetricCloudsMinimumThreshold; // 0x38

	// Methods

	// RVA: 0x29F5760 Offset: 0x29F4160 VA: 0x1829F5760
	public static GlobalDynamicResolutionSettings NewDefault() { }
}
