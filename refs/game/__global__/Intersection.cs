public class Intersection : MonoBehaviour // TypeDefIndex: 3376
{
	// Fields
	[SerializeField]
	[Header("References")]
	protected List<TrafficLight> path1Lights; // 0x20
	[SerializeField]
	protected List<TrafficLight> path2Lights; // 0x28
	[SerializeField]
	protected List<GameObject> path1Obstacles; // 0x30
	[SerializeField]
	protected List<GameObject> path2Obstacles; // 0x38
	[Header("Settings")]
	[SerializeField]
	protected float path1Time; // 0x40
	[SerializeField]
	protected float path2Time; // 0x44
	[SerializeField]
	protected float timeOffset; // 0x48

	// Methods

	// RVA: 0xA759B0 Offset: 0xA743B0 VA: 0x180A759B0 Slot: 4
	protected virtual void Start() { }

	[IteratorStateMachine(typeof(Intersection.<Run>d__8))]
	// RVA: 0xA752E0 Offset: 0xA73CE0 VA: 0x180A752E0
	protected IEnumerator Run() { }

	// RVA: 0xA75350 Offset: 0xA73D50 VA: 0x180A75350
	protected void SetPath1Lights(TrafficLight.State state) { }

	// RVA: 0xA75680 Offset: 0xA74080 VA: 0x180A75680
	protected void SetPath2Lights(TrafficLight.State state) { }

	// RVA: 0xA75AA0 Offset: 0xA744A0 VA: 0x180A75AA0
	public void .ctor() { }
}
