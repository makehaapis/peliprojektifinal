using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelSelector : MonoBehaviour
{
    public Button[] levelButtons;

    public void Start()
    {
        int levelReached = PlayerPrefs.GetInt("reachedLevel", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
            {
                levelButtons[i].interactable = false;
            }
        }
    }

    public void loadLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void loadLevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void loadLevel3()
    {
        SceneManager.LoadScene(5);
    }

    public void loadLevel4()
    {
        SceneManager.LoadScene(6);
    }
    public void loadLevel5()
    {
        SceneManager.LoadScene(7);
    }
    public void loadLevel6()
    {
        SceneManager.LoadScene(8);
    }
    public void loadLevel7()
    {
        SceneManager.LoadScene(9);
    }
    public void loadLevel8()
    {
        SceneManager.LoadScene(10);
    }
}
