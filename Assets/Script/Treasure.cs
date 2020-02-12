﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    GameObject clickedGameObject;
    public int value;

    public string tresureName;
    //public Scorebord scorebord;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        //UpdateScore(scorebord.Score());

        if (Input.GetMouseButtonDown(0))
        {

            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit))
            {

                clickedGameObject = hit.collider.gameObject;
                GameObject scoreTextGo = GameObject.Find("Score");
            scoreTextGo.SendMessage("OnScore", value);
                
                this.gameObject.SetActive(false);
            }

            Debug.Log(clickedGameObject);
        }
    }

    /*
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject scoreTextGo = GameObject.Find("Score");
            scoreTextGo.SendMessage(tresureName, value);
            this.gameObject.SetActive(false);
        }
    }
    */
}
