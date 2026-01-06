using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class KevinOakley : NPC
{
	public new static string NPCId => "kevin_oakley";

	internal KevinOakley()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "kevin_oakley"))
	{
	}
}
