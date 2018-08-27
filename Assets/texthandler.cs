using UnityEngine;
using UnityEngine.UI;

public class texthandler : MonoBehaviour {

	private Text tekscik;

	void Awake(){
		tekscik = GetComponent<Text>();
		tekscik.text = "Zebrane kloce: " + PlayerPrefs.GetInt("pkt", 0);
	}
	public void add1more(){
		int lpkt = PlayerPrefs.GetInt("pkt", 0);
			lpkt++;
			PlayerPrefs.SetInt("pkt", lpkt);
			tekscik.text = "Zebrane kloce: " + lpkt;
	}


}
