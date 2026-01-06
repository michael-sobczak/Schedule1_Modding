public class SceneUnloaderExample : MonoBehaviour // TypeDefIndex: 18086
{
	// Fields
	[SerializeField]
	[Tooltip("Scenes to unload.")]
	private string[] _scenes; // 0x20
	[Tooltip("True to only unload for the connectioning causing the trigger.")]
	[SerializeField]
	private bool _connectionOnly; // 0x28
	[Tooltip("True to unload unused scenes.")]
	[SerializeField]
	private bool _unloadUnused; // 0x29
	[Tooltip("True to fire when entering the trigger. False to fire when exiting the trigger.")]
	[SerializeField]
	private bool _onTriggerEnter; // 0x2A

	// Methods

	[Server(Logging = 0)]
	// RVA: 0xCEEE40 Offset: 0xCED840 VA: 0x180CEEE40
	private void OnTriggerEnter(Collider other) { }

	[Server(Logging = 0)]
	// RVA: 0xCEEEC0 Offset: 0xCED8C0 VA: 0x180CEEEC0
	private void OnTriggerExit(Collider other) { }

	// RVA: 0xCEEF40 Offset: 0xCED940 VA: 0x180CEEF40
	private void UnloadScenes(NetworkObject triggeringIdentity) { }

	// RVA: 0xCEF0C0 Offset: 0xCEDAC0 VA: 0x180CEF0C0
	public void .ctor() { }
}
