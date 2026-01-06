using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Il2CppFishNet;
using Il2CppFishNet.Managing.Transporting;
using Il2CppFishNet.Object;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using S1API.Internal.Abstraction;
using S1API.Internal.Utils;
using S1API.Logging;
using S1API.Map;
using S1API.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace S1API.Entities;

public sealed class NPCDealer
{
	internal readonly NPC NPC;

	private static readonly Log Logger = new Log("NPCDealer");

	private static readonly FieldInfo DealerRecruitedField = typeof(Dealer).GetField("onDealerRecruited", BindingFlags.Static | BindingFlags.Public);

	private readonly Dictionary<Action, Action<Dealer>> _dealerRecruitedHandlers = new Dictionary<Action, Action<Dealer>>();

	private Action _contractAcceptedHandlers;

	private bool _contractAcceptedHooked;

	public bool IsDealer => (Object)(object)Component != (Object)null;

	public global::S1API.Map.Building? Home
	{
		get
		{
			EnsureDealer();
			if ((Object)(object)Component == (Object)null)
			{
				return null;
			}
			try
			{
				object obj = global::S1API.Internal.Utils.ReflectionUtils.TryGetFieldOrProperty(Component, "Home");
				if (obj == null)
				{
					return null;
				}
				string text = global::S1API.Internal.Utils.ReflectionUtils.TryGetFieldOrProperty(obj, "BuildingName") as string;
				if (string.IsNullOrEmpty(text))
				{
					return null;
				}
				return global::S1API.Map.Building.GetByName(text);
			}
			catch (Exception ex)
			{
				Logger.Warning("Exception in Home getter for " + NPC.ID + ": " + ex.Message);
				return null;
			}
		}
		set
		{
			EnsureDealer();
			if ((Object)(object)Component == (Object)null)
			{
				Logger.Warning("Cannot set Home for " + NPC.ID + ": Dealer component not available.");
				return;
			}
			try
			{
				object obj = null;
				if (value != null)
				{
					obj = value.ResolveGameBuilding();
					if (obj == null)
					{
						Logger.Warning($"Cannot set Home for {NPC.ID}: Building '{value.Name}' could not be resolved.");
						return;
					}
				}
				global::S1API.Internal.Utils.ReflectionUtils.TrySetFieldOrProperty(Component, "Home", obj);
			}
			catch (Exception ex)
			{
				Logger.Warning("Exception in Home setter for " + NPC.ID + ": " + ex.Message);
			}
		}
	}

	internal Dealer Component
	{
		get
		{
			NPC s1NPC = NPC.S1NPC;
			Dealer val = (Dealer)(object)((s1NPC is Dealer) ? s1NPC : null);
			if ((Object)(object)val != (Object)null)
			{
				return val;
			}
			return NPC.gameObject.GetComponent<Dealer>();
		}
	}

	public event Action OnRecruited
	{
		add
		{
			EnsureDealer();
			if ((Object)(object)Component == (Object)null || value == null || DealerRecruitedField == null || _dealerRecruitedHandlers.ContainsKey(value))
			{
				return;
			}
			try
			{
				Action<Dealer> action = delegate(Dealer dealer)
				{
					if ((Object)(object)dealer != (Object)(object)Component)
					{
						return;
					}
					try
					{
						value();
					}
					catch (Exception ex2)
					{
						Logger.Warning("Exception in OnRecruited handler for " + NPC.ID + ": " + ex2.Message);
					}
				};
				Action<Dealer> value2 = ((DealerRecruitedField.GetValue(null) is Action<Dealer> a) ? ((Action<Dealer>)Delegate.Combine(a, action)) : action);
				DealerRecruitedField.SetValue(null, value2);
				_dealerRecruitedHandlers[value] = action;
			}
			catch (Exception ex)
			{
				Logger.Warning("Exception wiring OnRecruited for " + NPC.ID + ": " + ex.Message);
			}
		}
		remove
		{
			if (value == null || DealerRecruitedField == null || !_dealerRecruitedHandlers.TryGetValue(value, out Action<Dealer> value2))
			{
				return;
			}
			_dealerRecruitedHandlers.Remove(value);
			try
			{
				if (DealerRecruitedField.GetValue(null) is Action<Dealer> source)
				{
					Action<Dealer> value3 = (Action<Dealer>)Delegate.Remove(source, value2);
					DealerRecruitedField.SetValue(null, value3);
				}
			}
			catch (Exception ex)
			{
				Logger.Warning("Exception removing OnRecruited handler for " + NPC.ID + ": " + ex.Message);
			}
		}
	}

	public event Action OnContractAccepted
	{
		add
		{
			EnsureDealer();
			if (!((Object)(object)Component == (Object)null) && value != null)
			{
				EnsureContractAcceptedHook();
				_contractAcceptedHandlers = (Action)Delegate.Combine(_contractAcceptedHandlers, value);
			}
		}
		remove
		{
			if (value != null)
			{
				_contractAcceptedHandlers = (Action)Delegate.Remove(_contractAcceptedHandlers, value);
			}
		}
	}

	public event Action OnRecommended
	{
		add
		{
			EnsureDealer();
			if ((Object)(object)Component == (Object)null || value == null)
			{
				return;
			}
			try
			{
				UnityEvent recommendedUnityEvent = GetRecommendedUnityEvent(createIfMissing: true);
				if (recommendedUnityEvent != null)
				{
					EventHelper.AddListener(value, recommendedUnityEvent);
				}
			}
			catch (Exception ex)
			{
				Logger.Warning("Exception in OnRecommended for " + NPC.ID + ": " + ex.Message);
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
				UnityEvent recommendedUnityEvent = GetRecommendedUnityEvent(createIfMissing: false);
				if (recommendedUnityEvent != null)
				{
					EventHelper.RemoveListener(value, recommendedUnityEvent);
				}
			}
			catch (Exception ex)
			{
				Logger.Warning("Exception while removing OnRecommended handler for " + NPC.ID + ": " + ex.Message);
			}
		}
	}

	internal NPCDealer(NPC npc)
	{
		NPC = npc;
	}

	public void EnsureDealer()
	{
		if ((Object)(object)Component == (Object)null)
		{
			Logger.Warning("Dealer component not present on NPC prefab for " + NPC.ID + ". Add it via NPC.ConfigurePrefab(builder.EnsureDealer()).");
			return;
		}
		try
		{
			EnsureDealerCategory();
			WireCoreReferences(Component);
			InitializeRuntimeState(Component);
			EnsureUnityEvents(Component);
			TryNetworkInitialize(Component);
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in EnsureDealer for " + NPC.ID + ": " + ex.Message);
			Logger.Warning("Stack trace: " + ex.StackTrace);
		}
	}

	private void EnsureDealerCategory()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Invalid comparison between Unknown and I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Invalid comparison between Unknown and I4
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object obj = global::S1API.Utils.ReflectionUtils.TryGetFieldOrProperty(NPC.S1NPC, "ConversationCategories");
			List<EConversationCategory> categories = obj as List<EConversationCategory>;
			if (categories == null)
			{
				categories = new List<EConversationCategory>();
				global::S1API.Utils.ReflectionUtils.TrySetFieldOrProperty(NPC.S1NPC, "ConversationCategories", categories);
			}
			bool flag = false;
			try
			{
				string text = string.Join(",", from i in Enumerable.Range(0, categories.Count)
					select ((object)categories[i]/*cast due to .constrained prefix*/).ToString()) + " | first=" + ((categories.Count > 0) ? ((object)categories[0]/*cast due to .constrained prefix*/).ToString() : "<none>");
			}
			catch
			{
			}
			for (int num = categories.Count - 1; num >= 0; num--)
			{
				if ((int)categories[num] == 0)
				{
					categories.RemoveAt(num);
					flag = true;
				}
			}
			bool flag2 = false;
			for (int num2 = 0; num2 < categories.Count; num2++)
			{
				if ((int)categories[num2] == 2)
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				categories.Add((EConversationCategory)2);
				flag = true;
			}
			try
			{
				string text2 = string.Join(",", from i in Enumerable.Range(0, categories.Count)
					select ((object)categories[i]/*cast due to .constrained prefix*/).ToString()) + " | first=" + ((categories.Count > 0) ? ((object)categories[0]/*cast due to .constrained prefix*/).ToString() : "<none>");
			}
			catch
			{
			}
			if (flag && NPC.S1NPC.MSGConversation != null)
			{
				NPC.S1NPC.MSGConversation.SetCategories(categories);
				NPC.S1NPC.MSGConversation.EnsureUIExists();
				TryHookConversationUIRefresh(NPC.S1NPC.MSGConversation);
				RefreshDealerCategoryBadge();
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in EnsureDealerCategory for " + NPC.ID + ": " + ex.Message);
		}
	}

	private void TryHookConversationUIRefresh(object convoObj)
	{
		try
		{
			MSGConversation val = (MSGConversation)((convoObj is MSGConversation) ? convoObj : null);
			if (val == null)
			{
				return;
			}
			FieldInfo field = typeof(MSGConversation).GetField("uiCreated", BindingFlags.Instance | BindingFlags.NonPublic);
			if (field != null)
			{
				object value = field.GetValue(val);
				bool flag = default(bool);
				int num;
				if (value != null)
				{
					if (value is bool)
					{
						flag = (bool)value;
						num = 1;
					}
					else
					{
						num = 0;
					}
				}
				else
				{
					num = 0;
				}
				if (((uint)num & (flag ? 1u : 0u)) != 0)
				{
					RefreshDealerCategoryBadge();
				}
			}
			Action prevLoaded = val.onLoaded;
			val.onLoaded = Action.op_Implicit((Action)delegate
			{
				try
				{
					Action obj = prevLoaded;
					if (obj != null)
					{
						obj.Invoke();
					}
				}
				catch
				{
				}
				RefreshDealerCategoryBadge();
			});
			Action prevOpened = val.onConversationOpened;
			val.onConversationOpened = Action.op_Implicit((Action)delegate
			{
				try
				{
					Action obj = prevOpened;
					if (obj != null)
					{
						obj.Invoke();
					}
				}
				catch
				{
				}
				RefreshDealerCategoryBadge();
			});
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in TryHookConversationUIRefresh: " + ex.Message);
		}
	}

	private void RefreshDealerCategoryBadge()
	{
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MSGConversation mSGConversation = NPC.S1NPC.MSGConversation;
			if (mSGConversation == null)
			{
				return;
			}
			object? obj = global::S1API.Utils.ReflectionUtils.TryGetFieldOrProperty(mSGConversation, "entry");
			RectTransform val = (RectTransform)((obj is RectTransform) ? obj : null);
			if ((Object)(object)val == (Object)null)
			{
				return;
			}
			MessagesApp instance = PlayerSingleton<MessagesApp>.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				return;
			}
			CategoryInfo categoryInfo = instance.GetCategoryInfo((EConversationCategory)2);
			if (categoryInfo == null)
			{
				return;
			}
			Transform obj2 = ((Transform)val).Find("Category");
			RectTransform val2 = (RectTransform)(object)((obj2 is RectTransform) ? obj2 : null);
			if ((Object)(object)val2 == (Object)null)
			{
				try
				{
					for (int i = 0; i < ((Transform)val).childCount; i++)
					{
						Transform child = ((Transform)val).GetChild(i);
						if (((Object)child).name != null && ((Object)child).name.Contains("Category"))
						{
							val2 = (RectTransform)(object)((child is RectTransform) ? child : null);
						}
					}
				}
				catch
				{
				}
				if ((Object)(object)val2 == (Object)null)
				{
					return;
				}
			}
			Transform obj4 = ((Transform)val2).Find("Label");
			Text val3 = ((obj4 != null) ? ((Component)obj4).GetComponent<Text>() : null);
			Image component = ((Component)val2).GetComponent<Image>();
			Transform obj5 = ((Transform)val).Find("Name");
			Text val4 = ((obj5 != null) ? ((Component)obj5).GetComponent<Text>() : null);
			if (!((Object)(object)val3 == (Object)null) && !((Object)(object)component == (Object)null) && !((Object)(object)val4 == (Object)null))
			{
				val3.text = ((categoryInfo.Name != null && categoryInfo.Name.Length > 0) ? categoryInfo.Name[0].ToString() : "D");
				LayoutRebuilder.ForceRebuildLayoutImmediate(((Graphic)val3).rectTransform);
				((Graphic)component).color = categoryInfo.Color;
				val2.anchoredPosition = new Vector2(225f + val4.preferredWidth, val2.anchoredPosition.y);
				((Component)val2).gameObject.SetActive(true);
			}
		}
		catch
		{
		}
	}

	public void RecruitDealer()
	{
		EnsureDealer();
		if ((Object)(object)Component == (Object)null)
		{
			return;
		}
		try
		{
			Component.InitialRecruitment();
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in RecruitDealer for " + NPC.ID + ": " + ex.Message);
		}
	}

	public void MarkAsRecommended()
	{
		EnsureDealer();
		if ((Object)(object)Component == (Object)null)
		{
			return;
		}
		try
		{
			Component.MarkAsRecommended();
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in MarkAsRecommended for " + NPC.ID + ": " + ex.Message);
		}
	}

	public void AssignCustomer(NPC customer)
	{
		EnsureDealer();
		if ((Object)(object)Component == (Object)null || customer == null)
		{
			return;
		}
		try
		{
			Component.SendAddCustomer(customer.ID);
			try
			{
				Customer component = customer.gameObject.GetComponent<Customer>();
				if ((Object)(object)component != (Object)null && (Object)(object)component.AssignedDealer == (Object)null)
				{
					global::S1API.Internal.Utils.ReflectionUtils.TrySetFieldOrProperty(component, "AssignedDealer", Component);
				}
			}
			catch
			{
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in AssignCustomer for " + NPC.ID + ": " + ex.Message);
		}
	}

	public void RemoveCustomer(NPC customer)
	{
		EnsureDealer();
		if ((Object)(object)Component == (Object)null || customer == null)
		{
			return;
		}
		try
		{
			Component.SendRemoveCustomer(customer.ID);
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in RemoveCustomer for " + NPC.ID + ": " + ex.Message);
		}
	}

	public float GetCash()
	{
		EnsureDealer();
		if ((Object)(object)Component == (Object)null)
		{
			return 0f;
		}
		try
		{
			object obj = global::S1API.Internal.Utils.ReflectionUtils.TryGetFieldOrProperty(Component, "Cash");
			if (obj != null && obj is float result)
			{
				return result;
			}
			return 0f;
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in GetCash for " + NPC.ID + ": " + ex.Message);
			return 0f;
		}
	}

	public void ChangeCash(float amount)
	{
		EnsureDealer();
		if ((Object)(object)Component == (Object)null)
		{
			return;
		}
		try
		{
			Component.ChangeCash(amount);
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in ChangeCash for " + NPC.ID + ": " + ex.Message);
		}
	}

	public void CollectCash()
	{
		EnsureDealer();
		if ((Object)(object)Component == (Object)null)
		{
			return;
		}
		try
		{
			MethodInfo method = typeof(Dealer).GetMethod("CollectCash", BindingFlags.Instance | BindingFlags.NonPublic);
			if (method != null)
			{
				method.Invoke(Component, null);
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in CollectCash for " + NPC.ID + ": " + ex.Message);
		}
	}

	public bool IsRecruited()
	{
		EnsureDealer();
		if ((Object)(object)Component == (Object)null)
		{
			return false;
		}
		try
		{
			object obj = global::S1API.Internal.Utils.ReflectionUtils.TryGetFieldOrProperty(Component, "IsRecruited");
			if (obj != null && obj is bool result)
			{
				return result;
			}
			return false;
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in IsRecruited for " + NPC.ID + ": " + ex.Message);
			return false;
		}
	}

	public bool HasBeenRecommended()
	{
		EnsureDealer();
		if ((Object)(object)Component == (Object)null)
		{
			return false;
		}
		try
		{
			object obj = global::S1API.Internal.Utils.ReflectionUtils.TryGetFieldOrProperty(Component, "HasBeenRecommended");
			if (obj != null && obj is bool result)
			{
				return result;
			}
			return false;
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in HasBeenRecommended for " + NPC.ID + ": " + ex.Message);
			return false;
		}
	}

	public List<NPC> GetAssignedCustomers()
	{
		EnsureDealer();
		List<NPC> list = new List<NPC>();
		if ((Object)(object)Component == (Object)null)
		{
			return list;
		}
		try
		{
			Enumerator<Customer> enumerator = Component.AssignedCustomers.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Customer customer = enumerator.Current;
				Customer obj = customer;
				if ((Object)(object)((obj != null) ? obj.NPC : null) != (Object)null)
				{
					NPC nPC = global::S1API.Entities.NPC.All.FirstOrDefault((NPC n) => (Object)(object)n.S1NPC == (Object)(object)customer.NPC);
					if (nPC != null)
					{
						list.Add(nPC);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in GetAssignedCustomers for " + NPC.ID + ": " + ex.Message);
		}
		return list;
	}

	private void TryNetworkInitialize(Dealer dealer)
	{
		if ((Object)(object)dealer == (Object)null)
		{
			return;
		}
		try
		{
			TransportManager transportManager = InstanceFinder.TransportManager;
			NetworkObject component = NPC.gameObject.GetComponent<NetworkObject>();
			if (!((Object)(object)transportManager == (Object)null) && !((Object)(object)component == (Object)null))
			{
				SetNonPublicInstanceField(dealer, "_transportManagerCache", transportManager);
				SetNonPublicInstanceField(dealer, "_networkObjectCache", component);
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in TryNetworkInitialize for " + NPC.ID + ": " + ex.Message);
			Logger.Warning("Stack trace: " + ex.StackTrace);
		}
	}

	private void WireCoreReferences(Dealer dealer)
	{
		try
		{
			if ((Object)(object)dealer != (Object)null && !((Object)(object)dealer != (Object)/*isinst with value type is only supported in some contexts*/))
			{
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception in WireCoreReferences for " + NPC.ID + ": " + ex.Message);
			Logger.Warning("Stack trace: " + ex.StackTrace);
		}
	}

	private void InitializeRuntimeState(Dealer dealer)
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		try
		{
			try
			{
				object obj = global::S1API.Internal.Utils.ReflectionUtils.TryGetFieldOrProperty(dealer, "AssignedCustomers");
				if (obj == null)
				{
					global::S1API.Internal.Utils.ReflectionUtils.TrySetFieldOrProperty(dealer, "AssignedCustomers", new List<Customer>());
				}
				object obj2 = global::S1API.Internal.Utils.ReflectionUtils.TryGetFieldOrProperty(dealer, "ActiveContracts");
				if (obj2 == null)
				{
					global::S1API.Internal.Utils.ReflectionUtils.TrySetFieldOrProperty(dealer, "ActiveContracts", new List<Contract>());
				}
			}
			catch
			{
			}
			FieldInfo field = typeof(Dealer).GetField("overflowSlots", BindingFlags.Instance | BindingFlags.NonPublic);
			if (field != null && (!(field.GetValue(dealer) is ItemSlot[] array) || array.Length == 0))
			{
				ItemSlot[] array2 = (ItemSlot[])(object)new ItemSlot[10];
				for (int i = 0; i < 10; i++)
				{
					array2[i] = new ItemSlot();
					array2[i].SetSlotOwner(((Il2CppObjectBase)dealer).Cast<IItemSlotOwner>());
				}
				field.SetValue(dealer, array2);
			}
			try
			{
				FieldInfo field2 = typeof(Dealer).GetField("_attendDealBehaviour", BindingFlags.Instance | BindingFlags.NonPublic);
				object? obj4 = field2?.GetValue(dealer);
				DealerAttendDealBehaviour val = (DealerAttendDealBehaviour)((obj4 is DealerAttendDealBehaviour) ? obj4 : null);
				if ((Object)(object)val == (Object)null)
				{
					NPCBehaviour val2 = NPC.gameObject.GetComponentInChildren<NPCBehaviour>(true);
					if ((Object)(object)val2 == (Object)null)
					{
						GameObject val3 = new GameObject("NPCBehaviour");
						val3.transform.SetParent(NPC.gameObject.transform, false);
						val2 = val3.AddComponent<NPCBehaviour>();
					}
					DealerAttendDealBehaviour val4 = NPC.gameObject.GetComponentInChildren<DealerAttendDealBehaviour>(true);
					if ((Object)(object)val4 == (Object)null)
					{
						GameObject val5 = new GameObject("DealerAttendDealBehaviour");
						val5.transform.SetParent(((Component)val2).transform, false);
						val4 = val5.AddComponent<DealerAttendDealBehaviour>();
						val5.SetActive(false);
					}
					field2?.SetValue(dealer, val4);
				}
			}
			catch
			{
			}
			try
			{
				PropertyInfo property = typeof(Dealer).GetProperty("HomeEvent", BindingFlags.Instance | BindingFlags.Public);
				object? obj6 = property?.GetValue(dealer);
				NPCEvent_StayInBuilding val6 = (NPCEvent_StayInBuilding)((obj6 is NPCEvent_StayInBuilding) ? obj6 : null);
				if (!((Object)(object)val6 == (Object)null))
				{
					return;
				}
				NPCScheduleManager componentInChildren = NPC.gameObject.GetComponentInChildren<NPCScheduleManager>(true);
				if ((Object)(object)componentInChildren != (Object)null)
				{
					val6 = NPC.gameObject.GetComponentInChildren<NPCEvent_StayInBuilding>(true);
					if ((Object)(object)val6 == (Object)null)
					{
						GameObject val7 = new GameObject("HomeEvent");
						val7.transform.SetParent(((Component)componentInChildren).transform, false);
						val6 = val7.AddComponent<NPCEvent_StayInBuilding>();
						val7.SetActive(false);
					}
					property?.SetValue(dealer, val6);
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

	private void EnsureUnityEvents(Dealer dealer)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		try
		{
			PropertyInfo property = typeof(Dealer).GetProperty("onRecommended", BindingFlags.Instance | BindingFlags.Public);
			PropertyInfo property2 = typeof(Dealer).GetProperty("onContractAccepted", BindingFlags.Instance | BindingFlags.Public);
			if (property != null && property.GetValue(dealer) == null)
			{
				property.SetValue(dealer, (object?)new UnityEvent());
			}
			if (property2 != null && property2.GetValue(dealer) == null)
			{
				property2.SetValue(dealer, (Action)delegate
				{
				});
			}
		}
		catch (Exception)
		{
		}
	}

	private void EnsureContractAcceptedHook()
	{
		if (_contractAcceptedHooked || (Object)(object)Component == (Object)null)
		{
			return;
		}
		try
		{
			Action existing = Component.onContractAccepted;
			Action dispatch = DispatchContractAccepted;
			Component.onContractAccepted = Action.op_Implicit(((Delegate)(object)existing != (Delegate)null) ? ((Action)delegate
			{
				Action obj = existing;
				if (obj != null)
				{
					obj.Invoke();
				}
				dispatch();
			}) : dispatch);
			_contractAcceptedHooked = true;
		}
		catch (Exception ex)
		{
			Logger.Warning("Exception wiring OnContractAccepted for " + NPC.ID + ": " + ex.Message);
		}
	}

	private void DispatchContractAccepted()
	{
		Action contractAcceptedHandlers = _contractAcceptedHandlers;
		if (contractAcceptedHandlers == null)
		{
			return;
		}
		Delegate[] invocationList = contractAcceptedHandlers.GetInvocationList();
		for (int i = 0; i < invocationList.Length; i++)
		{
			Action action = (Action)invocationList[i];
			try
			{
				action();
			}
			catch (Exception ex)
			{
				Logger.Warning("Exception in OnContractAccepted handler for " + NPC.ID + ": " + ex.Message);
			}
		}
	}

	private UnityEvent GetRecommendedUnityEvent(bool createIfMissing)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		if ((Object)(object)Component == (Object)null)
		{
			return null;
		}
		PropertyInfo property = typeof(Dealer).GetProperty("onRecommended", BindingFlags.Instance | BindingFlags.Public);
		if (property != null)
		{
			object? value = property.GetValue(Component);
			UnityEvent val = (UnityEvent)((value is UnityEvent) ? value : null);
			if (val == null && createIfMissing)
			{
				val = new UnityEvent();
				property.SetValue(Component, val);
			}
			return val;
		}
		FieldInfo field = typeof(Dealer).GetField("onRecommended", BindingFlags.Instance | BindingFlags.Public);
		if (field == null)
		{
			return null;
		}
		object? value2 = field.GetValue(Component);
		UnityEvent val2 = (UnityEvent)((value2 is UnityEvent) ? value2 : null);
		if (val2 == null && createIfMissing)
		{
			val2 = new UnityEvent();
			field.SetValue(Component, val2);
		}
		return val2;
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
