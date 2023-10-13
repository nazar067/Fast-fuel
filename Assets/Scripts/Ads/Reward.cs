using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Reward : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] private Button buttonShowAd;

    [SerializeField] private string androidAdID = "Rewarded_Android";
    [SerializeField] private string iOSAdID = "Rewarded_iOS";

    private string adID;

    private bool rewardGiven = false;


    private void Awake()
    {
        adID = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? iOSAdID
            : androidAdID;

        buttonShowAd.interactable = false;
    }

    private void Start()
    {
        LoadAd();
    }

    public void LoadAd()
    {
        Debug.Log("Loading Ad: " + adID);
        Advertisement.Load(adID, this);
    }

    public void ShowAd()
    {
        buttonShowAd.interactable = false;

        Advertisement.Show(adID, this);
    }

    public void OnUnityAdsAdLoaded(string adUnitId)
    {
        Debug.Log("Ad Loaded: " + adUnitId);

        if (adUnitId.Equals(adID))
        {
            buttonShowAd.onClick.AddListener(ShowAd);

            buttonShowAd.interactable = true;
        }
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error loading Ad Unit {adID}: {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        Debug.Log($"Error showing Ad Unit {adID}: {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowStart(string placementId)
    {

    }

    public void OnUnityAdsShowClick(string placementId)
    {
    }

    public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState)
    {
        if (adUnitId.Equals(adID) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED) && !rewardGiven)
        {
            Debug.Log("Unity Ads Rewarded Ad Completed");
            FuelIndicator.Instance.ResumeGame();
            Money.Instance.money += 15;
            Money.Instance.UpdateMoneyText();
            PlayerPrefs.SetInt("Money", Money.Instance.money);

            rewardGiven = true;
        }
    }
    private void OnDestroy()
    {
        buttonShowAd.onClick.RemoveAllListeners();
    }
}