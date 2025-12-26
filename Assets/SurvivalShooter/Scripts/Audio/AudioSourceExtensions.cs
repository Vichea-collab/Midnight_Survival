using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioSourceExtensions
{
    public static void PlayOneShot(this AudioSource audioSource, AudioClipMetadata clipMetadata, float volumeLevel=1.0f)
    {
        if (clipMetadata == null || clipMetadata.Clip == null)
        {
            Debug.LogWarning("PlayOneShot called with missing clip metadata or clip.");
            return;
        }

        audioSource.PlayOneShot(clipMetadata.Clip, volumeLevel);

        var subtitlePanel = SubtitlePanel.Instance;
        if (subtitlePanel != null)
        {
            subtitlePanel.AddSubtitle(clipMetadata);
        }
    }
    
    public static void Play(this AudioSource audioSource, AudioClipMetadata clipMetadata)
    {
        if (clipMetadata == null || clipMetadata.Clip == null)
        {
            Debug.LogWarning("Play called with missing clip metadata or clip.");
            return;
        }

        audioSource.clip = clipMetadata.Clip;
        audioSource.Play();

        var subtitlePanel = SubtitlePanel.Instance;
        if (subtitlePanel != null)
        {
            subtitlePanel.AddSubtitle(clipMetadata);
        }
    }
}
