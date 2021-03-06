﻿// Copyright(C) Microsoft.All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

using Newtonsoft.Json;

namespace RulesEngine
{
    /// <summary>
    /// Content Type class
    /// </summary>
    public class LanguageInfo
    {
        public enum LangFileType { Code, Build, Other };

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "extensions")]
        public string[] Extensions { get; set; }
        [JsonProperty(PropertyName = "type")]
        public LangFileType Type { get; set; }
    }


}
