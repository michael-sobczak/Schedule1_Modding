using System;

namespace S1API.Map.Buildings;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class BuildingNameAttribute : Attribute
{
	public string Name { get; }

	public BuildingNameAttribute(string name)
	{
		Name = name;
	}
}
