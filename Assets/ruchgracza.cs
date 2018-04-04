using UnityEngine;

public class ruchgracza : MonoBehaviour {

	public float spid = 6f;
	public float predkoscskoku = 6f;
	private Rigidbody rb;
	private Collider cll;
	private FixedJoystick joystick;
	private guzikskakania skok;
	
	

	void Awake () {
		rb = GetComponent<Rigidbody>();
		cll = GetComponent<SphereCollider> ();
		joystick = FindObjectOfType<FixedJoystick>();
		skok = FindObjectOfType<guzikskakania>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		
		//natychmiastowa zmiana kierunku ruchu gracza - bez hamowania
		if ((rb.velocity.x < 0 && joystick.Horizontal < 0) || (rb.velocity.x > 0 && joystick.Horizontal > 0))
			rb.velocity = new Vector3 (0, rb.velocity.y, rb.velocity.z);
		
		if ((rb.velocity.z < 0 && joystick.Vertical < 0) || (rb.velocity.z > 0 && joystick.Vertical > 0))
			rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, 0);
		
		//skakanie
		if (skok.skokWcisniety && naziemi())
			rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y + predkoscskoku, rb.velocity.z);

		rb.AddForce (-joystick.Horizontal * spid, 0, -joystick.Vertical * spid);



	}

	bool naziemi(){
		return Physics.Raycast(transform.position, Vector3.down, maxDistance: cll.bounds.extents.y+0.1f);
	}
	
}
