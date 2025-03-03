namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>HyperV Replica Blue policy input.</summary>
    public partial class HyperVReplicaBluePolicyInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaBluePolicyInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaBluePolicyInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInput __hyperVReplicaPolicyInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HyperVReplicaPolicyInput();

        /// <summary>A value indicating the authentication type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public int? AllowedAuthenticationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).AllowedAuthenticationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).AllowedAuthenticationType = value ?? default(int); }

        /// <summary>A value indicating the application consistent frequency.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public int? ApplicationConsistentSnapshotFrequencyInHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).ApplicationConsistentSnapshotFrequencyInHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).ApplicationConsistentSnapshotFrequencyInHour = value ?? default(int); }

        /// <summary>A value indicating whether compression has to be enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Compression { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).Compression; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).Compression = value ?? null; }

        /// <summary>A value indicating whether IR is online.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InitialReplicationMethod { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).InitialReplicationMethod; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).InitialReplicationMethod = value ?? null; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInputInternal)__hyperVReplicaPolicyInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInputInternal)__hyperVReplicaPolicyInput).InstanceType = value ?? null; }

        /// <summary>A value indicating the offline IR export path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string OfflineReplicationExportPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).OfflineReplicationExportPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).OfflineReplicationExportPath = value ?? null; }

        /// <summary>A value indicating the offline IR import path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string OfflineReplicationImportPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).OfflineReplicationImportPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).OfflineReplicationImportPath = value ?? null; }

        /// <summary>A value indicating the online IR start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string OnlineReplicationStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).OnlineReplicationStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).OnlineReplicationStartTime = value ?? null; }

        /// <summary>A value indicating the number of recovery points.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public int? RecoveryPoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).RecoveryPoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).RecoveryPoint = value ?? default(int); }

        /// <summary>A value indicating whether the VM has to be auto deleted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string ReplicaDeletion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).ReplicaDeletion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).ReplicaDeletion = value ?? null; }

        /// <summary>Backing field for <see cref="ReplicationFrequencyInSecond" /> property.</summary>
        private int? _replicationFrequencyInSecond;

        /// <summary>A value indicating the replication interval.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? ReplicationFrequencyInSecond { get => this._replicationFrequencyInSecond; set => this._replicationFrequencyInSecond = value; }

        /// <summary>A value indicating the recovery HTTPS port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public int? ReplicationPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).ReplicationPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal)__hyperVReplicaPolicyInput).ReplicationPort = value ?? default(int); }

        /// <summary>Creates an new <see cref="HyperVReplicaBluePolicyInput" /> instance.</summary>
        public HyperVReplicaBluePolicyInput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__hyperVReplicaPolicyInput), __hyperVReplicaPolicyInput);
            await eventListener.AssertObjectIsValid(nameof(__hyperVReplicaPolicyInput), __hyperVReplicaPolicyInput);
        }
    }
    /// HyperV Replica Blue policy input.
    public partial interface IHyperVReplicaBluePolicyInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInput
    {
        /// <summary>A value indicating the replication interval.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating the replication interval.",
        SerializedName = @"replicationFrequencyInSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? ReplicationFrequencyInSecond { get; set; }

    }
    /// HyperV Replica Blue policy input.
    internal partial interface IHyperVReplicaBluePolicyInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaPolicyInputInternal
    {
        /// <summary>A value indicating the replication interval.</summary>
        int? ReplicationFrequencyInSecond { get; set; }

    }
}