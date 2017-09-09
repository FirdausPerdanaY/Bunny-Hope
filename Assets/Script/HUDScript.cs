using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {

	int playerScore =0;
	int redScore=0;
	int blueScore=0;
	int greenScore=0;
	int score;
	public Text red;
	public Text blue;
	public Text green;
	public Text total;
	public Text HighScore;
	private int HScore;
	bool nscore = false;

	void Awake()
	{
		HScore = PlayerPrefs.GetInt ("HScore",HScore);
		//red.text = "Score1: " ;
	}

	// Update is called once per frame
	void Update () {
		//playerScore += playerScore;
	}


	public void IncreaseScore(int amount,string id)
	{
		if (id == "red") {
			redScore += amount;
			amount = amount * 5;
		} else if (id == "blue") {
			blueScore += amount;
			amount = amount * 10;
		} else if (id == "green") {
			greenScore += amount;
			amount = amount * 20;

		}
		
		playerScore += amount;

	}
	void OnGUI()
	{
		red.text = "\t : "+ (int)(redScore) ;
		blue.text = "\t : "+ (int)(blueScore) ;
		green.text = "\t : "+ (int)(greenScore) ;
		total.text = "Total : "+ (int)(playerScore) ;


		if (playerScore > HScore) {
			nscore = true;
			HighScore.text = "Rekor Terbaru\n" + (int)(playerScore)+
				"\nSkor Tertinggi Sebelumnya\n" + (int)(HScore);
		PlayerPrefs.SetInt ("HScore", playerScore);
		}
		else if (nscore==false){
			HighScore.text = "Skor Tertinggi\n" + (int)(HScore) +
				"\nSkor Sekarang\n" + (int)(playerScore);
		}


	//	GUI.Label (new Rect (7, 3, 100, 30), "Score: " + (int)(playerScore));
	}
	void LastScore(){
		
	}
}
