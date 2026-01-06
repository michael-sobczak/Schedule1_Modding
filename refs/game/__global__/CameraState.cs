public struct CameraState // TypeDefIndex: 16127
{
	// Fields
	public LensSettings Lens; // 0x0
	public Vector3 ReferenceUp; // 0x34
	public Vector3 ReferenceLookAt; // 0x40
	public static Vector3 kNoPoint; // 0x0
	public Vector3 RawPosition; // 0x4C
	public Quaternion RawOrientation; // 0x58
	public Vector3 PositionDampingBypass; // 0x68
	public float ShotQuality; // 0x74
	public Vector3 PositionCorrection; // 0x78
	public Quaternion OrientationCorrection; // 0x84
	public CameraState.BlendHintValue BlendHint; // 0x94
	private CameraState.CustomBlendable mCustom0; // 0x98
	private CameraState.CustomBlendable mCustom1; // 0xA8
	private CameraState.CustomBlendable mCustom2; // 0xB8
	private CameraState.CustomBlendable mCustom3; // 0xC8
	private List<CameraState.CustomBlendable> m_CustomOverflow; // 0xD8
	[CompilerGenerated]
	private int <NumCustomBlendables>k__BackingField; // 0xE0

	// Properties
	public bool HasLookAt { get; }
	public Vector3 CorrectedPosition { get; }
	public Quaternion CorrectedOrientation { get; }
	public Vector3 FinalPosition { get; }
	public Quaternion FinalOrientation { get; }
	public static CameraState Default { get; }
	public int NumCustomBlendables { get; set; }

	// Methods

	// RVA: 0xC152F0 Offset: 0xC13CF0 VA: 0x180C152F0
	public bool get_HasLookAt() { }

	// RVA: 0xC14DF0 Offset: 0xC137F0 VA: 0x180C14DF0
	public Vector3 get_CorrectedPosition() { }

	// RVA: 0xC14C80 Offset: 0xC13680 VA: 0x180C14C80
	public Quaternion get_CorrectedOrientation() { }

	// RVA: 0xC14DF0 Offset: 0xC137F0 VA: 0x180C14DF0
	public Vector3 get_FinalPosition() { }

	// RVA: 0xC15080 Offset: 0xC13A80 VA: 0x180C15080
	public Quaternion get_FinalOrientation() { }

	// RVA: 0xC14E40 Offset: 0xC13840 VA: 0x180C14E40
	public static CameraState get_Default() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x505860 Offset: 0x504260 VA: 0x180505860
	public int get_NumCustomBlendables() { }

	[CompilerGenerated]
	// RVA: 0xC15350 Offset: 0xC13D50 VA: 0x180C15350
	private void set_NumCustomBlendables(int value) { }

	// RVA: 0xC10430 Offset: 0xC0EE30 VA: 0x180C10430
	public CameraState.CustomBlendable GetCustomBlendable(int index) { }

	// RVA: 0xC10210 Offset: 0xC0EC10 VA: 0x180C10210
	private int FindCustomBlendable(Object custom) { }

	// RVA: 0xC0FE90 Offset: 0xC0E890 VA: 0x180C0FE90
	public void AddCustomBlendable(CameraState.CustomBlendable b) { }

	// RVA: 0xC10B30 Offset: 0xC0F530 VA: 0x180C10B30
	public static CameraState Lerp(CameraState stateA, CameraState stateB, float t) { }

	// RVA: 0xC10530 Offset: 0xC0EF30 VA: 0x180C10530
	private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t) { }

	// RVA: 0xC10140 Offset: 0xC0EB40 VA: 0x180C10140
	private static Vector3 ApplyPosBlendHint(Vector3 posA, CameraState.BlendHintValue hintA, Vector3 posB, CameraState.BlendHintValue hintB, Vector3 original, Vector3 blended) { }

	// RVA: 0xC101C0 Offset: 0xC0EBC0 VA: 0x180C101C0
	private static Quaternion ApplyRotBlendHint(Quaternion rotA, CameraState.BlendHintValue hintA, Quaternion rotB, CameraState.BlendHintValue hintB, Quaternion original, Quaternion blended) { }

	// RVA: 0xC10670 Offset: 0xC0F070 VA: 0x180C10670
	private Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t) { }

	// RVA: 0xC14C30 Offset: 0xC13630 VA: 0x180C14C30
	private static void .cctor() { }
}
