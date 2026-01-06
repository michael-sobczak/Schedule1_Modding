using System.Collections.Generic;
using ScheduleOne.Property;

namespace S1API.Property;

public static class PropertyManager
{
	public static List<PropertyWrapper> GetAllProperties()
	{
		List<PropertyWrapper> list = new List<PropertyWrapper>();
		foreach (Property property in Property.Properties)
		{
			list.Add(new PropertyWrapper(property));
		}
		return list;
	}

	public static List<PropertyWrapper> GetOwnedProperties()
	{
		List<PropertyWrapper> list = new List<PropertyWrapper>();
		foreach (Property ownedProperty in Property.OwnedProperties)
		{
			list.Add(new PropertyWrapper(ownedProperty));
		}
		return list;
	}

	public static PropertyWrapper FindPropertyByName(string name)
	{
		foreach (Property property in Property.Properties)
		{
			if (property.PropertyName == name)
			{
				return new PropertyWrapper(property);
			}
		}
		return null;
	}
}
