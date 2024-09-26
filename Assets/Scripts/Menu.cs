using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void InicioJogo()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    public void MudaCena()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
