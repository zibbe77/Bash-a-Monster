using System;
#region Start
Player hero = new Player();
Text.Start();
Text.Continue();
#endregion

#region Game

Combat combat = new Combat();
combat.TurnCombat(hero);

#endregion