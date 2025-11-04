using UnityEngine;

public class BatW6 : MonoBehaviour
{
    public Transform player;      
    public float speed = 3f;     
    public float reachDistance = 0.5f;  

    private bool isChasing = false;
    private bool hasShown = false;


    void Update()
    {
        if (player == null) return;

        if (isChasing)
        {
            // 移动到玩家位置
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

            // 检查是否到达玩家
            float dist = Vector3.Distance(transform.position, player.position);
            if (dist <= reachDistance)
            {
                OnReachPlayer();
            }
        }
    }

    public void StartChasing()
    {
        isChasing = true;
    }

    public void StopChasing()
    {
        isChasing = false;
    }

    private void OnReachPlayer()
    {
        if (!hasShown)
        {
            hasShown = true;
            Debug.Log($"{gameObject.name}: Gotcha!");
        }
        StopChasing();
    }

    void OnEnable()
    {
        hasShown = false;
    }
}