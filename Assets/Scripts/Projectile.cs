using UnityEngine;

public class PlayerfireRangedWeaponing : MonoBehaviour
{
    public int shotDmg = 10;
    public float fireRate = 0.10f;
    public float shotRange = 150f;


	/*Scripter Notes (Vuk Ristic)
	 * This script has no visuals, but the code works.
	 * Things to do:
	 * - Add a custom-made particle effect
	 * - Add a custom made muzzle flash
	 * - Add visual bullet-time travel effects
	 * 
	 * Things that are done:
	 * - Secure, performance-oriented, ranged weapon script
	 * - 	Projectile resets position once it goes out of scope (shotRange).
	 * 		Said projectile will also enable multiple shots to be fired, once
	 * 		it reaches end of scope.  The distances can be set in these vars
	 * 		bellow.
	 * - 	Configured for drag-n-drop, but the dev will have to adhere to the
	 * 		class call-back functions listed bellow.
	 */


    float realTime;
    Ray gun_LaserPoint;
    RaycastHit shootHit;
    int shootableMask;
    ParticleSystem gunParticles;
    LineRenderer gunLine;
    float effectsDisplayTime = 0.2f;


    void Awake () //unity universal class for player with 0 health or more
    {
        shootableMask = LayerMask.GetMask ("fireRangedWeaponable");
        gunLine = GetComponent <LineRenderer> ();
    }


    void Update () //realTime timer that updates in-game events, live.
    {
        realTime += Time.deltaTime;

        if(realTime >= fireRate * effectsDisplayTime)
        {
            DisableEffects ();
        }

		if(Input.GetButton ("Fire1") && realTime >= fireRate)
		{
			fireRangedWeapon ();
		}

    }

    void fireRangedWeapon () //weapon shooting class (VR)
    {
        realTime = 0f;

        gunLine.enabled = true;
        gunLine.SetPosition (0, transform.position);

        gun_LaserPoint.origin = transform.position;
        gun_LaserPoint.direction = transform.forward;

        if(Physics.Raycast (gun_LaserPoint, out shootHit, shotRange, shootableMask))
        {
            EnemyHealth enemyHealth = shootHit.collider.GetComponent <EnemyHealth> ();
            if(enemyHealth != null)
            {
                enemyHealth.TakeDamage (shotDmg, shootHit.point);
            }
            gunLine.SetPosition (1, shootHit.point);
        }
        else
        {
            gunLine.SetPosition (1, gun_LaserPoint.origin + gun_LaserPoint.direction * shotRange);
        }
    }
}
