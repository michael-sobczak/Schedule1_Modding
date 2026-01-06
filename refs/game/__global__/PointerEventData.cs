public class PointerEventData : BaseEventData // TypeDefIndex: 16520
{
	// Fields
	[CompilerGenerated]
	private GameObject <pointerEnter>k__BackingField; // 0x20
	private GameObject m_PointerPress; // 0x28
	[CompilerGenerated]
	private GameObject <lastPress>k__BackingField; // 0x30
	[CompilerGenerated]
	private GameObject <rawPointerPress>k__BackingField; // 0x38
	[CompilerGenerated]
	private GameObject <pointerDrag>k__BackingField; // 0x40
	[CompilerGenerated]
	private GameObject <pointerClick>k__BackingField; // 0x48
	[CompilerGenerated]
	private RaycastResult <pointerCurrentRaycast>k__BackingField; // 0x50
	[CompilerGenerated]
	private RaycastResult <pointerPressRaycast>k__BackingField; // 0xA0
	public List<GameObject> hovered; // 0xF0
	[CompilerGenerated]
	private bool <eligibleForClick>k__BackingField; // 0xF8
	[CompilerGenerated]
	private int <displayIndex>k__BackingField; // 0xFC
	[CompilerGenerated]
	private int <pointerId>k__BackingField; // 0x100
	[CompilerGenerated]
	private Vector2 <position>k__BackingField; // 0x104
	[CompilerGenerated]
	private Vector2 <delta>k__BackingField; // 0x10C
	[CompilerGenerated]
	private Vector2 <pressPosition>k__BackingField; // 0x114
	[CompilerGenerated]
	private Vector3 <worldPosition>k__BackingField; // 0x11C
	[CompilerGenerated]
	private Vector3 <worldNormal>k__BackingField; // 0x128
	[CompilerGenerated]
	private float <clickTime>k__BackingField; // 0x134
	[CompilerGenerated]
	private int <clickCount>k__BackingField; // 0x138
	[CompilerGenerated]
	private Vector2 <scrollDelta>k__BackingField; // 0x13C
	[CompilerGenerated]
	private bool <useDragThreshold>k__BackingField; // 0x144
	[CompilerGenerated]
	private bool <dragging>k__BackingField; // 0x145
	[CompilerGenerated]
	private PointerEventData.InputButton <button>k__BackingField; // 0x148
	[CompilerGenerated]
	private float <pressure>k__BackingField; // 0x14C
	[CompilerGenerated]
	private float <tangentialPressure>k__BackingField; // 0x150
	[CompilerGenerated]
	private float <altitudeAngle>k__BackingField; // 0x154
	[CompilerGenerated]
	private float <azimuthAngle>k__BackingField; // 0x158
	[CompilerGenerated]
	private float <twist>k__BackingField; // 0x15C
	[CompilerGenerated]
	private Vector2 <tilt>k__BackingField; // 0x160
	[CompilerGenerated]
	private PenStatus <penStatus>k__BackingField; // 0x168
	[CompilerGenerated]
	private Vector2 <radius>k__BackingField; // 0x16C
	[CompilerGenerated]
	private Vector2 <radiusVariance>k__BackingField; // 0x174
	[CompilerGenerated]
	private bool <fullyExited>k__BackingField; // 0x17C
	[CompilerGenerated]
	private bool <reentered>k__BackingField; // 0x17D

	// Properties
	public GameObject pointerEnter { get; set; }
	public GameObject lastPress { get; set; }
	public GameObject rawPointerPress { get; set; }
	public GameObject pointerDrag { get; set; }
	public GameObject pointerClick { get; set; }
	public RaycastResult pointerCurrentRaycast { get; set; }
	public RaycastResult pointerPressRaycast { get; set; }
	public bool eligibleForClick { get; set; }
	public int displayIndex { get; set; }
	public int pointerId { get; set; }
	public Vector2 position { get; set; }
	public Vector2 delta { get; set; }
	public Vector2 pressPosition { get; set; }
	[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
	public Vector3 worldPosition { get; set; }
	[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
	public Vector3 worldNormal { get; set; }
	public float clickTime { get; set; }
	public int clickCount { get; set; }
	public Vector2 scrollDelta { get; set; }
	public bool useDragThreshold { get; set; }
	public bool dragging { get; set; }
	public PointerEventData.InputButton button { get; set; }
	public float pressure { get; set; }
	public float tangentialPressure { get; set; }
	public float altitudeAngle { get; set; }
	public float azimuthAngle { get; set; }
	public float twist { get; set; }
	public Vector2 tilt { get; set; }
	public PenStatus penStatus { get; set; }
	public Vector2 radius { get; set; }
	public Vector2 radiusVariance { get; set; }
	public bool fullyExited { get; set; }
	public bool reentered { get; set; }
	public Camera enterEventCamera { get; }
	public Camera pressEventCamera { get; }
	public GameObject pointerPress { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public GameObject get_pointerEnter() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_pointerEnter(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public GameObject get_lastPress() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_lastPress(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public GameObject get_rawPointerPress() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public GameObject get_pointerDrag() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_pointerDrag(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public GameObject get_pointerClick() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_pointerClick(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x2F4F350 Offset: 0x2F4DD50 VA: 0x182F4F350
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGenerated]
	// RVA: 0x2F4F5A0 Offset: 0x2F4DFA0 VA: 0x182F4F5A0
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGenerated]
	// RVA: 0x2F4F390 Offset: 0x2F4DD90 VA: 0x182F4F390
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGenerated]
	// RVA: 0x2F4F5F0 Offset: 0x2F4DFF0 VA: 0x182F4F5F0
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGenerated]
	// RVA: 0x516240 Offset: 0x514C40 VA: 0x180516240
	public bool get_eligibleForClick() { }

	[CompilerGenerated]
	// RVA: 0x1A3AEE0 Offset: 0x1A398E0 VA: 0x181A3AEE0
	public void set_eligibleForClick(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5232A0 Offset: 0x521CA0 VA: 0x1805232A0
	public int get_displayIndex() { }

	[CompilerGenerated]
	// RVA: 0x7C2510 Offset: 0x7C0F10 VA: 0x1807C2510
	public void set_displayIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x2302490 Offset: 0x2300E90 VA: 0x182302490
	public int get_pointerId() { }

	[CompilerGenerated]
	// RVA: 0x2F4F5E0 Offset: 0x2F4DFE0 VA: 0x182F4F5E0
	public void set_pointerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2F4F3D0 Offset: 0x2F4DDD0 VA: 0x182F4F3D0
	public Vector2 get_position() { }

	[CompilerGenerated]
	// RVA: 0x2F4F6D0 Offset: 0x2F4E0D0 VA: 0x182F4F6D0
	public void set_position(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2F4F290 Offset: 0x2F4DC90 VA: 0x182F4F290
	public Vector2 get_delta() { }

	[CompilerGenerated]
	// RVA: 0x2F4F580 Offset: 0x2F4DF80 VA: 0x182F4F580
	public void set_delta(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2F4F490 Offset: 0x2F4DE90 VA: 0x182F4F490
	public Vector2 get_pressPosition() { }

	[CompilerGenerated]
	// RVA: 0x2F4F6E0 Offset: 0x2F4E0E0 VA: 0x182F4F6E0
	public void set_pressPosition(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2F4F550 Offset: 0x2F4DF50 VA: 0x182F4F550
	public Vector3 get_worldPosition() { }

	[CompilerGenerated]
	// RVA: 0x2F4F750 Offset: 0x2F4E150 VA: 0x182F4F750
	public void set_worldPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x2F4F530 Offset: 0x2F4DF30 VA: 0x182F4F530
	public Vector3 get_worldNormal() { }

	[CompilerGenerated]
	// RVA: 0x2F4F730 Offset: 0x2F4E130 VA: 0x182F4F730
	public void set_worldNormal(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x8D2010 Offset: 0x8D0A10 VA: 0x1808D2010
	public float get_clickTime() { }

	[CompilerGenerated]
	// RVA: 0x2F4F570 Offset: 0x2F4DF70 VA: 0x182F4F570
	public void set_clickTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x858810 Offset: 0x857210 VA: 0x180858810
	public int get_clickCount() { }

	[CompilerGenerated]
	// RVA: 0x858820 Offset: 0x857220 VA: 0x180858820
	public void set_clickCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x2F4F4F0 Offset: 0x2F4DEF0 VA: 0x182F4F4F0
	public Vector2 get_scrollDelta() { }

	[CompilerGenerated]
	// RVA: 0x2F4F700 Offset: 0x2F4E100 VA: 0x182F4F700
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x8D20C0 Offset: 0x8D0AC0 VA: 0x1808D20C0
	public bool get_useDragThreshold() { }

	[CompilerGenerated]
	// RVA: 0x2F4F720 Offset: 0x2F4E120 VA: 0x182F4F720
	public void set_useDragThreshold(bool value) { }

	[CompilerGenerated]
	// RVA: 0x231C650 Offset: 0x231B050 VA: 0x18231C650
	public bool get_dragging() { }

	[CompilerGenerated]
	// RVA: 0x2F4F590 Offset: 0x2F4DF90 VA: 0x182F4F590
	public void set_dragging(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BFD70 Offset: 0x6BE770 VA: 0x1806BFD70
	public PointerEventData.InputButton get_button() { }

	[CompilerGenerated]
	// RVA: 0x6BFF70 Offset: 0x6BE970 VA: 0x1806BFF70
	public void set_button(PointerEventData.InputButton value) { }

	[CompilerGenerated]
	// RVA: 0x653810 Offset: 0x652210 VA: 0x180653810
	public float get_pressure() { }

	[CompilerGenerated]
	// RVA: 0x653880 Offset: 0x652280 VA: 0x180653880
	public void set_pressure(float value) { }

	[CompilerGenerated]
	// RVA: 0x513120 Offset: 0x511B20 VA: 0x180513120
	public float get_tangentialPressure() { }

	[CompilerGenerated]
	// RVA: 0x70E9B0 Offset: 0x70D3B0 VA: 0x18070E9B0
	public void set_tangentialPressure(float value) { }

	[CompilerGenerated]
	// RVA: 0x86C680 Offset: 0x86B080 VA: 0x18086C680
	public float get_altitudeAngle() { }

	[CompilerGenerated]
	// RVA: 0x86C690 Offset: 0x86B090 VA: 0x18086C690
	public void set_altitudeAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x7C75F0 Offset: 0x7C5FF0 VA: 0x1807C75F0
	public float get_azimuthAngle() { }

	[CompilerGenerated]
	// RVA: 0x7C7630 Offset: 0x7C6030 VA: 0x1807C7630
	public void set_azimuthAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x2C19CF0 Offset: 0x2C186F0 VA: 0x182C19CF0
	public float get_twist() { }

	[CompilerGenerated]
	// RVA: 0x2F4F710 Offset: 0x2F4E110 VA: 0x182F4F710
	public void set_twist(float value) { }

	[CompilerGenerated]
	// RVA: 0x2F4F510 Offset: 0x2F4DF10 VA: 0x182F4F510
	public Vector2 get_tilt() { }

	[CompilerGenerated]
	// RVA: 0xD39AF0 Offset: 0xD384F0 VA: 0x180D39AF0
	public void set_tilt(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x73B350 Offset: 0x739D50 VA: 0x18073B350
	public PenStatus get_penStatus() { }

	[CompilerGenerated]
	// RVA: 0x739E10 Offset: 0x738810 VA: 0x180739E10
	public void set_penStatus(PenStatus value) { }

	[CompilerGenerated]
	// RVA: 0x2F4F4D0 Offset: 0x2F4DED0 VA: 0x182F4F4D0
	public Vector2 get_radius() { }

	[CompilerGenerated]
	// RVA: 0xAB6570 Offset: 0xAB4F70 VA: 0x180AB6570
	public void set_radius(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x2F4F4B0 Offset: 0x2F4DEB0 VA: 0x182F4F4B0
	public Vector2 get_radiusVariance() { }

	[CompilerGenerated]
	// RVA: 0x2F4F6F0 Offset: 0x2F4E0F0 VA: 0x182F4F6F0
	public void set_radiusVariance(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x726320 Offset: 0x724D20 VA: 0x180726320
	public bool get_fullyExited() { }

	[CompilerGenerated]
	// RVA: 0x7264D0 Offset: 0x724ED0 VA: 0x1807264D0
	public void set_fullyExited(bool value) { }

	[CompilerGenerated]
	// RVA: 0x726420 Offset: 0x724E20 VA: 0x180726420
	public bool get_reentered() { }

	[CompilerGenerated]
	// RVA: 0x7264E0 Offset: 0x724EE0 VA: 0x1807264E0
	public void set_reentered(bool value) { }

	// RVA: 0x2F4F010 Offset: 0x2F4DA10 VA: 0x182F4F010
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x2F4E8C0 Offset: 0x2F4D2C0 VA: 0x182F4E8C0
	public bool IsPointerMoving() { }

	// RVA: 0x2F4E8F0 Offset: 0x2F4D2F0 VA: 0x182F4E8F0
	public bool IsScrolling() { }

	// RVA: 0x2F4F2B0 Offset: 0x2F4DCB0 VA: 0x182F4F2B0
	public Camera get_enterEventCamera() { }

	// RVA: 0x2F4F3F0 Offset: 0x2F4DDF0 VA: 0x182F4F3F0
	public Camera get_pressEventCamera() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public GameObject get_pointerPress() { }

	// RVA: 0x2F4F640 Offset: 0x2F4E040 VA: 0x182F4F640
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x2F4E920 Offset: 0x2F4D320 VA: 0x182F4E920 Slot: 3
	public override string ToString() { }
}
