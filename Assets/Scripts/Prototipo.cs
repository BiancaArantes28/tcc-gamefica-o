using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prototipo : MonoBehaviour {

	public GameObject[] ingredientes;
	public Sprite lanche;
	static public int[] arrayingredientes;
	static public int i = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	public void selecionaIngrediente(){
		print (i);
		ingredientes[i].GetComponent<SpriteRenderer>().sprite = lanche;

		ingredientes[i].SetActive(true);
		i++;
	}


}
