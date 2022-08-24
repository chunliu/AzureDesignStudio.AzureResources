// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The Security Settings of managed instance DTC.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ManagedInstanceDtcSecuritySettings
    {
        /// <summary>
        /// Allow SNA LU 6.2 to managed instance DTC.
        /// </summary>
        [JsonPropertyName("snaLu6point2TransactionsEnabled")]
        public bool SnaLu6point2TransactionsEnabled { get; set; }

        /// <summary>
        /// The Transaction Manager Communication Settings of managed instance DTC.
        /// </summary>
        [JsonPropertyName("transactionManagerCommunicationSettings")]
        public ManagedInstanceDtcTransactionManagerCommunicationSettings TransactionManagerCommunicationSettings { get; set; }

        /// <summary>
        /// Allow XA Transactions to managed instance DTC.
        /// </summary>
        [JsonPropertyName("xaTransactionsEnabled")]
        public bool XaTransactionsEnabled { get; set; }
    }
}