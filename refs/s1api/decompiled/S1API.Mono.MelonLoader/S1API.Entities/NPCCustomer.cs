using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using FishNet;
using FishNet.Managing.Transporting;
using FishNet.Object;
using MelonLoader;
using S1API.Economy;
using S1API.Internal.Abstraction;
using S1API.Internal.Utils;
using S1API.Logging;
using S1API.Utils;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.Economy;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.Quests;
using ScheduleOne.UI;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace S1API.Entities;

public sealed class NPCCustomer
{
	internal readonly NPC NPC;

	private static readonly Log Logger = new Log("NPCCustomer");

	private Action<float, int, int, int> _onContractAssigned;

	private Delegate _contractAssignedBridge;

	private object _contractAssignedUnityEvent;

	private FieldInfo customerDataField = typeof(Customer).GetField("customerData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

	private FieldInfo currentAffinityDataField = typeof(Customer).GetField("currentAffinityData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

	private MethodInfo setupDialogueMethod = typeof(Customer).GetMethod("SetUpDialogue", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

	public bool IsCustomer => (Object)(object)Component != (Object)null;

	internal Customer Component => NPC.gameObject.GetComponent<Customer>();

	public event Action OnUnlocked
	{
		add
		{
			EnsureCustomer();
			if ((Object)(object)Component == (Object)null || value == null)
			{
				return;
			}
			try
			{
				UnityEvent customerUnityEvent = GetCustomerUnityEvent("onUnlocked", createIfMissing: true);
				if (customerUnityEvent != null)
				{
					EventHelper.AddListener(value, customerUnityEvent);
				}
			}
			catch (Exception)
			{
			}
		}
		remove
		{
			if ((Object)(object)Component == (Object)null || value == null)
			{
				return;
			}
			try
			{
				UnityEvent customerUnityEvent = GetCustomerUnityEvent("onUnlocked", createIfMissing: false);
				if (customerUnityEvent != null)
				{
					EventHelper.RemoveListener(value, customerUnityEvent);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public event Action OnDealCompleted
	{
		add
		{
			EnsureCustomer();
			if ((Object)(object)Component == (Object)null || value == null)
			{
				return;
			}
			try
			{
				UnityEvent customerUnityEvent = GetCustomerUnityEvent("onDealCompleted", createIfMissing: true);
				if (customerUnityEvent != null)
				{
					EventHelper.AddListener(value, customerUnityEvent);
				}
			}
			catch (Exception ex)
			{
				Logger.Warning("Exception in OnDealCompleted for " + NPC.ID + ": " + ex.Message);
				Logger.Warning("Stack trace: " + ex.StackTrace);
			}
		}
		remove
		{
			if ((Object)(object)Component == (Object)null || value == null)
			{
				return;
			}
			try
			{
				UnityEvent customerUnityEvent = GetCustomerUnityEvent("onDealCompleted", createIfMissing: false);
				if (customerUnityEvent != null)
				{
					EventHelper.RemoveListener(value, customerUnityEvent);
				}
			}
			catch (Exception ex)
			{
				Logger.Warning("Exception while removing OnDealCompleted listener for " + NPC.ID + ": " + ex.Message);
			}
		}
	}

	public event Action<float, int, int, int> OnContractAssigned
	{
		add
		{
			EnsureCustomer();
			if (!((Object)(object)Component == (Object)null) && value != null && EnsureContractAssignedHook())
			{
				_onContractAssigned = (Action<float, int, int, int>)Delegate.Combine(_onContractAssigned, value);
			}
		}
		remove
		{
			if (value != null)
			{
				_onContractAssigned = (Action<float, int, int, int>)Delegate.Remove(_onContractAssigned, value);
				if (_onContractAssigned == null)
				{
					TryUnhookContractAssignedEvent();
				}
			}
		}
	}

	internal NPCCustomer(NPC npc)
	{
		NPC = npc;
	}

	public void EnsureCustomer()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		if ((Object)(object)Component == (Object)null)
		{
			Logger.Warning("Customer component not present on NPC prefab for " + NPC.ID + ". Add it via NPC.ConfigurePrefab(builder.EnsureCustomer()).");
			return;
		}
		try
		{
			EnsureCustomerData(Component);
			CustomerData val = null;
			val = (CustomerData)(customerDataField?.GetValue(Component));
			WireCoreReferences(Component);
			InitializeRuntimeState(Component);
			EnsureUnityEvents(Component);
			TryNetworkInitialize(Component);
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in EnsureCustomer for " + NPC.ID + ": " + ex.Message);
			Logger.Warning("Stack trace: " + ex.StackTrace);
		}
	}

	public void Unlock()
	{
		EnsureCustomer();
		if (!((Object)(object)Component == (Object)null))
		{
			NPCRelationData relationData = NPC.S1NPC.RelationData;
			if (relationData != null && !relationData.Unlocked)
			{
				relationData.Unlock((EUnlockType)1, true);
			}
		}
	}

	public bool ForceDealOffer()
	{
		if ((Object)(object)Component == (Object)null)
		{
			Logger.Warning("Cannot force deal offer for " + NPC.ID + ": Customer component is null");
			return false;
		}
		EnsureCurrentAffinityDataInitialized(Component);
		try
		{
			ContractInfo offeredContractInfo = Component.OfferedContractInfo;
			Component.ForceDealOffer();
			ContractInfo offeredContractInfo2 = Component.OfferedContractInfo;
			bool flag = offeredContractInfo2 != null && offeredContractInfo2 != offeredContractInfo;
			if (!flag)
			{
				Logger.Warning("Failed to generate contract for " + NPC.ID + ". Check if products are listed for sale and NPC meets order conditions.");
			}
			return flag;
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in ForceDealOffer for " + NPC.ID + ": " + ex.Message);
			return false;
		}
	}

	public bool OfferContract(ContractInfo info)
	{
		if ((Object)(object)Component == (Object)null)
		{
			Logger.Warning("Cannot offer contract to " + NPC.ID + ": Customer component is null");
			return false;
		}
		if (info == null)
		{
			Logger.Warning("Cannot offer contract to " + NPC.ID + ": ContractInfo is null");
			return false;
		}
		EnsureCurrentAffinityDataInitialized(Component);
		ContractInfo val = info.ToInternal();
		try
		{
			Component.OfferContract(val);
			return true;
		}
		catch (Exception ex)
		{
			Logger.Warning("OfferContract failed for " + NPC.ID + ": " + ex.Message);
			return false;
		}
	}

	public void RequestProduct(Player player = null)
	{
		if (!((Object)(object)Component == (Object)null))
		{
			EnsureCurrentAffinityDataInitialized(Component);
			if (player == null)
			{
				Component.RequestProduct(Player.Local);
			}
			else
			{
				Component.RequestProduct(player.S1Player);
			}
		}
	}

	public void SetAwaitingDelivery(bool awaiting)
	{
		if (!((Object)(object)Component == (Object)null))
		{
			Component.SetIsAwaitingDelivery(awaiting);
		}
	}

	public void SetupDialog()
	{
		setupDialogueMethod?.Invoke(Component, null);
	}

	private void TryNetworkInitialize(Customer customer)
	{
		if ((Object)(object)customer == (Object)null)
		{
			return;
		}
		try
		{
			TransportManager transportManager = InstanceFinder.TransportManager;
			NetworkObject component = NPC.gameObject.GetComponent<NetworkObject>();
			if (!((Object)(object)transportManager == (Object)null) && !((Object)(object)component == (Object)null))
			{
				SetNonPublicInstanceField(customer, "_transportManagerCache", transportManager);
				SetNonPublicInstanceField(customer, "_networkObjectCache", component);
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in TryNetworkInitialize for " + NPC.ID + ": " + ex.Message);
			Logger.Warning("Stack trace: " + ex.StackTrace);
		}
	}

	private void WireCoreReferences(Customer customer)
	{
		try
		{
			MethodInfo methodInfo = typeof(Customer).GetProperty("NPC", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.GetSetMethod(nonPublic: true);
			if (methodInfo != null)
			{
				methodInfo.Invoke(customer, new object[1] { NPC.S1NPC });
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in WireCoreReferences for " + NPC.ID + ": " + ex.Message);
			Logger.Warning("Stack trace: " + ex.StackTrace);
		}
	}

	private void EnsureCustomerData(Customer customer)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		try
		{
			CustomerData customerData = customer.CustomerData;
			CustomerData val = null;
			if (customerDataField == null)
			{
				Logger.Warning("customerDataField is null, attempting to find field again for " + NPC.ID);
				customerDataField = typeof(Customer).GetField("customerData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			}
			val = (CustomerData)(customerDataField?.GetValue(customer));
			if ((Object)(object)val == (Object)null && (Object)(object)customerData != (Object)null)
			{
				val = customerData;
			}
			if (!((Object)(object)val == (Object)null))
			{
				return;
			}
			val = ScriptableObject.CreateInstance<CustomerData>();
			val.DefaultAffinityData = new CustomerAffinityData();
			Array values = Enum.GetValues(typeof(EDrugType));
			foreach (object item in values)
			{
				val.DefaultAffinityData.ProductAffinities.Add(new ProductTypeAffinity
				{
					DrugType = (EDrugType)item,
					Affinity = 0f
				});
			}
			val.MinWeeklySpend = 100f;
			val.MaxWeeklySpend = 400f;
			val.MinOrdersPerWeek = 1;
			val.MaxOrdersPerWeek = 3;
			val.OrderTime = 1200;
			val.CanBeDirectlyApproached = true;
			val.DependenceMultiplier = 1f;
			val.BaseAddiction = 0f;
			if (customerDataField != null)
			{
				customerDataField.SetValue(customer, val);
			}
			else
			{
				Logger.Warning("Attempting manual field setting");
				customerDataField.SetValue(customer, val);
			}
			if (currentAffinityDataField == null)
			{
				currentAffinityDataField = typeof(Customer).GetField("currentAffinityData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			}
			CustomerAffinityData val2 = new CustomerAffinityData();
			if (val.DefaultAffinityData != null)
			{
				val.DefaultAffinityData.CopyTo(val2);
			}
			if (val2.ProductAffinities == null || val2.ProductAffinities.Count == 0)
			{
				Array values2 = Enum.GetValues(typeof(EDrugType));
				foreach (object item2 in values2)
				{
					val2.ProductAffinities.Add(new ProductTypeAffinity
					{
						DrugType = (EDrugType)item2,
						Affinity = 0f
					});
				}
			}
			currentAffinityDataField?.SetValue(customer, val2);
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in EnsureCustomerData for " + NPC.ID + ": " + ex.Message);
			Logger.Warning("Stack trace: " + ex.StackTrace);
		}
	}

	private void InitializeRuntimeState(Customer customer)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			CustomerData val = (CustomerData)(customerDataField?.GetValue(customer));
			if ((Object)(object)val == (Object)null)
			{
				EnsureCustomerData(customer);
				val = (CustomerData)(customerDataField?.GetValue(customer));
			}
			try
			{
				if ((Object)(object)customer.NPC == (Object)null && (Object)(object)NPC?.S1NPC != (Object)null)
				{
					global::S1API.Internal.Utils.ReflectionUtils.TrySetFieldOrProperty(customer, "NPC", NPC.S1NPC);
				}
			}
			catch
			{
			}
			try
			{
				if (Customer.UnlockedCustomers == null)
				{
					Customer.UnlockedCustomers = new List<Customer>();
				}
				if (Customer.LockedCustomers == null)
				{
					Customer.LockedCustomers = new List<Customer>();
				}
			}
			catch
			{
			}
			if (currentAffinityDataField == null)
			{
				currentAffinityDataField = typeof(Customer).GetField("currentAffinityData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			}
			object? obj3 = currentAffinityDataField?.GetValue(customer);
			CustomerAffinityData val2 = (CustomerAffinityData)((obj3 is CustomerAffinityData) ? obj3 : null);
			if (val2 == null)
			{
				val2 = new CustomerAffinityData();
				if ((Object)(object)val != (Object)null && val.DefaultAffinityData != null)
				{
					val.DefaultAffinityData.CopyTo(val2);
				}
				if (val2.ProductAffinities == null || val2.ProductAffinities.Count == 0)
				{
					Array values = Enum.GetValues(typeof(EDrugType));
					foreach (object item in values)
					{
						val2.ProductAffinities.Add(new ProductTypeAffinity
						{
							DrugType = (EDrugType)item,
							Affinity = 0f
						});
					}
				}
				currentAffinityDataField?.SetValue(customer, val2);
			}
			float num = val?.BaseAddiction ?? 0f;
			FieldInfo field = typeof(Customer).GetField("CurrentAddiction", BindingFlags.Instance | BindingFlags.Public);
			object obj4 = field?.GetValue(customer);
			float num2 = ((obj4 != null && obj4 is float) ? ((float)obj4) : 0f);
			if (num2 == 0f && num != 0f)
			{
				field?.SetValue(customer, num);
			}
			try
			{
				if ((Object)(object)customer.DefaultDeliveryLocation == (Object)null)
				{
					Map instance = Singleton<Map>.Instance;
					if ((Object)(object)instance != (Object)null)
					{
						MapRegionData regionData = instance.GetRegionData(NPC.S1NPC.Region);
						DeliveryLocation val3 = ((regionData != null) ? regionData.GetRandomUnscheduledDeliveryLocation() : null);
						if ((Object)(object)val3 != (Object)null)
						{
							customer.DefaultDeliveryLocation = val3;
						}
					}
				}
			}
			catch
			{
			}
			try
			{
				FieldInfo field2 = typeof(Customer).GetField("DealSignal", BindingFlags.Instance | BindingFlags.Public);
				object? obj6 = field2?.GetValue(customer);
				NPCSignal_WaitForDelivery val4 = (NPCSignal_WaitForDelivery)((obj6 is NPCSignal_WaitForDelivery) ? obj6 : null);
				if ((Object)(object)val4 == (Object)null)
				{
					NPCScheduleManager val5 = NPC.gameObject.GetComponentInChildren<NPCScheduleManager>(true);
					if ((Object)(object)val5 == (Object)null)
					{
						GameObject val6 = new GameObject("NPCScheduleManager");
						val6.transform.SetParent(NPC.gameObject.transform, false);
						val5 = val6.AddComponent<NPCScheduleManager>();
					}
					NPCSignal_WaitForDelivery val7 = NPC.gameObject.GetComponentInChildren<NPCSignal_WaitForDelivery>(true);
					if ((Object)(object)val7 == (Object)null)
					{
						GameObject val8 = new GameObject("DealSignal");
						val8.transform.SetParent(((Component)val5).transform, false);
						val7 = val8.AddComponent<NPCSignal_WaitForDelivery>();
						val8.SetActive(false);
					}
					field2?.SetValue(customer, val7);
				}
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}

	private void EnsureUnityEvents(Customer customer)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		try
		{
			if (global::S1API.Utils.ReflectionUtils.TryGetFieldOrProperty(customer, "onUnlocked") == null)
			{
				global::S1API.Utils.ReflectionUtils.TrySetFieldOrProperty(customer, "onUnlocked", (object)new UnityEvent());
			}
			if (global::S1API.Utils.ReflectionUtils.TryGetFieldOrProperty(customer, "onDealCompleted") == null)
			{
				global::S1API.Utils.ReflectionUtils.TrySetFieldOrProperty(customer, "onDealCompleted", (object)new UnityEvent());
			}
			if (global::S1API.Utils.ReflectionUtils.TryGetFieldOrProperty(customer, "onContractAssigned") == null)
			{
				Type type = typeof(UnityEvent<>).MakeGenericType(typeof(Contract));
				object value = Activator.CreateInstance(type);
				global::S1API.Utils.ReflectionUtils.TrySetFieldOrProperty(customer, "onContractAssigned", value);
			}
		}
		catch (Exception)
		{
		}
	}

	private UnityEvent GetCustomerUnityEvent(string memberName, bool createIfMissing)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		if ((Object)(object)Component == (Object)null)
		{
			return null;
		}
		object? obj = global::S1API.Utils.ReflectionUtils.TryGetFieldOrProperty(Component, memberName);
		UnityEvent val = (UnityEvent)((obj is UnityEvent) ? obj : null);
		if (val == null && createIfMissing)
		{
			val = new UnityEvent();
			global::S1API.Utils.ReflectionUtils.TrySetFieldOrProperty(Component, memberName, val);
		}
		return val;
	}

	private bool EnsureContractAssignedHook()
	{
		if ((object)_contractAssignedBridge != null || (Object)(object)Component == (Object)null)
		{
			return (object)_contractAssignedBridge != null;
		}
		try
		{
			object obj = typeof(Customer).GetField("onContractAssigned", BindingFlags.Instance | BindingFlags.Public)?.GetValue(Component);
			if (obj == null)
			{
				return false;
			}
			Type typeFromHandle = typeof(Contract);
			Type type = typeof(UnityAction<>).MakeGenericType(typeFromHandle);
			MethodInfo method = GetType().GetMethod("HandleContractAssigned", BindingFlags.Instance | BindingFlags.NonPublic);
			Delegate obj2 = Delegate.CreateDelegate(type, this, method);
			obj.GetType().GetMethod("AddListener", new Type[1] { type })?.Invoke(obj, new object[1] { obj2 });
			_contractAssignedBridge = obj2;
			_contractAssignedUnityEvent = obj;
			return true;
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception wiring OnContractAssigned for " + NPC.ID + ": " + ex.Message);
			return false;
		}
	}

	private void TryUnhookContractAssignedEvent()
	{
		if ((object)_contractAssignedBridge == null || _contractAssignedUnityEvent == null)
		{
			return;
		}
		try
		{
			Type type = _contractAssignedBridge.GetType();
			_contractAssignedUnityEvent.GetType().GetMethod("RemoveListener", new Type[1] { type })?.Invoke(_contractAssignedUnityEvent, new object[1] { _contractAssignedBridge });
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception removing OnContractAssigned for " + NPC.ID + ": " + ex.Message);
		}
		finally
		{
			_contractAssignedBridge = null;
			_contractAssignedUnityEvent = null;
		}
	}

	private void HandleContractAssigned(object contract)
	{
		try
		{
			Action<float, int, int, int> onContractAssigned = _onContractAssigned;
			if (onContractAssigned == null || contract == null)
			{
				return;
			}
			float arg = 0f;
			int num = 0;
			int arg2 = 0;
			int arg3 = 0;
			Type type = contract.GetType();
			PropertyInfo property = type.GetProperty("Payment", BindingFlags.Instance | BindingFlags.Public);
			if (property != null)
			{
				arg = Convert.ToSingle(property.GetValue(contract));
			}
			object obj = type.GetProperty("ProductList", BindingFlags.Instance | BindingFlags.Public)?.GetValue(contract);
			if (obj != null && obj.GetType().GetField("entries", BindingFlags.Instance | BindingFlags.Public)?.GetValue(obj) is IEnumerable enumerable)
			{
				foreach (object item in enumerable)
				{
					FieldInfo field = item.GetType().GetField("Quantity", BindingFlags.Instance | BindingFlags.Public);
					if (field != null)
					{
						num += Convert.ToInt32(field.GetValue(item));
					}
				}
			}
			object obj2 = type.GetProperty("DeliveryWindow", BindingFlags.Instance | BindingFlags.Public)?.GetValue(contract);
			if (obj2 != null)
			{
				FieldInfo field2 = obj2.GetType().GetField("WindowStartTime", BindingFlags.Instance | BindingFlags.Public);
				FieldInfo field3 = obj2.GetType().GetField("WindowEndTime", BindingFlags.Instance | BindingFlags.Public);
				if (field2 != null)
				{
					arg2 = Convert.ToInt32(field2.GetValue(obj2));
				}
				if (field3 != null)
				{
					arg3 = Convert.ToInt32(field3.GetValue(obj2));
				}
			}
			Delegate[] invocationList = onContractAssigned.GetInvocationList();
			for (int i = 0; i < invocationList.Length; i++)
			{
				Action<float, int, int, int> action = (Action<float, int, int, int>)invocationList[i];
				try
				{
					action(arg, num, arg2, arg3);
				}
				catch (Exception ex)
				{
					Logger.Warning("Exception in OnContractAssigned handler for " + NPC.ID + ": " + ex.Message);
				}
			}
		}
		catch (Exception ex2)
		{
			Logger.Warning("Exception while processing OnContractAssigned for " + NPC.ID + ": " + ex2.Message);
		}
	}

	private void EnsureCurrentAffinityDataInitialized(Customer customer)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		if ((Object)(object)customer == (Object)null)
		{
			return;
		}
		try
		{
			if (currentAffinityDataField == null)
			{
				currentAffinityDataField = typeof(Customer).GetField("currentAffinityData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			}
			object? obj = currentAffinityDataField?.GetValue(customer);
			CustomerAffinityData val = (CustomerAffinityData)((obj is CustomerAffinityData) ? obj : null);
			if (val == null)
			{
				InitializeRuntimeState(customer);
				object? obj2 = currentAffinityDataField?.GetValue(customer);
				val = (CustomerAffinityData)((obj2 is CustomerAffinityData) ? obj2 : null);
			}
			if (val == null || val.ProductAffinities == null)
			{
				return;
			}
			Array values = Enum.GetValues(typeof(EDrugType));
			foreach (object item in values)
			{
				EDrugType val2 = (EDrugType)item;
				ProductTypeAffinity val3 = null;
				foreach (ProductTypeAffinity productAffinity in val.ProductAffinities)
				{
					if (productAffinity != null && productAffinity.DrugType == val2)
					{
						val3 = productAffinity;
						break;
					}
				}
				if (val3 == null)
				{
					val.ProductAffinities.Add(new ProductTypeAffinity
					{
						DrugType = val2,
						Affinity = 0f
					});
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception ensuring currentAffinityData initialized for " + NPC.ID + ": " + ex.Message);
		}
	}

	public void RecommendDealer(NPCDealer dealer)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		if (dealer == null)
		{
			Logger.Warning("Cannot recommend dealer: dealer is null");
			return;
		}
		if ((Object)(object)Component == (Object)null)
		{
			Logger.Warning("Cannot recommend dealer for " + NPC.ID + ": Customer component is null");
			return;
		}
		EnsureCurrentAffinityDataInitialized(Component);
		try
		{
			dealer.MarkAsRecommended();
			HintDisplay instance = Singleton<HintDisplay>.Instance;
			if ((Object)(object)instance != (Object)null)
			{
				instance.ShowHint_20s("You can now hire <h1>" + dealer.NPC.FullName + "</h> as a dealer.");
			}
			float num = default(float);
			Player closestPlayer = Player.GetClosestPlayer(NPC.gameObject.transform.position, ref num, (List<Player>)null);
			if (!((Object)(object)closestPlayer == (Object)(object)Player.Local) || !(num < 6f))
			{
				return;
			}
			DialogueHandler val = NPC.S1NPC?.DialogueHandler;
			if ((Object)(object)val != (Object)null && (Object)(object)val.Database != (Object)null)
			{
				string line = val.Database.GetLine((EDialogueModule)3, "post_deal_recommend_dealer");
				if (!string.IsNullOrEmpty(line))
				{
					line = line.Replace("<NAME>", dealer.NPC.FullName);
					DialogueContainer val2 = ScriptableObject.CreateInstance<DialogueContainer>();
					DialogueNodeData val3 = new DialogueNodeData();
					val3.DialogueText = line;
					val3.choices = (DialogueChoiceData[])(object)new DialogueChoiceData[0];
					val3.DialogueNodeLabel = "ENTRY";
					val3.VoiceLine = (EVOLineType)3;
					DialogueNodeData item = val3;
					List<DialogueNodeData> dialogueNodeData = new List<DialogueNodeData> { item };
					val2.DialogueNodeData = dialogueNodeData;
					MelonCoroutines.Start(WaitAndShowDialogue(val2, val));
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in RecommendDealer for " + NPC.ID + ": " + ex.Message);
		}
	}

	private IEnumerator WaitAndShowDialogue(DialogueContainer container, DialogueHandler handler)
	{
		yield return (object)new WaitForSeconds(0.1f);
		if ((Object)(object)handler != (Object)null && (Object)(object)container != (Object)null)
		{
			handler.InitializeDialogue(container);
		}
	}

	private static void SetNonPublicInstanceField(object target, string fieldName, object value)
	{
		try
		{
			if (target != null && !string.IsNullOrEmpty(fieldName))
			{
				Type type = target.GetType();
				FieldInfo fieldInfo = null;
				while (type != null && fieldInfo == null)
				{
					fieldInfo = type.GetField(fieldName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					type = type.BaseType;
				}
				fieldInfo?.SetValue(target, value);
			}
		}
		catch (Exception)
		{
		}
	}
}
