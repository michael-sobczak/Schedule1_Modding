public class ButtonControl : AxisControl // TypeDefIndex: 7771
{
	// Fields
	private bool m_NeedsToCheckFramePress; // 0x130
	private uint m_UpdateCountLastPressed; // 0x134
	private uint m_UpdateCountLastReleased; // 0x138
	private bool m_LastUpdateWasPress; // 0x13C
	[CompilerGenerated]
	private bool <needsToCheckFramePress>k__BackingField; // 0x13D
	public float pressPoint; // 0x140
	internal static float s_GlobalDefaultButtonPressPoint; // 0x0
	internal static float s_GlobalDefaultButtonReleaseThreshold; // 0x4
	internal const float kMinButtonPressPoint = 0.0001;

	// Properties
	internal bool needsToCheckFramePress { get; set; }
	public float pressPointOrDefault { get; }
	public bool isPressed { get; }
	public bool wasPressedThisFrame { get; }
	public bool wasReleasedThisFrame { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2778BF0 Offset: 0x27775F0 VA: 0x182778BF0
	internal bool get_needsToCheckFramePress() { }

	[CompilerGenerated]
	// RVA: 0x2778E60 Offset: 0x2777860 VA: 0x182778E60
	private void set_needsToCheckFramePress(bool value) { }

	// RVA: 0x2778C00 Offset: 0x2777600 VA: 0x182778C00
	public float get_pressPointOrDefault() { }

	// RVA: 0x2778AE0 Offset: 0x27774E0 VA: 0x182778AE0
	public void .ctor() { }

	// RVA: 0x2777600 Offset: 0x2776000 VA: 0x182777600
	public bool IsValueConsideredPressed(float value) { }

	// RVA: 0x2778B90 Offset: 0x2777590 VA: 0x182778B90
	public bool get_isPressed() { }

	// RVA: 0x2778920 Offset: 0x2777320 VA: 0x182778920
	private void BeginTestingForFramePresses(bool currentlyPressed, bool pressedLastFrame) { }

	// RVA: 0x2778C60 Offset: 0x2777660 VA: 0x182778C60
	public bool get_wasPressedThisFrame() { }

	// RVA: 0x2778D60 Offset: 0x2777760 VA: 0x182778D60
	public bool get_wasReleasedThisFrame() { }

	// RVA: 0x2778A40 Offset: 0x2777440 VA: 0x182778A40
	internal void UpdateWasPressed() { }
}
