using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //For reloading a scene to replay or restart the game

public class GameManager : MonoBehaviour
{
    private float elapsedTime = 0;
	private bool isRunning = false;

    public GoalScript blue, green, red, orange;
    public ChaosGoalScript chaos;
    private bool isGameOver = true;

    // Start is called before the first frame update
    void Start()
    {
        //Start the timer at 0 second
        elapsedTime = 0;
		isRunning = true;
    }

    //Play the game again
    void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //Quit the game
    void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Add time to the clock if the game is running
		if (isRunning)
		{
			elapsedTime = elapsedTime + Time.deltaTime;
		}

        //If all five goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && chaos.isSolvedChaos;
    }

    void OnGUI()
    {
        if(isGameOver)
        {
            //End the timer
            isRunning = false;
            
            //Let the player know the game is over
            Rect rect = new Rect(Screen.width/2-100, Screen.height/2-50, 200, 75);
            GUI.Box(rect, "Game Over!");
            //Congratulate the player
            Rect rect2 = new Rect(Screen.width/2-30, Screen.height/2-25, 60, 50);
            GUI.Label(rect2, "Good Job!");
            //Display the time it took to win the game
            Rect rect3 = new Rect(Screen.width/2-70, Screen.height/2, 350, 25);
            GUI.Label(rect3, "Your Time: " + ((int)elapsedTime).ToString() + " Seconds!");

            //Replay the game button
            string playAgainMessage = "Click Here or Press Enter to Play Again";
			Rect playAgainButton = new Rect(Screen.width/2-120, Screen.height/2+50, 240, 30);
			if (GUI.Button(playAgainButton, playAgainMessage) || Input.GetKeyDown(KeyCode.Return))
			{
				//Restart the game if the user clicks the button or press Enter key
				PlayAgain();
			}

            //Quit the game button
            string quitMessage = "Click Here or Press X to Quit";
			Rect quitButton = new Rect(Screen.width/2-120, Screen.height/2+100, 240, 30);
			if (GUI.Button(quitButton, quitMessage) || Input.GetKeyDown(KeyCode.X))
			{
				//Exit the game if the user clicks the button or press X key
				QuitGame();
			}
        }
        else if(isRunning)
		{ 
			// If the game is running, show the current time
			GUI.Box(new Rect(Screen.width/2-65, Screen.height-115, 130, 40), "Your Time Is");
			GUI.Label(new Rect(Screen.width/2-10, Screen.height-100, 20, 30), ((int)elapsedTime).ToString());
		}
    }
}
