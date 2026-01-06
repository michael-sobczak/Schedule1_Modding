public class HeatmapManager : Singleton<HeatmapManager> // TypeDefIndex: 3400
{
	// Fields
	public Action<Property, bool> onHeatmapVisibilityChanged; // 0x28
	[Header("Components")]
	[SerializeField]
	private ComputeShader _shader; // 0x30
	[SerializeField]
	private RenderTexture _heatmaps; // 0x38
	[SerializeField]
	private HeatmapRegion _heatmapRegionPrefab; // 0x40
	[SerializeField]
	private Material _heatmapMat; // 0x48
	[SerializeField]
	[Header("Settings")]
	private Texture2D _gradientTexture; // 0x50
	[SerializeField]
	[Header("Debugging & Testing")]
	private string _propertyCodeToTest; // 0x58
	private Dictionary<string, HeatmapManager.PropertyData> _propertyGridMasks; // 0x60
	private List<HeatmapManager.PropertyRegionReference> _propertyRegionReferences; // 0x68
	private int _kernal; // 0x70
	private int _textureDepth; // 0x74
	public const int TEXTURE_SIZE = 128;
	public const int MAX_REGIONS = 16;

	// Methods

	// RVA: 0xA73200 Offset: 0xA71C00 VA: 0x180A73200 Slot: 5
	protected override void Awake() { }

	// RVA: 0xA74B10 Offset: 0xA73510 VA: 0x180A74B10 Slot: 4
	protected override void Start() { }

	// RVA: 0xA73920 Offset: 0xA72320 VA: 0x180A73920
	private void Initialise() { }

	// RVA: 0xA74810 Offset: 0xA73210 VA: 0x180A74810
	private void SetShader() { }

	// RVA: 0xA740D0 Offset: 0xA72AD0 VA: 0x180A740D0
	private void SetPropertyData() { }

	// RVA: 0xA73B50 Offset: 0xA72550 VA: 0x180A73B50
	private void OnEmitterUpdate(string propertyCode, TemperatureEmitterInfo[] emitterInfos) { }

	// RVA: 0xA732E0 Offset: 0xA71CE0 VA: 0x180A732E0
	private void DispatchHeatmap(string propertyCode, TemperatureEmitterInfo[] emitterInfos) { }

	// RVA: 0xA73820 Offset: 0xA72220 VA: 0x180A73820
	private Vector2Int GetPropertyRegionStartAndEndIndex(string propertyCode) { }

	// RVA: 0xA73E00 Offset: 0xA72800 VA: 0x180A73E00
	public void SetHeatmapActive(string propertyCode, bool isActive) { }

	// RVA: 0xA73EB0 Offset: 0xA728B0 VA: 0x180A73EB0
	public void SetHeatmapActive(Property property, bool isActive) { }

	// RVA: 0xA74B70 Offset: 0xA73570 VA: 0x180A74B70
	public void ToggleHeatmapActive(Property property) { }

	// RVA: 0xA73CB0 Offset: 0xA726B0 VA: 0x180A73CB0
	public void SetAllHeatmapsActive(bool isActive) { }

	// RVA: 0xA739E0 Offset: 0xA723E0 VA: 0x180A739E0
	public bool IsHeatmapActive(Property property) { }

	// RVA: 0xA73B00 Offset: 0xA72500 VA: 0x180A73B00 Slot: 6
	protected override void OnDestroy() { }

	[Button]
	// RVA: 0xA74D70 Offset: 0xA73770 VA: 0x180A74D70
	public void TurnOnAllHeatmaps() { }

	[Button]
	// RVA: 0xA74C30 Offset: 0xA73630 VA: 0x180A74C30
	public void TurnOffAllHeatmaps() { }

	[Button]
	// RVA: 0xA73B60 Offset: 0xA72560 VA: 0x180A73B60
	public void RunDispatchHeatmap() { }

	// RVA: 0xA74EE0 Offset: 0xA738E0 VA: 0x180A74EE0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xA74EB0 Offset: 0xA738B0 VA: 0x180A74EB0
	private bool <RunDispatchHeatmap>b__31_0(Property p) { }
}
