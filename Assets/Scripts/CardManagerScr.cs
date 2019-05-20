using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Card
{
    public string Name;
    public Sprite Logo;
    public int Attack, Defense;
    public string Status;
    public int ID;
    public string LogoPath;

    public Card(int id, string name, string logoPath, int attack, int defense, string status)
    {
        ID = id;
        Name = name;
        Logo = Resources.Load<Sprite>(logoPath);
        LogoPath = logoPath;
        Attack = attack;
        Defense = defense;
        Status = status;
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
        CardManager.AllCards.Add(new Card(1, "Balthasar_Gelt", "Cards/Legendary_Lords/Balthasar_Gelt1", 10, 10, "LegendaryLords"));
        CardManager.AllCards.Add(new Card(1,"Balthasar_Gelt", "Cards/Legendary_Lords/Balthasar_Gelt", 10, 10, "LegendaryLords"));
        CardManager.AllCards.Add(new Card(2,"Karl_France", "Cards/Legendary_Lords/Karl_France", 10, 10, "LegendaryLords"));
        CardManager.AllCards.Add(new Card(3,"Volkmar_the_ Grim", "Cards/Legendary_Lords/Volkmar_the_Grim", 10, 10, "LegendaryLords"));
        
        // LORDS

        CardManager.AllCards.Add(new Card(4,"Witch_Hunter", "Cards/Lords/Witch_Hunter", 10, 10, "Lords"));
        CardManager.AllCards.Add(new Card(5,"Light_Wizard", "Cards/Lords/Light_Wizard", 10, 10, "Lords"));
        CardManager.AllCards.Add(new Card(6,"Warrior_Priest", "Cards/Lords/Warrior_Priest", 10, 10, "Lords"));
        CardManager.AllCards.Add(new Card(7,"Grey_Wizard", "Cards/Lords/Grey_Wizard", 10, 10, "Lords"));
        CardManager.AllCards.Add(new Card(8,"Empire_Captain", "Cards/Lords/Empire_Captain", 10, 10, "Lords"));
        CardManager.AllCards.Add(new Card(9,"Bright_Wizard", "Cards/Lords/Bright_Wizard", 10, 10, "Lords"));
        CardManager.AllCards.Add(new Card(10,"Amber_wizard", "Cards/Lords/Amber_wizard", 10, 10, "Lords"));

        // ARTILLERY

        CardManager.AllCards.Add(new Card(11,"Great_Cannon", "Cards/Artillery/Great_Cannon", 10, 10, "Artillery"));
        CardManager.AllCards.Add(new Card(12,"Helblaster_Volley_ Gun", "Cards/Artillery/Helblaster_Volley_Gun", 10, 10, "Artillery"));
        CardManager.AllCards.Add(new Card(14, "Mortar", "Cards/Artillery/Mortar", 10, 10, "Artillery"));
        CardManager.AllCards.Add(new Card(14, "Mortar", "Cards/Artillery/Mortar", 10, 10, "Artillery"));
        CardManager.AllCards.Add(new Card(14, "Mortar", "Cards/Artillery/Mortar", 10, 10, "Artillery"));
        CardManager.AllCards.Add(new Card(14, "Mortar", "Cards/Artillery/Mortar", 10, 10, "Artillery"));
        CardManager.AllCards.Add(new Card(13,"Helstorm_Rocket_Battery", "Cards/Artillery/Helstorm_Rocket_Battery", 10, 10, "Artillery"));
        CardManager.AllCards.Add(new Card(13, "Helstorm_Rocket_Battery", "Cards/Artillery/Helstorm_Rocket_Battery", 10, 10, "Artillery"));


        // MELEE CAVALRY

        CardManager.AllCards.Add(new Card(15,"Demigryph_Knights_(Halderds)", "Cards/Melee_Cavalry/Demigryph_Knights_(Halderds)", 10, 10, "MeleeCavalry"));
        CardManager.AllCards.Add(new Card(16,"Demigryph_Knights", "Cards/Melee_Cavalry/Demigryph_Knights", 10, 10, "MeleeCavalry"));
        CardManager.AllCards.Add(new Card(17,"Empire_Knights", "Cards/Melee_Cavalry/Empire_Knights", 10, 10, "MeleeCavalry"));
        CardManager.AllCards.Add(new Card(18,"Knights_of_the_Blazing_Sun", "Cards/Melee_Cavalry/Knights_of_the_Blazing_Sun", 10, 10, "MeleeCavalry"));
        CardManager.AllCards.Add(new Card(19,"Reiksguard", "Cards/Melee_Cavalry/Reiksguard", 10, 10, "MeleeCavalry"));

        // MELEE INFANTRY

        CardManager.AllCards.Add(new Card(20,"Flagallents", "Cards/Melee_Infantry/Flagallents", 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(21,"Greatswords", "Cards/Melee_Infantry/Greatswords", 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(22,"Halberdies", "Cards/Melee_Infantry/Halberdies", 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(22, "Halberdies", "Cards/Melee_Infantry/Halberdies", 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(23,"Spearmen(Shields)", "Cards/Melee_Infantry/Spearmen(Shields)", 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(23, "Spearmen(Shields)", "Cards/Melee_Infantry/Spearmen(Shields)", 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(23, "Spearmen(Shields)", "Cards/Melee_Infantry/Spearmen(Shields)", 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(24,"Spearmen", "Cards/Melee_Infantry/Spearmen", 10, 10, "MeleeInfantry"));
        CardManager.AllCards.Add(new Card(25,"Swordsman", "Cards/Melee_Infantry/Swordsman", 10, 10, "MeleeInfantry"));

        // MISSILE CAVALRY

        CardManager.AllCards.Add(new Card(26,"Outriders", "Cards/Missile_Cavalry/Outriders", 10, 10, "MissileCavalry"));
        CardManager.AllCards.Add(new Card(26, "Outriders", "Cards/Missile_Cavalry/Outriders", 10, 10, "MissileCavalry"));
        CardManager.AllCards.Add(new Card(26, "Outriders", "Cards/Missile_Cavalry/Outriders", 10, 10, "MissileCavalry"));
        CardManager.AllCards.Add(new Card(27,"Outriders_(Grenade_Launcher)", "Cards/Missile_Cavalry/Outriders_(Grenade_Launcher)", 10, 10, "MissileCavalry"));
        CardManager.AllCards.Add(new Card(28,"Pistoliers", "Cards/Missile_Cavalry/Pistoliers", 10, 10, "MissileCavalry"));
        CardManager.AllCards.Add(new Card(28, "Pistoliers", "Cards/Missile_Cavalry/Pistoliers", 10, 10, "MissileCavalry"));
        CardManager.AllCards.Add(new Card(28, "Pistoliers", "Cards/Missile_Cavalry/Pistoliers", 10, 10, "MissileCavalry"));

        // MISSILE INFANTRY

        CardManager.AllCards.Add(new Card(29,"Crossbowmen", "Cards/Missile_Infantry/Crossbowmen", 10, 10, "MissileInfantry"));
        CardManager.AllCards.Add(new Card(30,"Free_Company_Militia", "Cards/Missile_Infantry/Free_Company_Militia", 10, 10, "MissileInfantry"));
        CardManager.AllCards.Add(new Card(31,"Grey_Wizard", "Cards/Missile_Infantry/Handgunner", 10, 10, "MissileInfantry"));
        CardManager.AllCards.Add(new Card(31, "Grey_Wizard", "Cards/Missile_Infantry/Handgunner", 10, 10, "MissileInfantry"));
        CardManager.AllCards.Add(new Card(31, "Grey_Wizard", "Cards/Missile_Infantry/Handgunner", 10, 10, "MissileInfantry"));
        CardManager.AllCards.Add(new Card(31, "Grey_Wizard", "Cards/Missile_Infantry/Handgunner", 10, 10, "MissileInfantry"));

        // WAR MACHINES

        CardManager.AllCards.Add(new Card(32, "Steam_Tank", "Cards/War_Machines/Steam_Tank", 10, 10, "WarMachines"));
        CardManager.AllCards.Add(new Card(33,"Luminark_of_Hysh", "Cards/War_Machines/Luminark_of_Hysh", 10, 10, "WarMachines"));
    }
}
