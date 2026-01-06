internal abstract class BaseShaderInfoStorage : IDisposable // TypeDefIndex: 7125
{
	// Fields
	protected static int s_TextureCounter; // 0x0
	internal static ProfilerMarker s_MarkerCopyTexture; // 0x8
	internal static ProfilerMarker s_MarkerGetTextureData; // 0x10
	internal static ProfilerMarker s_MarkerUpdateTexture; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x10

	// Properties
	public abstract Texture2D texture { get; }
	protected bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Texture2D get_texture();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool AllocateRect(int width, int height, out RectInt uvs);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetTexel(int x, int y, Color color);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void UpdateTexture();

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	private void set_disposed(bool value) { }

	// RVA: 0x2E12B30 Offset: 0x2E11530 VA: 0x182E12B30 Slot: 4
	public void Dispose() { }

	// RVA: 0x2E12B20 Offset: 0x2E11520 VA: 0x182E12B20 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x2E12BA0 Offset: 0x2E115A0 VA: 0x182E12BA0
	private static void .cctor() { }
}
