using System.Collections.Generic;
using ScheduleOne.Property;

namespace S1API.Property;

public static class BusinessManager
{
	public static List<BusinessWrapper> GetAllBusinesses()
	{
		List<BusinessWrapper> list = new List<BusinessWrapper>();
		foreach (Business business in Business.Businesses)
		{
			list.Add(new BusinessWrapper(business));
		}
		return list;
	}

	public static List<BusinessWrapper> GetOwnedBusinesses()
	{
		List<BusinessWrapper> list = new List<BusinessWrapper>();
		foreach (Business ownedBusiness in Business.OwnedBusinesses)
		{
			list.Add(new BusinessWrapper(ownedBusiness));
		}
		return list;
	}

	public static BusinessWrapper? FindBusinessByName(string name)
	{
		foreach (Business business in Business.Businesses)
		{
			if (((Property)business).PropertyName == name)
			{
				return new BusinessWrapper(business);
			}
		}
		return null;
	}
}
