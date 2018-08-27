using UnityEngine;

public class obracanieitemow : MonoBehaviour {

	private texthandler licznik;
	
	// Use this for initialization
	void Awake () {
		licznik = FindObjectOfType<texthandler>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(15, 30, 45)*Time.deltaTime);
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
			licznik.add1more();
			Destroy(gameObject);
		}
	}
}
