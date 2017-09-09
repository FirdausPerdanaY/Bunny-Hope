using UnityEngine;

public class PowerUpScript : MonoBehaviour {

	HUDScript hud;
	//Collider2D power;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag=="Player")
		{
			hud = GameObject.Find ("Main Camera").GetComponent<HUDScript> ();

			if (this.tag == "PowerUpRed")
				hud.IncreaseScore (1,"red");
			else if (this.tag == "PowerUpBlue")
				hud.IncreaseScore (1,"blue");
			else if (this.tag == "PowerUpGreen")
				hud.IncreaseScore (1,"green");
			Destroy (this.gameObject);

		}
	}
}
