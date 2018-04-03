using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambientScript : MonoBehaviour {

    public float czasPierwszegoSpawnu = 5f;
    public float czasSpawnów = 2f;
	public GameObject item;

    // Use this for initialization
    void Start () {
		InvokeRepeating("spawnProp", czasPierwszegoSpawnu, czasSpawnów);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void spawnProp(){
		Instantiate(item, new Vector3(Random.Range(-19f, 19f), -0.5f, Random.Range(-19f, 19f)), item.transform.rotation);
	}
}
