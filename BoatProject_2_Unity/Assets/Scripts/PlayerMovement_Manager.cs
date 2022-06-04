using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement_Manager : MonoBehaviour
{
    private PlayerMovement_Manager m_instance;

    #region COMPONENTS
    private Controls m_controls;
    private Rigidbody m_rigibody;
    #endregion

    #region VARIABLES
    private bool m_movingForward;
    private float m_orientationAngle;
    #endregion

    #region CONFIGURATION
    [Range(12, 20)][SerializeField] float m_forwardSpeed = 15;
    [SerializeField] float m_maxSpeed = 7.5f;
    [SerializeField] float m_orientationSpeed = 1;
    [SerializeField] float m_minimalVelocityForOrientation = 1;
    #endregion

    public PlayerMovement_Manager Instance()
    {
        if(m_instance == null)
        {
            m_instance = this;
        }else if(m_instance != this)
        {
            Destroy(gameObject);
        }
        return m_instance;
    }

    private void OnEnable() => m_controls.Gameplay.Enable();
    private void OnDisable() => m_controls.Gameplay.Disable();

    private void Awake()
    {
        m_controls = new Controls();

        m_controls.Gameplay.Forward.started += ctx => m_movingForward = true;
        m_controls.Gameplay.Forward.canceled += ctx => m_movingForward = false;
        m_controls.Gameplay.Debug_Respawn.performed += ctx => Respawn();
        m_controls.Gameplay.Orientation.performed += ctx => m_orientationAngle = ctx.ReadValue<float>();
        m_controls.Gameplay.Orientation.canceled += ctx => m_orientationAngle = 0;

        m_rigibody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        ForwardMovement();
        HandlingOrientation();
    }

    private void ForwardMovement()
    {
        if(m_movingForward)
        {
            m_rigibody.AddForce(m_forwardSpeed * transform.forward);
            m_rigibody.velocity = Vector3.ClampMagnitude(m_rigibody.velocity, m_maxSpeed);
        }
    }

    private void HandlingOrientation()
    {
        if(m_rigibody.velocity.magnitude > m_minimalVelocityForOrientation)
        {
            transform.Rotate(Vector3.up, m_orientationAngle * m_orientationSpeed);
        }
    }

    private void Respawn()
    {
        gameObject.transform.position = Vector3.zero;
    }
}