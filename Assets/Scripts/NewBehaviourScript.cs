using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene("platformer");
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}
