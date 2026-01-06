namespace S1API.Properties.Interfaces;

public abstract class PropertyBase
{
	public abstract string ID { get; }

	public abstract string Name { get; }

	public abstract string name { get; }

	public abstract string Description { get; }

	public abstract int Tier { get; }

	public abstract float Addictiveness { get; }
}
