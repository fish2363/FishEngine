using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatTrigger : MonoBehaviour
{
    private ChatManager chatManager;

    [SerializeField]
    private float waitSecond;

    private void Awake()
    {
        chatManager = FindAnyObjectByType<ChatManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            chatManager.Text(int.Parse(gameObject.name.Substring(0, 1)), waitSecond);
            Destroy(gameObject);
        }
    }
}
