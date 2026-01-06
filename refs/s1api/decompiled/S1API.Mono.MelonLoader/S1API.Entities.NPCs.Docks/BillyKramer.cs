using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class BillyKramer : NPC
{
	public new static string NPCId => "billy_kramer";

	internal BillyKramer()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "billy_kramer"))
	{
	}
}
