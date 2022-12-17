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
    private float m_orientationAngle;
    private Sails m_currentSails;
    private float m_accelerationTimer;
    private float m_decelerationTimer;
    private SpeedStatus m_currentSpeedStatus;

    enum Sails
    {
        none, low, middle, high
    }

    enum SpeedStatus
    {
        stopped, accelerating, deccelerating, maxSpeed
    }
    #endregion

    #region CONFIGURATION
    [Range(12, 20)][SerializeField] float m_forwardSpeed = 15;
    [SerializeField] float m_maxSpeed = 7.5f;
    [SerializeField] float m_orientationSpeed = 1;
    [SerializeField] float m_minimalVelocityForOrientation = 1;
    [SerializeField] float m_accelerationSpeed;
    [SerializeField] float m_deccelerationSpeed;
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

        m_controls.Gameplay.Debug_Respawn.performed += ctx => Respawn();
        m_controls.Gameplay.Orientation.performed += ctx => m_orientationAngle = ctx.ReadValue<float>();
        m_controls.Gameplay.Orientation.canceled += ctx => m_orientationAngle = 0;
        m_controls.Gameplay.SpeedUp.performed += ctx => ChangeSpeed(1);
        m_controls.Gameplay.SpeedDown.performed += ctx => ChangeSpeed(-1);

        m_rigibody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        ForwardMovement();
        HandlingOrientation();
        print(m_currentSails);
    }

    private void ForwardMovement()
    {
        if(m_currentSails > Sails.none)
        {
            m_rigibody.AddForce(m_forwardSpeed * transform.forward);

            m_rigibody.velocity = Vector3.ClampMagnitude(m_rigibody.velocity, m_maxSpeed * (int)m_currentSails);
            if (m_rigibody.velocity.magnitude == m_maxSpeed)
            {
                m_currentSpeedStatus = SpeedStatus.maxSpeed;
                m_accelerationTimer = 0;
                m_decelerationTimer = 0;
            }
            else
            {
                m_currentSpeedStatus = SpeedStatus.accelerating;

                m_accelerationTimer += m_accelerationSpeed;
            }
        }
        else
        {
            if (m_rigibody.velocity.magnitude != 0)
            {
                m_currentSpeedStatus = SpeedStatus.deccelerating;
            }
            else
            {
                m_currentSpeedStatus = SpeedStatus.stopped;
                m_accelerationTimer = 0;
                m_decelerationTimer = 0;
            }
        }
    }

    private void HandlingOrientation()
    {
        if(m_rigibody.velocity.magnitude > m_minimalVelocityForOrientation)
        {
            transform.Rotate(Vector3.up, m_orientationAngle * m_orientationSpeed);
        }
    }

    private void ChangeSpeed(int signe)
    {
        if(m_currentSails == Sails.none && signe < 0)
        {
            return;
        }
        if (m_currentSails == Sails.high && signe > 0)
        {
            return;
        }
        m_currentSails += signe;
    }

    private void Respawn()
    {
        gameObject.transform.position = Vector3.zero;
    }
}