using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayPlatorm : MonoBehaviour
{
    public float speed;
    public Transform movePos;
    public GameObject trigger;

    private bool activated;

   
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activated)
        {
            moving();
        }
    }

    void moving()
    {
        //ƽ̨�ƶ�
        transform.position = Vector2.MoveTowards(transform.position, movePos.position, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //�жϽӴ�������ʵ�ַ����е�֣��Ұ�����������ײ����ڰ�ť��λ����Ȼ��ʹ���������
        //��Ϊ�Ҳ�֪����ô������ļ����ⰴť�Ǹ�ͼ�����ײ����������Ҿ͸ɴ�ֱ�Ӱ�ƽ̨����ײ����ڰ�ť��ͼ����Ȼ�����˸�trigger
        //ƽ̨�����ס���Ǹ���ײ����Ū�˸������壬��������������Ǵ���������ײ��䵱�ذ�
        if (other.gameObject.CompareTag("Player"))
        {
            activated = true;
        }
    }


}
