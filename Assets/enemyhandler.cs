using UnityEngine;

public class enemyhandler : MonoBehaviour {
	
	public Transform graczol;
	public float predkoscwroga = 2f;

	void Awake(){

	}

	void Start () {
		
	}
	

	void Update () {
	transform.LookAt(new Vector3(graczol.position.x, transform.position.y, graczol.position.z));
	transform.position += transform.forward*predkoscwroga*Time.deltaTime;
	}
}
