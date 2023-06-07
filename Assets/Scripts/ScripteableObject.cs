using UnityEngine;

[CreateAssetMenu(fileName = "Nombre del nuevo item", menuName = "Nombre del menu")]
public class ScripteableObject : ScriptableObject
{

    public string weaponName;

    public string weaponPrice;

    public string weaponDescription;

    public Sprite weaponSprite;

    public float weaponDamage;
    
    public float weaponMagicDamage;

    public float weaponType;
}
