public class CurvySplineMoveEventArgs : CancelEventArgs // TypeDefIndex: 10587
{
	// Fields
	[CompilerGenerated]
	private SplineController <Sender>k__BackingField; // 0x18
	[CompilerGenerated]
	private CurvySpline <Spline>k__BackingField; // 0x20
	[CompilerGenerated]
	private CurvySplineSegment <ControlPoint>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <WorldUnits>k__BackingField; // 0x30
	[CompilerGenerated]
	private MovementDirection <MovementDirection>k__BackingField; // 0x34
	[CompilerGenerated]
	private float <Delta>k__BackingField; // 0x38
	[CompilerGenerated]
	private float <Position>k__BackingField; // 0x3C

	// Properties
	public SplineController Sender { get; set; }
	public CurvySpline Spline { get; set; }
	public CurvySplineSegment ControlPoint { get; set; }
	public bool WorldUnits { get; set; }
	public MovementDirection MovementDirection { get; set; }
	public float Delta { get; set; }
	public float Position { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public SplineController get_Sender() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_Sender(SplineController value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public CurvySpline get_Spline() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_Spline(CurvySpline value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public CurvySplineSegment get_ControlPoint() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_ControlPoint(CurvySplineSegment value) { }

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_WorldUnits() { }

	[CompilerGenerated]
	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	private void set_WorldUnits(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public MovementDirection get_MovementDirection() { }

	[CompilerGenerated]
	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	private void set_MovementDirection(MovementDirection value) { }

	[CompilerGenerated]
	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	public float get_Delta() { }

	[CompilerGenerated]
	// RVA: 0x4E2CD0 Offset: 0x4E16D0 VA: 0x1804E2CD0
	private void set_Delta(float value) { }

	[CompilerGenerated]
	// RVA: 0x4E2CC0 Offset: 0x4E16C0 VA: 0x1804E2CC0
	public float get_Position() { }

	[CompilerGenerated]
	// RVA: 0x4E2CE0 Offset: 0x4E16E0 VA: 0x1804E2CE0
	private void set_Position(float value) { }

	// RVA: 0x4E2C20 Offset: 0x4E1620 VA: 0x1804E2C20
	public void .ctor(SplineController sender, CurvySpline spline, CurvySplineSegment controlPoint, float position, bool usingWorldUnits, float delta, MovementDirection direction) { }

	// RVA: 0x4E2BA0 Offset: 0x4E15A0 VA: 0x1804E2BA0
	internal void Set_INTERNAL(SplineController sender, CurvySpline spline, CurvySplineSegment controlPoint, float position, float delta, MovementDirection direction, bool usingWorldUnits) { }
}
