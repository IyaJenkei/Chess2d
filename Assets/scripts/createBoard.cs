using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBoard : MonoBehaviour {
	
	public Transform[] spawnLocations;
	public GameObject[] allPrefabs;
	public GameObject[] prefabsClone;

	void spawnBoard() {
		var incrementSize = 0.64f;
		var darkVectorx = 0f - incrementSize;
		var darkVectory = 0f - incrementSize;
		var lightVectorx = -.32f;
		var lightVectory = -.64f;
		var vectorz = .02f;

		prefabsClone [2] = Instantiate (allPrefabs [2], new Vector3 (0, 0, -.01f), transform.rotation);

		for (float i = 0; i < 4; i++) {
			prefabsClone [0] = Instantiate (allPrefabs [0], new Vector3 (darkVectorx += incrementSize, darkVectory + incrementSize, vectorz), transform.rotation);
			prefabsClone [0] = Instantiate (allPrefabs [0], new Vector3 (darkVectorx + (incrementSize * .5f), darkVectory + (incrementSize * 1.5f), vectorz), transform.rotation);
			prefabsClone [0] = Instantiate (allPrefabs [0], new Vector3 (darkVectorx, darkVectory + (incrementSize * 2f), vectorz), transform.rotation);
			prefabsClone [0] = Instantiate (allPrefabs [0], new Vector3 (darkVectorx + (incrementSize * .5f), darkVectory + (incrementSize * 2.5f), vectorz), transform.rotation);
			prefabsClone [0] = Instantiate (allPrefabs [0], new Vector3 (darkVectorx, darkVectory + (incrementSize * 3f), vectorz), transform.rotation);
			prefabsClone [0] = Instantiate (allPrefabs [0], new Vector3 (darkVectorx + (incrementSize * .5f), darkVectory + (incrementSize * 3.5f), vectorz), transform.rotation);
			prefabsClone [0] = Instantiate (allPrefabs [0], new Vector3 (darkVectorx, darkVectory + (incrementSize * 4f), vectorz), transform.rotation);
			prefabsClone [0] = Instantiate (allPrefabs [0], new Vector3 (darkVectorx + (incrementSize * .5f), darkVectory + (incrementSize * 4.5f), vectorz), transform.rotation);


			prefabsClone [1] = Instantiate (allPrefabs [1], new Vector3 (lightVectorx += incrementSize, lightVectory + incrementSize, vectorz), transform.rotation);
			prefabsClone [1] = Instantiate (allPrefabs [1], new Vector3 (lightVectorx - (incrementSize * .5f), lightVectory + (incrementSize * 1.5f), vectorz), transform.rotation);
			prefabsClone [1] = Instantiate (allPrefabs [1], new Vector3 (lightVectorx, lightVectory + (incrementSize * 2f), vectorz), transform.rotation);
			prefabsClone [1] = Instantiate (allPrefabs [1], new Vector3 (lightVectorx - (incrementSize * .5f), lightVectory + (incrementSize * 2.5f), vectorz), transform.rotation);
			prefabsClone [1] = Instantiate (allPrefabs [1], new Vector3 (lightVectorx, lightVectory + (incrementSize * 3f), vectorz), transform.rotation);
			prefabsClone [1] = Instantiate (allPrefabs [1], new Vector3 (lightVectorx - (incrementSize * .5f), lightVectory + (incrementSize * 3.5f), vectorz), transform.rotation);
			prefabsClone [1] = Instantiate (allPrefabs [1], new Vector3 (lightVectorx, lightVectory + (incrementSize * 4f), vectorz), transform.rotation);
			prefabsClone [1] = Instantiate (allPrefabs [1], new Vector3 (lightVectorx - (incrementSize * .5f), lightVectory + (incrementSize * 4.5f), vectorz), transform.rotation);
		}


	}

	void spawnPieces () {
		spawnPawns ();
		spawnKnights ();
		//spawnBishops ();
		//spawnRooks ();
		//spawnQueens ();
		//spawnKings ();
	}

	void spawnKnights () {
		
	}

	void spawnPawns () {
		var incrementSize = 0.32f;
		var lightVectorx = 0f - incrementSize;
		var lightVectory = incrementSize;
		var darkVectorx = 0f - incrementSize;
		var darkVectory = incrementSize * 6;
		var vectorz = -.03f;

		for (float i = 0; i < 8; i++) {
			prefabsClone [3] = Instantiate (allPrefabs [3], new Vector3 (lightVectorx += incrementSize, lightVectory, vectorz), transform.rotation);
		}
		for (float i = 0; i < 8; i++) {
			prefabsClone [4] = Instantiate (allPrefabs [4], new Vector3 (darkVectorx += incrementSize, darkVectory, vectorz), transform.rotation);
		}
	}

	void Start () {
		spawnBoard ();
		spawnPieces ();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
