using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class TestGame : MonoBehaviour
{
    public GameObject target;

    private void Update()
    {
        Vector3 dis3D = target.transform.position - transform.position;
        // Vector2 dis2D = new Vector2(dis3D.x, dis3D.y);
        transform.right = dis3D.normalized;
    }
}
