using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}

	public void LoadLevel()
	{
		SceneManager.LoadScene ("Main");
//		Application.LoadLevel (0);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
