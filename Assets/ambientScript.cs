using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ambientScript : MonoBehaviour {

    public float czasPierwszegoSpawnu = 5f;
    public float czasSpawnów = 2f;
	public GameObject item;
	Scene thescene;
	string scenename;

    void Start () {
		InvokeRepeating("spawnProp", czasPierwszegoSpawnu, czasSpawnów);
		thescene = SceneManager.GetActiveScene();
		scenename = thescene.name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void spawnProp(){
		Instantiate(item, new Vector3(Random.Range(-19f, 19f), -0.5f, Random.Range(-19f, 19f)), item.transform.rotation);
	}

	public void death(){
		SceneManager.LoadScene(scenename);
	}
}
