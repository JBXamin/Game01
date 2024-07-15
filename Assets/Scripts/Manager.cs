using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public int packagesInGame;
    public static bool deli = false;
    public TMP_Text pL;
    public TMP_Text cL;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (packagesInGame == 0 || Delivery.carLives<=0)
        {
            SceneManager.LoadScene(0);
            packagesInGame = 3;
            Delivery.carLives = 5;
        }
        if (deli)
        {
            packagesInGame --;
            deli = false;
        }
        pL.text = packagesInGame.ToString();
        cL.text = Delivery.carLives.ToString();
    }
}
