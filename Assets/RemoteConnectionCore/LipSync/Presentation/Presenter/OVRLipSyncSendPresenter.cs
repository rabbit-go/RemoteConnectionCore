using System.Collections;
using System.Collections.Generic;
using RemoteConnectionCore.LipSync.Presentation.Model;
using UnityEngine;
using Zenject;

public class OVRLipSyncSendPresenter : OVRLipSyncContextBase
{
    [Inject] private LipDataSendModel lipDataSendModel;
    public AudioSource audioSource = null;
    [Tooltip("Skip data from the Audio Source. Use if you intend to pass audio data in manually.")]
    public bool skipAudioSource = false;
    [Tooltip("Adjust the linear audio gain multiplier before processing lipsync")]
    public float gain = 1.0f;
    [Tooltip("Play input audio back through audio output.")]
    public bool audioLoopback = false;
    void OnAudioFilterRead(float[] data, int channels)
    {
        if (!skipAudioSource)
        {
            ProcessAudioSamples(data, channels);
            lipDataSendModel.SendData(Frame);
        }
    }
    public void ProcessAudioSamples(float[] data, int channels)
    {
        // Do not process if we are not initialized, or if there is no
        // audio source attached to game object
        if ((OVRLipSync.IsInitialized() != OVRLipSync.Result.Success) || audioSource == null)
        {
            return;
        }
        PreprocessAudioSamples(data, channels);
        ProcessAudioSamplesRaw(data, channels);
        PostprocessAudioSamples(data, channels);
    }
    public void PreprocessAudioSamples(float[] data, int channels)
    {
        // Increase the gain of the input
        for (int i = 0; i < data.Length; ++i)
        {
            data[i] = data[i] * gain;
        }
    }

    /// <summary>
    /// Postprocess F32 PCM audio buffer
    /// </summary>
    /// <param name="data">Data.</param>
    /// <param name="channels">Channels.</param>
    public void PostprocessAudioSamples(float[] data, int channels)
    {
        // Turn off output (so that we don't get feedback from mics too close to speakers)
        if (!audioLoopback)
        {
            for (int i = 0; i < data.Length; ++i)
                data[i] = data[i] * 0.0f;
        }
    }

    /// <summary>
    /// Pass F32 PCM audio buffer to the lip sync module
    /// </summary>
    /// <param name="data">Data.</param>
    /// <param name="channels">Channels.</param>
    public void ProcessAudioSamplesRaw(float[] data, int channels)
    {
        // Send data into Phoneme context for processing (if context is not 0)
        lock (this)
        {
            if (Context == 0 || OVRLipSync.IsInitialized() != OVRLipSync.Result.Success)
            {
                return;
            }
            var frame = this.Frame;
            OVRLipSync.ProcessFrame(Context, data, frame, channels == 2);
        }
    }
}
