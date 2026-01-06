public class SceneLoaderExample : MonoBehaviour // TypeDefIndex: 18085
{
	// Fields
	[Tooltip("True to move the triggering object.")]
	[SerializeField]
	private bool _moveObject; // 0x20
	[Tooltip("True to move all connection objects (clients).")]
	[SerializeField]
	private bool _moveAllObjects; // 0x21
	[Tooltip("True to replace current scenes with new scenes. First scene loaded will become active scene.")]
	[SerializeField]
	private ReplaceOption _replaceOption; // 0x22
	[Tooltip("Scenes to load.")]
	[SerializeField]
	private string[] _scenes; // 0x28
	[Tooltip("True to only unload for the connectioning causing the trigger.")]
	[SerializeField]
	private bool _connectionOnly; // 0x30
	[Tooltip("True to automatically unload the loaded scenes when no more connections are using them.")]
	[SerializeField]
	private bool _automaticallyUnload; // 0x31
	[Tooltip("True to fire when entering the trigger. False to fire when exiting the trigger.")]
	[SerializeField]
	private bool _onTriggerEnter; // 0x32
	private Dictionary<NetworkConnection, float> _triggeredTimes; // 0x38

	// Methods

	[Server(Logging = 0)]
	// RVA: 0xCEECB0 Offset: 0xCED6B0 VA: 0x180CEECB0
	private void OnTriggerEnter(Collider other) { }

	[Server(Logging = 0)]
	// RVA: 0xCEED20 Offset: 0xCED720 VA: 0x180CEED20
	private void OnTriggerExit(Collider other) { }

	// RVA: 0xCEE740 Offset: 0xCED140 VA: 0x180CEE740
	private void LoadScene(NetworkObject triggeringIdentity) { }

	// RVA: 0xCEED90 Offset: 0xCED790 VA: 0x180CEED90
	public void .ctor() { }
}
