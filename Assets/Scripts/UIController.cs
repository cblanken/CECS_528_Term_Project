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

    public void ExitGame()
    {
        EditorApplication.ExecuteMenuItem("Edit/Play");
    }

}


