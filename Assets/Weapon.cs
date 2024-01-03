using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    int AK47_Damage = 20;
    int AWP_Damage = 10;
    int MP5_Damage = 8;

    public int Damage_AK47
    {
        get { return AK47_Damage; }
        set { AK47_Damage = value; }
    }
    public int Damage_AWP
    {
        get { return AWP_Damage; }
        set { AWP_Damage = value; }
    }
    public int Damage_MP5
    {
        get { return MP5_Damage; }
        set { MP5_Damage = value; }
    }

}
public class DamagePowerUp
{
    float BoostUp = 5;
    public float Boost_Up
    {
        get { return BoostUp; }
        set { BoostUp = value; }
    }
    //Percentage Values
    float Berserk = 20;
    public float berserk
    {
        get { return Berserk; }
        set { Berserk = value; }
    }

    //Base Values
}
