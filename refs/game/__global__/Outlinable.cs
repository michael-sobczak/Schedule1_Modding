public class Outlinable : MonoBehaviour // TypeDefIndex: 10824
{
	// Fields
	private static List<TargetStateListener> tempListeners; // 0x0
	private static HashSet<Outlinable> outlinables; // 0x8
	[SerializeField]
	private ComplexMaskingMode complexMaskingMode; // 0x20
	[SerializeField]
	private OutlinableDrawingMode drawingMode; // 0x24
	[SerializeField]
	private int outlineLayer; // 0x28
	[SerializeField]
	private List<OutlineTarget> outlineTargets; // 0x30
	[SerializeField]
	private RenderStyle renderStyle; // 0x38
	[SerializeField]
	private Outlinable.OutlineProperties outlineParameters; // 0x40
	[SerializeField]
	private Outlinable.OutlineProperties backParameters; // 0x48
	[SerializeField]
	private Outlinable.OutlineProperties frontParameters; // 0x50
	private bool shouldValidateTargets; // 0x58

	// Properties
	public RenderStyle RenderStyle { get; set; }
	public ComplexMaskingMode ComplexMaskingMode { get; set; }
	public bool ComplexMaskingEnabled { get; }
	public OutlinableDrawingMode DrawingMode { get; set; }
	public int OutlineLayer { get; set; }
	public IReadOnlyList<OutlineTarget> OutlineTargets { get; }
	public Outlinable.OutlineProperties OutlineParameters { get; }
	public Outlinable.OutlineProperties BackParameters { get; }
	public bool NeedFillMask { get; }
	public Outlinable.OutlineProperties FrontParameters { get; }
	public bool IsObstacle { get; }
	public OutlineTarget Item { get; set; }

	// Methods

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public RenderStyle get_RenderStyle() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void set_RenderStyle(RenderStyle value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public ComplexMaskingMode get_ComplexMaskingMode() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_ComplexMaskingMode(ComplexMaskingMode value) { }

	// RVA: 0x5431E0 Offset: 0x541BE0 VA: 0x1805431E0
	public bool get_ComplexMaskingEnabled() { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public OutlinableDrawingMode get_DrawingMode() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_DrawingMode(OutlinableDrawingMode value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_OutlineLayer() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_OutlineLayer(int value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public IReadOnlyList<OutlineTarget> get_OutlineTargets() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Outlinable.OutlineProperties get_OutlineParameters() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public Outlinable.OutlineProperties get_BackParameters() { }

	// RVA: 0x543260 Offset: 0x541C60 VA: 0x180543260
	public bool get_NeedFillMask() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Outlinable.OutlineProperties get_FrontParameters() { }

	// RVA: 0x5431F0 Offset: 0x541BF0 VA: 0x1805431F0
	public bool get_IsObstacle() { }

	// RVA: 0x542650 Offset: 0x541050 VA: 0x180542650
	public bool TryAddTarget(OutlineTarget target) { }

	// RVA: 0x5423B0 Offset: 0x540DB0 VA: 0x1805423B0
	public void RemoveTarget(OutlineTarget target) { }

	// RVA: 0x543200 Offset: 0x541C00 VA: 0x180543200
	public OutlineTarget get_Item(int index) { }

	// RVA: 0x543370 Offset: 0x541D70 VA: 0x180543370
	public void set_Item(int index, OutlineTarget value) { }

	// RVA: 0x5424F0 Offset: 0x540EF0 VA: 0x1805424F0
	private void Reset() { }

	// RVA: 0x542380 Offset: 0x540D80 VA: 0x180542380
	private void OnValidate() { }

	// RVA: 0x542500 Offset: 0x540F00 VA: 0x180542500
	private void SubscribeToVisibilityChange(GameObject go) { }

	// RVA: 0x542700 Offset: 0x541100 VA: 0x180542700
	private void UpdateVisibility() { }

	// RVA: 0x542370 Offset: 0x540D70 VA: 0x180542370
	private void OnEnable() { }

	// RVA: 0x5422F0 Offset: 0x540CF0 VA: 0x1805422F0
	private void OnDisable() { }

	// RVA: 0x541DF0 Offset: 0x5407F0 VA: 0x180541DF0
	private void Awake() { }

	// RVA: 0x542C80 Offset: 0x541680 VA: 0x180542C80
	private void ValidateTargets() { }

	// RVA: 0x542270 Offset: 0x540C70 VA: 0x180542270
	private void OnDestroy() { }

	// RVA: 0x541E00 Offset: 0x540800 VA: 0x180541E00
	public static void GetAllActiveOutlinables(Camera camera, List<Outlinable> outlinablesList) { }

	// RVA: 0x541FD0 Offset: 0x5409D0 VA: 0x180541FD0
	private int GetSubmeshCount(Renderer renderer) { }

	// RVA: 0x541B40 Offset: 0x540540 VA: 0x180541B40
	public void AddAllChildRenderersToRenderingList(RenderersAddingMode renderersAddingMode = -1) { }

	// RVA: 0x542C60 Offset: 0x541660 VA: 0x180542C60
	private void Update() { }

	// RVA: 0x542110 Offset: 0x540B10 VA: 0x180542110
	private bool MatchingMode(Renderer renderer, RenderersAddingMode mode) { }

	// RVA: 0x5430D0 Offset: 0x541AD0 VA: 0x1805430D0
	public void .ctor() { }

	// RVA: 0x542FE0 Offset: 0x5419E0 VA: 0x180542FE0
	private static void .cctor() { }
}
