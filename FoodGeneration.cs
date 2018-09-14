using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour {

    public float xPlaneSize = 18f;
    public float zPlaneSize1 = 2f;
    public float zPlaneSize2 = 38f;


    public GameObject foodPrefab;
    public GameObject currentFood;
    public Vector3 currentPos;

	public void Start () {
        RndPosition();
        currentFood = GameObject.Instantiate(foodPrefab,currentPos, Quaternion.identity) as GameObject;
	}

    public void RndPosition () {
        currentPos = new Vector3(Random.Range(xPlaneSize * -1, xPlaneSize), 0.5f, Random.Range(zPlaneSize1,zPlaneSize2));
    }

}
