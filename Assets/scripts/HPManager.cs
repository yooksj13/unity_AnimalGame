using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManager : MonoBehaviour
{
    public GameObject eggS1;
    public GameObject eggS2;
    public GameObject eggS3;
    public GameObject eggB1;
    public GameObject eggB2;
    public GameObject eggB3;

    void Start(){
        eggS1.GetComponent<Image>().enabled = true;
        eggS2.GetComponent<Image>().enabled = true;
        eggS3.GetComponent<Image>().enabled = true;
        eggB1.GetComponent<Image>().enabled = false;
        eggB2.GetComponent<Image>().enabled = false;
        eggB3.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerController.life==2){
            eggS3.GetComponent<Image>().enabled = false;
            eggB3.GetComponent<Image>().enabled = true;
        }
        else if(PlayerController.life==1){
            eggS3.GetComponent<Image>().enabled = false;
            eggS2.GetComponent<Image>().enabled = false;
            eggB3.GetComponent<Image>().enabled = true;
            eggB2.GetComponent<Image>().enabled = true;
        }
        else if(PlayerController.life==0){
            eggS3.GetComponent<Image>().enabled = false;
            eggS2.GetComponent<Image>().enabled = false;
            eggS1.GetComponent<Image>().enabled = false;
            eggB3.GetComponent<Image>().enabled = true;
            eggB2.GetComponent<Image>().enabled = true;
            eggB1.GetComponent<Image>().enabled = true;
        }
    }
}
