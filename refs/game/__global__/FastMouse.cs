internal class FastMouse : Mouse, IInputStateCallbackReceiver, IEventMerger // TypeDefIndex: 7381
{
	// Fields
	public const string metadata = "AutoWindowSpace;Vector2;Delta;Button;Axis;Digital;Integer;Mouse;Pointer";

	// Methods

	// RVA: 0x2806BB0 Offset: 0x28055B0 VA: 0x182806BB0
	public void .ctor() { }

	// RVA: 0x2803D30 Offset: 0x2802730 VA: 0x182803D30
	private Vector2Control Initialize_ctrlMouseposition(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x2802020 Offset: 0x2800A20 VA: 0x182802020
	private DeltaControl Initialize_ctrlMousedelta(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x28052F0 Offset: 0x2803CF0 VA: 0x1828052F0
	private DeltaControl Initialize_ctrlMousescroll(InternedString kDeltaLayout, InputControl parent) { }

	// RVA: 0x2804470 Offset: 0x2802E70 VA: 0x182804470
	private ButtonControl Initialize_ctrlMousepress(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x28035C0 Offset: 0x2801FC0 VA: 0x1828035C0
	private ButtonControl Initialize_ctrlMouseleftButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x2805020 Offset: 0x2803A20 VA: 0x182805020
	private ButtonControl Initialize_ctrlMouserightButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x2803880 Offset: 0x2802280 VA: 0x182803880
	private ButtonControl Initialize_ctrlMousemiddleButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x2803340 Offset: 0x2801D40 VA: 0x182803340
	private ButtonControl Initialize_ctrlMouseforwardButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x2801B80 Offset: 0x2800580 VA: 0x182801B80
	private ButtonControl Initialize_ctrlMousebackButton(InternedString kButtonLayout, InputControl parent) { }

	// RVA: 0x28046E0 Offset: 0x28030E0 VA: 0x1828046E0
	private AxisControl Initialize_ctrlMousepressure(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x2804930 Offset: 0x2803330 VA: 0x182804930
	private Vector2Control Initialize_ctrlMouseradius(InternedString kVector2Layout, InputControl parent) { }

	// RVA: 0x2803B30 Offset: 0x2802530 VA: 0x182803B30
	private IntegerControl Initialize_ctrlMousepointerId(InternedString kDigitalLayout, InputControl parent) { }

	// RVA: 0x2803130 Offset: 0x2801B30 VA: 0x182803130
	private IntegerControl Initialize_ctrlMousedisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x2801E00 Offset: 0x2800800 VA: 0x182801E00
	private IntegerControl Initialize_ctrlMouseclickCount(InternedString kIntegerLayout, InputControl parent) { }

	// RVA: 0x2803F80 Offset: 0x2802980 VA: 0x182803F80
	private AxisControl Initialize_ctrlMousepositionx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x28041F0 Offset: 0x2802BF0 VA: 0x1828041F0
	private AxisControl Initialize_ctrlMousepositiony(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x28029F0 Offset: 0x28013F0 VA: 0x1828029F0
	private AxisControl Initialize_ctrlMousedeltaup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x2802250 Offset: 0x2800C50 VA: 0x182802250
	private AxisControl Initialize_ctrlMousedeltadown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x28024E0 Offset: 0x2800EE0 VA: 0x1828024E0
	private AxisControl Initialize_ctrlMousedeltaleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x2802770 Offset: 0x2801170 VA: 0x182802770
	private AxisControl Initialize_ctrlMousedeltaright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x2802C70 Offset: 0x2801670 VA: 0x182802C70
	private AxisControl Initialize_ctrlMousedeltax(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x2802ED0 Offset: 0x28018D0 VA: 0x182802ED0
	private AxisControl Initialize_ctrlMousedeltay(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x2805CB0 Offset: 0x28046B0 VA: 0x182805CB0
	private AxisControl Initialize_ctrlMousescrollup(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x2805510 Offset: 0x2803F10 VA: 0x182805510
	private AxisControl Initialize_ctrlMousescrolldown(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x28057A0 Offset: 0x28041A0 VA: 0x1828057A0
	private AxisControl Initialize_ctrlMousescrollleft(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x2805A30 Offset: 0x2804430 VA: 0x182805A30
	private AxisControl Initialize_ctrlMousescrollright(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x2805F30 Offset: 0x2804930 VA: 0x182805F30
	private AxisControl Initialize_ctrlMousescrollx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x28061A0 Offset: 0x2804BA0 VA: 0x1828061A0
	private AxisControl Initialize_ctrlMousescrolly(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x2804B60 Offset: 0x2803560 VA: 0x182804B60
	private AxisControl Initialize_ctrlMouseradiusx(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x2804DC0 Offset: 0x28037C0 VA: 0x182804DC0
	private AxisControl Initialize_ctrlMouseradiusy(InternedString kAxisLayout, InputControl parent) { }

	// RVA: 0x2806570 Offset: 0x2804F70 VA: 0x182806570
	protected void OnNextUpdate() { }

	// RVA: 0x28066D0 Offset: 0x28050D0 VA: 0x1828066D0
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x2806570 Offset: 0x2804F70 VA: 0x182806570 Slot: 22
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x28069E0 Offset: 0x28053E0 VA: 0x1828069E0 Slot: 23
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x2806430 Offset: 0x2804E30 VA: 0x182806430
	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	// RVA: 0x28068A0 Offset: 0x28052A0 VA: 0x1828068A0 Slot: 25
	private bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }
}
