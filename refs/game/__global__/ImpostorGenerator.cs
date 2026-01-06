public class ImpostorGenerator : MonoBehaviour // TypeDefIndex: 3122
{
	// Fields
	[Header("References")]
	public Camera ImpostorCamera; // 0x20
	public Avatar Avatar; // 0x28
	[Header("Settings")]
	public List<AvatarSettings> GenerationQueue; // 0x30
	[SerializeField]
	private Texture2D output; // 0x38

	// Methods

	// RVA: 0x9BBA80 Offset: 0x9BA480 VA: 0x1809BBA80
	public void .ctor() { }
}
