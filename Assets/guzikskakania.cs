using UnityEngine;

public class guzikskakania : MonoBehaviour {

	public bool skokWcisniety;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void wcisniety(){
		skokWcisniety = true;
	}
	public void puszczony(){
		skokWcisniety = false;
	}
}
