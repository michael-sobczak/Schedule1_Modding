public sealed class PostProcessDebug : MonoBehaviour // TypeDefIndex: 17029
{
	// Fields
	public PostProcessLayer postProcessLayer; // 0x20
	private PostProcessLayer m_PreviousPostProcessLayer; // 0x28
	public bool lightMeter; // 0x30
	public bool histogram; // 0x31
	public bool waveform; // 0x32
	public bool vectorscope; // 0x33
	public DebugOverlay debugOverlay; // 0x34
	private Camera m_CurrentCamera; // 0x38
	private CommandBuffer m_CmdAfterEverything; // 0x40

	// Methods

	// RVA: 0x29AE310 Offset: 0x29ACD10 VA: 0x1829AE310
	private void OnEnable() { }

	// RVA: 0x29AE270 Offset: 0x29ACC70 VA: 0x1829AE270
	private void OnDisable() { }

	// RVA: 0x29AE890 Offset: 0x29AD290 VA: 0x1829AE890
	private void Update() { }

	// RVA: 0x29AE5E0 Offset: 0x29ACFE0 VA: 0x1829AE5E0
	private void Reset() { }

	// RVA: 0x29AE630 Offset: 0x29AD030 VA: 0x1829AE630
	private void UpdateStates() { }

	// RVA: 0x29AE4D0 Offset: 0x29ACED0 VA: 0x1829AE4D0
	private void OnPostRender() { }

	// RVA: 0x29AE3A0 Offset: 0x29ACDA0 VA: 0x1829AE3A0
	private void OnGUI() { }

	// RVA: 0x29AE100 Offset: 0x29ACB00 VA: 0x1829AE100
	private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
