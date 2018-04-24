using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;


public class UIController : MonoBehaviour
{
    public void StartGame()
    {
        Load_Level_01();
    }

    public void Load_Level_01()
    {
        SceneManager.LoadScene("Level_01", LoadSceneMode.Additive);
    }

    public void Reload_Level_01()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        //SceneManager.UnloadSceneAsync(1);
        SceneManager.LoadScene(currentScene);
    }

    public void Reload_Level_02()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.UnloadSceneAsync(2);
        SceneManager.LoadScene(currentScene);
    }

    public void ExitGame()
    {
        EditorApplication.ExecuteMenuItem("Edit/Play");
    }

}


