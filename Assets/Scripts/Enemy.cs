using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [Header("Projétil")]
    [SerializeField] float minShootTime = 1f;
    [SerializeField] float maxShootTime = 5f;
    [SerializeField] GameObject projectilePreFab;
    [SerializeField] GameObject gun;

    [Header("Efeito sonoro do tiro")]
    [SerializeField] AudioClip shootAFX;
    [SerializeField] float shootAFXvolume = 1f;
    
    float waitToShoot;

    bool shoot = true;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShootProjectile());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ShootProjectile()
    {
        while (shoot)
        {
            waitToShoot = Random.Range(minShootTime, maxShootTime);
            yield return new WaitForSeconds(waitToShoot);
            Fire();
        }
    }

    private void Fire()
    {
        GameObject newProjectile = Instantiate(projectilePreFab, transform.position, Quaternion.identity) as GameObject;
        newProjectile.transform.position = gun.transform.position;
        newProjectile.transform.parent = gameObject.transform;
        AudioSource.PlayClipAtPoint(shootAFX, Camera.main.transform.position, shootAFXvolume);

    }
}
