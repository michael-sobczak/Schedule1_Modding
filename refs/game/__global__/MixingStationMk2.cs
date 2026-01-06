public class MixingStationMk2 : MixingStation // TypeDefIndex: 3266
{
	// Fields
	public Animation Animation; // 0x3C0
	[Header("Screen")]
	public Canvas ScreenCanvas; // 0x3C8
	public Image OutputIcon; // 0x3D0
	public RectTransform QuestionMark; // 0x3D8
	public TextMeshProUGUI QuantityLabel; // 0x3E0
	public TextMeshProUGUI ProgressLabel; // 0x3E8
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.MixingStationMk2Assembly-CSharp.dll_Excuted; // 0x3F0
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.MixingStationMk2Assembly-CSharp.dll_Excuted; // 0x3F1

	// Methods

	// RVA: 0xA21750 Offset: 0xA20150 VA: 0x180A21750 Slot: 136
	protected override void MinPass() { }

	// RVA: 0xA218A0 Offset: 0xA202A0 VA: 0x180A218A0 Slot: 138
	public override void MixingStart() { }

	// RVA: 0xA21770 Offset: 0xA20170 VA: 0x180A21770 Slot: 139
	public override void MixingDone() { }

	// RVA: 0xA21540 Offset: 0xA1FF40 VA: 0x180A21540
	private void EnableScreen() { }

	// RVA: 0xA21A10 Offset: 0xA20410 VA: 0x180A21A10
	private void UpdateScreen() { }

	// RVA: 0xA21510 Offset: 0xA1FF10 VA: 0x180A21510
	private void DisableScreen() { }

	// RVA: 0xA21AC0 Offset: 0xA204C0 VA: 0x180A21AC0
	public void .ctor() { }

	// RVA: 0xA219F0 Offset: 0xA203F0 VA: 0x180A219F0 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA21940 Offset: 0xA20340 VA: 0x180A21940 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA214A0 Offset: 0xA1FEA0 VA: 0x180A214A0 Slot: 47
	public override void Awake() { }
}
