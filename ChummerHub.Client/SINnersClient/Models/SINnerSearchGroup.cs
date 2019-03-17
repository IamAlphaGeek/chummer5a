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

    public partial class SINnerSearchGroup
    {
        /// <summary>
        /// Initializes a new instance of the SINnerSearchGroup class.
        /// </summary>
        public SINnerSearchGroup() { }

        /// <summary>
        /// Initializes a new instance of the SINnerSearchGroup class.
        /// </summary>
        public SINnerSearchGroup(SINnerSearchGroup mySINSearchGroup = default(SINnerSearchGroup), string errorText = default(string), IList<SINnerSearchGroupMember> myMembers = default(IList<SINnerSearchGroupMember>), Guid? id = default(Guid?), bool? isPublic = default(bool?), string gameMasterUsername = default(string), SINnerGroupSetting mySettings = default(SINnerGroupSetting), string groupname = default(string), string language = default(string), IList<SINnerGroup> myGroups = default(IList<SINnerGroup>), SINnerGroup myParentGroup = default(SINnerGroup), string myAdminIdentityRole = default(string))
        {
            MySINSearchGroup = mySINSearchGroup;
            ErrorText = errorText;
            MyMembers = myMembers;
            Id = id;
            IsPublic = isPublic;
            GameMasterUsername = gameMasterUsername;
            MySettings = mySettings;
            Groupname = groupname;
            Language = language;
            MyGroups = myGroups;
            MyParentGroup = myParentGroup;
            MyAdminIdentityRole = myAdminIdentityRole;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mySINSearchGroup")]
        public SINnerSearchGroup MySINSearchGroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorText")]
        public string ErrorText { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "myMembers")]
        public IList<SINnerSearchGroupMember> MyMembers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isPublic")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gameMasterUsername")]
        public string GameMasterUsername { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mySettings")]
        public SINnerGroupSetting MySettings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "groupname")]
        public string Groupname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "myGroups")]
        public IList<SINnerGroup> MyGroups { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "myParentGroup")]
        public SINnerGroup MyParentGroup { get; set; }

        /// <summary>
        /// Only users of the specified Role can join this group
        /// </summary>
        [JsonProperty(PropertyName = "myAdminIdentityRole")]
        public string MyAdminIdentityRole { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.MySINSearchGroup != null)
            {
                this.MySINSearchGroup.Validate();
            }
            if (this.MyMembers != null)
            {
                foreach (var element in this.MyMembers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.Groupname != null)
            {
                if (this.Groupname.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Groupname", 64);
                }
            }
            if (this.Language != null)
            {
                if (this.Language.Length > 6)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Language", 6);
                }
            }
            if (this.MyGroups != null)
            {
                foreach (var element1 in this.MyGroups)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.MyParentGroup != null)
            {
                this.MyParentGroup.Validate();
            }
            if (this.MyAdminIdentityRole != null)
            {
                if (this.MyAdminIdentityRole.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "MyAdminIdentityRole", 64);
                }
            }
        }
    }
}