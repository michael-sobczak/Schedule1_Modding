using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class ElizabethHomley : NPC
{
	public new static string NPCId => "elizabeth_homley";

	internal ElizabethHomley()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "elizabeth_homley"))
	{
	}
}
