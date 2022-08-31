using System;
public class Combat
{
    public static void TurnCombat(Figther h)
    {
        List<Figther> Figthers = new List<Figther>();
        Figthers.Add(h);
        Slime slime = new Slime();
        slime.CreatSlime();
        
        Text.Continue();
    }
}
