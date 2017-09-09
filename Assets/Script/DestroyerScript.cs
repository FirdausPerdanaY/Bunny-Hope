using UnityEngine;


public class DestroyerScript : MonoBehaviour {
	private CameraRunnerScript script;
	HUDScript score;

	[SerializeField]
	private GameObject Button,Back,Kalah,Score;
	public AudioSource main,end;


	void OnTriggerEnter2D (Collider2D other)
	{
		score = GetComponent<HUDScript> ();
		
		if (other.tag == "Player") {
			Back.SetActive (true);
			Button.SetActive (true);
			Kalah.SetActive (true);
			Score.SetActive (false);
			main.Stop ();
			end.Play ();
			//score.LastScore ();


			Time.timeScale = 0;


			//Debug.Break ();
			return;

		}
		else if (other.gameObject.transform.parent)
			Destroy (other.gameObject.transform.parent.gameObject);
		else {
			Destroy (other.gameObject);
		}

	}
}
