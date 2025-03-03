namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    public partial class IPConfigInputDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal
    {

        /// <summary>Backing field for <see cref="IPConfigName" /> property.</summary>
        private string _iPConfigName;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IPConfigName { get => this._iPConfigName; set => this._iPConfigName = value; }

        /// <summary>Backing field for <see cref="IsPrimary" /> property.</summary>
        private bool? _isPrimary;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public bool? IsPrimary { get => this._isPrimary; set => this._isPrimary = value; }

        /// <summary>Backing field for <see cref="IsSeletedForFailover" /> property.</summary>
        private bool? _isSeletedForFailover;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public bool? IsSeletedForFailover { get => this._isSeletedForFailover; set => this._isSeletedForFailover = value; }

        /// <summary>Backing field for <see cref="RecoveryLbBackendAddressPoolId" /> property.</summary>
        private string[] _recoveryLbBackendAddressPoolId;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string[] RecoveryLbBackendAddressPoolId { get => this._recoveryLbBackendAddressPoolId; set => this._recoveryLbBackendAddressPoolId = value; }

        /// <summary>Backing field for <see cref="RecoveryPublicIPAddressId" /> property.</summary>
        private string _recoveryPublicIPAddressId;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryPublicIPAddressId { get => this._recoveryPublicIPAddressId; set => this._recoveryPublicIPAddressId = value; }

        /// <summary>Backing field for <see cref="RecoveryStaticIPAddress" /> property.</summary>
        private string _recoveryStaticIPAddress;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryStaticIPAddress { get => this._recoveryStaticIPAddress; set => this._recoveryStaticIPAddress = value; }

        /// <summary>Backing field for <see cref="RecoverySubnetName" /> property.</summary>
        private string _recoverySubnetName;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoverySubnetName { get => this._recoverySubnetName; set => this._recoverySubnetName = value; }

        /// <summary>Backing field for <see cref="TfoLbBackendAddressPoolId" /> property.</summary>
        private string[] _tfoLbBackendAddressPoolId;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string[] TfoLbBackendAddressPoolId { get => this._tfoLbBackendAddressPoolId; set => this._tfoLbBackendAddressPoolId = value; }

        /// <summary>Backing field for <see cref="TfoPublicIPAddressId" /> property.</summary>
        private string _tfoPublicIPAddressId;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TfoPublicIPAddressId { get => this._tfoPublicIPAddressId; set => this._tfoPublicIPAddressId = value; }

        /// <summary>Backing field for <see cref="TfoStaticIPAddress" /> property.</summary>
        private string _tfoStaticIPAddress;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TfoStaticIPAddress { get => this._tfoStaticIPAddress; set => this._tfoStaticIPAddress = value; }

        /// <summary>Backing field for <see cref="TfoSubnetName" /> property.</summary>
        private string _tfoSubnetName;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TfoSubnetName { get => this._tfoSubnetName; set => this._tfoSubnetName = value; }

        /// <summary>Creates an new <see cref="IPConfigInputDetails" /> instance.</summary>
        public IPConfigInputDetails()
        {

        }
    }
    public partial interface IIPConfigInputDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"ipConfigName",
        PossibleTypes = new [] { typeof(string) })]
        string IPConfigName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isPrimary",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsPrimary { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isSeletedForFailover",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsSeletedForFailover { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"recoveryLBBackendAddressPoolIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] RecoveryLbBackendAddressPoolId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"recoveryPublicIPAddressId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPublicIPAddressId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"recoveryStaticIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryStaticIPAddress { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"recoverySubnetName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoverySubnetName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tfoLBBackendAddressPoolIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] TfoLbBackendAddressPoolId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tfoPublicIPAddressId",
        PossibleTypes = new [] { typeof(string) })]
        string TfoPublicIPAddressId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tfoStaticIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string TfoStaticIPAddress { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tfoSubnetName",
        PossibleTypes = new [] { typeof(string) })]
        string TfoSubnetName { get; set; }

    }
    internal partial interface IIPConfigInputDetailsInternal

    {
        string IPConfigName { get; set; }

        bool? IsPrimary { get; set; }

        bool? IsSeletedForFailover { get; set; }

        string[] RecoveryLbBackendAddressPoolId { get; set; }

        string RecoveryPublicIPAddressId { get; set; }

        string RecoveryStaticIPAddress { get; set; }

        string RecoverySubnetName { get; set; }

        string[] TfoLbBackendAddressPoolId { get; set; }

        string TfoPublicIPAddressId { get; set; }

        string TfoStaticIPAddress { get; set; }

        string TfoSubnetName { get; set; }

    }
}