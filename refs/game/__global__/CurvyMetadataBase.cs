public abstract class CurvyMetadataBase : DTVersionedMonoBehaviour // TypeDefIndex: 10550
{
	// Fields
	private CurvySplineSegment mCP; // 0x30

	// Properties
	public CurvySplineSegment ControlPoint { get; }
	public CurvySpline Spline { get; }

	// Methods

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public CurvySplineSegment get_ControlPoint() { }

	// RVA: 0x4C6C80 Offset: 0x4C5680 VA: 0x1804C6C80
	public CurvySpline get_Spline() { }

	// RVA: 0x4C6AA0 Offset: 0x4C54A0 VA: 0x1804C6AA0 Slot: 9
	protected virtual void Awake() { }

	[UsedImplicitly]
	// RVA: 0x4C6C20 Offset: 0x4C5620 VA: 0x1804C6C20
	private void OnDestroy() { }

	// RVA: -1 Offset: -1
	public T GetPreviousData<T>(bool autoCreate = True, bool segmentsOnly = True, bool useFollowUp = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6EC00 Offset: 0xE6D600 VA: 0x180E6EC00
	|-CurvyMetadataBase.GetPreviousData<object>
	*/

	// RVA: -1 Offset: -1
	public T GetNextData<T>(bool autoCreate = True, bool segmentsOnly = True, bool useFollowUp = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6EA40 Offset: 0xE6D440 VA: 0x180E6EA40
	|-CurvyMetadataBase.GetNextData<object>
	*/

	// RVA: 0x4C6B50 Offset: 0x4C5550 VA: 0x1804C6B50
	protected void NotifyModification() { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	protected void .ctor() { }
}
