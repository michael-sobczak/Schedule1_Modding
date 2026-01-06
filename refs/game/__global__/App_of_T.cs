public abstract class App<T> : PlayerSingleton<T> // TypeDefIndex: 2656
{
	// Fields
	public static List<App<T>> Apps; // 0x0
	[Header("Settings")]
	public string AppName; // 0x0
	public string IconLabel; // 0x0
	public Sprite AppIcon; // 0x0
	public App.EOrientation<T> Orientation; // 0x0
	public bool AvailableInTutorial; // 0x0
	[SerializeField]
	[Header("References")]
	protected RectTransform appContainer; // 0x0
	protected RectTransform notificationContainer; // 0x0
	protected Text notificationText; // 0x0
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x0
	protected Button appIconButton; // 0x0

	// Properties
	public bool isOpen { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public static App<T> GetApp(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1648360 Offset: 0x1646D60 VA: 0x181648360
	|-App<object>.GetApp
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public bool get_isOpen() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	|-App<object>.get_isOpen
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_isOpen(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520
	|-App<object>.set_isOpen
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void OnStartClient(bool IsOwner) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1648770 Offset: 0x1647170 VA: 0x181648770
	|-App<object>.OnStartClient
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1648E40 Offset: 0x1647840 VA: 0x181648E40
	|-App<object>.Start
	*/

	// RVA: -1 Offset: -1
	private void Close() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1648080 Offset: 0x1646A80 VA: 0x181648080
	|-App<object>.Close
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected virtual void Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1649120 Offset: 0x1647B20 VA: 0x181649120
	|-App<object>.Update
	*/

	// RVA: -1 Offset: -1
	private bool IsHoveringButton() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16484F0 Offset: 0x1646EF0 VA: 0x1816484F0
	|-App<object>.IsHoveringButton
	*/

	// RVA: -1 Offset: -1
	private void GenerateHomeScreenIcon() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1648150 Offset: 0x1646B50 VA: 0x181648150
	|-App<object>.GenerateHomeScreenIcon
	*/

	// RVA: -1 Offset: -1
	public void SetNotificationCount(int amount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1648970 Offset: 0x1647370 VA: 0x181648970
	|-App<object>.SetNotificationCount
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual void OnPhoneOpened() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16486E0 Offset: 0x16470E0 VA: 0x1816486E0
	|-App<object>.OnPhoneOpened
	*/

	// RVA: -1 Offset: -1
	private void ShortcutClicked() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1648E20 Offset: 0x1647820 VA: 0x181648E20
	|-App<object>.ShortcutClicked
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual void Exit(ExitAction exit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16480A0 Offset: 0x1646AA0 VA: 0x1816480A0
	|-App<object>.Exit
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual void SetOpen(bool open) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16489F0 Offset: 0x16473F0 VA: 0x1816489F0
	|-App<object>.SetOpen
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1649320 Offset: 0x1647D20 VA: 0x181649320
	|-App<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1649220 Offset: 0x1647C20 VA: 0x181649220
	|-App<object>..cctor
	*/
}
