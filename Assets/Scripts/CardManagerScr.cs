using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Card
{
    public string Name;
    public Sprite Logo;
    public int HP, Defense, Attack, Leader, Cost, Upkeep;
    public string Status;
    public int ID;
    public string LogoPath;

    public Card(int id, string name, string logoPath, int hp, int defense, 
                int attack, int leader, int cost, int upkeep, string status)
    {
        ID = id;
        Name = name;
        Logo = Resources.Load<Sprite>(logoPath);
        LogoPath = logoPath;
        Status = status;
        HP = hp;
        Leader = leader;
        Upkeep = upkeep;
        Cost = cost;
        Attack = attack;
        Defense = defense;
    }
}

public static class CardManager
{
    public static List<Card> AllCards = new List<Card>();         
}

public class CardManagerScr : MonoBehaviour
{
    public void Awake() 
    {
        // LEGENDARY LORDS
        CardManager.AllCards.Add(new Card(0, "Balthasar_Gelt", "Cards/Legendary_Lords/Balthasar_Gelt1", 12, 12, 12, 12, 12, 12, "LegendaryLords"));
        CardManager.AllCards.Add(new Card(1,"Balthasar_Gelt", "Cards/Legendary_Lords/Balthasar_Gelt", 12, 12, 12, 12, 12, 12, "LegendaryLords"));
        CardManager.AllCards.Add(new Card(2,"Karl_France", "Cards/Legendary_Lords/Karl_France", 12, 12, 12, 12, 12, 10, "LegendaryLords"));
        CardManager.AllCards.Add(new Card(3,"Volkmar_the_ Grim", "Cards/Legendary_Lords/Volkmar_the_Grim", 12, 12, 12, 12, 10, 10, "LegendaryLords"));
        
        // LORDS

        CardManager.AllCards.Add(new Card(4,"Witch_Hunter", "Cards/Lords/Witch_Hunter", 12, 12, 12, 12, 12, 12, "Lords"));
        CardManager.AllCards.Add(new Card(5,"Light_Wizard", "Cards/Lords/Light_Wizard", 12, 12, 12, 12, 10, 10, "Lords"));
        CardManager.AllCards.Add(new Card(6,"Warrior_Priest", "Cards/Lords/Warrior_Priest", 12, 12, 12, 12, 10, 10, "Lords"));
        CardManager.AllCards.Add(new Card(7,"Grey_Wizard", "Cards/Lords/Grey_Wizard", 12, 12, 12, 12, 10, 10, "Lords"));
        CardManager.AllCards.Add(new Card(8,"Empire_Captain", "Cards/Lords/Empire_Captain", 12, 12, 12, 12, 10, 10, "Lords"));
        CardManager.AllCards.Add(new Card(9,"Bright_Wizard", "Cards/Lords/Bright_Wizard", 12, 12, 12, 12, 10, 10, "Lords"));
        CardManager.AllCards.Add(new Card(10,"Amber_wizard", "Cards/Lords/Amber_wizard", 12, 12, 12, 12, 10, 10, "Lords"));

        // ARTILLERY

        CardManager.AllCards.Add(new Card(11,"Great_Cannon", "Cards/Artillery/Great_Cannon", 12, 12, 12, 12, 10, 10, "Artillery"));
        CardManager.AllCards.Add(new Card(12,"Helblaster_Volley_ Gun", "Cards/Artillery/Helblaster_Volley_Gun", 12, 12, 12, 12, 10, 10, "Artillery"));
        CardManager.AllCards.Add(new Card(13, "Mortar", "Cards/Artillery/Mortar", 12, 12, 12, 12, 10, 10, "Artillery"));
        CardManager.AllCards.Add(new Card(14, "Mortar", "Cards/Artillery/Mortar", 12, 12, 12, 12, 10, 10, "Artillery"));
        CardManager.AllCards.Add(new Card(15, "Mortar", "Cards/Artillery/Mortar", 12, 12, 12, 12, 10, 10, "Artillery"));
        CardManager.AllCards.Add(new Card(16, "Mortar", "Cards/Artillery/Mortar", 12, 12, 12, 12, 10, 10, "Artillery"));
        CardManager.AllCards.Add(new Card(17,"Helstorm_Rocket_Battery", "Cards/Artillery/Helstorm_Rocket_Battery", 12, 12, 12, 12, 10, 10, "Artillery"));
        CardManager.AllCards.Add(new Card(18, "Helstorm_Rocket_Battery", "Cards/Artillery/Helstorm_Rocket_Battery", 12, 12, 12, 12, 10, 10, "Artillery"));


        // MELEE CAVALRY

        CardManager.AllCards.Add(new Card(19,"Demigryph_Knights_(Halderds)", "Cards/Melee_Cavalry/Demigryph_Knights_(Halderds)", 12, 12, 12, 12, 10, 10, "MeleeCavalry"));
        CardManager.AllCards.Add(new Card(20,"Demigryph_Knights", "Cards/Melee_Cavalry/Demigryph_Knights", 12, 12, 12, 12, 10, 10, "MeleeCavalry"));
        CardManager.AllCards.Add(new Card(21,"Empire_Knights", "Cards/Melee_Cavalry/Empire_Knights", 12, 12, 12, 12, 10, 10, "MeleeCavalry"));
        CardManager.AllCards.Add(new Card(22,"Knights_of_the_Blazing_Sun", "Cards/Melee_Cavalry/Knights_of_the_Blazing_Sun", 12, 12, 12, 12, 10, 10, "MeleeCavalry"));
        CardManager.AllCards.Add(new Card(23,"Reiksguard", "Cards/Melee_Cavalry/Reiksguard", 12, 12, 12, 12, 10, 10, "MeleeCavalry"));

        // MELEE INFANTRY

        CardManager.AllCards.Add(new Card(24,"Flagallents", "Cards/Melee_Infantry/Flagallents", 12, 12, 12, 12, 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(25,"Greatswords", "Cards/Melee_Infantry/Greatswords", 12, 12, 12, 12, 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(26,"Halberdies", "Cards/Melee_Infantry/Halberdies", 12, 12, 12, 12, 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(27, "Halberdies", "Cards/Melee_Infantry/Halberdies", 12, 12, 12, 12, 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(28,"Spearmen(Shields)", "Cards/Melee_Infantry/Spearmen(Shields)", 12, 12, 12, 12, 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(29, "Spearmen(Shields)", "Cards/Melee_Infantry/Spearmen(Shields)", 12, 12, 12, 12, 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(30, "Spearmen(Shields)", "Cards/Melee_Infantry/Spearmen(Shields)", 12, 12, 12, 12, 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(31,"Spearmen", "Cards/Melee_Infantry/Spearmen", 12, 12, 12, 12, 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(32,"Swordsman", "Cards/Melee_Infantry/Swordsman", 12, 12, 12, 12, 10, 10, "MeleeInfantry"));

        // MISSILE CAVALRY

        CardManager.AllCards.Add(new Card(33,"Outriders", "Cards/Missile_Cavalry/Outriders", 12, 12, 12, 12, 10, 10, "MissileCavalry"));
        CardManager.AllCards.Add(new Card(34, "Outriders", "Cards/Missile_Cavalry/Outriders", 12, 12, 12, 12, 10, 10, "MissileCavalry"));
        CardManager.AllCards.Add(new Card(35, "Outriders", "Cards/Missile_Cavalry/Outriders", 12, 12, 12, 12, 10, 10, "MissileCavalry"));
        CardManager.AllCards.Add(new Card(36,"Outriders_(Grenade_Launcher)", "Cards/Missile_Cavalry/Outriders_(Grenade_Launcher)", 12, 12, 12, 12, 10, 10, "MissileCavalry"));
        CardManager.AllCards.Add(new Card(37,"Pistoliers", "Cards/Missile_Cavalry/Pistoliers", 12, 12, 12, 12, 10, 10, "MissileCavalry"));
        CardManager.AllCards.Add(new Card(38, "Pistoliers", "Cards/Missile_Cavalry/Pistoliers", 12, 12, 12, 12, 10, 10, "MissileCavalry"));
        CardManager.AllCards.Add(new Card(39, "Pistoliers", "Cards/Missile_Cavalry/Pistoliers", 12, 12, 12, 12, 10, 10, "MissileCavalry"));

        // MISSILE INFANTRY

        CardManager.AllCards.Add(new Card(40,"Crossbowmen", "Cards/Missile_Infantry/Crossbowmen", 12, 12, 12, 12, 10, 10, "MissileInfantry"));
        CardManager.AllCards.Add(new Card(41,"Free_Company_Militia", "Cards/Missile_Infantry/Free_Company_Militia", 12, 12, 12, 12, 10, 10, "MissileInfantry"));
        CardManager.AllCards.Add(new Card(42,"Grey_Wizard", "Cards/Missile_Infantry/Handgunner", 12, 12, 12, 12, 10, 10, "MissileInfantry"));
        CardManager.AllCards.Add(new Card(43, "Grey_Wizard", "Cards/Missile_Infantry/Handgunner", 12, 12, 12, 12, 10, 10, "MissileInfantry"));
        CardManager.AllCards.Add(new Card(44, "Grey_Wizard", "Cards/Missile_Infantry/Handgunner", 12, 12, 12, 12, 10, 10, "MissileInfantry"));
        CardManager.AllCards.Add(new Card(45, "Grey_Wizard", "Cards/Missile_Infantry/Handgunner", 12, 12, 12, 12, 10, 10, "MissileInfantry"));

        // WAR MACHINES

        CardManager.AllCards.Add(new Card(46, "Steam_Tank", "Cards/War_Machines/Steam_Tank", 12, 12, 12, 12, 10, 10, "WarMachines"));
        CardManager.AllCards.Add(new Card(47,"Luminark_of_Hysh", "Cards/War_Machines/Luminark_of_Hysh", 12, 12, 12, 12, 10, 10, "WarMachines"));
    }
}
