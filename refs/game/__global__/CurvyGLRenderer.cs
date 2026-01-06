public class CurvyGLRenderer : DTVersionedMonoBehaviour // TypeDefIndex: 10563
{
	// Fields
	[ArrayEx(ShowAdd = False, Draggable = False)]
	public List<GLSlotData> Splines; // 0x30
	private readonly Lazy<Material> lineMaterial; // 0x38

	// Methods

	// RVA: 0x4C6270 Offset: 0x4C4C70 VA: 0x1804C6270 Slot: 7
	protected override void OnValidate() { }

	// RVA: 0x4C5ED0 Offset: 0x4C48D0 VA: 0x1804C5ED0 Slot: 4
	protected override void OnEnable() { }

	[UsedImplicitly]
	// RVA: 0x4C5EF0 Offset: 0x4C48F0 VA: 0x1804C5EF0
	private void OnPostRender() { }

	// RVA: 0x4C66C0 Offset: 0x4C50C0 VA: 0x1804C66C0
	private void sanitize() { }

	// RVA: 0x4C60D0 Offset: 0x4C4AD0 VA: 0x1804C60D0
	private void OnSplineRefresh(CurvySplineEventArgs e) { }

	// RVA: 0x4C6520 Offset: 0x4C4F20 VA: 0x1804C6520
	private GLSlotData getSlot(CurvySpline spline) { }

	// RVA: 0x4C5D10 Offset: 0x4C4710 VA: 0x1804C5D10
	public void Add(CurvySpline spline) { }

	[UsedImplicitly]
	[Obsolete("No more used in Curvy. Will get removed. Copy it if you still need it")]
	// RVA: 0x4C62A0 Offset: 0x4C4CA0 VA: 0x1804C62A0
	public void Remove(CurvySpline spline) { }

	// RVA: 0x4C6390 Offset: 0x4C4D90 VA: 0x1804C6390
	public void .ctor() { }
}
