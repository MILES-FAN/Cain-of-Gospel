using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    public float speed;
    public float waitTime;
    public Transform[] movePos;

    private int i;
    private Transform playerTrans;
    // Start is called before the first frame update
    void Start()
    {
        i= 1;
        playerTrans = GameObject.FindGameObjectWithTag("Player").transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        moveBF();
    }

    void moveBF() 
    {
        // �����ƶ�
        transform.position = Vector2.MoveTowards(transform.position, movePos[i].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, movePos[i].position) < 0.1f)
        {
            if (waitTime < 0.0f)
            {
                if (i == 0)
                {
                    i = 1;
                }
                else
                {
                    i = 0;
                }
                waitTime = 0.5f;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }

   
    private void OnTriggerEnter2D(Collider2D col)
    {
        //�ж��Ƿ���ƽ̨�ϣ������ƽ̨��ʱ���ƽ̨������
        if (col.gameObject.CompareTag("Player"))
        {
            col.gameObject.transform.parent = gameObject.transform;
        }
          
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        //�뿪ƽ̨
        if (col.gameObject.CompareTag("Player"))
        {
            col.gameObject.transform.parent = playerTrans;
        }
    }
}
