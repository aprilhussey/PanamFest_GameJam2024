using Cinemachine;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	private Vector2 lookInput;

	[SerializeField]
	public bool Inverted;

	[Header("Camera")]
	[SerializeField]
	private GameObject cameraTarget;

	[SerializeField]
	private CinemachineVirtualCamera aimVirtualCamera;

	private Vector3 mouseWorldPosition = new Vector3();
	private Vector2 screenCenterPoint = new Vector2();

	private float cameraSensitivity;
	[SerializeField]
	[Tooltip("Camera sensitivity when NOT aiming")]
	private float cameraMainSensitivity = 5f;  // Camera sensitivity when NOT aiming
	[SerializeField]
	[Tooltip("Camera sensitivity when aiming")]
	private float cameraAimSensitivity = 2.5f;   // Camera sensitivity when aiming

	[SerializeField]
	[Tooltip("Minimum vertical rotation of the CameraTarget gameobject")]
	float minVerticalRotation = -80f;   // Define min rotation
	[SerializeField]
	[Tooltip("Maximum vertical rotation of the CameraTarget gameobject")]
	float maxVerticalRotation = 80f;   // Define max rotation

	[Header("Raycast")]
	[SerializeField]
	private float raycastRange = 200f;
	[SerializeField]
	private float projectileSpeed = 30f;

	private Transform hitTransform = null;
	private float hitDistance;
	[SerializeField]
	private Transform debugTransform;

	[Header("Crosshair")]
	[SerializeField]
	private GameObject mainCrosshair;
	[SerializeField]
	private GameObject aimCrosshair;

	[Header("VFX")]
	[SerializeField]
	private GameObject vfxHitGreen;
	[SerializeField]
	private GameObject vfxHitRed;

	[Header("Cooldown")]
	public float cooldownTime = .5f;
	[HideInInspector]
	public float cooldownTimer = 0;

	void Awake()
	{
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;

		mouseWorldPosition = Vector3.zero;
		screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);
	}

	void Start()
	{
		aimVirtualCamera.gameObject.SetActive(false);

		mainCrosshair.SetActive(true);
		aimCrosshair.SetActive(false);
	}

	void Update()
	{
		// LOOK //
		// Keep track of current rotation
		float verticalRotation = cameraTarget.transform.localEulerAngles.x;

		// Rotate the player and camera based on lookInput
		if (lookInput != Vector2.zero)
		{
			// Calculate new rotation
			float newVerticalRotation = verticalRotation - lookInput.y * cameraSensitivity;

			// Adjust for 360 degree system
			if (newVerticalRotation > 180)
			{
				newVerticalRotation -= 360;
			}

			// Clamp rotation to min and max angles
			verticalRotation = Mathf.Clamp(newVerticalRotation, minVerticalRotation, maxVerticalRotation);

			// Apply rotation
			cameraTarget.transform.localEulerAngles = new Vector3(verticalRotation, 0, 0);
			this.transform.Rotate(Vector3.up, lookInput.x * cameraSensitivity);
		}

		if (cooldownTimer > 0)	// If in cooldown
		{
			cooldownTimer -= Time.deltaTime;
		}
	}

	public void OnLook(InputAction.CallbackContext context)
	{
		if (!Inverted)
		{
            if (context.phase == InputActionPhase.Started || context.phase == InputActionPhase.Performed)
            {
                lookInput = context.ReadValue<Vector2>();
                //Debug.Log(context.ReadValue<Vector2>());
            }
            else if (context.phase == InputActionPhase.Canceled)
            {
                lookInput = Vector2.zero;
            }
        }
		else if (Inverted)
		{
            if (context.phase == InputActionPhase.Started || context.phase == InputActionPhase.Performed)
            {
                lookInput = -context.ReadValue<Vector2>();
                //Debug.Log(context.ReadValue<Vector2>());
            }
            else if (context.phase == InputActionPhase.Canceled)
            {
                lookInput = Vector2.zero;
            }
        }

	}

	public void OnAim(InputAction.CallbackContext context)
	{
		if (context.action.triggered)
		{
			if (!aimVirtualCamera.gameObject.activeInHierarchy)
			{
				cameraSensitivity = cameraAimSensitivity / 10;  // Divided by 10 to get the correct value
				aimVirtualCamera.gameObject.SetActive(true);

				mainCrosshair.SetActive(false);
				aimCrosshair.SetActive(true);
			}
			else
			{
				cameraSensitivity = cameraMainSensitivity / 10;   // Divided by 10 to get the correct value
				aimVirtualCamera.gameObject.SetActive(false);

				mainCrosshair.SetActive(true);
				aimCrosshair.SetActive(false);
			}
		}
	}

	public void OnShoot(InputAction.CallbackContext context)
	{
		if (cooldownTimer <= 0)	// If not in cooldown
		{
			if (!context.performed)
			{
				return;
			}

			Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);

			Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);

			if (Physics.Raycast(ray, out RaycastHit raycastHit, raycastRange))
			{
				hitDistance = raycastHit.distance;

				debugTransform.position = raycastHit.point;
				mouseWorldPosition = raycastHit.point;
				hitTransform = raycastHit.transform;
			}
			else    // Manually set distance of raycast
			{
				hitDistance = raycastHit.distance;

				debugTransform.position = Camera.main.transform.position + Camera.main.transform.forward * raycastRange;
				mouseWorldPosition = Camera.main.transform.position + Camera.main.transform.forward * raycastRange;
				hitTransform = raycastHit.transform;
			}

			cooldownTimer = cooldownTime;

			AudioManager.Instance.Play("SniperLaser_Shoot");
			StartCoroutine(HitTransform());
		}
	}

	IEnumerator HitTransform()
	{
		if (hitTransform != null)
		{
			float waitTime = CalculateImpactWaitTime(projectileSpeed, hitDistance);
			hitDistance = 0;

			yield return new WaitForSecondsRealtime(waitTime);

			if (hitTransform.GetComponent<IDamageable>() != null)
			{
				// Hit damageable
				Instantiate(vfxHitGreen, debugTransform.position, Quaternion.identity);
				Destroy(hitTransform.gameObject);
				AudioManager.Instance.Play("SniperLaser_Impact");
			}
			else
			{
				// Hit something else
				Instantiate(vfxHitRed, debugTransform.position, Quaternion.identity);
			}
		}
	}

	private float CalculateImpactWaitTime(float speed, float distance)
	{
		float time = distance / speed;
		return time;
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, raycastRange);
	}
}
