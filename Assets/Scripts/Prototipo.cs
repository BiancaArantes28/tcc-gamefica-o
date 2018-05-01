using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prototipo : MonoBehaviour {

	public GameObject[] ingredientes;
	public GameObject[] pedidos;
	public Sprite[] spritepedidos;
	public Sprite lanche;
	// int[] arrayingredientes;
	int[] arrayingredientes = new int[6];
	static public int i = 0;
	public int value;
	int[] usuario = new int[6];
	bool resposta;
	public Text txt;
	int placar = 0;
	int verificar = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		montaPedido ();
		
	}

	public void selecionaIngrediente(){
		
		ingredientes[i].GetComponent<SpriteRenderer>().sprite = lanche;

		ingredientes[i].SetActive(true);

		usuario[i] = value;
		resposta = checkLanche (usuario [i]);
		if (resposta == false) {
			descartaLanche ();
			i = 0;
		} else {
			// print (i);
//			verificar = i + 1;
//			// print (verificar);
//			if (verificar == arrayingredientes.Length) {
//				confereLancheEAumentaPlacar ();
//			}
			i++;

		}
		//i++;
	}

	public void montaPedido(){
		for (int b = 0; b < pedidos.Length; b++) {
			arrayingredientes[b] = b + 1;
			pedidos[b].GetComponent<SpriteRenderer>().sprite = spritepedidos[b];
			pedidos[b].SetActive(true);
		}
	}

	public bool checkLanche(int ingredienteSelecionado){
		if (ingredienteSelecionado == arrayingredientes[i]) {
			
			if (i + 1 == 6) {
				placar += 1;
				txt.text = placar.ToString ();
				descartaLanche ();
				descartaPedido ();
				return true;

			}
			return true;
		} else {
			return false;
		}
	}

	public void descartaLanche(){
		for (int c = 0; c < ingredientes.Length; c++) {
			ingredientes[c].SetActive(false);
		}
	}

	public void descartaPedido(){
		for (int c = 0; c < ingredientes.Length; c++) {
			pedidos[c].SetActive(false);
			arrayingredientes [c] = 0;
		}
	}

	public void confereLancheEAumentaPlacar(){
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
	}


}
