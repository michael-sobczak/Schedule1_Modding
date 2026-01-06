public class AvatarImpostor : MonoBehaviour // TypeDefIndex: 3121
{
	// Fields
	[CompilerGenerated]
	private bool <HasTexture>k__BackingField; // 0x20
	public MeshRenderer meshRenderer; // 0x28
	public Transform AnchorBone; // 0x30
	private Transform cachedCamera; // 0x38
	private Vector3 anchorBoneOffset; // 0x40

	// Properties
	public bool HasTexture { get; set; }
	private Transform Camera { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_HasTexture() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_HasTexture(bool value) { }

	// RVA: 0x9AF6F0 Offset: 0x9AE0F0 VA: 0x1809AF6F0
	private Transform get_Camera() { }

	// RVA: 0x9AF2F0 Offset: 0x9ADCF0 VA: 0x1809AF2F0
	private void Awake() { }

	// RVA: 0x9AF5F0 Offset: 0x9ADFF0 VA: 0x1809AF5F0
	public void SetAvatarSettings(AvatarSettings settings) { }

	// RVA: 0x9AF3B0 Offset: 0x9ADDB0 VA: 0x1809AF3B0
	private void LateUpdate() { }

	// RVA: 0x9AF3C0 Offset: 0x9ADDC0 VA: 0x1809AF3C0
	private void Realign() { }

	// RVA: 0x9AF370 Offset: 0x9ADD70 VA: 0x1809AF370
	public void EnableImpostor() { }

	// RVA: 0x6FE090 Offset: 0x6FCA90 VA: 0x1806FE090
	public void DisableImpostor() { }

	// RVA: 0x9AF690 Offset: 0x9AE090 VA: 0x1809AF690
	public void .ctor() { }
}
