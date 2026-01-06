public class Zone : MonoBehaviour // TypeDefIndex: 2164
{
	// Fields
	public const float UPDATE_INTERVAL = 0.25;
	public Transform PointContainer; // 0x20
	public bool IsClosed; // 0x28
	public float VerticalSize; // 0x2C
	[Header("Debug")]
	public Color ZoneColor; // 0x30
	protected Vector3[] points; // 0x40

	// Methods

	// RVA: 0x823C40 Offset: 0x822640 VA: 0x180823C40 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x824950 Offset: 0x823350 VA: 0x180824950
	private void OnDrawGizmos() { }

	// RVA: 0x824700 Offset: 0x823100 VA: 0x180824700
	protected Vector3[] GetPoints() { }

	// RVA: 0x823E90 Offset: 0x822890 VA: 0x180823E90
	protected bool DoBoundsContainPoint(Vector3 point) { }

	// RVA: 0x823F30 Offset: 0x822930 VA: 0x180823F30
	protected Tuple<Vector3, Vector3> GetBoundingPoints() { }

	// RVA: 0x824860 Offset: 0x823260 VA: 0x180824860
	public bool IsPointInsidePolygon(Vector3 point) { }

	// RVA: 0x823C70 Offset: 0x822670 VA: 0x180823C70
	protected int CalculateWindingNumber(Vector2[] polygon, Vector2 point) { }

	// RVA: 0x824370 Offset: 0x822D70 VA: 0x180824370
	protected Vector3 GetClosestPointOnPolygon(Vector3[] polyPoints, Vector3 point) { }

	// RVA: 0x8252C0 Offset: 0x823CC0 VA: 0x1808252C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x824FB0 Offset: 0x8239B0 VA: 0x180824FB0
	internal static bool <CalculateWindingNumber>g__IsPointOnSegment|12_0(Vector2 start, Vector2 end, Vector2 point) { }

	[CompilerGenerated]
	// RVA: 0x824E60 Offset: 0x823860 VA: 0x180824E60
	internal static float <CalculateWindingNumber>g__CrossProduct|12_1(Vector2 start, Vector2 end, Vector2 point) { }

	[CompilerGenerated]
	// RVA: 0x824EC0 Offset: 0x8238C0 VA: 0x180824EC0
	internal static float <CalculateWindingNumber>g__DotProduct|12_2(Vector2 start, Vector2 end, Vector2 point) { }

	[CompilerGenerated]
	// RVA: 0x824F20 Offset: 0x823920 VA: 0x180824F20
	internal static int <CalculateWindingNumber>g__IsLeft|12_3(Vector2 start, Vector2 end, Vector2 point) { }

	[CompilerGenerated]
	// RVA: 0x8250A0 Offset: 0x823AA0 VA: 0x1808250A0
	internal static Vector3 <GetClosestPointOnPolygon>g__ProjectPointOnLineSegment|13_0(Vector3 lineStart, Vector3 lineEnd, Vector3 point) { }
}
