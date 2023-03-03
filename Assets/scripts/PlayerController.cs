using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public GameObject projectilePrefab;
    public float speed = 10.0f;
    public float xRange = 10;

    public float fadeDuration = 1f;
    float m_Timer;
    public static int life = 3;
    public CanvasGroup gameoverBackgroundImageCanvasGroup;


    // Update is called once per frame
    void Update()
    {
        if(life==0){
            m_Timer += Time.deltaTime;
            gameoverBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration;
        }

        //캐릭터 범위 안에 유지
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }  
        
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //플레이어가 발사체 발사
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        horizontalInput =  Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
