public class ReflectionProbeUpdater : MonoBehaviour // TypeDefIndex: 1270
{
	// Fields
	public ReflectionProbe Probe; // 0x20
	private static List<ReflectionProbe> renderQueue; // 0x0
	private static Coroutine RenderRoutine; // 0x8

	// Methods

	// RVA: 0x620CE0 Offset: 0x61F6E0 VA: 0x180620CE0
	private void OnValidate() { }

	// RVA: 0x620DC0 Offset: 0x61F7C0 VA: 0x180620DC0
	private void Start() { }

	// RVA: 0x621100 Offset: 0x61FB00 VA: 0x180621100
	private void UpdateProbe() { }

	[IteratorStateMachine(typeof(ReflectionProbeUpdater.<ProcessQueue>d__6))]
	// RVA: 0x620D70 Offset: 0x61F770 VA: 0x180620D70
	private IEnumerator ProcessQueue() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x621230 Offset: 0x61FC30 VA: 0x180621230
	private static void .cctor() { }
}
