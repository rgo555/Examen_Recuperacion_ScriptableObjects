using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    
    public static InventoryManager Instance;

    public ScripteableObject[] weapons;
    public ScripteableObject[] shields;

    public Text[] weaponsNames;
    public Image[] weaponsSprites;

    public Text[] shieldNames;
    public Image[] shieldSprites;

    void Awake() 
    {
        Instance = this;
    }

    public void AddWeapon(ScripteableObject weapon)
    {

        for( int i = 0; i < weapons.Length; i++)
        {
            if(weapon.weaponType == 0)
            {
                if(weapons[i] == null)
                {
                    weapons[i] = weapon;
                    weaponsNames[i].text = weapon.weaponName;
                    weaponsSprites[i].sprite = weapon.weaponSprite;

                    return;                
                }
            }
            if(weapon.weaponType == 1)
            {
                if(shields[i] == null)
                {
                    shields[i] = weapon;
                    shieldNames[i].text = weapon.weaponName;
                    shieldSprites[i].sprite = weapon.weaponSprite;

                    return;                
                }
            }
        }
    }
}
