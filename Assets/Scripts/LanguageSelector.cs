using System.Collections;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LanguageSelector : MonoBehaviour
{
    public void SetLanguage(string localeCode)
    {
        StartCoroutine(ChangeLanguage(localeCode));
    }

    private IEnumerator ChangeLanguage(string localeCode)
    {
        yield return LocalizationSettings.InitializationOperation;

        Locale locale = LocalizationSettings.AvailableLocales.GetLocale(new LocaleIdentifier(localeCode));
        if (locale != null)
            LocalizationSettings.SelectedLocale = locale;
    }
}
