public class RenderCloudCubemap : MonoBehaviour // TypeDefIndex: 475
{
	// Fields
	public const string kDefaultFilenamePrefix = "CloudCubemap";
	[Tooltip("Filename of the final output cubemap asset. It will be written to the same directory as the current scene.")]
	public string filenamePrefix; // 0x20
	[Tooltip("Resolution of each face of the cubemap.")]
	public int faceWidth; // 0x28
	[Tooltip("Format for the exported cubemap. RGBColor (Additive texture), RGBAColor (Color with alpha channel), RGBANormal (Normal lighting data encoded).")]
	public RenderCloudCubemap.CubemapTextureFormat textureFormat; // 0x2C
	public bool exportFaces; // 0x30

	// Methods

	// RVA: 0xA8CA70 Offset: 0xA8B470 VA: 0x180A8CA70
	public void .ctor() { }
}
