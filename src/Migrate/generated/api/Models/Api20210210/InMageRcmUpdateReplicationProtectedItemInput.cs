namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcm provider specific input to update replication protected item.</summary>
    public partial class InMageRcmUpdateReplicationProtectedItemInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmUpdateReplicationProtectedItemInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmUpdateReplicationProtectedItemInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInput __updateReplicationProtectedItemProviderInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.UpdateReplicationProtectedItemProviderInput();

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInputInternal)__updateReplicationProtectedItemProviderInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInputInternal)__updateReplicationProtectedItemProviderInput).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="LicenseType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? _licenseType;

        /// <summary>The license type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get => this._licenseType; set => this._licenseType = value; }

        /// <summary>Backing field for <see cref="TargetAvailabilitySetId" /> property.</summary>
        private string _targetAvailabilitySetId;

        /// <summary>The target availability set ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAvailabilitySetId { get => this._targetAvailabilitySetId; set => this._targetAvailabilitySetId = value; }

        /// <summary>Backing field for <see cref="TargetAvailabilityZone" /> property.</summary>
        private string _targetAvailabilityZone;

        /// <summary>The target availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAvailabilityZone { get => this._targetAvailabilityZone; set => this._targetAvailabilityZone = value; }

        /// <summary>
        /// Backing field for <see cref="TargetBootDiagnosticsStorageAccountId" /> property.
        /// </summary>
        private string _targetBootDiagnosticsStorageAccountId;

        /// <summary>The target boot diagnostics storage account ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetBootDiagnosticsStorageAccountId { get => this._targetBootDiagnosticsStorageAccountId; set => this._targetBootDiagnosticsStorageAccountId = value; }

        /// <summary>Backing field for <see cref="TargetNetworkId" /> property.</summary>
        private string _targetNetworkId;

        /// <summary>The target network ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetNetworkId { get => this._targetNetworkId; set => this._targetNetworkId = value; }

        /// <summary>Backing field for <see cref="TargetProximityPlacementGroupId" /> property.</summary>
        private string _targetProximityPlacementGroupId;

        /// <summary>The target proximity placement group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetProximityPlacementGroupId { get => this._targetProximityPlacementGroupId; set => this._targetProximityPlacementGroupId = value; }

        /// <summary>Backing field for <see cref="TargetResourceGroupId" /> property.</summary>
        private string _targetResourceGroupId;

        /// <summary>The target resource group ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetResourceGroupId { get => this._targetResourceGroupId; set => this._targetResourceGroupId = value; }

        /// <summary>Backing field for <see cref="TargetVMName" /> property.</summary>
        private string _targetVMName;

        /// <summary>The target VM name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetVMName { get => this._targetVMName; set => this._targetVMName = value; }

        /// <summary>Backing field for <see cref="TargetVMSize" /> property.</summary>
        private string _targetVMSize;

        /// <summary>The target VM size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetVMSize { get => this._targetVMSize; set => this._targetVMSize = value; }

        /// <summary>Backing field for <see cref="TestNetworkId" /> property.</summary>
        private string _testNetworkId;

        /// <summary>The test network ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TestNetworkId { get => this._testNetworkId; set => this._testNetworkId = value; }

        /// <summary>Backing field for <see cref="VMNic" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicInput[] _vMNic;

        /// <summary>The list of NIC details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicInput[] VMNic { get => this._vMNic; set => this._vMNic = value; }

        /// <summary>
        /// Creates an new <see cref="InMageRcmUpdateReplicationProtectedItemInput" /> instance.
        /// </summary>
        public InMageRcmUpdateReplicationProtectedItemInput()
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
            await eventListener.AssertNotNull(nameof(__updateReplicationProtectedItemProviderInput), __updateReplicationProtectedItemProviderInput);
            await eventListener.AssertObjectIsValid(nameof(__updateReplicationProtectedItemProviderInput), __updateReplicationProtectedItemProviderInput);
        }
    }
    /// InMageRcm provider specific input to update replication protected item.
    public partial interface IInMageRcmUpdateReplicationProtectedItemInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInput
    {
        /// <summary>The license type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The license type.",
        SerializedName = @"licenseType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get; set; }
        /// <summary>The target availability set ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target availability set ARM Id.",
        SerializedName = @"targetAvailabilitySetId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAvailabilitySetId { get; set; }
        /// <summary>The target availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target availability zone.",
        SerializedName = @"targetAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAvailabilityZone { get; set; }
        /// <summary>The target boot diagnostics storage account ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target boot diagnostics storage account ARM Id.",
        SerializedName = @"targetBootDiagnosticsStorageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetBootDiagnosticsStorageAccountId { get; set; }
        /// <summary>The target network ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target network ARM Id.",
        SerializedName = @"targetNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetNetworkId { get; set; }
        /// <summary>The target proximity placement group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target proximity placement group Id.",
        SerializedName = @"targetProximityPlacementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetProximityPlacementGroupId { get; set; }
        /// <summary>The target resource group ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target resource group ARM Id.",
        SerializedName = @"targetResourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetResourceGroupId { get; set; }
        /// <summary>The target VM name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target VM name.",
        SerializedName = @"targetVmName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetVMName { get; set; }
        /// <summary>The target VM size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target VM size.",
        SerializedName = @"targetVmSize",
        PossibleTypes = new [] { typeof(string) })]
        string TargetVMSize { get; set; }
        /// <summary>The test network ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The test network ARM Id.",
        SerializedName = @"testNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string TestNetworkId { get; set; }
        /// <summary>The list of NIC details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of NIC details.",
        SerializedName = @"vmNics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicInput) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicInput[] VMNic { get; set; }

    }
    /// InMageRcm provider specific input to update replication protected item.
    internal partial interface IInMageRcmUpdateReplicationProtectedItemInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInputInternal
    {
        /// <summary>The license type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get; set; }
        /// <summary>The target availability set ARM Id.</summary>
        string TargetAvailabilitySetId { get; set; }
        /// <summary>The target availability zone.</summary>
        string TargetAvailabilityZone { get; set; }
        /// <summary>The target boot diagnostics storage account ARM Id.</summary>
        string TargetBootDiagnosticsStorageAccountId { get; set; }
        /// <summary>The target network ARM Id.</summary>
        string TargetNetworkId { get; set; }
        /// <summary>The target proximity placement group Id.</summary>
        string TargetProximityPlacementGroupId { get; set; }
        /// <summary>The target resource group ARM Id.</summary>
        string TargetResourceGroupId { get; set; }
        /// <summary>The target VM name.</summary>
        string TargetVMName { get; set; }
        /// <summary>The target VM size.</summary>
        string TargetVMSize { get; set; }
        /// <summary>The test network ARM Id.</summary>
        string TestNetworkId { get; set; }
        /// <summary>The list of NIC details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicInput[] VMNic { get; set; }

    }
}