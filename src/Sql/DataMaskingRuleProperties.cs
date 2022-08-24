// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The properties of a database data masking rule.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DataMaskingRuleProperties
    {
        /// <summary>
        /// The alias name. This is a legacy parameter and is no longer used.
        /// </summary>
        [JsonPropertyName("aliasName")]
        public string AliasName { get; set; }

        /// <summary>
        /// The column name on which the data masking rule is applied.
        /// </summary>
        [Required]
        [JsonPropertyName("columnName")]
        public string ColumnName { get; set; }

        /// <summary>
        /// The masking function that is used for the data masking rule.
        /// </summary>
        [Required]
        [JsonPropertyName("maskingFunction")]
        public string MaskingFunction { get; set; }

        /// <summary>
        /// The numberFrom property of the masking rule. Required if maskingFunction is set to Number, otherwise this parameter will be ignored.
        /// </summary>
        [JsonPropertyName("numberFrom")]
        public string NumberFrom { get; set; }

        /// <summary>
        /// The numberTo property of the data masking rule. Required if maskingFunction is set to Number, otherwise this parameter will be ignored.
        /// </summary>
        [JsonPropertyName("numberTo")]
        public string NumberTo { get; set; }

        /// <summary>
        /// If maskingFunction is set to Text, the number of characters to show unmasked in the beginning of the string. Otherwise, this parameter will be ignored.
        /// </summary>
        [JsonPropertyName("prefixSize")]
        public string PrefixSize { get; set; }

        /// <summary>
        /// If maskingFunction is set to Text, the character to use for masking the unexposed part of the string. Otherwise, this parameter will be ignored.
        /// </summary>
        [JsonPropertyName("replacementString")]
        public string ReplacementString { get; set; }

        /// <summary>
        /// The rule state. Used to delete a rule. To delete an existing rule, specify the schemaName, tableName, columnName, maskingFunction, and specify ruleState as disabled. However, if the rule doesn't already exist, the rule will be created with ruleState set to enabled, regardless of the provided value of ruleState.
        /// </summary>
        [JsonPropertyName("ruleState")]
        public string RuleState { get; set; }

        /// <summary>
        /// The schema name on which the data masking rule is applied.
        /// </summary>
        [Required]
        [JsonPropertyName("schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// If maskingFunction is set to Text, the number of characters to show unmasked at the end of the string. Otherwise, this parameter will be ignored.
        /// </summary>
        [JsonPropertyName("suffixSize")]
        public string SuffixSize { get; set; }

        /// <summary>
        /// The table name on which the data masking rule is applied.
        /// </summary>
        [Required]
        [JsonPropertyName("tableName")]
        public string TableName { get; set; }
    }
}