// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.RecoveryServices.Backup;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    public partial interface IRecoveryServicesBackupManagementClient : IDisposable
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        string ApiVersion
        {
            get; 
        }
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationInitialTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationRetryTimeout
        {
            get; set; 
        }
        
        string ResourceNamespace
        {
            get; set; 
        }
        
        /// <summary>
        /// The Resource Manager API includes operations for managing the
        /// backup engines registered to your Recovery Services Vault.
        /// </summary>
        IBackupEngineOperations BackupEngines
        {
            get; 
        }
        
        /// <summary>
        /// Definition of OperationResults operations for the Azure Backup
        /// extension.
        /// </summary>
        IBackupOperationResults BackupOperationResults
        {
            get; 
        }
        
        /// <summary>
        /// The Resource Manager API includes operations for triggering and
        /// managing the backups of items protected by your Recovery Services
        /// Vault.
        /// </summary>
        IBackupOperations Backups
        {
            get; 
        }
        
        /// <summary>
        /// The Resource Manager API includes operations for managing the
        /// containers registered to your Recovery Services Vault.
        /// </summary>
        IContainerOperations Containers
        {
            get; 
        }
        
        /// <summary>
        /// The Resource Manager API includes operations for managing the jobs
        /// created by various operations on a given item protected by your
        /// Recovery Services Vault.
        /// </summary>
        IJobOperations Jobs
        {
            get; 
        }
        
        /// <summary>
        /// The Resource Manager API includes operations for managing the
        /// protectable objects registered to your Recovery Services Vault.
        /// </summary>
        IProtectableObjectOperations ProtectableObjects
        {
            get; 
        }
        
        /// <summary>
        /// The Resource Manager API includes operations for managing the items
        /// protected by your Recovery Services Vault.
        /// </summary>
        IProtectedItemOperations ProtectedItems
        {
            get; 
        }
        
        /// <summary>
        /// The Resource Manager API includes operations for managing
        /// protection policies defined for your Recovery Services Vault
        /// </summary>
        IProtectionPolicyOperations ProtectionPolicies
        {
            get; 
        }
        
        /// <summary>
        /// The Resource Manager API includes operations for managing recovery
        /// points created by backup operations on the items protected by your
        /// Recovery Services Vault.
        /// </summary>
        IRecoveryPointOperations RecoveryPoints
        {
            get; 
        }
        
        /// <summary>
        /// The Resource Manager API includes operations for triggering and
        /// managing restore actions of the items protected by your Recovery
        /// Services Vault.
        /// </summary>
        IRestoreOperations Restores
        {
            get; 
        }
        
        /// <summary>
        /// Get the status of Protection policy operation by URL.
        /// </summary>
        /// <param name='operationResultLink'>
        /// Location value returned by operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a OperationStatusResponse.
        /// </returns>
        Task<BackUpOperationStatusResponse> GetOperationStatusByURLAsync(string operationResultLink, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
