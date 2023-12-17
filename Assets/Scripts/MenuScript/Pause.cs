using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public GameObject PauseObjet;
    public GameObject Parametres;
    public GameObject Sure;
    public bool ispaused ;


    public GameObject Carcomponents ;

    public GameObject RightHandJeu ;
    public GameObject RightHandPause ;
    public GameObject LeftHandJeu ;
    public GameObject LeftHandPause ; 
    public GameObject GameObjectJeu ;

    

    // Start is called before the first frame update
    void Start()
    {
        ispaused = true;
        PauseObjet.SetActive(true) ;
        
    }

    // Update is called once per frame
    void Update()
    {


    }



    public void Recommencer()
    {
        SceneManager.LoadScene("PrioritéV2"); 
        //ajouter une script pour passer à la scene du jeu 
    }

    public void Reprendre()
    {
        PauseObjet.SetActive(false);
        ispaused = false;
        Time.timeScale = 1;
        Carcomponents.SetActive(true) ;
        RightHandPause.SetActive(false) ;
        LeftHandPause.SetActive(false) ;
        RightHandJeu.SetActive(true) ;
        LeftHandJeu.SetActive(true) ;
        GameObjectJeu.SetActive(true) ;
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void GoToMainMenu()
    {
        // Désactive le panneau actuel (pause)
        PauseObjet.SetActive(false);

        // Active le panneau du menu principal
        Sure.SetActive(true);

    }
    public void GoToParameters()
    {
       PauseObjet.SetActive(false);
       Parametres.SetActive(true) ; 
    }



}