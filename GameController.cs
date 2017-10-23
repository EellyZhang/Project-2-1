using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject cubePrefab;
	Vector3 cubePosition;
	public static GameObject selectedCube;


	// Use this for initialization
	void Start () {

		for (int y = -4; y < 5; y++)
		for (int x = -8; x < 8; x++)
		{
			cubePosition = new Vector3 (x*2, y*2, 0);
			Instantiate(cubePrefab, cubePosition, Quaternion.identity);
		}
	}



	public static void ProcessClick (GameObject clickCube) {
		if (selectedCube != null) {
			selectedCube.GetComponent<Renderer>().material.color = Color.white;
			}

		clickCube.GetComponent<Renderer>().material.color = Color.red;
		selectedCube = clickCube;
		}
	// Update is called once per frame
	//void Update () {
				
	//}
}