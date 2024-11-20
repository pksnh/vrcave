using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToPlace : MonoBehaviour
{

    public string goStageName;

    public void Go()
    {
        SceneManager.LoadScene(goStageName);
    }
}
