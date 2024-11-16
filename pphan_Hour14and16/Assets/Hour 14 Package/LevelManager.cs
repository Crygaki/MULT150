using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "game_Description";


	public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
