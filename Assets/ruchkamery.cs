using UnityEngine;

public class ruchkamery : MonoBehaviour {


	public Transform gracz;
	// Use this for initialization
	void Awake () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (gracz);
		transform.position = Vector3.Lerp (transform.position, gracz.position +new Vector3(0, 6, 10), Time.deltaTime);

	}
}
