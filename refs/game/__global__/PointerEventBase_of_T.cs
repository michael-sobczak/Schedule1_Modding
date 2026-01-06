public abstract class PointerEventBase<T> : EventBase<T>, IPointerEvent, IPointerEventInternal // TypeDefIndex: 6624
{
	// Fields
	private bool m_AltitudeNeedsConversion; // 0x0
	private bool m_AzimuthNeedsConversion; // 0x0
	private float m_AltitudeAngle; // 0x0
	private float m_AzimuthAngle; // 0x0
	private bool m_TiltNeeded; // 0x0
	private Vector2 m_Tilt; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <pointerId>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <pointerType>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isPrimary>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <button>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <pressedButtons>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Vector3 <position>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Vector3 <localPosition>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Vector3 <deltaPosition>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private float <deltaTime>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <clickCount>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private float <pressure>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private float <tangentialPressure>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private float <twist>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private PenStatus <penStatus>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Vector2 <radius>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Vector2 <radiusVariance>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventModifiers <modifiers>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <UnityEngine.UIElements.IPointerEventInternal.triggeredByOS>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer>k__BackingField; // 0x0

	// Properties
	public int pointerId { get; set; }
	public string pointerType { get; set; }
	public bool isPrimary { get; set; }
	public int button { get; set; }
	public int pressedButtons { get; set; }
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 deltaPosition { get; set; }
	public float deltaTime { get; set; }
	public int clickCount { get; set; }
	public float pressure { get; set; }
	public float tangentialPressure { get; set; }
	public float altitudeAngle { get; set; }
	public float azimuthAngle { get; set; }
	public float twist { get; set; }
	public Vector2 tilt { get; set; }
	public PenStatus penStatus { get; set; }
	public Vector2 radius { get; set; }
	public Vector2 radiusVariance { get; set; }
	public EventModifiers modifiers { get; set; }
	public bool shiftKey { get; }
	public bool ctrlKey { get; }
	public bool commandKey { get; }
	public bool altKey { get; }
	public bool actionKey { get; }
	private bool UnityEngine.UIElements.IPointerEventInternal.triggeredByOS { get; set; }
	private bool UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer { get; set; }
	public override IEventHandler currentTarget { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public int get_pointerId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B3AE0 Offset: 0x5B24E0 VA: 0x1805B3AE0
	|-PointerEventBase<object>.get_pointerId
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_pointerId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B3AF0 Offset: 0x5B24F0 VA: 0x1805B3AF0
	|-PointerEventBase<object>.set_pointerId
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 16
	public string get_pointerType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	|-PointerEventBase<object>.get_pointerType
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_pointerType(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20
	|-PointerEventBase<object>.set_pointerType
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 17
	public bool get_isPrimary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063B40 Offset: 0x1062540 VA: 0x181063B40
	|-PointerEventBase<object>.get_isPrimary
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_isPrimary(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063B60 Offset: 0x1062560 VA: 0x181063B60
	|-PointerEventBase<object>.set_isPrimary
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 18
	public int get_button() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9570 Offset: 0x10F7F70 VA: 0x1810F9570
	|-PointerEventBase<object>.get_button
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_button(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9800 Offset: 0x10F8200 VA: 0x1810F9800
	|-PointerEventBase<object>.set_button
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 19
	public int get_pressedButtons() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6A4D80 Offset: 0x6A3780 VA: 0x1806A4D80
	|-PointerEventBase<object>.get_pressedButtons
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_pressedButtons(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6A5560 Offset: 0x6A3F60 VA: 0x1806A5560
	|-PointerEventBase<object>.set_pressedButtons
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 20
	public Vector3 get_position() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F95E0 Offset: 0x10F7FE0 VA: 0x1810F95E0
	|-PointerEventBase<object>.get_position
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_position(Vector3 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F99B0 Offset: 0x10F83B0 VA: 0x1810F99B0
	|-PointerEventBase<object>.set_position
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 21
	public Vector3 get_localPosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F95C0 Offset: 0x10F7FC0 VA: 0x1810F95C0
	|-PointerEventBase<object>.get_localPosition
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_localPosition(Vector3 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9980 Offset: 0x10F8380 VA: 0x1810F9980
	|-PointerEventBase<object>.set_localPosition
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 22
	public Vector3 get_deltaPosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F95A0 Offset: 0x10F7FA0 VA: 0x1810F95A0
	|-PointerEventBase<object>.get_deltaPosition
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_deltaPosition(Vector3 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9950 Offset: 0x10F8350 VA: 0x1810F9950
	|-PointerEventBase<object>.set_deltaPosition
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 23
	public float get_deltaTime() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51E8E0 Offset: 0x51D2E0 VA: 0x18051E8E0
	|-PointerEventBase<object>.get_deltaTime
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_deltaTime(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9970 Offset: 0x10F8370 VA: 0x1810F9970
	|-PointerEventBase<object>.set_deltaTime
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 24
	public int get_clickCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5231E0 Offset: 0x521BE0 VA: 0x1805231E0
	|-PointerEventBase<object>.get_clickCount
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_clickCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9810 Offset: 0x10F8210 VA: 0x1810F9810
	|-PointerEventBase<object>.set_clickCount
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 25
	public float get_pressure() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8D2110 Offset: 0x8D0B10 VA: 0x1808D2110
	|-PointerEventBase<object>.get_pressure
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_pressure(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F99D0 Offset: 0x10F83D0 VA: 0x1810F99D0
	|-PointerEventBase<object>.set_pressure
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 26
	public float get_tangentialPressure() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51D960 Offset: 0x51C360 VA: 0x18051D960
	|-PointerEventBase<object>.get_tangentialPressure
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_tangentialPressure(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA63CD0 Offset: 0xA626D0 VA: 0x180A63CD0
	|-PointerEventBase<object>.set_tangentialPressure
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public float get_altitudeAngle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F93C0 Offset: 0x10F7DC0 VA: 0x1810F93C0
	|-PointerEventBase<object>.get_altitudeAngle
	*/

	// RVA: -1 Offset: -1
	protected void set_altitudeAngle(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F97E0 Offset: 0x10F81E0 VA: 0x1810F97E0
	|-PointerEventBase<object>.set_altitudeAngle
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public float get_azimuthAngle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9450 Offset: 0x10F7E50 VA: 0x1810F9450
	|-PointerEventBase<object>.get_azimuthAngle
	*/

	// RVA: -1 Offset: -1
	protected void set_azimuthAngle(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F97F0 Offset: 0x10F81F0 VA: 0x1810F97F0
	|-PointerEventBase<object>.set_azimuthAngle
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 29
	public float get_twist() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xABF1D0 Offset: 0xABDBD0 VA: 0x180ABF1D0
	|-PointerEventBase<object>.get_twist
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_twist(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9A10 Offset: 0x10F8410 VA: 0x1810F9A10
	|-PointerEventBase<object>.set_twist
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public Vector2 get_tilt() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9650 Offset: 0x10F8050 VA: 0x1810F9650
	|-PointerEventBase<object>.get_tilt
	*/

	// RVA: -1 Offset: -1
	protected void set_tilt(Vector2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9A00 Offset: 0x10F8400 VA: 0x1810F9A00
	|-PointerEventBase<object>.set_tilt
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 31
	public PenStatus get_penStatus() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD9E760 Offset: 0xD9D160 VA: 0x180D9E760
	|-PointerEventBase<object>.get_penStatus
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_penStatus(PenStatus value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD9EBD0 Offset: 0xD9D5D0 VA: 0x180D9EBD0
	|-PointerEventBase<object>.set_penStatus
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 32
	public Vector2 get_radius() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9620 Offset: 0x10F8020 VA: 0x1810F9620
	|-PointerEventBase<object>.get_radius
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_radius(Vector2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F99F0 Offset: 0x10F83F0 VA: 0x1810F99F0
	|-PointerEventBase<object>.set_radius
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 33
	public Vector2 get_radiusVariance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9600 Offset: 0x10F8000 VA: 0x1810F9600
	|-PointerEventBase<object>.get_radiusVariance
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_radiusVariance(Vector2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F99E0 Offset: 0x10F83E0 VA: 0x1810F99E0
	|-PointerEventBase<object>.set_radiusVariance
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 34
	public EventModifiers get_modifiers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51D970 Offset: 0x51C370 VA: 0x18051D970
	|-PointerEventBase<object>.get_modifiers
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_modifiers(EventModifiers value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F99A0 Offset: 0x10F83A0 VA: 0x1810F99A0
	|-PointerEventBase<object>.set_modifiers
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public bool get_shiftKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9640 Offset: 0x10F8040 VA: 0x1810F9640
	|-PointerEventBase<object>.get_shiftKey
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool get_ctrlKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9590 Offset: 0x10F7F90 VA: 0x1810F9590
	|-PointerEventBase<object>.get_ctrlKey
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public bool get_commandKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9580 Offset: 0x10F7F80 VA: 0x1810F9580
	|-PointerEventBase<object>.get_commandKey
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public bool get_altKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F93B0 Offset: 0x10F7DB0 VA: 0x1810F93B0
	|-PointerEventBase<object>.get_altKey
	*/

	// RVA: -1 Offset: -1 Slot: 39
	public bool get_actionKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9320 Offset: 0x10F7D20 VA: 0x1810F9320
	|-PointerEventBase<object>.get_actionKey
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 40
	private bool UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9250 Offset: 0x10F7C50 VA: 0x1810F9250
	|-PointerEventBase<object>.UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 41
	private void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9270 Offset: 0x10F7C70 VA: 0x1810F9270
	|-PointerEventBase<object>.UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 42
	private bool UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9240 Offset: 0x10F7C40 VA: 0x1810F9240
	|-PointerEventBase<object>.UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 43
	private void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9260 Offset: 0x10F7C60 VA: 0x1810F9260
	|-PointerEventBase<object>.UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F8B70 Offset: 0x10F7570 VA: 0x1810F8B70
	|-PointerEventBase<object>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F8C40 Offset: 0x10F7640 VA: 0x1810F8C40
	|-PointerEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override IEventHandler get_currentTarget() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063C20 Offset: 0x1062620 VA: 0x181063C20
	|-PointerEventBase<object>.get_currentTarget
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override void set_currentTarget(IEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9820 Offset: 0x10F8220 VA: 0x1810F9820
	|-PointerEventBase<object>.set_currentTarget
	*/

	// RVA: -1 Offset: -1
	private static bool IsMouse(Event systemEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F8BC0 Offset: 0x10F75C0 VA: 0x1810F8BC0
	|-PointerEventBase<object>.IsMouse
	*/

	// RVA: -1 Offset: -1
	private static bool IsTouch(Event systemEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F8C00 Offset: 0x10F7600 VA: 0x1810F8C00
	|-PointerEventBase<object>.IsTouch
	*/

	// RVA: -1 Offset: -1
	private static float TiltToAzimuth(Vector2 tilt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9130 Offset: 0x10F7B30 VA: 0x1810F9130
	|-PointerEventBase<object>.TiltToAzimuth
	*/

	// RVA: -1 Offset: -1
	private static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F6740 Offset: 0x10F5140 VA: 0x1810F6740
	|-PointerEventBase<object>.AzimuthAndAlitutudeToTilt
	*/

	// RVA: -1 Offset: -1
	private static float TiltToAltitude(Vector2 tilt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F90E0 Offset: 0x10F7AE0 VA: 0x1810F90E0
	|-PointerEventBase<object>.TiltToAltitude
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(Event systemEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F6E50 Offset: 0x10F5850 VA: 0x1810F6E50
	|-PointerEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	internal static T GetPooled(EventType eventType, Vector3 mousePosition, Vector2 delta, int button, int clickCount, EventModifiers modifiers) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F8790 Offset: 0x10F7190 VA: 0x1810F8790
	|-PointerEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(Touch touch, EventModifiers modifiers = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F67E0 Offset: 0x10F51E0 VA: 0x1810F67E0
	|-PointerEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(PenData pen, EventModifiers modifiers = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F8170 Offset: 0x10F6B70 VA: 0x1810F8170
	|-PointerEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F7F80 Offset: 0x10F6980 VA: 0x1810F7F80
	|-PointerEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(IPointerEvent triggerEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F7970 Offset: 0x10F6370 VA: 0x1810F7970
	|-PointerEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected internal override void PreDispatch(IPanel panel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F8FD0 Offset: 0x10F79D0 VA: 0x1810F8FD0
	|-PointerEventBase<object>.PreDispatch
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected internal override void PostDispatch(IPanel panel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F8EB0 Offset: 0x10F78B0 VA: 0x1810F8EB0
	|-PointerEventBase<object>.PostDispatch
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9280 Offset: 0x10F7C80 VA: 0x1810F9280
	|-PointerEventBase<object>..ctor
	*/
}
