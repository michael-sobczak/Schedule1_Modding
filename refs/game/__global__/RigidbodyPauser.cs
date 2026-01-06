public class RigidbodyPauser // TypeDefIndex: 12691
{
	// Fields
	[CompilerGenerated]
	private bool <Paused>k__BackingField; // 0x10
	private List<RigidbodyPauser.RigidbodyData> _rigidbodyDatas; // 0x18
	private List<RigidbodyPauser.Rigidbody2DData> _rigidbody2dDatas; // 0x20
	private static Scene _kinematicSceneCache; // 0x0
	private Transform _graphicalParent; // 0x28
	private Transform _graphicalObject; // 0x30
	private bool _getInChildren; // 0x38
	private Transform _transform; // 0x40
	private RigidbodyType _rigidbodyType; // 0x48
	private bool _initialized; // 0x49

	// Properties
	public bool Paused { get; set; }
	private static Scene _kinematicScene { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_Paused() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	private void set_Paused(bool value) { }

	// RVA: 0xD56760 Offset: 0xD55160 VA: 0x180D56760
	private static Scene get__kinematicScene() { }

	// RVA: 0xD55E50 Offset: 0xD54850 VA: 0x180D55E50
	public void UpdateRigidbodies() { }

	// RVA: 0xD55F30 Offset: 0xD54930 VA: 0x180D55F30
	public void UpdateRigidbodies(Transform t, RigidbodyType rbType, bool getInChildren, Transform graphicalObject) { }

	// RVA: 0xD54F00 Offset: 0xD53900 VA: 0x180D54F00
	public void Pause() { }

	// RVA: 0xD559E0 Offset: 0xD543E0 VA: 0x180D559E0
	public void Unpause() { }

	// RVA: 0xD566A0 Offset: 0xD550A0 VA: 0x180D566A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xD553C0 Offset: 0xD53DC0 VA: 0x180D553C0
	private bool <Pause>g__PauseRigidbody|19_0(int index, ref RigidbodyPauser.<>c__DisplayClass19_0 ) { }

	[CompilerGenerated]
	// RVA: 0xD55580 Offset: 0xD53F80 VA: 0x180D55580
	private bool <Pause>g__PauseRigidbody|19_1(int index, ref RigidbodyPauser.<>c__DisplayClass19_0 ) { }

	[CompilerGenerated]
	// RVA: 0xD55710 Offset: 0xD54110 VA: 0x180D55710
	private bool <Unpause>g__UnpauseRigidbody|20_0(int index) { }

	[CompilerGenerated]
	// RVA: 0xD55870 Offset: 0xD54270 VA: 0x180D55870
	private bool <Unpause>g__UnpauseRigidbody|20_1(int index) { }
}
