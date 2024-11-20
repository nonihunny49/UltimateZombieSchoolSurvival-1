using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibilityController : MonoBehaviour
{
    private HealthController _healthController;
    private SpriteFlash _spriteFlash;

    private void Awake()
    {
        _healthController = GetComponent<HealthController>();
        _spriteFlash = GetComponent<SpriteFlash>();
    }

    public void StartInvincibility(float invincibilityDuration, Color flashColor, int numberOffFlashes)
    {
        StartCoroutine(InvincibilityCoroutione(invincibilityDuration , flashColor , numberOffFlashes));
    }

    private IEnumerator InvincibilityCoroutione(float invincibilityDuration , Color flashColor , int numberOffFlashes)
    {
        _healthController.IsInvicible = true;
        yield return _spriteFlash.FlashCoroutine(invincibilityDuration, flashColor, numberOffFlashes);
        _healthController.IsInvicible = false;
    }
}
