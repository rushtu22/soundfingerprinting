namespace SoundFingerprinting.Configuration
{
    using System;

    public class FingerprintConfiguration
    {
        private int topWavelets;
        private int sampleRate;

        /// <summary>
        ///   Gets number of audio samples read for one fingerprint
        /// </summary>
        public int SamplesPerFingerprint
        {
            get
            {
                return SpectrogramConfig.ImageLength * SpectrogramConfig.Overlap;
            }
        }

        /// <summary>
        ///   Gets or sets number of Top wavelets to consider
        /// </summary>
        public int TopWavelets
        {
            get
            {
                return topWavelets;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("TopWavelets can't be negative or equal to 0", "value");
                }

                topWavelets = value;
            }
        }

        /// <summary>
        ///   Gets or sets sample rate
        /// </summary>
        public int SampleRate
        {
            get
            {
                return sampleRate;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("SampleRate can't be negative or equal to 0", "value");
                }

                sampleRate = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the algorithm has to normalize the audio signal
        /// </summary>
        public bool NormalizeSignal { get; set; }

        /// <summary>
        /// Gets or sets spectrogram creation configuration parameters
        /// </summary>
        public SpectrogramConfig SpectrogramConfig { get; set; }

        /// <summary>
        /// Gets or sets hashing configuration parameters
        /// </summary>
        public HashingConfig HashingConfig { get; set; }
    }
}