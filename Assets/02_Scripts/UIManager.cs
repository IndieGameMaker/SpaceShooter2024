using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("Level01");
        SceneManager.LoadScene("InGame", LoadSceneMode.Additive);
    }
}
