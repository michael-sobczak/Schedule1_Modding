public class PoliceLight : MonoBehaviour // TypeDefIndex: 1268
{
	// Fields
	public bool IsOn; // 0x20
	[Header("References")]
	public MeshRenderer[] RedMeshes; // 0x28
	public MeshRenderer[] BlueMeshes; // 0x30
	public OptimizedLight[] RedLights; // 0x38
	public OptimizedLight[] BlueLights; // 0x40
	public AudioSourceController Siren; // 0x48
	[Header("Settings")]
	public float CycleDuration; // 0x50
	public Material RedOffMat; // 0x58
	public Material RedOnMat; // 0x60
	public Material BlueOffMat; // 0x68
	public Material BlueOnMat; // 0x70
	public AnimationCurve RedBrightnessCurve; // 0x78
	public AnimationCurve BlueBrightnessCurve; // 0x80
	public float LightBrightness; // 0x88
	private Coroutine cycleRoutine; // 0x90

	// Methods

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void SetIsOn(bool isOn) { }

	// RVA: 0x61DF50 Offset: 0x61C950 VA: 0x18061DF50
	private void FixedUpdate() { }

	[IteratorStateMachine(typeof(PoliceLight.<CycleCoroutine>d__17))]
	// RVA: 0x61DEE0 Offset: 0x61C8E0 VA: 0x18061DEE0
	protected IEnumerator CycleCoroutine() { }

	// RVA: 0x61E050 Offset: 0x61CA50 VA: 0x18061E050
	public void .ctor() { }
}
