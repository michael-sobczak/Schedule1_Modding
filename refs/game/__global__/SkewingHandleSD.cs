public class SkewingHandleSD : MonoBehaviour // TypeDefIndex: 326
{
	// Fields
	public const string ClassName = "SkewingHandleSD";
	public VolumetricLightBeamSD volumetricLightBeam; // 0x20
	public bool shouldUpdateEachFrame; // 0x28

	// Methods

	// RVA: 0x7B6600 Offset: 0x7B5000 VA: 0x1807B6600
	public bool IsAttachedToSelf() { }

	// RVA: 0x7B64D0 Offset: 0x7B4ED0 VA: 0x1807B64D0
	public bool CanSetSkewingVector() { }

	// RVA: 0x7B6550 Offset: 0x7B4F50 VA: 0x1807B6550
	public bool CanUpdateEachFrame() { }

	// RVA: 0x7B6790 Offset: 0x7B5190 VA: 0x1807B6790
	private bool ShouldUpdateEachFrame() { }

	// RVA: 0x7B66C0 Offset: 0x7B50C0 VA: 0x1807B66C0
	private void OnEnable() { }

	// RVA: 0x7B67D0 Offset: 0x7B51D0 VA: 0x1807B67D0
	private void Start() { }

	[IteratorStateMachine(typeof(SkewingHandleSD.<CoUpdate>d__9))]
	// RVA: 0x7B6590 Offset: 0x7B4F90 VA: 0x1807B6590
	private IEnumerator CoUpdate() { }

	// RVA: 0x7B66F0 Offset: 0x7B50F0 VA: 0x1807B66F0
	private void SetSkewingVector() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
