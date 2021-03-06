﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class CreatureData 
{
    //Data properties for every single creature in our creatureList
    public string creatureName;
    public string creatureDescription;

    public int creatureLevel;
    public int rewardForCreature;
    public int CreatureID;

    public float creatureHealth;
    public float creatureArmor;
    public float howMuchEnergyNeededForOneTime;
    public float howMuchHealthNeededForOneTime;
    public float howMuchExperienceDoesOneGonnaGet;
}