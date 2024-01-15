using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	private Vector2 lookInput;

	[SerializeField]
	private GameObject cameraTarget;

	[SerializeField]
	private CinemachineVirtualCamera aimVirtualCamera;

	private Vector3 mouseWorldPosition = new Vector3();
	private Vector2 screenCenterPoint = new Vector2();

	[SerializeField]
	private float weaponRange = 50f;

	private Transform hitTransform = null;
	[SerializeField]
	private Transform debugTransform;

	public GameObject vfxHitGreen;
	public GameObject vfxHitRed;

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
	}

	void FixedUpdate()
	{
		Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);

		Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);

		if (Physics.Raycast(ray, out RaycastHit raycastHit, weaponRange))
		{
			debugTransform.position = raycastHit.point;
			mouseWorldPosition = raycastHit.point;
			hitTransform = raycastHit.transform;

			Debug.Log($"Raycast hit");
		}
		else    // Manually set distance of raycast
		{
			debugTransform.position = Camera.main.transform.position + Camera.main.transform.forward * weaponRange;
			mouseWorldPosition = Camera.main.transform.position + Camera.main.transform.forward * weaponRange;
			hitTransform = raycastHit.transform;
		}
	}

	public void OnLook(InputAction.CallbackContext context)
	{
		if (context.phase == InputActionPhase.Started || context.phase == InputActionPhase.Performed)
		{
			lookInput = context.ReadValue<Vector2>();
		}
		else if (context.phase == InputActionPhase.Canceled)
		{
			lookInput = Vector2.zero;
		}
	}

	public void OnAim(InputAction.CallbackContext context)
	{
		if (context.action.triggered)
		{
			if (!aimVirtualCamera.gameObject.activeInHierarchy)
			{
				aimVirtualCamera.gameObject.SetActive(true);
			}
			else
			{
				aimVirtualCamera.gameObject.SetActive(false);
			}
		}
	}

	public void OnShoot(InputAction.CallbackContext context)
	{
		/*if (!context.performed)
		{
			return;
		}*/

		if (hitTransform != null)
		{
			if (hitTransform.GetComponent<Damageable>() != null)
			{
				// Hit damageable
				Instantiate(vfxHitGreen, debugTransform.position, Quaternion.identity);
			}
			else
			{
				// Hit something else
				Instantiate(vfxHitRed, debugTransform.position, Quaternion.identity);
			}
		}
	}
}
