public class FieldMouseDragger<T> : BaseFieldMouseDragger // TypeDefIndex: 6665
{
	// Fields
	private readonly IValueField<T> m_DrivenField; // 0x0
	private VisualElement m_DragElement; // 0x0
	private Rect m_DragHotZone; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <dragging>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private T <startValue>k__BackingField; // 0x0

	// Properties
	public bool dragging { get; set; }
	public T startValue { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IValueField<T> drivenField) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17BB9B0 Offset: 0x17BA3B0 VA: 0x1817BB9B0
	|-FieldMouseDragger<double>..ctor
	|-FieldMouseDragger<int>..ctor
	|-FieldMouseDragger<long>..ctor
	|-FieldMouseDragger<float>..ctor
	|-FieldMouseDragger<uint>..ctor
	|-FieldMouseDragger<ulong>..ctor
	|
	|-RVA: 0x17C0740 Offset: 0x17BF140 VA: 0x1817C0740
	|-FieldMouseDragger<__Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public bool get_dragging() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	|-FieldMouseDragger<double>.get_dragging
	|-FieldMouseDragger<int>.get_dragging
	|-FieldMouseDragger<long>.get_dragging
	|-FieldMouseDragger<float>.get_dragging
	|-FieldMouseDragger<uint>.get_dragging
	|-FieldMouseDragger<ulong>.get_dragging
	|
	|-RVA: 0x17C0870 Offset: 0x17BF270 VA: 0x1817C0870
	|-FieldMouseDragger<__Il2CppFullySharedGenericType>.get_dragging
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_dragging(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	|-FieldMouseDragger<double>.set_dragging
	|-FieldMouseDragger<int>.set_dragging
	|-FieldMouseDragger<long>.set_dragging
	|-FieldMouseDragger<float>.set_dragging
	|-FieldMouseDragger<uint>.set_dragging
	|-FieldMouseDragger<ulong>.set_dragging
	|
	|-RVA: 0x17C0950 Offset: 0x17BF350 VA: 0x1817C0950
	|-FieldMouseDragger<__Il2CppFullySharedGenericType>.set_dragging
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_startValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDF800 Offset: 0xCDE200 VA: 0x180CDF800
	|-FieldMouseDragger<double>.get_startValue
	|
	|-RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	|-FieldMouseDragger<int>.get_startValue
	|-FieldMouseDragger<uint>.get_startValue
	|
	|-RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	|-FieldMouseDragger<long>.get_startValue
	|-FieldMouseDragger<ulong>.get_startValue
	|
	|-RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250
	|-FieldMouseDragger<float>.get_startValue
	|
	|-RVA: 0x17C08A0 Offset: 0x17BF2A0 VA: 0x1817C08A0
	|-FieldMouseDragger<__Il2CppFullySharedGenericType>.get_startValue
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_startValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDF820 Offset: 0xCDE220 VA: 0x180CDF820
	|-FieldMouseDragger<double>.set_startValue
	|
	|-RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	|-FieldMouseDragger<int>.set_startValue
	|-FieldMouseDragger<uint>.set_startValue
	|
	|-RVA: 0x57CCF0 Offset: 0x57B6F0 VA: 0x18057CCF0
	|-FieldMouseDragger<long>.set_startValue
	|-FieldMouseDragger<ulong>.set_startValue
	|
	|-RVA: 0x8928D0 Offset: 0x8912D0 VA: 0x1808928D0
	|-FieldMouseDragger<float>.set_startValue
	|
	|-RVA: 0x17C09C0 Offset: 0x17BF3C0 VA: 0x1817C09C0
	|-FieldMouseDragger<__Il2CppFullySharedGenericType>.set_startValue
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public sealed override void SetDragZone(VisualElement dragElement, Rect hotZone) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17BA9B0 Offset: 0x17B93B0 VA: 0x1817BA9B0
	|-FieldMouseDragger<double>.SetDragZone
	|
	|-RVA: 0x17BA6F0 Offset: 0x17B90F0 VA: 0x1817BA6F0
	|-FieldMouseDragger<int>.SetDragZone
	|
	|-RVA: 0x17BD9D0 Offset: 0x17BC3D0 VA: 0x1817BD9D0
	|-FieldMouseDragger<long>.SetDragZone
	|
	|-RVA: 0x17BE0E0 Offset: 0x17BCAE0 VA: 0x1817BE0E0
	|-FieldMouseDragger<float>.SetDragZone
	|
	|-RVA: 0x17BD710 Offset: 0x17BC110 VA: 0x1817BD710
	|-FieldMouseDragger<uint>.SetDragZone
	|
	|-RVA: 0x17BE3A0 Offset: 0x17BCDA0 VA: 0x1817BE3A0
	|-FieldMouseDragger<ulong>.SetDragZone
	|
	|-RVA: 0x17BDC90 Offset: 0x17BC690 VA: 0x1817BDC90
	|-FieldMouseDragger<__Il2CppFullySharedGenericType>.SetDragZone
	*/

	// RVA: -1 Offset: -1
	private bool CanStartDrag(int button, Vector2 localPosition) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B9BC0 Offset: 0x17B85C0 VA: 0x1817B9BC0
	|-FieldMouseDragger<double>.CanStartDrag
	|-FieldMouseDragger<int>.CanStartDrag
	|-FieldMouseDragger<long>.CanStartDrag
	|-FieldMouseDragger<float>.CanStartDrag
	|-FieldMouseDragger<uint>.CanStartDrag
	|-FieldMouseDragger<ulong>.CanStartDrag
	|
	|-RVA: 0x17BBA60 Offset: 0x17BA460 VA: 0x1817BBA60
	|-FieldMouseDragger<__Il2CppFullySharedGenericType>.CanStartDrag
	*/

	// RVA: -1 Offset: -1
	private void UpdateValueOnPointerDown(PointerDownEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17BB330 Offset: 0x17B9D30 VA: 0x1817BB330
	|-FieldMouseDragger<double>.UpdateValueOnPointerDown
	|
	|-RVA: 0x17BB150 Offset: 0x17B9B50 VA: 0x1817BB150
	|-FieldMouseDragger<int>.UpdateValueOnPointerDown
	|
	|-RVA: 0x17BF550 Offset: 0x17BDF50 VA: 0x1817BF550
	|-FieldMouseDragger<long>.UpdateValueOnPointerDown
	|
	|-RVA: 0x17BFAF0 Offset: 0x17BE4F0 VA: 0x1817BFAF0
	|-FieldMouseDragger<float>.UpdateValueOnPointerDown
	|
	|-RVA: 0x17BF730 Offset: 0x17BE130 VA: 0x1817BF730
	|-FieldMouseDragger<uint>.UpdateValueOnPointerDown
	|
	|-RVA: 0x17BF370 Offset: 0x17BDD70 VA: 0x1817BF370
	|-FieldMouseDragger<ulong>.UpdateValueOnPointerDown
	|
	|-RVA: 0x17BF910 Offset: 0x17BE310 VA: 0x1817BF910
	|-FieldMouseDragger<__Il2CppFullySharedGenericType>.UpdateValueOnPointerDown
	*/

	// RVA: -1 Offset: -1
	private void ProcessDownEvent(EventBase evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B9E10 Offset: 0x17B8810 VA: 0x1817B9E10
	|-FieldMouseDragger<double>.ProcessDownEvent
	|
	|-RVA: 0x17B9C50 Offset: 0x17B8650 VA: 0x1817B9C50
	|-FieldMouseDragger<int>.ProcessDownEvent
	|
	|-RVA: 0x17BC200 Offset: 0x17BAC00 VA: 0x1817BC200
	|-FieldMouseDragger<long>.ProcessDownEvent
	|
	|-RVA: 0x17BBDC0 Offset: 0x17BA7C0 VA: 0x1817BBDC0
	|-FieldMouseDragger<float>.ProcessDownEvent
	|
	|-RVA: 0x17BBFE0 Offset: 0x17BA9E0 VA: 0x1817BBFE0
	|-FieldMouseDragger<uint>.ProcessDownEvent
	|
	|-RVA: 0x17BBBA0 Offset: 0x17BA5A0 VA: 0x1817BBBA0
	|-FieldMouseDragger<ulong>.ProcessDownEvent
	|
	|-RVA: 0x17BC420 Offset: 0x17BAE20 VA: 0x1817BC420
	|-FieldMouseDragger<__Il2CppFullySharedGenericType>.ProcessDownEvent
	*/

	// RVA: -1 Offset: -1
	private void UpdateValueOnPointerMove(PointerMoveEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17BB510 Offset: 0x17B9F10 VA: 0x1817BB510
	|-FieldMouseDragger<double>.UpdateValueOnPointerMove
	|
	|-RVA: 0x17BB6F0 Offset: 0x17BA0F0 VA: 0x1817BB6F0
	|-FieldMouseDragger<int>.UpdateValueOnPointerMove
	|
	|-RVA: 0x17C0300 Offset: 0x17BED00 VA: 0x1817C0300
	|-FieldMouseDragger<long>.UpdateValueOnPointerMove
	|
	|-RVA: 0x17C0050 Offset: 0x17BEA50 VA: 0x1817C0050
	|-FieldMouseDragger<float>.UpdateValueOnPointerMove
	|
	|-RVA: 0x17BFE90 Offset: 0x17BE890 VA: 0x1817BFE90
	|-FieldMouseDragger<uint>.UpdateValueOnPointerMove
	|
	|-RVA: 0x17BFCD0 Offset: 0x17BE6D0 VA: 0x1817BFCD0
	|-FieldMouseDragger<ulong>.UpdateValueOnPointerMove
	|
	|-RVA: 0x17C0230 Offset: 0x17BEC30 VA: 0x1817C0230
	|-FieldMouseDragger<__Il2CppFullySharedGenericType>.UpdateValueOnPointerMove
	*/

	// RVA: -1 Offset: -1
	private void ProcessMoveEvent(bool shiftKey, bool altKey, Vector2 deltaPosition) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17BA180 Offset: 0x17B8B80 VA: 0x1817BA180
	|-FieldMouseDragger<double>.ProcessMoveEvent
	|
	|-RVA: 0x17BA030 Offset: 0x17B8A30 VA: 0x1817BA030
	|-FieldMouseDragger<int>.ProcessMoveEvent
	|-FieldMouseDragger<uint>.ProcessMoveEvent
	|
	|-RVA: 0x17BC770 Offset: 0x17BB170 VA: 0x1817BC770
	|-FieldMouseDragger<long>.ProcessMoveEvent
	|-FieldMouseDragger<ulong>.ProcessMoveEvent
	|
	|-RVA: 0x17BCAD0 Offset: 0x17BB4D0 VA: 0x1817BCAD0
	|-FieldMouseDragger<float>.ProcessMoveEvent
	|
	|-RVA: 0x17BC8C0 Offset: 0x17BB2C0 VA: 0x1817BC8C0
	|-FieldMouseDragger<__Il2CppFullySharedGenericType>.ProcessMoveEvent
	*/

	// RVA: -1 Offset: -1
	private void UpdateValueOnPointerUp(PointerUpEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17BB930 Offset: 0x17BA330 VA: 0x1817BB930
	|-FieldMouseDragger<double>.UpdateValueOnPointerUp
	|
	|-RVA: 0x17BB8B0 Offset: 0x17BA2B0 VA: 0x1817BB8B0
	|-FieldMouseDragger<int>.UpdateValueOnPointerUp
	|
	|-RVA: 0x17C06C0 Offset: 0x17BF0C0 VA: 0x1817C06C0
	|-FieldMouseDragger<long>.UpdateValueOnPointerUp
	|
	|-RVA: 0x17C0540 Offset: 0x17BEF40 VA: 0x1817C0540
	|-FieldMouseDragger<float>.UpdateValueOnPointerUp
	|
	|-RVA: 0x17C05C0 Offset: 0x17BEFC0 VA: 0x1817C05C0
	|-FieldMouseDragger<uint>.UpdateValueOnPointerUp
	|
	|-RVA: 0x17C0640 Offset: 0x17BF040 VA: 0x1817C0640
	|-FieldMouseDragger<ulong>.UpdateValueOnPointerUp
	|
	|-RVA: 0x17C04C0 Offset: 0x17BEEC0 VA: 0x1817C04C0
	|-FieldMouseDragger<__Il2CppFullySharedGenericType>.UpdateValueOnPointerUp
	*/

	// RVA: -1 Offset: -1
	private void ProcessUpEvent(EventBase evt, int pointerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17BA2F0 Offset: 0x17B8CF0 VA: 0x1817BA2F0
	|-FieldMouseDragger<double>.ProcessUpEvent
	|
	|-RVA: 0x17BA4F0 Offset: 0x17B8EF0 VA: 0x1817BA4F0
	|-FieldMouseDragger<int>.ProcessUpEvent
	|
	|-RVA: 0x17BCC40 Offset: 0x17BB640 VA: 0x1817BCC40
	|-FieldMouseDragger<long>.ProcessUpEvent
	|
	|-RVA: 0x17BCE40 Offset: 0x17BB840 VA: 0x1817BCE40
	|-FieldMouseDragger<float>.ProcessUpEvent
	|
	|-RVA: 0x17BD040 Offset: 0x17BBA40 VA: 0x1817BD040
	|-FieldMouseDragger<uint>.ProcessUpEvent
	|
	|-RVA: 0x17BD240 Offset: 0x17BBC40 VA: 0x1817BD240
	|-FieldMouseDragger<ulong>.ProcessUpEvent
	|
	|-RVA: 0x17BD440 Offset: 0x17BBE40 VA: 0x1817BD440
	|-FieldMouseDragger<__Il2CppFullySharedGenericType>.ProcessUpEvent
	*/

	// RVA: -1 Offset: -1
	private void UpdateValueOnKeyDown(KeyDownEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17BAEE0 Offset: 0x17B98E0 VA: 0x1817BAEE0
	|-FieldMouseDragger<double>.UpdateValueOnKeyDown
	|
	|-RVA: 0x17BAC70 Offset: 0x17B9670 VA: 0x1817BAC70
	|-FieldMouseDragger<int>.UpdateValueOnKeyDown
	|
	|-RVA: 0x17BE8D0 Offset: 0x17BD2D0 VA: 0x1817BE8D0
	|-FieldMouseDragger<long>.UpdateValueOnKeyDown
	|
	|-RVA: 0x17BF100 Offset: 0x17BDB00 VA: 0x1817BF100
	|-FieldMouseDragger<float>.UpdateValueOnKeyDown
	|
	|-RVA: 0x17BE660 Offset: 0x17BD060 VA: 0x1817BE660
	|-FieldMouseDragger<uint>.UpdateValueOnKeyDown
	|
	|-RVA: 0x17BEB40 Offset: 0x17BD540 VA: 0x1817BEB40
	|-FieldMouseDragger<ulong>.UpdateValueOnKeyDown
	|
	|-RVA: 0x17BEDB0 Offset: 0x17BD7B0 VA: 0x1817BEDB0
	|-FieldMouseDragger<__Il2CppFullySharedGenericType>.UpdateValueOnKeyDown
	*/
}
