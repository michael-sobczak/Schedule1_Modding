using System;

namespace S1API.Map;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public sealed class ParkingLotNameAttribute : Attribute
{
	public string Name { get; }

	public ParkingLotNameAttribute(string name)
	{
		Name = name ?? throw new ArgumentNullException("name");
	}
}
