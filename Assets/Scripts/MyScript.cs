using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public GameObject lancheSprite;
    public Sprite ingrediente;
    public int value;
    public int[] myInt;
    public int[] usuario;
    public Sprite[] ing;
    public Lanche lanche;
    //public int[5] usuario;

    public void TrocarIngrediente() {
        lancheSprite.GetComponent<SpriteRenderer>().sprite = ingrediente;
       
        
        //lancheSprite.GetComponent<>
        lancheSprite.SetActive(true);

    
    }
    public bool CheckIfCorrect(int ingrediente, int ingredienteCorreto)
    {
        if (ingrediente == ingredienteCorreto)
        {
            print("Uhuuu");
            return true;
        }
        else
        {
            return false;
            
        }
    }
}
