public struct ProbeVolumeSystemParameters // TypeDefIndex: 13724
{
	// Fields
	public ProbeVolumeTextureMemoryBudget memoryBudget; // 0x0
	public ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget; // 0x4
	public Mesh probeDebugMesh; // 0x8
	public Shader probeDebugShader; // 0x10
	public Mesh offsetDebugMesh; // 0x18
	public Shader offsetDebugShader; // 0x20
	public ComputeShader scenarioBlendingShader; // 0x28
	public ProbeVolumeSceneData sceneData; // 0x30
	public ProbeVolumeSHBands shBands; // 0x38
	public bool supportsRuntimeDebug; // 0x3C
	public bool supportStreaming; // 0x3D
}
