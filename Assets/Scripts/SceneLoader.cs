using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
	[SerializeField]
	private string sceneToLoad; // Serialized field for scene name

	// Function to be called when the button is clicked
	public void LoadScene()
	{
		foreach (Touch touch in Input.touches)
		{
			if (touch.phase == TouchPhase.Began)
			{
				// Load the specified scene
				SceneManager.LoadScene(sceneToLoad);
			}
		}
	}
}
