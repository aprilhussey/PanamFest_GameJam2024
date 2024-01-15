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
	private GameObject playerCamera;
	[SerializeField]
	private CinemachineVirtualCamera mainVirtualCamera;
	[SerializeField]
	private CinemachineVirtualCamera aimVirtualCamera;

	private Vector3 mouseWorldPosition = new Vector3();
	private Vector2 screenCenterPoint;

	private float weaponRange;

	private Transform hitTransform = null;
	[SerializeField]
	private Transform debugTransform;

	void Awake()
	{
		mouseWorldPosition = Vector3.zero;
		screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);
	}

	void Start()
	{
		mainVirtualCamera.gameObject.SetActive(true);
		aimVirtualCamera.gameObject.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{

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
			if (aimVirtualCamera.gameObject.activeInHierarchy)
			{
				aimVirtualCamera.gameObject.SetActive(false);
			}
			else if (!aimVirtualCamera.gameObject.activeInHierarchy)
			{
				aimVirtualCamera.gameObject.SetActive(true);
			}
		}
	}

	public void OnShoot(InputAction.CallbackContext context)
	{
		/*if (!context.performed)
		{
			return;
		}*/

		Ray ray = playerCamera.GetComponent<Camera>().ScreenPointToRay(screenCenterPoint);

		if (Physics.Raycast(ray, out RaycastHit raycastHit, weaponRange))
		{
			debugTransform.position = raycastHit.point;
			mouseWorldPosition = raycastHit.point;
			hitTransform = raycastHit.transform;
		}

		if (hitTransform != null)
		{
			if (hitTransform.GetComponent<IDamageable>() != null)
			{
				// Hit damageable
				//Instantiate(vfx, debugTransform.position, Quaternion.identity);
			}
			else
			{
				// Hit something else
				//Instantiate(vfx, debugTransform.position, Quaternion.identity);
			}
		}
	}
}
