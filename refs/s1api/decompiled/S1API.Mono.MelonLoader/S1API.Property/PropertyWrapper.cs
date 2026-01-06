using System.Collections.Generic;
using ScheduleOne.Money;
using ScheduleOne.Property;
using TMPro;
using UnityEngine;

namespace S1API.Property;

public class PropertyWrapper : BaseProperty
{
	internal readonly Property InnerProperty;

	public override string PropertyName => InnerProperty.PropertyName;

	public override string PropertyCode => InnerProperty.PropertyCode;

	public override float Price
	{
		get
		{
			return InnerProperty.Price;
		}
		set
		{
			InnerProperty.Price = value;
			UpdatePriceDisplay(value);
		}
	}

	public override bool IsOwned => InnerProperty.IsOwned;

	public override int EmployeeCapacity
	{
		get
		{
			return InnerProperty.EmployeeCapacity;
		}
		set
		{
			InnerProperty.EmployeeCapacity = value;
		}
	}

	public Vector3 ExteriorSpawnPosition => InnerProperty.SpawnPoint.position;

	public Vector3 InteriorSpawnPosition => InnerProperty.InteriorSpawnPoint.position;

	public int LoadingDockCount => InnerProperty.LoadingDockCount;

	public float DefaultRotation => InnerProperty.DefaultRotation;

	public bool AvailableInDemo => InnerProperty.AvailableInDemo;

	public bool IsContentCulled
	{
		get
		{
			return InnerProperty.IsContentCulled;
		}
		set
		{
			InnerProperty.SetContentCulled(value);
		}
	}

	public int EmployeeCount => InnerProperty.Employees.Count;

	public int BuildableItemCount => InnerProperty.BuildableItems.Count;

	public Vector3 NPCSpawnPosition => ((Object)(object)InnerProperty.NPCSpawnPoint != (Object)null) ? InnerProperty.NPCSpawnPoint.position : Vector3.zero;

	public int EmployeeIdlePointCount
	{
		get
		{
			Transform[] employeeIdlePoints = InnerProperty.EmployeeIdlePoints;
			return (employeeIdlePoints != null) ? employeeIdlePoints.Length : 0;
		}
	}

	internal virtual string SignPrefix => "@Properties/";

	internal virtual string WhiteboardPath => "Map/Container/RE Office/Interior/Whiteboard/PropertyListing " + PropertyName + "/Price";

	internal virtual IEnumerable<string> SignPaths
	{
		get
		{
			string baseName = PropertyName.Replace(" ", "");
			yield return SignPrefix + baseName + "/ForSaleSign/Price";
			yield return SignPrefix + PropertyName + "/ForSaleSign/Price";
			yield return SignPrefix + baseName + "/ForSaleSign (1)/Price";
			yield return SignPrefix + PropertyName + "/ForSaleSign (1)/Price";
		}
	}

	public PropertyWrapper(Property property)
	{
		InnerProperty = property;
	}

	public override void SetOwned()
	{
		InnerProperty.SetOwned();
	}

	public override bool IsPointInside(Vector3 point)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return InnerProperty.DoBoundsContainPoint(point);
	}

	public Vector3 GetEmployeeIdlePointPosition(int index)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		if (InnerProperty.EmployeeIdlePoints != null && index >= 0 && index < InnerProperty.EmployeeIdlePoints.Length && (Object)(object)InnerProperty.EmployeeIdlePoints[index] != (Object)null)
		{
			return InnerProperty.EmployeeIdlePoints[index].position;
		}
		return Vector3.zero;
	}

	public int GetUnassignedBedCount()
	{
		return InnerProperty.GetUnassignedBeds().Count;
	}

	internal void UpdatePriceDisplay(float price)
	{
		string priceText = MoneyManager.FormatAmount(price, false, false);
		TrySetTMPText(WhiteboardPath, priceText, "whiteboard");
		foreach (string signPath in SignPaths)
		{
			if (TrySetTMPText(signPath, priceText, "sign"))
			{
				break;
			}
		}
	}

	internal bool TrySetTMPText(string path, string priceText, string context)
	{
		GameObject val = GameObject.Find(path);
		if ((Object)(object)val != (Object)null)
		{
			TMP_Text component = val.GetComponent<TMP_Text>();
			if ((Object)(object)component != (Object)null)
			{
				component.text = priceText;
				return true;
			}
			Debug.LogWarning((object)("TMP_Text not found on " + context + " price object."));
		}
		else
		{
			Debug.LogWarning((object)(context + " price object not found at path: " + path));
		}
		return false;
	}
}
