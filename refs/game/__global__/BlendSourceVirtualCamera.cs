internal class BlendSourceVirtualCamera : ICinemachineCamera // TypeDefIndex: 16132
{
	// Fields
	[CompilerGenerated]
	private CinemachineBlend <Blend>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Priority>k__BackingField; // 0x18
	[CompilerGenerated]
	private Transform <LookAt>k__BackingField; // 0x20
	[CompilerGenerated]
	private Transform <Follow>k__BackingField; // 0x28
	[CompilerGenerated]
	private CameraState <State>k__BackingField; // 0x30

	// Properties
	public CinemachineBlend Blend { get; set; }
	public string Name { get; }
	public string Description { get; }
	public int Priority { get; set; }
	public Transform LookAt { get; set; }
	public Transform Follow { get; set; }
	public CameraState State { get; set; }
	public GameObject VirtualCameraGameObject { get; }
	public bool IsValid { get; }
	public ICinemachineCamera ParentCamera { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(CinemachineBlend blend) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public CinemachineBlend get_Blend() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Blend(CinemachineBlend value) { }

	// RVA: 0xC0EDA0 Offset: 0xC0D7A0 VA: 0x180C0EDA0 Slot: 4
	public string get_Name() { }

	// RVA: 0xC0ED30 Offset: 0xC0D730 VA: 0x180C0ED30 Slot: 5
	public string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 6
	public int get_Priority() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810 Slot: 7
	public void set_Priority(int value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 8
	public Transform get_LookAt() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0 Slot: 9
	public void set_LookAt(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 10
	public Transform get_Follow() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0 Slot: 11
	public void set_Follow(Transform value) { }

	[CompilerGenerated]
	// RVA: 0xC0EA00 Offset: 0xC0D400 VA: 0x180C0EA00 Slot: 12
	public CameraState get_State() { }

	[CompilerGenerated]
	// RVA: 0xC0EDD0 Offset: 0xC0D7D0 VA: 0x180C0EDD0
	private void set_State(CameraState value) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 13
	public GameObject get_VirtualCameraGameObject() { }

	// RVA: 0xC0ED80 Offset: 0xC0D780 VA: 0x180C0ED80 Slot: 14
	public bool get_IsValid() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 15
	public ICinemachineCamera get_ParentCamera() { }

	// RVA: 0xC0EAA0 Offset: 0xC0D4A0 VA: 0x180C0EAA0 Slot: 16
	public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0xC0EA00 Offset: 0xC0D400 VA: 0x180C0EA00
	public CameraState CalculateNewState(float deltaTime) { }

	// RVA: 0xC0EAC0 Offset: 0xC0D4C0 VA: 0x180C0EAC0 Slot: 17
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 18
	public void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 19
	public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 20
	public void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }
}
