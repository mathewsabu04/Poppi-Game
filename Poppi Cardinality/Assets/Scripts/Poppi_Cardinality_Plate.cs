using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poppi_Cardinality_Plate : MonoBehaviour
{
    [SerializeField]
    private int numberOfFood;

    [SerializeField]
    private GameObject[] spawnPoints;

    [SerializeField]
    private GameObject defaultFoodItem;
    
    [SerializeField]
    private Sprite[] foodSprites;





    public void SetFoodCount(int setFood)
    {
        if (setFood < 0)
        {
            numberOfFood = 0;
        }
        else if(setFood > 4) 
        {
            numberOfFood= 4;
        }
        else
        {
            numberOfFood = setFood;
        }
       
    }

    

    public void SpawnFood()
    {
        for (int i =0; i < numberOfFood; i++)
        {
            //access the posistion and rotation of the spawn point
            // postition - Vector3
            Vector3 spawnPosition = spawnPoints[ i % spawnPoints.Length].transform.position;
            // rotation - Quaternion
            Quaternion spawnRotation = spawnPoints[ i % spawnPoints.Length].transform.rotation;
            


            // instantiate food item
            //make a game object variable with a temp name, and set it equal to Instantiate(defaultFoodItem,Postition,Rotation)
            GameObject foodItem = Instantiate(defaultFoodItem, spawnPosition,spawnRotation);

        


            //set the food sprite randomly

           int temp = Random.Range(0,2);

           switch(temp)
           {
                case(0):
                    foodItem.GetComponent<Poppi_Cardinality_Food_Item>().SetSprite(FoodType.Fish);
                    break;
                case(1):
                    foodItem.GetComponent<Poppi_Cardinality_Food_Item>().SetSprite(FoodType.Shrimp);
                    break;
                default:
                    foodItem.GetComponent<Poppi_Cardinality_Food_Item>().SetSprite(FoodType.Fish);
                    break;
           }

        }


    }
}
