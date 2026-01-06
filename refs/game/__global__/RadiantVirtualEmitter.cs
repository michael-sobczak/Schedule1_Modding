public class RadiantVirtualEmitter : MonoBehaviour // TypeDefIndex: 18589
{
	// Fields
	[Header("GI Color")]
	[ColorUsage(False, True)]
	public Color color; // 0x20
	[Tooltip("Enable this option to add the emission color of the material used by this object to the global illumination.")]
	public bool addMaterialEmission; // 0x30
	[Tooltip("The renderer from which synchronize the emission color")]
	public Renderer targetRenderer; // 0x38
	[Tooltip("Optionally specify the material for the emission color")]
	public Material material; // 0x40
	public string emissionPropertyName; // 0x48
	[Tooltip("Useful in case the gameobject uses more than one material")]
	public int materialIndex; // 0x50
	public float intensity; // 0x54
	public float range; // 0x58
	[Header("Area Of Influence")]
	public Vector3 boxCenter; // 0x5C
	public Vector3 boxSize; // 0x68
	public bool boundsInLocalSpace; // 0x74
	private int emissionNameId; // 0x78
	private Renderer thisRenderer; // 0x80
	private static List<Material> sharedMaterials; // 0x0

	// Methods

	// RVA: 0x1E91C80 Offset: 0x1E90680 VA: 0x181E91C80
	private void OnValidate() { }

	// RVA: 0x1E91AA0 Offset: 0x1E904A0 VA: 0x181E91AA0
	private void OnEnable() { }

	// RVA: 0x1E918E0 Offset: 0x1E902E0 VA: 0x181E918E0
	private void OnDisable() { }

	// RVA: 0x1E91A30 Offset: 0x1E90430 VA: 0x181E91A30
	private void OnDrawGizmosSelected() { }

	// RVA: 0x1E91600 Offset: 0x1E90000 VA: 0x181E91600
	public Color GetGIColor() { }

	// RVA: 0x1E915B0 Offset: 0x1E8FFB0 VA: 0x181E915B0
	public Vector4 GetGIColorAndRange() { }

	// RVA: 0x1E914D0 Offset: 0x1E8FED0 VA: 0x181E914D0
	public Bounds GetBounds() { }

	// RVA: 0x1E91CA0 Offset: 0x1E906A0 VA: 0x181E91CA0
	public void SetBounds(Bounds bounds) { }

	// RVA: 0x1E91DF0 Offset: 0x1E907F0 VA: 0x181E91DF0
	public void .ctor() { }

	// RVA: 0x1E91D60 Offset: 0x1E90760 VA: 0x181E91D60
	private static void .cctor() { }
}
