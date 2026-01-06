public static class PostProcessUtils // TypeDefIndex: 8971
{
	// Methods

	[Obsolete("This method is obsolete. Use ConfigureDithering override that takes camera pixel width and height instead.")]
	// RVA: 0x2B179A0 Offset: 0x2B163A0 VA: 0x182B179A0
	public static int ConfigureDithering(PostProcessData data, int index, Camera camera, Material material) { }

	// RVA: 0x2B17790 Offset: 0x2B16190 VA: 0x182B17790
	public static int ConfigureDithering(PostProcessData data, int index, int cameraPixelWidth, int cameraPixelHeight, Material material) { }

	[Obsolete("This method is obsolete. Use ConfigureFilmGrain override that takes camera pixel width and height instead.")]
	// RVA: 0x2B17DD0 Offset: 0x2B167D0 VA: 0x182B17DD0
	public static void ConfigureFilmGrain(PostProcessData data, FilmGrain settings, Camera camera, Material material) { }

	// RVA: 0x2B17A20 Offset: 0x2B16420 VA: 0x182B17A20
	public static void ConfigureFilmGrain(PostProcessData data, FilmGrain settings, int cameraPixelWidth, int cameraPixelHeight, Material material) { }

	// RVA: 0x2B17E60 Offset: 0x2B16860 VA: 0x182B17E60
	internal static void SetSourceSize(CommandBuffer cmd, RenderTextureDescriptor desc) { }
}
