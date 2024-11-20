using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamagedInvoncibility : MonoBehaviour
{
    [SerializeField]
    private float _invincibilityDuration;

    [SerializeField]
    private Color _flashColor;

    [SerializeField]
    private int _numberOffFlashes;

    private InvisibilityController _invincibilityController;

    public void Awake()
    {
        _invincibilityController = GetComponent<InvisibilityController>();
    }
    public void StartInvincibility()
    {
        _invincibilityController.StartInvincibility(_invincibilityDuration, _flashColor, _numberOffFlashes);
    }
}
