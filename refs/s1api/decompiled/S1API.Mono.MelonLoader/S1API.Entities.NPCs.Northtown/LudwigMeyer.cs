using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class LudwigMeyer : NPC
{
	public new static string NPCId => "ludwig_meyer";

	internal LudwigMeyer()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "ludwig_meyer"))
	{
	}
}
