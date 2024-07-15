using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTeleport : MonoBehaviour
{
    [SerializeField]
    private Vector2 attackRadius;
    [SerializeField]
    private LayerMask whatIsStar;
    [SerializeField]
    private Transform reSpawnTrans;

    private void Update()
    {
        Collider2D star = Physics2D.OverlapBox(transform.position, attackRadius, whatIsStar); //�ϳ� ��������
                                                                                                            //All �� �ȿ� �ִ� �� ��δ� �迭��
        if (star)
        {
            var starTrans = star.GetComponent<Transform>();
            starTrans.position = reSpawnTrans.position;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(transform.position, attackRadius);
    }
}
