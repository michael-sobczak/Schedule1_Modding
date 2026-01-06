public class DelayedUnityEvent : MonoBehaviour // TypeDefIndex: 2283
{
	// Fields
	public float Delay; // 0x20
	public UnityEvent onDelayStart; // 0x28
	public UnityEvent onDelayedExecute; // 0x30

	// Methods

	[Button]
	// RVA: 0x840050 Offset: 0x83EA50 VA: 0x180840050
	public void Execute() { }

	// RVA: 0x55D3D0 Offset: 0x55BDD0 VA: 0x18055D3D0
	public void .ctor() { }

	[IteratorStateMachine(typeof(DelayedUnityEvent.<<Execute>g__Wait|3_0>d))]
	[CompilerGenerated]
	// RVA: 0x8400D0 Offset: 0x83EAD0 VA: 0x1808400D0
	private IEnumerator <Execute>g__Wait|3_0() { }
}
