using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanche : MonoBehaviour {

	static public int[] montar_lanche = new int[4];
	int num;
	// Use this for initialization
	void Start () {
		montarLanche ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void montarLanche(){
		for (int i = 0; i < montar_lanche.Length; i++) {
			num = Random.Range (1, 5);
			montar_lanche [i] = num;
		}
	}

}
