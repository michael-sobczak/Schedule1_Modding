public struct TouchState : IInputStateTypeInfo // TypeDefIndex: 7656
{
	// Fields
	internal const int kSizeInBytes = 56;
	[InputControl(displayName = "Touch ID", layout = "Integer", synthetic = True, dontReset = True)]
	public int touchId; // 0x0
	[InputControl(displayName = "Position", dontReset = True)]
	public Vector2 position; // 0x4
	[InputControl(displayName = "Delta", layout = "Delta")]
	public Vector2 delta; // 0xC
	[InputControl(displayName = "Pressure", layout = "Axis")]
	public float pressure; // 0x14
	[InputControl(displayName = "Radius")]
	public Vector2 radius; // 0x18
	[InputControl(name = "phase", displayName = "Touch Phase", layout = "TouchPhase", synthetic = True)]
	[InputControl(name = "press", displayName = "Touch Contact?", layout = "TouchPress", useStateFrom = "phase")]
	public byte phaseId; // 0x20
	[InputControl(name = "tapCount", displayName = "Tap Count", layout = "Integer")]
	public byte tapCount; // 0x21
	[InputControl(name = "displayIndex", displayName = "Display Index", layout = "Integer")]
	public byte displayIndex; // 0x22
	[InputControl(name = "tap", displayName = "Tap", layout = "Button", bit = 4)]
	[InputControl(name = "indirectTouch", displayName = "Indirect Touch?", layout = "Button", bit = 0, synthetic = True)]
	public byte flags; // 0x23
	internal uint updateStepCount; // 0x24
	[InputControl(displayName = "Start Time", layout = "Double", synthetic = True)]
	public double startTime; // 0x28
	[InputControl(displayName = "Start Position", synthetic = True)]
	public Vector2 startPosition; // 0x30

	// Properties
	public static FourCC Format { get; }
	public TouchPhase phase { get; set; }
	public bool isNoneEndedOrCanceled { get; }
	public bool isInProgress { get; }
	public bool isPrimaryTouch { get; set; }
	internal bool isOrphanedPrimaryTouch { get; set; }
	public bool isIndirectTouch { get; set; }
	public bool isTap { get; set; }
	internal bool isTapPress { get; set; }
	internal bool isTapRelease { get; set; }
	internal bool beganInSameFrame { get; set; }
	public FourCC format { get; }

	// Methods

	// RVA: 0x2867F30 Offset: 0x2866930 VA: 0x182867F30
	public static FourCC get_Format() { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public TouchPhase get_phase() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_phase(TouchPhase value) { }

	// RVA: 0x2867FF0 Offset: 0x28669F0 VA: 0x182867FF0
	public bool get_isNoneEndedOrCanceled() { }

	// RVA: 0x2867FC0 Offset: 0x28669C0 VA: 0x182867FC0
	public bool get_isInProgress() { }

	// RVA: 0x2868020 Offset: 0x2866A20 VA: 0x182868020
	public bool get_isPrimaryTouch() { }

	// RVA: 0x28680E0 Offset: 0x2866AE0 VA: 0x1828680E0
	public void set_isPrimaryTouch(bool value) { }

	// RVA: 0x2868010 Offset: 0x2866A10 VA: 0x182868010
	internal bool get_isOrphanedPrimaryTouch() { }

	// RVA: 0x28680B0 Offset: 0x2866AB0 VA: 0x1828680B0
	internal void set_isOrphanedPrimaryTouch(bool value) { }

	// RVA: 0x2867FE0 Offset: 0x28669E0 VA: 0x182867FE0
	public bool get_isIndirectTouch() { }

	// RVA: 0x2868080 Offset: 0x2866A80 VA: 0x182868080
	public void set_isIndirectTouch(bool value) { }

	// RVA: 0x2868030 Offset: 0x2866A30 VA: 0x182868030
	public bool get_isTap() { }

	// RVA: 0x2868110 Offset: 0x2866B10 VA: 0x182868110
	public void set_isTap(bool value) { }

	// RVA: 0x2868030 Offset: 0x2866A30 VA: 0x182868030
	internal bool get_isTapPress() { }

	// RVA: 0x2868110 Offset: 0x2866B10 VA: 0x182868110
	internal void set_isTapPress(bool value) { }

	// RVA: 0x2868040 Offset: 0x2866A40 VA: 0x182868040
	internal bool get_isTapRelease() { }

	// RVA: 0x2868140 Offset: 0x2866B40 VA: 0x182868140
	internal void set_isTapRelease(bool value) { }

	// RVA: 0x2867F70 Offset: 0x2866970 VA: 0x182867F70
	internal bool get_beganInSameFrame() { }

	// RVA: 0x2868050 Offset: 0x2866A50 VA: 0x182868050
	internal void set_beganInSameFrame(bool value) { }

	// RVA: 0x2867F80 Offset: 0x2866980 VA: 0x182867F80 Slot: 4
	public FourCC get_format() { }

	// RVA: 0x2867BB0 Offset: 0x28665B0 VA: 0x182867BB0 Slot: 3
	public override string ToString() { }
}
