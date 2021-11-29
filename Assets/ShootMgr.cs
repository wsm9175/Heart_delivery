using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMgr : MonoBehaviour
{

    [SerializeField]
    GameObject m_ballPrefab;

    public void Shoot() {
        var newBall = Instantiate(m_ballPrefab);
        newBall.transform.position = transform.position;
        newBall.GetComponent<Rigidbody>().AddForce(transform.forward * 300);
    }
}   
