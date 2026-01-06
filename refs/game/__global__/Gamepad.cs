public class Gamepad : InputDevice, IDualMotorRumble, IHaptics // TypeDefIndex: 7367
{
	// Fields
	[CompilerGenerated]
	private ButtonControl <buttonWest>k__BackingField; // 0x190
	[CompilerGenerated]
	private ButtonControl <buttonNorth>k__BackingField; // 0x198
	[CompilerGenerated]
	private ButtonControl <buttonSouth>k__BackingField; // 0x1A0
	[CompilerGenerated]
	private ButtonControl <buttonEast>k__BackingField; // 0x1A8
	[CompilerGenerated]
	private ButtonControl <leftStickButton>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private ButtonControl <rightStickButton>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private ButtonControl <startButton>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private ButtonControl <selectButton>k__BackingField; // 0x1C8
	[CompilerGenerated]
	private DpadControl <dpad>k__BackingField; // 0x1D0
	[CompilerGenerated]
	private ButtonControl <leftShoulder>k__BackingField; // 0x1D8
	[CompilerGenerated]
	private ButtonControl <rightShoulder>k__BackingField; // 0x1E0
	[CompilerGenerated]
	private StickControl <leftStick>k__BackingField; // 0x1E8
	[CompilerGenerated]
	private StickControl <rightStick>k__BackingField; // 0x1F0
	[CompilerGenerated]
	private ButtonControl <leftTrigger>k__BackingField; // 0x1F8
	[CompilerGenerated]
	private ButtonControl <rightTrigger>k__BackingField; // 0x200
	[CompilerGenerated]
	private static Gamepad <current>k__BackingField; // 0x0
	private DualMotorRumble m_Rumble; // 0x208
	private static int s_GamepadCount; // 0x8
	private static Gamepad[] s_Gamepads; // 0x10

	// Properties
	public ButtonControl buttonWest { get; set; }
	public ButtonControl buttonNorth { get; set; }
	public ButtonControl buttonSouth { get; set; }
	public ButtonControl buttonEast { get; set; }
	public ButtonControl leftStickButton { get; set; }
	public ButtonControl rightStickButton { get; set; }
	public ButtonControl startButton { get; set; }
	public ButtonControl selectButton { get; set; }
	public DpadControl dpad { get; set; }
	public ButtonControl leftShoulder { get; set; }
	public ButtonControl rightShoulder { get; set; }
	public StickControl leftStick { get; set; }
	public StickControl rightStick { get; set; }
	public ButtonControl leftTrigger { get; set; }
	public ButtonControl rightTrigger { get; set; }
	public ButtonControl aButton { get; }
	public ButtonControl bButton { get; }
	public ButtonControl xButton { get; }
	public ButtonControl yButton { get; }
	public ButtonControl triangleButton { get; }
	public ButtonControl squareButton { get; }
	public ButtonControl circleButton { get; }
	public ButtonControl crossButton { get; }
	public ButtonControl Item { get; }
	public static Gamepad current { get; set; }
	public static ReadOnlyArray<Gamepad> all { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public ButtonControl get_buttonWest() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_buttonWest(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x1E43DE0 Offset: 0x1E427E0 VA: 0x181E43DE0
	public ButtonControl get_buttonNorth() { }

	[CompilerGenerated]
	// RVA: 0x1E44940 Offset: 0x1E43340 VA: 0x181E44940
	protected void set_buttonNorth(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public ButtonControl get_buttonSouth() { }

	[CompilerGenerated]
	// RVA: 0x76A800 Offset: 0x769200 VA: 0x18076A800
	protected void set_buttonSouth(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x76A7D0 Offset: 0x7691D0 VA: 0x18076A7D0
	public ButtonControl get_buttonEast() { }

	[CompilerGenerated]
	// RVA: 0x76A7E0 Offset: 0x7691E0 VA: 0x18076A7E0
	protected void set_buttonEast(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	public ButtonControl get_leftStickButton() { }

	[CompilerGenerated]
	// RVA: 0xBF26E0 Offset: 0xBF10E0 VA: 0x180BF26E0
	protected void set_leftStickButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	public ButtonControl get_rightStickButton() { }

	[CompilerGenerated]
	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0
	protected void set_rightStickButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public ButtonControl get_startButton() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	protected void set_startButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public ButtonControl get_selectButton() { }

	[CompilerGenerated]
	// RVA: 0x7264F0 Offset: 0x724EF0 VA: 0x1807264F0
	protected void set_selectButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x68E6E0 Offset: 0x68D0E0 VA: 0x18068E6E0
	public DpadControl get_dpad() { }

	[CompilerGenerated]
	// RVA: 0x68E700 Offset: 0x68D100 VA: 0x18068E700
	protected void set_dpad(DpadControl value) { }

	[CompilerGenerated]
	// RVA: 0x6855A0 Offset: 0x683FA0 VA: 0x1806855A0
	public ButtonControl get_leftShoulder() { }

	[CompilerGenerated]
	// RVA: 0x6855B0 Offset: 0x683FB0 VA: 0x1806855B0
	protected void set_leftShoulder(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public ButtonControl get_rightShoulder() { }

	[CompilerGenerated]
	// RVA: 0x718BD0 Offset: 0x7175D0 VA: 0x180718BD0
	protected void set_rightShoulder(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCE0 Offset: 0x6BE6E0 VA: 0x1806BFCE0
	public StickControl get_leftStick() { }

	[CompilerGenerated]
	// RVA: 0x6BFF10 Offset: 0x6BE910 VA: 0x1806BFF10
	protected void set_leftStick(StickControl value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCF0 Offset: 0x6BE6F0 VA: 0x1806BFCF0
	public StickControl get_rightStick() { }

	[CompilerGenerated]
	// RVA: 0x6BFF30 Offset: 0x6BE930 VA: 0x1806BFF30
	protected void set_rightStick(StickControl value) { }

	[CompilerGenerated]
	// RVA: 0x6410E0 Offset: 0x63FAE0 VA: 0x1806410E0
	public ButtonControl get_leftTrigger() { }

	[CompilerGenerated]
	// RVA: 0x27498C0 Offset: 0x27482C0 VA: 0x1827498C0
	protected void set_leftTrigger(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x2031380 Offset: 0x202FD80 VA: 0x182031380
	public ButtonControl get_rightTrigger() { }

	[CompilerGenerated]
	// RVA: 0x27498A0 Offset: 0x27482A0 VA: 0x1827498A0
	protected void set_rightTrigger(ButtonControl value) { }

	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public ButtonControl get_aButton() { }

	// RVA: 0x76A7D0 Offset: 0x7691D0 VA: 0x18076A7D0
	public ButtonControl get_bButton() { }

	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public ButtonControl get_xButton() { }

	// RVA: 0x1E43DE0 Offset: 0x1E427E0 VA: 0x181E43DE0
	public ButtonControl get_yButton() { }

	// RVA: 0x1E43DE0 Offset: 0x1E427E0 VA: 0x181E43DE0
	public ButtonControl get_triangleButton() { }

	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public ButtonControl get_squareButton() { }

	// RVA: 0x76A7D0 Offset: 0x7691D0 VA: 0x18076A7D0
	public ButtonControl get_circleButton() { }

	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public ButtonControl get_crossButton() { }

	// RVA: 0x2799660 Offset: 0x2798060 VA: 0x182799660
	public ButtonControl get_Item(GamepadButton button) { }

	[CompilerGenerated]
	// RVA: 0x27998F0 Offset: 0x27982F0 VA: 0x1827998F0
	public static Gamepad get_current() { }

	[CompilerGenerated]
	// RVA: 0x2799930 Offset: 0x2798330 VA: 0x182799930
	private static void set_current(Gamepad value) { }

	// RVA: 0x2799880 Offset: 0x2798280 VA: 0x182799880
	public static ReadOnlyArray<Gamepad> get_all() { }

	// RVA: 0x2798FE0 Offset: 0x27979E0 VA: 0x182798FE0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2799370 Offset: 0x2797D70 VA: 0x182799370 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x27993D0 Offset: 0x2797DD0 VA: 0x1827993D0 Slot: 18
	protected override void OnAdded() { }

	// RVA: 0x2799440 Offset: 0x2797E40 VA: 0x182799440 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x2799560 Offset: 0x2797F60 VA: 0x182799560 Slot: 26
	public virtual void PauseHaptics() { }

	// RVA: 0x27995A0 Offset: 0x2797FA0 VA: 0x1827995A0 Slot: 27
	public virtual void ResumeHaptics() { }

	// RVA: 0x2799580 Offset: 0x2797F80 VA: 0x182799580 Slot: 28
	public virtual void ResetHaptics() { }

	// RVA: 0x27995C0 Offset: 0x2797FC0 VA: 0x1827995C0 Slot: 29
	public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

	// RVA: 0x27995F0 Offset: 0x2797FF0 VA: 0x1827995F0
	public void .ctor() { }
}
