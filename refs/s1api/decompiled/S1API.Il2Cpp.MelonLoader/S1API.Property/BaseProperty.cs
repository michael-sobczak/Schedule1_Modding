using UnityEngine;

namespace S1API.Property;

public abstract class BaseProperty
{
	public abstract string PropertyName { get; }

	public abstract string PropertyCode { get; }

	public abstract float Price { get; set; }

	public abstract bool IsOwned { get; }

	public abstract int EmployeeCapacity { get; set; }

	public abstract void SetOwned();

	public abstract bool IsPointInside(Vector3 point);
}
