using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInterection
{
    public void Interection();
}

public class PlayerInterection : MonoBehaviour
{
    [SerializeField]
    private float attackRadius = 1f;
    [SerializeField]
    private LayerMask whatIsPlayer;

    // Update is called once per frame
    void Update()
    {
        Collider2D collision = Physics2D.OverlapCircle(transform.position, attackRadius, whatIsPlayer); //�ϳ� ��������
                                                                                                        //All �� �ȿ� �ִ� �� ��δ� �迭��
        if (collision && Input.GetKeyDown(KeyCode.E))
        {
            var lever = collision.GetComponent<IInterection>();
            lever?.Interection();
        }
    }
}
