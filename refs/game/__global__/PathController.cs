public class PathController : CurvyController // TypeDefIndex: 10592
{
	// Fields
	[Section("General", True, False, 100, Sort = 0)]
	[SerializeField]
	[CGDataReferenceSelector(typeof(CGPath), Label = "Path/Slot")]
	private CGDataReference m_Path; // 0xB0

	// Properties
	public CGDataReference Path { get; set; }
	public CGPath PathData { get; }
	public override float Length { get; }
	public override bool IsReady { get; }

	// Methods

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	public CGDataReference get_Path() { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80
	public void set_Path(CGDataReference value) { }

	// RVA: 0x4E4BC0 Offset: 0x4E35C0 VA: 0x1804E4BC0
	public CGPath get_PathData() { }

	// RVA: 0x4E4B80 Offset: 0x4E3580 VA: 0x1804E4B80 Slot: 35
	public override float get_Length() { }

	// RVA: 0x4E4B10 Offset: 0x4E3510 VA: 0x1804E4B10 Slot: 11
	public override bool get_IsReady() { }

	// RVA: 0x4E48D0 Offset: 0x4E32D0 VA: 0x1804E48D0 Slot: 39
	protected override float RelativeToAbsolute(float relativeDistance) { }

	// RVA: 0x4E4410 Offset: 0x4E2E10 VA: 0x1804E4410 Slot: 38
	protected override float AbsoluteToRelative(float worldUnitDistance) { }

	// RVA: 0x4E4660 Offset: 0x4E3060 VA: 0x1804E4660 Slot: 40
	protected override Vector3 GetInterpolatedSourcePosition(float tf) { }

	// RVA: 0x4E4500 Offset: 0x4E2F00 VA: 0x1804E4500 Slot: 41
	protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up) { }

	// RVA: 0x4E4800 Offset: 0x4E3200 VA: 0x1804E4800 Slot: 43
	protected override Vector3 GetTangent(float tf) { }

	// RVA: 0x4E4730 Offset: 0x4E3130 VA: 0x1804E4730 Slot: 42
	protected override Vector3 GetOrientation(float tf) { }

	// RVA: 0x4E4470 Offset: 0x4E2E70 VA: 0x1804E4470 Slot: 36
	protected override void Advance(float speed, float deltaTime) { }

	// RVA: 0x4E4930 Offset: 0x4E3330 VA: 0x1804E4930 Slot: 37
	protected override void SimulateAdvance(ref float tf, ref MovementDirection direction, float speed, float deltaTime) { }

	// RVA: 0x4E4AA0 Offset: 0x4E34A0 VA: 0x1804E4AA0
	public void .ctor() { }
}
