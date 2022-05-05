using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Escape : MonoBehaviour
{
    [SerializeField]
    GameObject go;
    bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        go.SetActive(false);
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isActive == false)
            {
                go.SetActive(true);
                isActive = true;
            }
            else
            {
                go.SetActive(false);
                isActive = false;
            }
        }
    }
    public void ShutDownMenu()
    {
        go.SetActive(false);
    }
    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
