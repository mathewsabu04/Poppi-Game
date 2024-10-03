using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FoodType
{
    Fish,Shrimp
}
public class Poppi_Cardinality_Food_Item : MonoBehaviour
{
    [SerializeField]
    private FoodType foodType;

    [SerializeField]
    private Sprite spriteFish;


    [SerializeField]
    private Sprite spriteShrimp;

   
    public void SetSprite(FoodType type)
    {
        switch(type)
        {
            case(FoodType.Fish):
                this.GetComponent <SpriteRenderer> ().sprite = spriteFish;
                break;
            case(FoodType.Shrimp):
                this.GetComponent <SpriteRenderer> ().sprite = spriteShrimp;
                break;
            default:
                this.GetComponent <SpriteRenderer> ().sprite = spriteFish;
                break;
        }

    }
    

}
