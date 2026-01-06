using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class LisaGardener : NPC
{
	public new static string NPCId => "lisa_gardener";

	internal LisaGardener()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "lisa_gardener"))
	{
	}
}
