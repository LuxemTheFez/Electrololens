using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSiteProd : MonoBehaviour
{

    public GameObject objet;
    Camera camera;

    public void CreateNewSiteProd()
    {
        GameObject plateforme = GameObject.FindGameObjectsWithTag("Plateforme")[0].transform.GetChild(1).gameObject;
        camera = Camera.main;
        Vector3 camVect;
        Vector3 camForward = Camera.current.transform.forward;
        camVect = Camera.current.transform.position + new Vector3(Vector3.Dot(camForward, new Vector3(1f, 0f, 0f)), 0f, Vector3.Dot(camForward, new Vector3(0f, 0f, 1f))) * 1.2f;
        GameObject go = (GameObject)Instantiate(objet, camVect, Quaternion.identity);
        go.transform.parent = plateforme.transform;
        go.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
        Vector3 scale = plateforme.transform.GetChild(0).localScale;
        go.transform.localScale = scale;
        //Positionne le nouveau site au centre de la zone de jeu
    }
}