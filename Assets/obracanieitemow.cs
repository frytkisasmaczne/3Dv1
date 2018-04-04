using UnityEngine;
using UnityEngine.UI;

public class obracanieitemow : MonoBehaviour {

	
	private Text licznik;
	// Use this for initialization
	void Awake () {
		licznik = Text.FindObjectOfType<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(15, 30, 45)*Time.deltaTime);
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
			int lpkt = PlayerPrefs.GetInt("pkt", 0);
			lpkt++;
			PlayerPrefs.SetInt("pkt", lpkt);
			licznik.text = "Zebrane kloce: " + lpkt;
			Destroy(gameObject);
		}
	}
}
