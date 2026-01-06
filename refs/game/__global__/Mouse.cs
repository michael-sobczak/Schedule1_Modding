public class Mouse : Pointer, IInputStateCallbackReceiver // TypeDefIndex: 7376
{
	// Fields
	[CompilerGenerated]
	private DeltaControl <scroll>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private ButtonControl <leftButton>k__BackingField; // 0x1C8
	[CompilerGenerated]
	private ButtonControl <middleButton>k__BackingField; // 0x1D0
	[CompilerGenerated]
	private ButtonControl <rightButton>k__BackingField; // 0x1D8
	[CompilerGenerated]
	private ButtonControl <backButton>k__BackingField; // 0x1E0
	[CompilerGenerated]
	private ButtonControl <forwardButton>k__BackingField; // 0x1E8
	[CompilerGenerated]
	private IntegerControl <clickCount>k__BackingField; // 0x1F0
	[CompilerGenerated]
	private static Mouse <current>k__BackingField; // 0x0
	internal static Mouse s_PlatformMouseDevice; // 0x8

	// Properties
	public DeltaControl scroll { get; set; }
	public ButtonControl leftButton { get; set; }
	public ButtonControl middleButton { get; set; }
	public ButtonControl rightButton { get; set; }
	public ButtonControl backButton { get; set; }
	public ButtonControl forwardButton { get; set; }
	public IntegerControl clickCount { get; set; }
	public static Mouse current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public DeltaControl get_scroll() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	protected void set_scroll(DeltaControl value) { }

	[CompilerGenerated]
	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public ButtonControl get_leftButton() { }

	[CompilerGenerated]
	// RVA: 0x7264F0 Offset: 0x724EF0 VA: 0x1807264F0
	protected void set_leftButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x68E6E0 Offset: 0x68D0E0 VA: 0x18068E6E0
	public ButtonControl get_middleButton() { }

	[CompilerGenerated]
	// RVA: 0x68E700 Offset: 0x68D100 VA: 0x18068E700
	protected void set_middleButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6855A0 Offset: 0x683FA0 VA: 0x1806855A0
	public ButtonControl get_rightButton() { }

	[CompilerGenerated]
	// RVA: 0x6855B0 Offset: 0x683FB0 VA: 0x1806855B0
	protected void set_rightButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public ButtonControl get_backButton() { }

	[CompilerGenerated]
	// RVA: 0x718BD0 Offset: 0x7175D0 VA: 0x180718BD0
	protected void set_backButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCE0 Offset: 0x6BE6E0 VA: 0x1806BFCE0
	public ButtonControl get_forwardButton() { }

	[CompilerGenerated]
	// RVA: 0x6BFF10 Offset: 0x6BE910 VA: 0x1806BFF10
	protected void set_forwardButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCF0 Offset: 0x6BE6F0 VA: 0x1806BFCF0
	public IntegerControl get_clickCount() { }

	[CompilerGenerated]
	// RVA: 0x6BFF30 Offset: 0x6BE930 VA: 0x1806BFF30
	protected void set_clickCount(IntegerControl value) { }

	[CompilerGenerated]
	// RVA: 0x27CB810 Offset: 0x27CA210 VA: 0x1827CB810
	public static Mouse get_current() { }

	[CompilerGenerated]
	// RVA: 0x27CB850 Offset: 0x27CA250 VA: 0x1827CB850
	private static void set_current(Mouse value) { }

	// RVA: 0x27CB4D0 Offset: 0x27C9ED0 VA: 0x1827CB4D0 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x27CB570 Offset: 0x27C9F70 VA: 0x1827CB570 Slot: 18
	protected override void OnAdded() { }

	// RVA: 0x27CB690 Offset: 0x27CA090 VA: 0x1827CB690 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x27CB7A0 Offset: 0x27CA1A0 VA: 0x1827CB7A0
	public void WarpCursorPosition(Vector2 position) { }

	// RVA: 0x27CB2C0 Offset: 0x27C9CC0 VA: 0x1827CB2C0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x27CB5F0 Offset: 0x27C9FF0 VA: 0x1827CB5F0
	protected void OnNextUpdate() { }

	// RVA: 0x27CB720 Offset: 0x27CA120 VA: 0x1827CB720
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x27CB5F0 Offset: 0x27C9FF0 VA: 0x1827CB5F0 Slot: 22
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x27CB720 Offset: 0x27CA120 VA: 0x1827CB720 Slot: 23
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
