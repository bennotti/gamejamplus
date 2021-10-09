using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] float minShootTime = 1f;
    [SerializeField] float maxShootTime = 5f;
    float waitToShoot;
    [SerializeField] GameObject projectilePreFab;
    [SerializeField] GameObject gun;

    bool shoot = true;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Shoot()
    {
        while (shoot)
        {
            waitToShoot = Random.Range(minShootTime, maxShootTime);
            yield return new WaitForSeconds(waitToShoot);
            GameObject newProjectile = Instantiate(projectilePreFab, transform.position, Quaternion.identity) as GameObject;
            newProjectile.transform.position = gun.transform.position;
            newProjectile.transform.parent = gameObject.transform;
        }
    }

}
