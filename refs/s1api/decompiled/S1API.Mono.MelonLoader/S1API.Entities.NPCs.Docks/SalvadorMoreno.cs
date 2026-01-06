using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class SalvadorMoreno : NPC
{
	public new static string NPCId => "salvador_moreno";

	internal SalvadorMoreno()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "salvador_moreno"))
	{
	}
}
