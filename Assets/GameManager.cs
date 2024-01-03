using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eEquippedWeapons
{
    AK47,
    AWP,
    MP5
}
public class GameManager : MonoBehaviour
{
    [Header("Player_Stats")]
    public float BaseDamage;
    public float FinalDamage;
    [Header("Weapons_Equipped")]
    public eEquippedWeapons EquippedWeapons;

    private void OnValidate()
    {
        #region Weapon Equipment
        Weapon weapon = new();
        switch (EquippedWeapons)
        {
            case eEquippedWeapons.AK47:
                FinalDamage = BaseDamage + weapon.Damage_AK47;
                break;
            case eEquippedWeapons.AWP:
                FinalDamage = BaseDamage + weapon.Damage_AWP;
                break;
            case eEquippedWeapons.MP5:
                FinalDamage = BaseDamage + weapon.Damage_MP5;
                break;
        }

        #endregion
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            BoostUpPowerUp();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            BerserkPowerUp();
        }
    }
    public void BoostUpPowerUp()
    {
        DamagePowerUp damage_powerup = new();
        FinalDamage += damage_powerup.Boost_Up;
    }
    public void BerserkPowerUp()
    {
        DamagePowerUp damage_powerup = new();
        FinalDamage += damage_powerup.berserk;
    }
}
