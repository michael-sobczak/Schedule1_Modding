using System.Collections.Generic;
using ScheduleOne.Money;
using ScheduleOne.Property;

namespace S1API.Property;

public class BusinessWrapper : PropertyWrapper
{
	internal readonly Business InnerBusiness;

	public float LaunderCapacity
	{
		get
		{
			return InnerBusiness.LaunderCapacity;
		}
		set
		{
			InnerBusiness.LaunderCapacity = value;
			foreach (string launderingCapacityPath in LaunderingCapacityPaths)
			{
				if (TrySetTMPText(launderingCapacityPath, MoneyManager.FormatAmount(value, false, false), "laundering capacity"))
				{
					break;
				}
			}
		}
	}

	public List<LaunderingOperation> LaunderingOperations
	{
		get
		{
			List<LaunderingOperation> list = new List<LaunderingOperation>();
			foreach (LaunderingOperation launderingOperation in InnerBusiness.LaunderingOperations)
			{
				list.Add(new LaunderingOperation(launderingOperation));
			}
			return list;
		}
	}

	public float CurrentLaunderTotal => InnerBusiness.currentLaunderTotal;

	public float AppliedLaunderLimit => InnerBusiness.appliedLaunderLimit;

	public int LaunderingOperationCount => InnerBusiness.LaunderingOperations.Count;

	public bool IsAtLaunderingCapacity => AppliedLaunderLimit <= 0f;

	public float LaunderingCapacityUsagePercent => (LaunderCapacity > 0f) ? (CurrentLaunderTotal / LaunderCapacity) : 0f;

	internal override string SignPrefix => "@Businesses/";

	internal override IEnumerable<string> SignPaths
	{
		get
		{
			string baseName = PropertyName.Replace(" ", "");
			yield return SignPrefix + baseName + "/ForSaleSign_Blue/Price";
			yield return SignPrefix + baseName + "/ForSaleSign_Blue (1)/Price";
			yield return SignPrefix + PropertyName + "/ForSaleSign_Blue/Price";
			yield return SignPrefix + PropertyName + "/ForSaleSign_Blue (1)/Price";
		}
	}

	internal override string WhiteboardPath => "Map/Container/RE Office/Interior/Whiteboard (1)/PropertyListing " + PropertyName + "/Price";

	internal IEnumerable<string> LaunderingCapacityPaths
	{
		get
		{
			string baseName = PropertyName.Replace(" ", "");
			yield return "@Businesses/" + baseName + "/Grid/ItemContainer/LaunderingStation_Built(Clone)/LaunderingInterface/CurrentOperations/Total/Max";
			yield return "@Businesses/" + PropertyName + "/Grid/ItemContainer/LaunderingStation_Built(Clone)/LaunderingInterface/CurrentOperations/Total/Max";
			yield return "@Businesses/" + baseName + "/Grid (1)/ItemContainer/LaunderingStation_Built(Clone)/LaunderingInterface/CurrentOperations/Total/Max";
			yield return "@Businesses/" + PropertyName + "/Grid (1)/ItemContainer/LaunderingStation_Built(Clone)/LaunderingInterface/CurrentOperations/Total/Max";
		}
	}

	public BusinessWrapper(Business business)
		: base((Property)(object)business)
	{
		InnerBusiness = business;
	}

	public void AddLaunderingOperation(float amount, int minutesSinceStarted)
	{
		InnerBusiness.StartLaunderingOperation(amount, minutesSinceStarted);
	}
}
