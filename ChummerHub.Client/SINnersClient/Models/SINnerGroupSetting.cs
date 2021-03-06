﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SINners.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class SINnerGroupSetting
    {
        /// <summary>
        /// Initializes a new instance of the SINnerGroupSetting class.
        /// </summary>
        public SINnerGroupSetting() { }

        /// <summary>
        /// Initializes a new instance of the SINnerGroupSetting class.
        /// </summary>
        public SINnerGroupSetting(Guid? id = default(Guid?), string downloadUrl = default(string), Guid? myGroupId = default(Guid?))
        {
            Id = id;
            DownloadUrl = downloadUrl;
            MyGroupId = myGroupId;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "downloadUrl")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "myGroupId")]
        public Guid? MyGroupId { get; set; }

    }
}
