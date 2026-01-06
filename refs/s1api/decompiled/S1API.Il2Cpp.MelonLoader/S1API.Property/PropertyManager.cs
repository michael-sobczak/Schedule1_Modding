using System.Collections.Generic;
using Il2CppScheduleOne.Property;
using Il2CppSystem.Collections.Generic;

namespace S1API.Property;

public static class PropertyManager
{
	public static List<PropertyWrapper> GetAllProperties()
	{
		List<PropertyWrapper> list = new List<PropertyWrapper>();
		Enumerator<Property> enumerator = Property.Properties.GetEnumerator();
		while (enumerator.MoveNext())
		{
			Property current = enumerator.Current;
			list.Add(new PropertyWrapper(current));
		}
		return list;
	}

	public static List<PropertyWrapper> GetOwnedProperties()
	{
		List<PropertyWrapper> list = new List<PropertyWrapper>();
		Enumerator<Property> enumerator = Property.OwnedProperties.GetEnumerator();
		while (enumerator.MoveNext())
		{
			Property current = enumerator.Current;
			list.Add(new PropertyWrapper(current));
		}
		return list;
	}

	public static PropertyWrapper FindPropertyByName(string name)
	{
		Enumerator<Property> enumerator = Property.Properties.GetEnumerator();
		while (enumerator.MoveNext())
		{
			Property current = enumerator.Current;
			if (current.PropertyName == name)
			{
				return new PropertyWrapper(current);
			}
		}
		return null;
	}
}
