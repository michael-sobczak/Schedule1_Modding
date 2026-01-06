public interface ICustomStyle // TypeDefIndex: 6775
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetValue(CustomStyleProperty<float> property, out float value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool TryGetValue(CustomStyleProperty<int> property, out int value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool TryGetValue(CustomStyleProperty<Color> property, out Color value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool TryGetValue(CustomStyleProperty<string> property, out string value);
}
