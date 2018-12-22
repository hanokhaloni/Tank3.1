using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {
	[SerializeField]
	private float sizeX=0;

	[SerializeField]
	private float sizeY=0;



	[SerializeField]
	private GameObject templateTile=null;

	[SerializeField]
	private float locationScale = 0.2f;

	// Use this for initialization
	void Start () {
		for (int x = 0; x < sizeX; x++) {
			for (int y = 0; y < sizeY; y++) {
				GameObject tile = Instantiate (templateTile, new Vector3 (x * sizeX * locationScale, y * sizeY * locationScale, 0), Quaternion.identity) as GameObject;

				tile.name = string.Format ("[{0},{1}]", x, y);
				Debug.Log ("Created tile " + tile.name);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
