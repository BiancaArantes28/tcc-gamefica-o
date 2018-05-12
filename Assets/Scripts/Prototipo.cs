using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prototipo : MonoBehaviour {

	public GameObject[] ingredientes;
	public GameObject[] pedidos;
	public Sprite[] spritepedidos;
	public Sprite lanche;
	public AudioSource musica;
	public AudioSource musica_descartalanche;
	//int[] arrayingredientes = new int[6];
	 

	int num;
	static public int i = 0;
	public int value;
	//int[] usuario = new int[6];
	bool resposta;
	public Text txt;
	int placar = 0;
	//int verificar = 1;
	// Use this for initialization
	void Start () {
		montaPedido ();
	}
	
	// Update is called once per frame
	void Update () {
		

		
	}

	public void selecionaIngrediente(){
		
		ingredientes[i].GetComponent<SpriteRenderer>().sprite = lanche;

		ingredientes[i].SetActive(true);

		//usuario[i] = value;
		resposta = checkLanche ();
		if (resposta == false) {
			descartaLanche ();
			musica_descartalanche.Play ();
			i = 0;
		} else {
			i++;

		}
	}
	public void montaPedido(){
		//arrayingredientes[0] = 1;
		pedidos[0].GetComponent<SpriteRenderer>().sprite = spritepedidos[0];
		pedidos[0].SetActive(true);
		for (int b = 1; b < pedidos.Length - 1; b++) {
			num = Random.Range(1,5);
			//arrayingredientes[b] = b + 1;
			pedidos[b].GetComponent<SpriteRenderer>().sprite = spritepedidos[num];
			pedidos[b].SetActive(true);

		}
		//arrayingredientes[5] = 6;
		pedidos[5].GetComponent<SpriteRenderer>().sprite = spritepedidos[5];
		pedidos[5].SetActive(true);
	}



	public bool checkLanche(){
		if (lanche == pedidos [i].GetComponent<SpriteRenderer> ().sprite) {
			if (i == 5) {
				i = 0;
				musica.Play ();
				placar += 1;
				txt.text = placar.ToString ();
				descartaLanche ();
				descartaPedido ();
				montaPedido ();

				return true;

			}
			return true;
			
		} else {
			return false;
		}
		/*if (ingredienteSelecionado == arrayingredientes[i]) {
			
			if (i + 1 == 6) {
				//Instantiate (musica, new Vector3 (-7, 2, 0), Quaternion.identity);
				//print("aqui");
				i = 0;
				musica.Play();
				//print ("usuario");
				//print (usuario [i]);
				placar += 1;
				txt.text = placar.ToString ();
				descartaLanche ();
				descartaPedido ();

				montaPedido ();

				return true;

			}
			return true;
		} else {
			return false;
		}*/
	}

	public void descartaLanche(){
		for (int c = 0; c < ingredientes.Length; c++) {
			ingredientes[c].SetActive(false);
		}
		i = 0;

	}

	public void descartaPedido(){
		for (int c = 0; c < ingredientes.Length; c++) {
			pedidos [c].SetActive (false);
			//arrayingredientes [c] = 0;
			//usuario [c] = 0;

		}
		i = 0;

	}

	/*public void confereLancheEAumentaPlacar(){
		int erro = 0;
		for (int c = 0; c < arrayingredientes.Length; c++) {
			
			if (arrayingredientes [c] != usuario [c]) {
				erro += 1;
			}

		}
		if (erro == 0) {
			
			placar += 1;
			txt.text = placar.ToString ();
		}
	}*/


}
