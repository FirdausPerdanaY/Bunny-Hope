using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit_Game : MonoBehaviour {

	// Use this for initialization
	public void Quit () {
		Application.Quit ();
		Debug.Log ("keluar");
	}
	
	// Update is called once per frame
	public void Restart () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
		
	}
	public void Home()
	{
		SceneManager.LoadScene ("Menu");
		Time.timeScale = 1;
	}
}
