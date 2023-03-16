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
    private float m_deccelerationTimer;
    private float m_targetSpeed;

    public enum Sails
    {
        none, low, middle, high
    }

    #endregion

    #region CONFIGURATION
    [SerializeField] float m_targetSpeedLowSails;
    [SerializeField] float m_targetSpeedMiddleSails;
    [SerializeField] float m_targetSpeedHighSails;
    [SerializeField] float m_orientationSpeed = 1;
    [SerializeField] float m_minimalVelocityForOrientation = 1;
    [SerializeField] float m_accelerationSpeedTime;
    [SerializeField] float m_deccelerationSpeedTime;
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
    }

    private void ForwardMovement()
    {
        if(m_currentSails > Sails.none)
        {
            m_accelerationTimer += m_accelerationSpeedTime;
            m_rigibody.velocity = Mathf.Lerp(m_rigibody.velocity.magnitude, m_targetSpeed, m_accelerationTimer) * transform.forward;
            /*
            if (m_rigibody.velocity.magnitude > m_targetSpeed)
            {
                m_rigibody.velocity = Mathf.Lerp(m_targetSpeed, m_rigibody.velocity.magnitude, m_accelerationTimer) * transform.forward;
            }
            else
            {
                m_rigibody.velocity = Mathf.Lerp(m_rigibody.velocity.magnitude, m_targetSpeed, m_accelerationTimer) * transform.forward;
            }
            */
        }
        else
        {
            m_deccelerationTimer += m_deccelerationSpeedTime;

            m_rigibody.velocity = Mathf.Lerp(m_rigibody.velocity.magnitude, 0, m_deccelerationSpeedTime) * transform.forward;
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

        switch (m_currentSails)
        {
            case Sails.low:
                m_targetSpeed = m_targetSpeedLowSails;
                break;
            case Sails.middle:
                m_targetSpeed = m_targetSpeedMiddleSails;
                break;
            case Sails.high:
                m_targetSpeed = m_targetSpeedHighSails;
                break;
        }

        m_accelerationTimer = 0;
        m_deccelerationTimer = 0;
    }

    private void Respawn()
    {
        gameObject.transform.position = Vector3.zero;
    }
}