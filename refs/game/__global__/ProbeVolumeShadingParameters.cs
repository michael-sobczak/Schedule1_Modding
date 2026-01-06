public struct ProbeVolumeShadingParameters // TypeDefIndex: 13725
{
	// Fields
	public float normalBias; // 0x0
	public float viewBias; // 0x4
	public bool scaleBiasByMinDistanceBetweenProbes; // 0x8
	public float samplingNoise; // 0xC
	public float weight; // 0x10
	public APVLeakReductionMode leakReductionMode; // 0x14
	public float occlusionWeightContribution; // 0x18
	public float minValidNormalWeight; // 0x1C
	public int frameIndexForNoise; // 0x20
	public float reflNormalizationLowerClamp; // 0x24
	public float reflNormalizationUpperClamp; // 0x28
}
