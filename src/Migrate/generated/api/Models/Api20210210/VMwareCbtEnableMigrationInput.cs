namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>VMwareCbt specific enable migration input.</summary>
    public partial class VMwareCbtEnableMigrationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableMigrationProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableMigrationProviderSpecificInput __enableMigrationProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.EnableMigrationProviderSpecificInput();

        /// <summary>Backing field for <see cref="DataMoverRunAsAccountId" /> property.</summary>
        private string _dataMoverRunAsAccountId;

        /// <summary>The data mover run as account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DataMoverRunAsAccountId { get => this._dataMoverRunAsAccountId; set => this._dataMoverRunAsAccountId = value; }

        /// <summary>Backing field for <see cref="DisksToInclude" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtDiskInput[] _disksToInclude;

        /// <summary>The disks to include list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtDiskInput[] DisksToInclude { get => this._disksToInclude; set => this._disksToInclude = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableMigrationProviderSpecificInputInternal)__enableMigrationProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableMigrationProviderSpecificInputInternal)__enableMigrationProviderSpecificInput).InstanceType = value ; }

        /// <summary>Backing field for <see cref="LicenseType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? _licenseType;

        /// <summary>License type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get => this._licenseType; set => this._licenseType = value; }

        /// <summary>Backing field for <see cref="PerformAutoResync" /> property.</summary>
        private string _performAutoResync;

        /// <summary>A value indicating whether auto resync is to be done.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PerformAutoResync { get => this._performAutoResync; set => this._performAutoResync = value; }

        /// <summary>Backing field for <see cref="SeedDiskTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputSeedDiskTags _seedDiskTag;

        /// <summary>The tags for the seed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputSeedDiskTags SeedDiskTag { get => (this._seedDiskTag = this._seedDiskTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VMwareCbtEnableMigrationInputSeedDiskTags()); set => this._seedDiskTag = value; }

        /// <summary>Backing field for <see cref="SnapshotRunAsAccountId" /> property.</summary>
        private string _snapshotRunAsAccountId;

        /// <summary>The snapshot run as account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SnapshotRunAsAccountId { get => this._snapshotRunAsAccountId; set => this._snapshotRunAsAccountId = value; }

        /// <summary>Backing field for <see cref="SqlServerLicenseType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? _sqlServerLicenseType;

        /// <summary>The SQL Server license type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? SqlServerLicenseType { get => this._sqlServerLicenseType; set => this._sqlServerLicenseType = value; }

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

        /// <summary>Backing field for <see cref="TargetDiskTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetDiskTags _targetDiskTag;

        /// <summary>The tags for the target disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetDiskTags TargetDiskTag { get => (this._targetDiskTag = this._targetDiskTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VMwareCbtEnableMigrationInputTargetDiskTags()); set => this._targetDiskTag = value; }

        /// <summary>Backing field for <see cref="TargetNetworkId" /> property.</summary>
        private string _targetNetworkId;

        /// <summary>The target network ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetNetworkId { get => this._targetNetworkId; set => this._targetNetworkId = value; }

        /// <summary>Backing field for <see cref="TargetNicTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetNicTags _targetNicTag;

        /// <summary>The tags for the target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetNicTags TargetNicTag { get => (this._targetNicTag = this._targetNicTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VMwareCbtEnableMigrationInputTargetNicTags()); set => this._targetNicTag = value; }

        /// <summary>Backing field for <see cref="TargetProximityPlacementGroupId" /> property.</summary>
        private string _targetProximityPlacementGroupId;

        /// <summary>The target proximity placement group ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetProximityPlacementGroupId { get => this._targetProximityPlacementGroupId; set => this._targetProximityPlacementGroupId = value; }

        /// <summary>Backing field for <see cref="TargetResourceGroupId" /> property.</summary>
        private string _targetResourceGroupId;

        /// <summary>The target resource group ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetResourceGroupId { get => this._targetResourceGroupId; set => this._targetResourceGroupId = value; }

        /// <summary>Backing field for <see cref="TargetSubnetName" /> property.</summary>
        private string _targetSubnetName;

        /// <summary>The target subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetSubnetName { get => this._targetSubnetName; set => this._targetSubnetName = value; }

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

        /// <summary>Backing field for <see cref="TargetVMTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetVmtags _targetVMTag;

        /// <summary>The target VM tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetVmtags TargetVMTag { get => (this._targetVMTag = this._targetVMTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VMwareCbtEnableMigrationInputTargetVmtags()); set => this._targetVMTag = value; }

        /// <summary>Backing field for <see cref="VmwareMachineId" /> property.</summary>
        private string _vmwareMachineId;

        /// <summary>The ARM Id of the VM discovered in VMware.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string VmwareMachineId { get => this._vmwareMachineId; set => this._vmwareMachineId = value; }

        /// <summary>Creates an new <see cref="VMwareCbtEnableMigrationInput" /> instance.</summary>
        public VMwareCbtEnableMigrationInput()
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
            await eventListener.AssertNotNull(nameof(__enableMigrationProviderSpecificInput), __enableMigrationProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__enableMigrationProviderSpecificInput), __enableMigrationProviderSpecificInput);
        }
    }
    /// VMwareCbt specific enable migration input.
    public partial interface IVMwareCbtEnableMigrationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableMigrationProviderSpecificInput
    {
        /// <summary>The data mover run as account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The data mover run as account Id.",
        SerializedName = @"dataMoverRunAsAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string DataMoverRunAsAccountId { get; set; }
        /// <summary>The disks to include list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The disks to include list.",
        SerializedName = @"disksToInclude",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtDiskInput) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtDiskInput[] DisksToInclude { get; set; }
        /// <summary>License type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"License type.",
        SerializedName = @"licenseType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get; set; }
        /// <summary>A value indicating whether auto resync is to be done.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether auto resync is to be done.",
        SerializedName = @"performAutoResync",
        PossibleTypes = new [] { typeof(string) })]
        string PerformAutoResync { get; set; }
        /// <summary>The tags for the seed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the seed disks.",
        SerializedName = @"seedDiskTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputSeedDiskTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputSeedDiskTags SeedDiskTag { get; set; }
        /// <summary>The snapshot run as account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The snapshot run as account Id.",
        SerializedName = @"snapshotRunAsAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string SnapshotRunAsAccountId { get; set; }
        /// <summary>The SQL Server license type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SQL Server license type.",
        SerializedName = @"sqlServerLicenseType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? SqlServerLicenseType { get; set; }
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
        /// <summary>The tags for the target disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the target disks.",
        SerializedName = @"targetDiskTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetDiskTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetDiskTags TargetDiskTag { get; set; }
        /// <summary>The target network ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The target network ARM Id.",
        SerializedName = @"targetNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetNetworkId { get; set; }
        /// <summary>The tags for the target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the target NICs.",
        SerializedName = @"targetNicTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetNicTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetNicTags TargetNicTag { get; set; }
        /// <summary>The target proximity placement group ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target proximity placement group ARM Id.",
        SerializedName = @"targetProximityPlacementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetProximityPlacementGroupId { get; set; }
        /// <summary>The target resource group ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The target resource group ARM Id.",
        SerializedName = @"targetResourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetResourceGroupId { get; set; }
        /// <summary>The target subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target subnet name.",
        SerializedName = @"targetSubnetName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetSubnetName { get; set; }
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
        /// <summary>The target VM tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target VM tags.",
        SerializedName = @"targetVmTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetVmtags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetVmtags TargetVMTag { get; set; }
        /// <summary>The ARM Id of the VM discovered in VMware.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ARM Id of the VM discovered in VMware.",
        SerializedName = @"vmwareMachineId",
        PossibleTypes = new [] { typeof(string) })]
        string VmwareMachineId { get; set; }

    }
    /// VMwareCbt specific enable migration input.
    internal partial interface IVMwareCbtEnableMigrationInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableMigrationProviderSpecificInputInternal
    {
        /// <summary>The data mover run as account Id.</summary>
        string DataMoverRunAsAccountId { get; set; }
        /// <summary>The disks to include list.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtDiskInput[] DisksToInclude { get; set; }
        /// <summary>License type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get; set; }
        /// <summary>A value indicating whether auto resync is to be done.</summary>
        string PerformAutoResync { get; set; }
        /// <summary>The tags for the seed disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputSeedDiskTags SeedDiskTag { get; set; }
        /// <summary>The snapshot run as account Id.</summary>
        string SnapshotRunAsAccountId { get; set; }
        /// <summary>The SQL Server license type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary>The target availability set ARM Id.</summary>
        string TargetAvailabilitySetId { get; set; }
        /// <summary>The target availability zone.</summary>
        string TargetAvailabilityZone { get; set; }
        /// <summary>The target boot diagnostics storage account ARM Id.</summary>
        string TargetBootDiagnosticsStorageAccountId { get; set; }
        /// <summary>The tags for the target disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetDiskTags TargetDiskTag { get; set; }
        /// <summary>The target network ARM Id.</summary>
        string TargetNetworkId { get; set; }
        /// <summary>The tags for the target NICs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetNicTags TargetNicTag { get; set; }
        /// <summary>The target proximity placement group ARM Id.</summary>
        string TargetProximityPlacementGroupId { get; set; }
        /// <summary>The target resource group ARM Id.</summary>
        string TargetResourceGroupId { get; set; }
        /// <summary>The target subnet name.</summary>
        string TargetSubnetName { get; set; }
        /// <summary>The target VM name.</summary>
        string TargetVMName { get; set; }
        /// <summary>The target VM size.</summary>
        string TargetVMSize { get; set; }
        /// <summary>The target VM tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetVmtags TargetVMTag { get; set; }
        /// <summary>The ARM Id of the VM discovered in VMware.</summary>
        string VmwareMachineId { get; set; }

    }
}