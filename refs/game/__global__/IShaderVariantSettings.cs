public interface IShaderVariantSettings // TypeDefIndex: 13790
{
	// Properties
	public abstract ShaderVariantLogLevel shaderVariantLogLevel { get; set; }
	public abstract bool exportShaderVariants { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ShaderVariantLogLevel get_shaderVariantLogLevel();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_shaderVariantLogLevel(ShaderVariantLogLevel value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_exportShaderVariants();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_exportShaderVariants(bool value);
}
