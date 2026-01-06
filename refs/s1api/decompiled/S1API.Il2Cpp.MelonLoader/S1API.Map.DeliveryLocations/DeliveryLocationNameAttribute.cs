using System;

namespace S1API.Map.DeliveryLocations;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class DeliveryLocationNameAttribute : Attribute
{
	public string Name { get; }

	public DeliveryLocationNameAttribute(string name)
	{
		Name = name;
	}
}
