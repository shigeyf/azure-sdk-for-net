// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Ingest track discontinuity detected event data.
    /// </summary>
    public partial class MediaLiveEventTrackDiscontinuityDetectedEventData
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MediaLiveEventTrackDiscontinuityDetectedEventData class.
        /// </summary>
        public MediaLiveEventTrackDiscontinuityDetectedEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MediaLiveEventTrackDiscontinuityDetectedEventData class.
        /// </summary>
        /// <param name="trackType">Gets the type of the track (Audio /
        /// Video).</param>
        /// <param name="trackName">Gets the track name.</param>
        /// <param name="bitrate">Gets the bitrate.</param>
        /// <param name="previousTimestamp">Gets the timestamp of the previous
        /// fragment.</param>
        /// <param name="newTimestamp">Gets the timestamp of the current
        /// fragment.</param>
        /// <param name="timescale">Gets the timescale in which both timestamps
        /// and discontinuity gap are represented.</param>
        /// <param name="discontinuityGap">Gets the discontinuity gap between
        /// PreviousTimestamp and NewTimestamp.</param>
        public MediaLiveEventTrackDiscontinuityDetectedEventData(string trackType = default(string), string trackName = default(string), long? bitrate = default(long?), string previousTimestamp = default(string), string newTimestamp = default(string), string timescale = default(string), string discontinuityGap = default(string))
        {
            TrackType = trackType;
            TrackName = trackName;
            Bitrate = bitrate;
            PreviousTimestamp = previousTimestamp;
            NewTimestamp = newTimestamp;
            Timescale = timescale;
            DiscontinuityGap = discontinuityGap;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the type of the track (Audio / Video).
        /// </summary>
        [JsonProperty(PropertyName = "trackType")]
        public string TrackType { get; private set; }

        /// <summary>
        /// Gets the track name.
        /// </summary>
        [JsonProperty(PropertyName = "trackName")]
        public string TrackName { get; private set; }

        /// <summary>
        /// Gets the bitrate.
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public long? Bitrate { get; private set; }

        /// <summary>
        /// Gets the timestamp of the previous fragment.
        /// </summary>
        [JsonProperty(PropertyName = "previousTimestamp")]
        public string PreviousTimestamp { get; private set; }

        /// <summary>
        /// Gets the timestamp of the current fragment.
        /// </summary>
        [JsonProperty(PropertyName = "newTimestamp")]
        public string NewTimestamp { get; private set; }

        /// <summary>
        /// Gets the timescale in which both timestamps and discontinuity gap
        /// are represented.
        /// </summary>
        [JsonProperty(PropertyName = "timescale")]
        public string Timescale { get; private set; }

        /// <summary>
        /// Gets the discontinuity gap between PreviousTimestamp and
        /// NewTimestamp.
        /// </summary>
        [JsonProperty(PropertyName = "discontinuityGap")]
        public string DiscontinuityGap { get; private set; }

    }
}