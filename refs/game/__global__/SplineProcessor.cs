public abstract class SplineProcessor : DTVersionedMonoBehaviour // TypeDefIndex: 10509
{
	// Fields
	[SerializeField]
	protected CurvySpline m_Spline; // 0x30

	// Properties
	public CurvySpline Spline { get; set; }

	// Methods

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public CurvySpline get_Spline() { }

	// RVA: 0x4BC210 Offset: 0x4BAC10 VA: 0x1804BC210
	public void set_Spline(CurvySpline value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Refresh();

	// RVA: 0x4BBF10 Offset: 0x4BA910 VA: 0x1804BBF10
	private void OnSplineRefresh(CurvySplineEventArgs e) { }

	// RVA: 0x4BBF00 Offset: 0x4BA900 VA: 0x1804BBF00
	private void OnSplineCoordinatesChanged(CurvySpline spline) { }

	// RVA: 0x4BBF80 Offset: 0x4BA980 VA: 0x1804BBF80
	private void ProcessEvent(CurvySpline spline) { }

	[UsedImplicitly]
	// RVA: 0x4BBAB0 Offset: 0x4BA4B0 VA: 0x1804BBAB0 Slot: 10
	protected virtual void Awake() { }

	// RVA: 0x4BBE60 Offset: 0x4BA860 VA: 0x1804BBE60 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x4BBDE0 Offset: 0x4BA7E0 VA: 0x1804BBDE0 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x4BBF30 Offset: 0x4BA930 VA: 0x1804BBF30 Slot: 7
	protected override void OnValidate() { }

	[UsedImplicitly]
	// RVA: 0x4BC030 Offset: 0x4BAA30 VA: 0x1804BC030 Slot: 11
	protected virtual void Start() { }

	// RVA: 0x4BBBB0 Offset: 0x4BA5B0 VA: 0x1804BBBB0
	protected void BindEvents() { }

	// RVA: 0x4BC050 Offset: 0x4BAA50 VA: 0x1804BC050
	protected void UnbindEvents() { }

	// RVA: 0x4BC0C0 Offset: 0x4BAAC0 VA: 0x1804BC0C0
	private void UnbindEvents(CurvySpline spline) { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	protected void .ctor() { }
}
