public class Transform : Component, IEnumerable // TypeDefIndex: 11889
{
	// Properties
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 eulerAngles { get; set; }
	public Vector3 localEulerAngles { get; set; }
	public Vector3 right { get; }
	public Vector3 up { get; set; }
	public Vector3 forward { get; set; }
	public Quaternion rotation { get; set; }
	public Quaternion localRotation { get; set; }
	public Vector3 localScale { get; set; }
	public Transform parent { get; set; }
	internal Transform parentInternal { get; set; }
	public Matrix4x4 worldToLocalMatrix { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public Transform root { get; }
	public int childCount { get; }
	public Vector3 lossyScale { get; }
	[NativeProperty("HasChangedDeprecated")]
	public bool hasChanged { get; set; }

	// Methods

	// RVA: 0x2CB9B50 Offset: 0x2CB8550 VA: 0x182CB9B50
	protected void .ctor() { }

	// RVA: 0x2CCEAD0 Offset: 0x2CCD4D0 VA: 0x182CCEAD0
	public Vector3 get_position() { }

	// RVA: 0x2CCF2E0 Offset: 0x2CCDCE0 VA: 0x182CCF2E0
	public void set_position(Vector3 value) { }

	// RVA: 0x2CCE7A0 Offset: 0x2CCD1A0 VA: 0x182CCE7A0
	public Vector3 get_localPosition() { }

	// RVA: 0x2CCF040 Offset: 0x2CCDA40 VA: 0x182CCF040
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x2CCE4A0 Offset: 0x2CCCEA0 VA: 0x182CCE4A0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x2CCEE10 Offset: 0x2CCD810 VA: 0x182CCEE10
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x2CCE680 Offset: 0x2CCD080 VA: 0x182CCE680
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x2CCEF60 Offset: 0x2CCD960 VA: 0x182CCEF60
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x2CCEB20 Offset: 0x2CCD520 VA: 0x182CCEB20
	public Vector3 get_right() { }

	// RVA: 0x2CCEC90 Offset: 0x2CCD690 VA: 0x182CCEC90
	public Vector3 get_up() { }

	// RVA: 0x2CCF3D0 Offset: 0x2CCDDD0 VA: 0x182CCF3D0
	public void set_up(Vector3 value) { }

	// RVA: 0x2CCE570 Offset: 0x2CCCF70 VA: 0x182CCE570
	public Vector3 get_forward() { }

	// RVA: 0x2CCEEA0 Offset: 0x2CCD8A0 VA: 0x182CCEEA0
	public void set_forward(Vector3 value) { }

	// RVA: 0x2CCEC40 Offset: 0x2CCD640 VA: 0x182CCEC40
	public Quaternion get_rotation() { }

	// RVA: 0x2CCF380 Offset: 0x2CCDD80 VA: 0x182CCF380
	public void set_rotation(Quaternion value) { }

	// RVA: 0x2CCE840 Offset: 0x2CCD240 VA: 0x182CCE840
	public Quaternion get_localRotation() { }

	// RVA: 0x2CCF0E0 Offset: 0x2CCDAE0 VA: 0x182CCF0E0
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x2CCE8E0 Offset: 0x2CCD2E0 VA: 0x182CCE8E0
	public Vector3 get_localScale() { }

	// RVA: 0x2CCF180 Offset: 0x2CCDB80 VA: 0x182CCF180
	public void set_localScale(Vector3 value) { }

	// RVA: 0x2CCC750 Offset: 0x2CCB150 VA: 0x182CCC750
	public Transform get_parent() { }

	// RVA: 0x2CCF1D0 Offset: 0x2CCDBD0 VA: 0x182CCF1D0
	public void set_parent(Transform value) { }

	// RVA: 0x2CCC750 Offset: 0x2CCB150 VA: 0x182CCC750
	internal Transform get_parentInternal() { }

	// RVA: 0x2CCDC00 Offset: 0x2CCC600 VA: 0x182CCDC00
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x2CCC750 Offset: 0x2CCB150 VA: 0x182CCC750
	private Transform GetParent() { }

	// RVA: 0x2CCDC00 Offset: 0x2CCC600 VA: 0x182CCDC00
	public void SetParent(Transform p) { }

	[FreeFunction("SetParent", HasExplicitThis = True)]
	// RVA: 0x2CCDC50 Offset: 0x2CCC650 VA: 0x182CCDC50
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x2CCEDB0 Offset: 0x2CCD7B0 VA: 0x182CCEDB0
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x2CCE980 Offset: 0x2CCD380 VA: 0x182CCE980
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x2CCDD10 Offset: 0x2CCC710 VA: 0x182CCDD10
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x2CCDBA0 Offset: 0x2CCC5A0 VA: 0x182CCDBA0
	public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation) { }

	// RVA: 0x2CCC790 Offset: 0x2CCB190 VA: 0x182CCC790
	public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation) { }

	// RVA: 0x2CCE180 Offset: 0x2CCCB80 VA: 0x182CCE180
	public void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0x2CCE080 Offset: 0x2CCCA80 VA: 0x182CCE080
	public void Translate(Vector3 translation) { }

	// RVA: 0x2CCE310 Offset: 0x2CCCD10 VA: 0x182CCE310
	public void Translate(float x, float y, float z, Space relativeTo) { }

	// RVA: 0x2CCE340 Offset: 0x2CCCD40 VA: 0x182CCE340
	public void Translate(float x, float y, float z) { }

	// RVA: 0x2CCD4E0 Offset: 0x2CCBEE0 VA: 0x182CCD4E0
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x2CCD220 Offset: 0x2CCBC20 VA: 0x182CCD220
	public void Rotate(Vector3 eulers) { }

	// RVA: 0x2CCDA90 Offset: 0x2CCC490 VA: 0x182CCDA90
	public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo) { }

	// RVA: 0x2CCD4B0 Offset: 0x2CCBEB0 VA: 0x182CCD4B0
	public void Rotate(float xAngle, float yAngle, float zAngle) { }

	[NativeMethod("RotateAround")]
	// RVA: 0x2CCD020 Offset: 0x2CCBA20 VA: 0x182CCD020
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x2CCD350 Offset: 0x2CCBD50 VA: 0x182CCD350
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x2CCD250 Offset: 0x2CCBC50 VA: 0x182CCD250
	public void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x2CCD080 Offset: 0x2CCBA80 VA: 0x182CCD080
	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	// RVA: 0x2CCCDB0 Offset: 0x2CCB7B0 VA: 0x182CCCDB0
	public void LookAt(Transform target, Vector3 worldUp) { }

	// RVA: 0x2CCCBC0 Offset: 0x2CCB5C0 VA: 0x182CCCBC0
	public void LookAt(Transform target) { }

	// RVA: 0x2CCCD40 Offset: 0x2CCB740 VA: 0x182CCCD40
	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x2CCCF20 Offset: 0x2CCB920 VA: 0x182CCCF20
	public void LookAt(Vector3 worldPosition) { }

	[FreeFunction("Internal_LookAt", HasExplicitThis = True)]
	// RVA: 0x2CCC8D0 Offset: 0x2CCB2D0 VA: 0x182CCC8D0
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x2CCDE10 Offset: 0x2CCC810 VA: 0x182CCDE10
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x2CCC990 Offset: 0x2CCB390 VA: 0x182CCC990
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x2CCE020 Offset: 0x2CCCA20 VA: 0x182CCE020
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x2CCCB10 Offset: 0x2CCB510 VA: 0x182CCCB10
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x2CCDED0 Offset: 0x2CCC8D0 VA: 0x182CCDED0
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x2CCDF30 Offset: 0x2CCC930 VA: 0x182CCDF30
	public Vector3 TransformPoint(float x, float y, float z) { }

	// RVA: 0x2CCCA50 Offset: 0x2CCB450 VA: 0x182CCCA50
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x2CCC7F0 Offset: 0x2CCB1F0 VA: 0x182CCC7F0
	public Transform get_root() { }

	// RVA: 0x2CCC7F0 Offset: 0x2CCB1F0 VA: 0x182CCC7F0
	private Transform GetRoot() { }

	[NativeMethod("GetChildrenCount")]
	// RVA: 0x2CCE460 Offset: 0x2CCCE60 VA: 0x182CCE460
	public int get_childCount() { }

	// RVA: 0x2CCDAC0 Offset: 0x2CCC4C0 VA: 0x182CCDAC0
	public void SetAsFirstSibling() { }

	// RVA: 0x2CCDB00 Offset: 0x2CCC500 VA: 0x182CCDB00
	public void SetAsLastSibling() { }

	// RVA: 0x2CCDD70 Offset: 0x2CCC770 VA: 0x182CCDD70
	public void SetSiblingIndex(int index) { }

	// RVA: 0x2CCC830 Offset: 0x2CCB230 VA: 0x182CCC830
	public int GetSiblingIndex() { }

	[FreeFunction]
	// RVA: 0x2CCC5A0 Offset: 0x2CCAFA0 VA: 0x182CCC5A0
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	// RVA: 0x2CCC600 Offset: 0x2CCB000 VA: 0x182CCC600
	public Transform Find(string n) { }

	[NativeMethod("GetWorldScaleLossy")]
	// RVA: 0x2CCEA30 Offset: 0x2CCD430 VA: 0x182CCEA30
	public Vector3 get_lossyScale() { }

	[FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = True)]
	// RVA: 0x2CCCB70 Offset: 0x2CCB570 VA: 0x182CCCB70
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x2CCE640 Offset: 0x2CCD040 VA: 0x182CCE640
	public bool get_hasChanged() { }

	// RVA: 0x2CCEF10 Offset: 0x2CCD910 VA: 0x182CCEF10
	public void set_hasChanged(bool value) { }

	// RVA: 0x2CCC6E0 Offset: 0x2CCB0E0 VA: 0x182CCC6E0 Slot: 4
	public IEnumerator GetEnumerator() { }

	[NativeThrows]
	[FreeFunction("GetChild", HasExplicitThis = True)]
	// RVA: 0x2CCC6A0 Offset: 0x2CCB0A0 VA: 0x182CCC6A0
	public Transform GetChild(int index) { }

	// RVA: 0x2CCEA80 Offset: 0x2CCD480 VA: 0x182CCEA80
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x2CCF290 Offset: 0x2CCDC90 VA: 0x182CCF290
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x2CCE750 Offset: 0x2CCD150 VA: 0x182CCE750
	private void get_localPosition_Injected(out Vector3 ret) { }

	// RVA: 0x2CCEFF0 Offset: 0x2CCD9F0 VA: 0x182CCEFF0
	private void set_localPosition_Injected(ref Vector3 value) { }

	// RVA: 0x2CCEBF0 Offset: 0x2CCD5F0 VA: 0x182CCEBF0
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x2CCF330 Offset: 0x2CCDD30 VA: 0x182CCF330
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x2CCE7F0 Offset: 0x2CCD1F0 VA: 0x182CCE7F0
	private void get_localRotation_Injected(out Quaternion ret) { }

	// RVA: 0x2CCF090 Offset: 0x2CCDA90 VA: 0x182CCF090
	private void set_localRotation_Injected(ref Quaternion value) { }

	// RVA: 0x2CCE890 Offset: 0x2CCD290 VA: 0x182CCE890
	private void get_localScale_Injected(out Vector3 ret) { }

	// RVA: 0x2CCF130 Offset: 0x2CCDB30 VA: 0x182CCF130
	private void set_localScale_Injected(ref Vector3 value) { }

	// RVA: 0x2CCED60 Offset: 0x2CCD760 VA: 0x182CCED60
	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2CCE930 Offset: 0x2CCD330 VA: 0x182CCE930
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2CCDCB0 Offset: 0x2CCC6B0 VA: 0x182CCDCB0
	private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x2CCDB40 Offset: 0x2CCC540 VA: 0x182CCDB40
	private void SetLocalPositionAndRotation_Injected(ref Vector3 localPosition, ref Quaternion localRotation) { }

	// RVA: 0x2CCCFC0 Offset: 0x2CCB9C0 VA: 0x182CCCFC0
	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	// RVA: 0x2CCC870 Offset: 0x2CCB270 VA: 0x182CCC870
	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	// RVA: 0x2CCDDB0 Offset: 0x2CCC7B0 VA: 0x182CCDDB0
	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x2CCC930 Offset: 0x2CCB330 VA: 0x182CCC930
	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x2CCDFC0 Offset: 0x2CCC9C0 VA: 0x182CCDFC0
	private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x2CCCAB0 Offset: 0x2CCB4B0 VA: 0x182CCCAB0
	private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x2CCDE70 Offset: 0x2CCC870 VA: 0x182CCDE70
	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2CCC9F0 Offset: 0x2CCB3F0 VA: 0x182CCC9F0
	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2CCE9E0 Offset: 0x2CCD3E0 VA: 0x182CCE9E0
	private void get_lossyScale_Injected(out Vector3 ret) { }
}
